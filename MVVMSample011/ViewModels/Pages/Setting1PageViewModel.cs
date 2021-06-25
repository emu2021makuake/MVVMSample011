namespace MVVMSample011.ViewModels.Pages
{
    public class Setting1PageViewModel : PageViewModelBase
    {
        private bool _check1;
        public bool Check1
        {
            get => _check1;
            set => SetProperty(ref _check1, value);
        }

        private bool _check2;
        public bool Check2
        {
            get => _check2;
            set => SetProperty(ref _check2, value);
        }

        public Setting1PageViewModel()
        {
            Check1 = false;
            Check2 = true;
        }
    }
}
