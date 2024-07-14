using DevExpress.Mvvm;
using System.Windows.Input;


namespace ExpenseTracker.ViewModels
{
    public class SignupViewModel : ViewModelBase
    {
        public IDelegateCommand BackToLoginCommand { get; }

        private readonly MainViewModel _mainViewModel;

        public SignupViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            BackToLoginCommand = new DelegateCommand(ShowLoginView);
        }

        private void ShowLoginView()
        {
            _mainViewModel.CurrentView = new LoginViewModel(_mainViewModel);
        }
    }
}
