using CookYourself.Model;
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
using System.Windows.Shapes;

namespace CookYourself.View
{
    public partial class ViewCadastro : Window
    {
        string img;
        int i = 0;
                //Getters and setters for image counting.
        int y = 1;

        ModelReceita receita = new ModelReceita();
        Model.DAO.ReceitaDAO dao = new Model.DAO.ReceitaDAO();        

        public ViewCadastro()
        {
            InitializeComponent();
        }

        internal ViewCadastro(ModelReceita receita)
        {

            InitializeComponent();
            txtIngrediente1.IsEnabled = false; txtIngrediente2.IsEnabled = false; txtIngrediente3.IsEnabled = false; txtIngrediente4.IsEnabled = false;
            txtIngrediente5.IsEnabled = false; txtIngrediente6.IsEnabled = false; txtIngrediente7.IsEnabled = false; txtIngrediente8.IsEnabled = false;
            txtIngrediente8.IsEnabled = false; txtIngrediente9.IsEnabled = false; txtIngrediente10.IsEnabled = false; txtModoDePreparo.IsEnabled = true;
            txtRendimento.IsEnabled = false; txtTitulo.IsEnabled = false; txtTempoPreparo.IsEnabled = false; txtCustoTotal.IsEnabled = false;
            imgReceita.Visibility = Visibility.Hidden; btnSelecionar.Visibility = Visibility.Hidden;

            txtIngrediente1.Text = receita.Ingrediente1; txtIngrediente2.Text = receita.Ingrediente2; txtIngrediente3.Text = receita.Ingrediente3;
            txtIngrediente4.Text = receita.Ingrediente4; txtIngrediente5.Text = receita.Ingrediente5; txtIngrediente6.Text = receita.Ingrediente6;
            txtIngrediente7.Text = receita.Ingrediente7; txtIngrediente8.Text = receita.Ingrediente8; txtIngrediente9.Text = receita.Ingrediente9;
            txtIngrediente10.Text = receita.Ingrediente10; txtModoDePreparo.Text = receita.Preparo; txtRendimento.Text = receita.Rendimento;
            txtTitulo.Text = receita.Titulo; txtTempoPreparo.Text = receita.TempoPreparo; txtCustoTotal.Text = receita.CustoTotal;

            btnCadastrar.IsEnabled = false; btnCancelar.IsEnabled = false; btnSelecionar.IsEnabled = false;

            if (receita.Tipo == "Doce") { rdbtn_Doce.IsChecked = true; }
            else if (receita.Tipo == "Salgado") { rdbtn_Salgado.IsChecked = true; }
            else if (receita.Tipo == "Lanche") { rdbtn_Lanche.IsChecked = true; } else if (receita.Tipo == "Bebida") { rdbtn_Bebida.IsChecked = true; }


            if (!System.IO.File.Exists(@"C:\CookYourself\" + receita.Titulo + ".png"))
            {
                //The image does not exists.
            }
            else
            {
                if (System.IO.File.Exists(@"C:\CookYourself\" + receita.Titulo + "Temp.png"))
                {
                    File.Copy(@"C:\CookYourself\" + receita.Titulo + ".png", @"C:\CookYourself\" + receita.Titulo + "Temp" + y + ".png", true);
                    if (System.IO.File.Exists(@"C:\CookYourself\" + receita.Titulo + "Temp" + y + ".png"))
                    {
                        y = Directory.GetFiles(@"C:\CookYourself\", "*", SearchOption.TopDirectoryOnly).Length;
                        y++;
                        File.Copy(@"C:\CookYourself\" + receita.Titulo + ".png", @"C:\CookYourself\" + receita.Titulo + "Temp" + y + ".png", true);
                        ImageBrush ib = new ImageBrush();
                        ib.ImageSource = new BitmapImage(new Uri(@"C:\CookYourself\" + receita.Titulo + "Temp" + y + ".png", UriKind.Relative));
                        Cadastro.Background = ib;
                    }
                }
                else
                {
                    File.Copy(@"C:\CookYourself\" + receita.Titulo + ".png", @"C:\CookYourself\" + receita.Titulo + "Temp.png", true);
                    ImageBrush ib = new ImageBrush();
                    ib.ImageSource = new BitmapImage(new Uri(@"C:\CookYourself\" + receita.Titulo + "Temp.png", UriKind.Relative));
                    Cadastro.Background = ib;
                }
            }


        }

        
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, RoutedEventArgs e)
        {
            //creates the dialog for selection 
            Microsoft.Win32.OpenFileDialog selection = new Microsoft.Win32.OpenFileDialog();

            //default file extasion configurated for images. 
            selection.DefaultExt = ".jpg*";
            selection.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            //boolean for check selection further in the code.
            Nullable<bool> result = selection.ShowDialog();

            //get the selected file.
            if (result == true)
            {
                //loads the image into the imgseries component.
                imgReceita.Source = new BitmapImage(new Uri(selection.FileName));
            }

            if (!System.IO.Directory.Exists(@"C:\CookYourself"))
            {
                System.IO.Directory.CreateDirectory(@"C:\CookYourself");
            }

            //set the global variable fileName with the filename
            img = selection.FileName;
            i++;

        }

        private void txtIngrediente1_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.Ingrediente1 = txtIngrediente1.Text.ToString();
        }

        private void txtIngrediente2_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.Ingrediente2 = txtIngrediente2.Text.ToString();
        }

        private void txtIngrediente3_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.Ingrediente3 = txtIngrediente3.Text.ToString();
        }

        private void txtIngrediente4_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.Ingrediente4 = txtIngrediente4.Text.ToString();
        }

        private void txtIngrediente5_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.Ingrediente5 = txtIngrediente5.Text.ToString();
        }

        private void txtIngrediente6_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.Ingrediente6 = txtIngrediente6.Text.ToString();
        }

        private void txtIngrediente7_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.Ingrediente7 = txtIngrediente7.Text.ToString();
        }

        private void txtIngrediente8_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.Ingrediente8 = txtIngrediente8.Text.ToString();
        }

        private void txtIngrediente9_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.Ingrediente9 = txtIngrediente9.Text.ToString();
        }

        private void txtIngrediente10_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.Ingrediente10 = txtIngrediente10.Text.ToString();
        }

        private void txtModoDePreparo_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.Preparo = txtModoDePreparo.Text.ToString();
        }

        private void txtTitulo_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.Titulo = txtTitulo.Text.ToString();
        }

        private void txtRendimento_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.Rendimento = txtRendimento.Text.ToString();
        }

        private void rdbtn_Lanche_Checked(object sender, RoutedEventArgs e)
        {
            receita.Tipo = "Lanche";
        }

        private void rdbtn_Salgado_Checked(object sender, RoutedEventArgs e)
        {
            receita.Tipo = "Salgado";
        }

        private void rdbtn_Doce_Checked(object sender, RoutedEventArgs e)
        {
            receita.Tipo = "Doce";
        }

        private void rdbtn_Bebida_Checked(object sender, RoutedEventArgs e)
        {
            receita.Tipo = "Bebida";
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (dao.CadastroReceita(receita))
            {
                if (i > 0)
                {
                    File.Copy(img, @"C:\CookYourself\" + receita.Titulo + ".png", true);
                }
                MessageBox.Show("Receita cadastrada com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Algo errado aconteceu durante o cadastro. Cheque se os campos foram preenchidos corretamente.", "Oops!", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
        }

        private void txtTempoPreparo_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.TempoPreparo = txtTempoPreparo.Text.ToString();
        }

        private void txtCustoTotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            receita.CustoTotal = txtCustoTotal.Text.ToString();
        }
    }
}
