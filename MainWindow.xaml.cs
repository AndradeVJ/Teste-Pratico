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


namespace ProtecPass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        String usuario, Se;
        

        public MainWindow()
        {

            



        }
        
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
           


        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RecuperarSenha r2 = new RecuperarSenha();
            r2.Show();

        }

        private void TxtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TxtSenha_TextChanged(object sender, TextChangedEventArgs e) 
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
        }
         
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Adm1 a1 = new Adm1();
            this.Content = a1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {




            usuario = Properties.Settings.Default.Usuario;
            Se = Properties.Settings.Default.Se;
            if (txtusuario.Text == usuario && txtSe.Password == Se)
            {
                MessageBox.Show("successfully logged in");
            }
            else
            {
                MessageBox.Show("Incorrect password");
            }

           

        }
    }
    }

