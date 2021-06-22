namespace MVVMSample011.ViewModels.Pages
{
    public class Setting2PageViewModel : PageViewModwlBase
    {
        private string _text1;
        public string Text1
        {
            get => _text1;
            set => SetProperty(ref _text1, value);
        }

        private string _text2;
        public string Text2
        {
            get => _text2;
            set => SetProperty(ref _text2, value);
        }

        public Setting2PageViewModel()
        {
            Text1 = "Hello.";
            Text2 = "";
        }
    }
}
