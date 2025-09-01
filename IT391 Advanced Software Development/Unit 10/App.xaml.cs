using IT391_Unit10.Services;
using IT391_Unit10.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IT391_Unit10
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
