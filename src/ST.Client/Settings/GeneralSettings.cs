using System;
using System.Application.Services;
using System.Application.UI;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Properties;
using System.Text;
using System.Threading.Tasks;

namespace System.Application.Settings
{
    public sealed partial class GeneralSettings : SettingsHost2<GeneralSettings>
    {
        /// <summary>
        /// 自动检查更新
        /// </summary>
        public static SerializableProperty<bool> IsAutoCheckUpdate { get; }
            = GetProperty(defaultValue: true, autoSave: true);

        /// <summary>
        /// 下载更新渠道
        /// </summary>
        public static SerializableProperty<UpdateChannelType> UpdateChannel { get; }
            = GetProperty(defaultValue: (UpdateChannelType)default, autoSave: true);
    }
}
