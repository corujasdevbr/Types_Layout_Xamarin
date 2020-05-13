using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Types_Layout_Xamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MudarLayout(object sender, EventArgs args)
        {
            string text = ((Button)sender).Text;

            switch (text)
            {
                case "Absolute":
                    Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
                    break;
                case "Grid":
                    Navigation.PushAsync(new Layouts.Grid.GridPage());
                    break;
                case "Relative":
                    Navigation.PushAsync(new Layouts.Relative.RelativePage());
                    break;
                case "Scroll":
                    Navigation.PushAsync(new Layouts.Scroll.ScrollPage());
                    break;
                case "Stack":
                    Navigation.PushAsync(new Layouts.Stack.StackPage());
                    break;
            }
        }
    }
}
