using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using MVVMSample011.ViewModels.Pages;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVMSample011.ViewModels
{
    public class MainWindowViewModel : ObservableObject
{
        private PageViewModwlBase _currentPage;
        /// <summary>
        /// Current page
        /// </summary>
        public PageViewModwlBase CurrentPage
        {
            get => _currentPage;
            set
            {
                SetProperty(ref _currentPage, value);

                PageBackCommand?.NotifyCanExecuteChanged();
                PageNextCommand?.NotifyCanExecuteChanged();
            }
        }

        public StartPageViewModel StartPage { get; }
        public Setting1PageViewModel Setting1Page { get; }
        public Setting2PageViewModel Setting2Page { get; }
        public EndPageViewModel EndPage { get; }

        /// <summary>
        /// Page management
        /// </summary>
        private List<PageViewModwlBase> _pages;

        public IRelayCommand PageBackCommand { get; }
        public IRelayCommand PageNextCommand { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindowViewModel()
        {
            _pages = new List<PageViewModwlBase>();
            _pages.Add(StartPage = new StartPageViewModel());
            _pages.Add(Setting1Page = new Setting1PageViewModel());
            _pages.Add(Setting2Page = new Setting2PageViewModel());
            _pages.Add(EndPage = new EndPageViewModel());

            CurrentPage = StartPage;

            PageBackCommand = new RelayCommand(PageBackExecute, PageBackCanExecute);
            PageNextCommand = new RelayCommand(PageNextExecute, PageNextCanExecute);
        }

        /// <summary>
        /// Back page processing.
        /// </summary>
        private void PageBackExecute()
        {
            CurrentPage = _pages[_pages.FindIndex(x => x == CurrentPage) - 1];
        }

        private bool PageBackCanExecute()
        {
            return CurrentPage != _pages.First();
        }

        /// <summary>
        /// Next page processing.
        /// </summary>
        private void PageNextExecute()
        {
            CurrentPage = _pages[_pages.FindIndex(x => x == CurrentPage) + 1];

            if (CurrentPage == _pages.Last())
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Check1:{Setting1Page.Check1}");
                sb.AppendLine($"Check2:{Setting1Page.Check2}");
                sb.AppendLine($"Text1:{Setting2Page.Text1}");
                sb.AppendLine($"Text2:{Setting2Page.Text2}");

                EndPage.SettingListText = sb.ToString();
            }
        }

        private bool PageNextCanExecute()
        {
            return CurrentPage != _pages.Last();
        }
    }
}
