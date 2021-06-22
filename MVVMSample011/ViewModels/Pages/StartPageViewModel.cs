namespace MVVMSample011.ViewModels.Pages
{
    public class StartPageViewModel : PageViewModwlBase
    {
        private string _message;
        /// <summary>
        /// start page message
        /// </summary>
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public StartPageViewModel()
        {
            Message = "Start Page";
        }
    }
}
