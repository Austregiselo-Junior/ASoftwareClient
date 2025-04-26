using ASoftware_Client.ViewModel;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ASoftware_Client.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Client : Page
    {
        public ClientViewModel ViewModel => (ClientViewModel)this.DataContext;

        public Client()
        {
            this.InitializeComponent();
            this.DataContext = new ClientViewModel();
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
        }

        private void EditClient_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}