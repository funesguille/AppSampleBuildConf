using Xamarin.Forms;

namespace AppSampleBuildConf
{
    public partial class AppSampleBuildConfPage : ContentPage
    {
        public AppSampleBuildConfPage()
        {
            InitializeComponent();
#if DEBUG
            message.Text = "Ejecución en Debug";
#else
            message.Text = "Ejecución en Release";
#endif
        }
    }
}
