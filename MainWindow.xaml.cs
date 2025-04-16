using ASoftware_Client.Views;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace ASoftware_Client
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void AdicionarCliente_Click(object sender, RoutedEventArgs e)
        {
        }

        private void NavigationView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            if (args.InvokedItemContainer is NavigationViewItem item)
            {
                switch (item.Tag)
                {
                    case "Patients":
                        contentFrame.Navigate(typeof(Patients));
                        break;

                    case "PatientsbySession":
                        contentFrame.Navigate(typeof(PatientsbySession));
                        break;

                    case "PatientsbyMonth":
                        contentFrame.Navigate(typeof(PatientsbyMonth));
                        break;

                    case "Settings":
                        contentFrame.Navigate(typeof(Settings));
                        break;
                }
            }
        }
    }
}