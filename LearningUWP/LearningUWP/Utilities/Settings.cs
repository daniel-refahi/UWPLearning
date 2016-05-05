using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace LearningUWP.Utilities
{
    public static class Settings
    {
        private static bool? _LiveTileEnabled;
        public static bool LiveTileEnabled
        {
            get
            {
                if (_LiveTileEnabled != null)
                    return (bool)_LiveTileEnabled;
                else
                {
                    _LiveTileEnabled = Convert.ToBoolean(
                        ApplicationData.Current.LocalSettings.Values[nameof(LiveTileEnabled)]);
                    return (bool)_LiveTileEnabled;
                }
            }
            set
            {
                _LiveTileEnabled = value;
                ApplicationData.Current.LocalSettings.Values[nameof(LiveTileEnabled)] = _LiveTileEnabled;
            }
        }
    }
}
