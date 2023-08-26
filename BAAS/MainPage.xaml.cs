using BAAS.ViewModel;
using System.Diagnostics;

namespace BAAS
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenWebPage_Clicked(object sender, EventArgs e)
        {
            try
            {
                Uri uri = new("https://www.saab.com/");
                await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception)
            {
                Debug.WriteLine("An unexpected error occurred. No browser may be installed on the device.");
            }
        }
    }

}