using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RPdaraye
{
    /// <summary>
    /// Логика взаимодействия для skver.xaml
    /// </summary>
    public partial class skver : Window
    {
        bool _IsTrue= false;
        private Socket server;
        private List<Socket> sockets;
        
        public skver()
        {
            InitializeComponent();
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.ConnectAsync("127.0.0.1", 8888);
            RecieveMassege();
            ambient.Source = new Uri("D:\\RPdaraye\\RPdaraye\\ambient.mp3");
            ambient.Play();
            ambient.Volume = 0.2;
        }
        private void send(object sender, RoutedEventArgs e)
        {
            /* while (true) {*/
            SendMassage(txf.Text);
            // }
        }
        private async Task RecieveMassege()
        {
            while (true)
            {
                byte[] bytes = new byte[1024];
                await server.ReceiveAsync(bytes, SocketFlags.None);
                string message = Encoding.UTF8.GetString(bytes);
                chat.Items.Add(namespassword.username+": "+ message);

            }
        }
        private async Task SendMassage(string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            await server.SendAsync(bytes, SocketFlags.None);
        }
        private void spravka(object sender, RoutedEventArgs e)
        {
            _IsTrue = !_IsTrue;
            if(_IsTrue == true)
            {
                openSP.Content = new srpavka1();
            }
           else if(_IsTrue == false)
            {

                openSP.Content = null;
            }
        }
        private void btn_back(object sender, RoutedEventArgs e)
        {
            field fld = new field();
            fld.Show();
            Close();
        }
    }
}
