using PM22024VVMM.Views;

namespace PM22024VVMM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PageProducts());
        }
    }
}
