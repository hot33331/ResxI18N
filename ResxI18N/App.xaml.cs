// copyright msg systems ag
// Tobias Hoppenthaler - tobias.hoppenthaler@msg.group
using ResxI18N.Helpers;
using Xamarin.Forms;

namespace ResxI18N
{
    public partial class App : Application
    {
        public App()
        {
            
            if (Device.OS == TargetPlatform.iOS || Device.OS == TargetPlatform.Android)
            {
                var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
                ResxI18N.Resx.Resources.Culture = ci; // set the RESX for resource localization
                DependencyService.Get<ILocalize>().SetLocale(ci); // set the Thread for locale-aware methods
            }
            InitializeComponent();

            MainPage = new ResxI18NPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
