using DevExpress.Mvvm;
using System;
using System.Diagnostics;
using System.Windows.Input;


namespace ExpenseTracker.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        // commands
        public IDelegateCommand SignupCommand { get; }
        public IDelegateCommand SigninCommand { get; }
        public IDelegateCommand AzureLoginCommand { get; }
        public IDelegateCommand ForgetPasswordCommand { get; }


        private readonly MainViewModel _mainViewModel;

        public LoginViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            // commands
            SignupCommand = new DelegateCommand(ShowSignupView);
            SigninCommand = new DelegateCommand(Signin);
            AzureLoginCommand = new DelegateCommand(AzureLogin);
            ForgetPasswordCommand = new DelegateCommand(ForgetPassword);
        }

        private void ForgetPassword()
        {
            Debug.WriteLine("Forget Password");
        }

        private void AzureLogin()
        {
           Debug.WriteLine("Azure login");
        }

        private void Signin()
        {
            Debug.WriteLine("Signin");
        }

        private void ShowSignupView()
        {
            _mainViewModel.CurrentView = new SignupViewModel(_mainViewModel);
        }
    }
}
