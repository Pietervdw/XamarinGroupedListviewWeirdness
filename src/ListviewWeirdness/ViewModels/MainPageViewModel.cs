using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListviewWeirdness.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private DelegateCommand _goToMoviesCommand;
        public DelegateCommand GoToMoviesCommand =>_goToMoviesCommand ?? (_goToMoviesCommand = new DelegateCommand(ExecuteGoToMoviesCommand));
        
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Main Page";
        }

        async void ExecuteGoToMoviesCommand()
        {
            await _navigationService.NavigateAsync("GroupedListviewPage");
        }
    }
}
