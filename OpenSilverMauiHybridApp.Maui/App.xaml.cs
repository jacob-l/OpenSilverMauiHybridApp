using Microsoft.Extensions.Configuration;

namespace OpenSilverMauiHybridApp.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}