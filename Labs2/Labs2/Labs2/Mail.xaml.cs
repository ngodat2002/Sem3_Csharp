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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Labs2.Labs2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Mail : Page
    {
        public Mail()
        {
            this.InitializeComponent();
        }
        private void Submit(object sender, RoutedEventArgs e)
        {
            var fullName = inputFullname.Text;// lấy nội dung người dùng nhập trong input
            var email = inputEmail.Text;
            var phone = inputPhone.Text;

            txtFullname.Text = fullName;
            txtEmail.Text = email;
            txtPhone.Text = phone;
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MailFrame.Navigate(typeof(Labs2.Home));
        }
    }
}
