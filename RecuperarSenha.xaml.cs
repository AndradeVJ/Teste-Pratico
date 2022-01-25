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

namespace ProtecPass
{
    /// <summary>
    /// Lógica interna para RecuperarSenha.xaml
    /// </summary>
    public partial class RecuperarSenha : Window
    {
        

        public RecuperarSenha()
        {
            InitializeComponent();

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        { 
            string senha_antiga = Properties.Settings.Default.Se;
            if (txtsenha_antiga.Text == senha_antiga)
            {

                Properties.Settings.Default.Se = txtsenha_nova.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show("Password changed successfully");

            }
            else
            {
                MessageBox.Show("Password does not match ");

            }

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
