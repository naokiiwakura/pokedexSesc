using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PokeDexSesc.Services;
using PokeDexSesc.Views;

namespace PokeDexSesc
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
