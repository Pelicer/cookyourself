using CookYourself.Model;
using CookYourself.Model.DAO;
using CookYourself.View;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace CookYourself
{   

    public partial class Login : Window
    {
        //Objetos
        ModelUser user = new ModelUser();
        UserDAO dao = new UserDAO();

        public Login()
        {
            InitializeComponent();
            if (Directory.Exists(@"C:\CookYourself"))
            {
                //Delete on tempporary files in cache.
                string path = @"C:\CookYourself";
                string filesToDelete = @"*Temp*.png";
                string[] fileList = Directory.GetFiles(path, filesToDelete);

                foreach (string file in fileList)
                {
                    File.Delete(file);
                }
            }
            else
            {
                System.IO.Directory.CreateDirectory(@"C:\CookYourself");
            }
            
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            if(dao.Login(user.UserName, user.UserPassword))
            {
                ViewMainMenu mainMenu = new ViewMainMenu();
                mainMenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Suas credenciais não estão cadastradas. Tem certeza de as digitou corretamente?", "Oops!", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            user.UserName = txtUser.Text;
        }

        private void pswPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            user.UserPassword = pswPassword.Password;
        }

        private void lblNewUser_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ViewNewUser newUser = new ViewNewUser();
            newUser.ShowDialog();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
