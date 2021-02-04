using Windows.UI.Xaml.Controls;

namespace Samples.ManagedUWP
{
    public sealed partial class MainPage : UserControl
    {
        public MainPage()
        {
            this.InitializeComponent();
            contentFrame.Navigate(typeof(BasicInputPage), null);
        }
    }
}
