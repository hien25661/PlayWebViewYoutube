using Xamarin.Forms;

namespace CustomRenderer
{
    public partial class HybridWebViewPage : ContentPage
    {
        public HybridWebViewPage()
        {
            InitializeComponent();

            
            var VideoSource = new HtmlWebViewSource();
            VideoSource.Html = @"<html><body>  <div style=' position: relative; padding-bottom: 56.25%; padding-top: 25px;'> <iframe style='position: absolute; top: 0; left: 0; width: 100%; height: 100%;'  src='https://www.youtube.com/embed/bVdfj7HXuXE' frameborder='0' allowfullscreen></iframe></div> </body></html>";

            hybridWebView.Source = VideoSource;
            hybridWebView.RegisterAction(data => DisplayAlert("Alert", "Hello " + data, "OK"));
        }
    }
}
