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
using System.Windows.Shapes;

namespace RPdaraye
{
    /// <summary>
    /// Логика взаимодействия для info.xaml
    /// </summary>
    public partial class info : Window
    {
        
        public info()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            namespassword.result = !namespassword.result;
            MainWindow main = new MainWindow();
            main.Hide();
            Close();
        }

        private void poh_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
