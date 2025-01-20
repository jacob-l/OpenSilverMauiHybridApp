using System;
using System.Windows.Controls;

namespace OpenSilverMauiHybridApp
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Enter construction logic here...
        }

        public void OnClick(object sender, EventArgs args)
        {
            TB.Text += $"{Environment.NewLine}Clicked at {DateTime.Now:o}";
        }
    }
}
