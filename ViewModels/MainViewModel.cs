using DevExpress.Mvvm;


namespace ExpenseTracker.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private bool _isLoginView = true;

        public bool IsLoginView
        {
            get => _isLoginView;
            set
            {
                SetProperty(ref _isLoginView, value, nameof(IsLoginView));
            }
        }

        private object _currentView;

        public object CurrentView
        {
            get => _currentView;
            set
            {
                SetProperty(ref _currentView, value, nameof(CurrentView));
            }
        }

        public bool IsSignupView => !IsLoginView;

        public IDelegateCommand ToggleViewCommand { get; }
        public IDelegateCommand LoginCommand { get; }
        public IDelegateCommand SignupCommand { get; }

        public MainViewModel()
        {
            ToggleViewCommand = new DelegateCommand(ToggleView);
            LoginCommand = new DelegateCommand(Login);
            SignupCommand = new DelegateCommand(Signup);

            // Set initial view
            CurrentView = new LoginViewModel(this);
        }

        private void ToggleView()
        {
            IsLoginView = !IsLoginView;
        }

        private void Login()
        {
            // Implement login logic here
        }

        private void Signup()
        {
            // Implement signup logic here
        }
    }
}
