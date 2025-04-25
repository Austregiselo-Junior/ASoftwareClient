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
    public sealed partial class Patients : Page
    {
        public PatientsViewModel ViewModel => (PatientsViewModel)this.DataContext;

        public Patients()
        {
            this.InitializeComponent();
            this.DataContext = new PatientsViewModel();
        }

        private void AdicionarCliente_Click(object sender, RoutedEventArgs e)
        {
        }

        private void EditCliente_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DeleteCliente_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}