using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace RPdaraye
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
        private void enter_Click(object sender, RoutedEventArgs e)
        {
            namespassword.username = name.Text;
            string pole = name.Text + password.Password;
            foreach (var a in namespassword.usernamespassword)
            {
                if (a == pole)
                {
                    newWindow();
                    Close();
                }
                else
                {
                    error();
                    if (namespassword.result == true)
                    {
                        namespassword.usernamespassword.Add(pole);
                        newWindow();
                        Close();
                        namespassword.result = !namespassword.result;
                    }

                }
            }
            if (namespassword.usernamespassword.Count == 0)
            {
                error();
                if (namespassword.result == true)
                {
                    namespassword.usernamespassword.Add(pole);
                    newWindow();
                    Close();
                    namespassword.result = !namespassword.result;
                }
            }
        }

        private static void newWindow()
        {
            field field = new field();
            field.Show();
        }
        private static void error()
        {
            info warn = new info();
            warn.Show();
        }
    }
    }
