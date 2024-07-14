using DevExpress.Xpf.Core;
using ExpenseTracker.ViewModels;


namespace ExpenseTracker.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext =  new MainViewModel();
        }
    }
}
