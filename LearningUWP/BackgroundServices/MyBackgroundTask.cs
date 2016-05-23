using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.ApplicationModel.Background;
using Windows.UI.Notifications;

namespace BackgroundServices
{
    public sealed class MyBackgroundTask : IBackgroundTask
    {
        private BackgroundTaskDeferral _defferal;
        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            _defferal = taskInstance.GetDeferral();
            await SendNotificationAsync();
            await UpdateLiveTileAsync();
            _defferal.Complete();
        }

        private async Task<bool> UpdateLiveTileAsync()
        {
            try
            {
                var biggestCompany = await Queries.GetBiggestCompanyAsync();
                var template =
                        @"<tile>
                        <visual>
                            <binding template=""TileSmall"">
                                <text hint-wrap=""true"">{0}</text>
                            </binding>
                            <binding template = ""TileMedium"">
                                <text hint-wrap=""true"">{0}</text>
                            </binding>
                            <binding template = ""TileWide"">
                                <text hint-wrap=""true"">{0}</text>
                            </binding>
                            <binding template = ""TileLarge"">
                                <text hint-wrap=""true"">{0}</text>
                            </binding>
                        </visual>
                    </tile>
                    ";
                var content = string.Format(template, $"The biggest company is {biggestCompany.Name}\nWith {biggestCompany.Employees.Count} employess.");
                var doc = new XmlDocument();
                doc.LoadXml(content);
                TileUpdateManager.CreateTileUpdaterForApplication().Update(new TileNotification(doc));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private async Task<bool> SendNotificationAsync()
        {
            var biggestCompany = await Queries.GetBiggestCompanyAsync();
            ToastNotifier notifier = ToastNotificationManager.CreateToastNotifier();
            XmlDocument content = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText02);
            var texts = content.GetElementsByTagName("text");
            texts[0].InnerText = biggestCompany.Name;
            texts[1].InnerText = $"With {biggestCompany.Employees.Count} employees."; 
            notifier.Show(new ToastNotification(content));
            return true;
        }

        public static async void Register()
        {
            var isRegistered = BackgroundTaskRegistration
                .AllTasks.Values.Any(t=> t.Name == nameof(MyBackgroundTask));

            if (isRegistered)
                return;

            if (await BackgroundExecutionManager.RequestAccessAsync() == BackgroundAccessStatus.Denied)
                return;

            var builder = new BackgroundTaskBuilder
            {
                Name = nameof(MyBackgroundTask),
                TaskEntryPoint = $"{nameof(BackgroundServices)}.{nameof(MyBackgroundTask)}"
            };
            builder.SetTrigger(new TimeTrigger(120, false));
            builder.Register();
        }
    }
}
