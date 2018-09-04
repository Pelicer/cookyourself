using CookYourself.Model;
using CookYourself.Model.DAO;
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

namespace CookYourself.View
{

    public partial class ViewNewUser : Window
    {
        ModelUser user = new ModelUser();
        UserDAO dao = new UserDAO();

        public ViewNewUser()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            user.UserName = txtUser.Text;
        }

        private void pswPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            user.UserPassword = pswPassword.Password;
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            dao.CadastrarUsuario(user.UserName, user.UserPassword);
            MessageBox.Show("Usuário cadastrado com sucesso.", "Sucesso!", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            this.Close();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
