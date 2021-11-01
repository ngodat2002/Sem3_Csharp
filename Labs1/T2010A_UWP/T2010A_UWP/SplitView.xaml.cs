using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using T2010A_UWP.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2010A_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SplitView : Page
    {
        public SplitView()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Labs2.Home));
            var menu1 = new MenuItem() { Name = "Home", MenuPage = "homepage", Icon = "\uE80F" };
            var menu2 = new MenuItem() { Name = "Contact", MenuPage = "contact", Icon = "\uE780" };
            var menu3 = new MenuItem() { Name = "Customer", MenuPage = "customer", Icon = "\uE716" };
            var menu4 = new MenuItem() { Name = "Mail", MenuPage = "mail", Icon = "\uE8C3" };

            MenuSpl.Items.Add(menu1);
            MenuSpl.Items.Add(menu2);
            MenuSpl.Items.Add(menu3);
            MenuSpl.Items.Add(menu4);
        }

        private void IconClick_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Slpv.IsPaneOpen = !Slpv.IsPaneOpen;
        }

        private void ListViewItem_Tapped1(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)MenuSpl.SelectedItem;
            switch (selected.MenuPage)
            {
                case "homepage":
                    MainFrame.Navigate(typeof(Labs2.Home));
                    break;
                case "contact":
                    MainFrame.Navigate(typeof(Labs2.Contact));
                    break;
                case "demo":
                    MainFrame.Navigate(typeof(Labs2.Customer));
                    break;
                case "mail":
                    MainFrame.Navigate(typeof(Labs2.Mail));
                    break;
            }
        }
    }
}
