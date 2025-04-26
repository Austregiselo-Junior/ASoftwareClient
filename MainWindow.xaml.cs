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

        private void NavigationView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            if (args.InvokedItemContainer is NavigationViewItem item)
            {
                switch (item.Tag)
                {
                    case "Patients":
                        contentFrame.Navigate(typeof(Client));
                        break;

                    case "PatientsbySession":
                        contentFrame.Navigate(typeof(ClientbySession));
                        break;

                    case "PatientsbyMonth":
                        contentFrame.Navigate(typeof(ClientbyMonth));
                        break;

                    case "Settings":
                        contentFrame.Navigate(typeof(Settings));
                        break;
                }
            }
        }
    }
}