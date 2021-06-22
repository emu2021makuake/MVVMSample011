namespace MVVMSample011.ViewModels.Pages
{
    public class EndPageViewModel : PageViewModwlBase
    {
        private string _settingListText;
        /// <summary>
        /// Text in the settings list
        /// </summary>
        public string SettingListText
        {
            get => _settingListText;
            set => SetProperty(ref _settingListText, value);
        }
    }
}
