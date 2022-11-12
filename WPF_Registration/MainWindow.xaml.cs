using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Registration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (userNameTxtB.Text != "admin")
            {
                userNameLbl.Content= "User name is not correct";
                userNameLbl.Foreground=new SolidColorBrush(Colors.Red);
            }
            else
            {
                userNameLbl.Content=String.Empty;
            }

            if (passwordBox.Password != "admin")
            {
                passwordLbl.Content = "Password is not correct";
                passwordLbl.Foreground=new SolidColorBrush(Colors.Red);
            }
            else
            {
                passwordLbl.Content=String.Empty;
            }

            if(userNameTxtB.Text == "admin" && passwordBox.Password == "admin")
            {
                MessageBox.Show("Log in Successfuly");
            }
        }
    }
}
