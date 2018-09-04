using CookYourself.Model;
using CookYourself.Model.DAO;
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

    public partial class ViewMainMenu : Window
    {
        int i = 0;
        ReceitaDAO dao = new ReceitaDAO();
        Model.ModelReceita receita = new Model.ModelReceita();

        public ViewMainMenu()
        {
            InitializeComponent();
            MessageBox.Show("Bem-Vindo ao Cook Yourself!", "Bem-Vindo!", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            Inicio.Width = 200; Sobre.Width = 200; Salgados.Width = 200; Doces.Width = 200; Lanches.Width = 200; Bebidas.Width = 200;
            Inicio.Height = 60; Sobre.Height = 60; Salgados.Height = 60; Doces.Height = 60; Lanches.Height = 60; Bebidas.Height = 60;

            tblSalgados.ItemsSource = dao.CarregarReceitas("Salgado");
            tblLanches.ItemsSource = dao.CarregarReceitas("Lanche");
            tblBebidas.ItemsSource = dao.CarregarReceitas("Bebida");
            tblDoces.ItemsSource = dao.CarregarReceitas("Doce");
        }

        public string TableSalgado(int i)
        {
            try
            {
                DataGridCellInfo cellInfo = tblSalgados.SelectedCells[i];
                DataGridBoundColumn column = cellInfo.Column as DataGridBoundColumn;
                FrameworkElement element = new FrameworkElement() { DataContext = cellInfo.Item };
                BindingOperations.SetBinding(element, TagProperty, column.Binding);

                return (element.Tag.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Por favor, selecione a receita que você gostaria de visualizar.", "Aviso!", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

            return null;
        }

        public string TableLanches(int i)
        {
            try
            {
                DataGridCellInfo cellInfo = tblLanches.SelectedCells[i];
                DataGridBoundColumn column = cellInfo.Column as DataGridBoundColumn;
                FrameworkElement element = new FrameworkElement() { DataContext = cellInfo.Item };
                BindingOperations.SetBinding(element, TagProperty, column.Binding);

                return (element.Tag.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Por favor, selecione a receita que você gostaria de visualizar.", "Aviso!", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

            return null;
        }

        public string TableDoces(int i)
        {
            try
            {
                DataGridCellInfo cellInfo = tblDoces.SelectedCells[i];
                DataGridBoundColumn column = cellInfo.Column as DataGridBoundColumn;
                FrameworkElement element = new FrameworkElement() { DataContext = cellInfo.Item };
                BindingOperations.SetBinding(element, TagProperty, column.Binding);

                return (element.Tag.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Por favor, selecione a receita que você gostaria de visualizar.", "Aviso!", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

            return null;
        }

        public string TableBebidas(int i)
        {
            try
            {
                DataGridCellInfo cellInfo = tblBebidas.SelectedCells[i];
                DataGridBoundColumn column = cellInfo.Column as DataGridBoundColumn;
                FrameworkElement element = new FrameworkElement() { DataContext = cellInfo.Item };
                BindingOperations.SetBinding(element, TagProperty, column.Binding);

                return (element.Tag.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Por favor, selecione a receita que você gostaria de visualizar.", "Aviso!", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

            return null;
        }

        public string TableMensagens(int i)
        {
            try
            {
                DataGridCellInfo cellInfo = tblMensagens.SelectedCells[i];
                DataGridBoundColumn column = cellInfo.Column as DataGridBoundColumn;
                FrameworkElement element = new FrameworkElement() { DataContext = cellInfo.Item };
                BindingOperations.SetBinding(element, TagProperty, column.Binding);

                return (element.Tag.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Por favor, selecione a receita que você gostaria de visualizar.", "Aviso!", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
            }

            return null;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ViewCadastro cadastro = new ViewCadastro();
            cadastro.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void tblBebidas_Loaded(object sender, RoutedEventArgs e)
        {
            receita.Tipo = "Bebida";
            tblBebidas.ItemsSource = dao.CarregarReceitas("Bebida");
        }

        private void tblDoces_Loaded(object sender, RoutedEventArgs e)
        {
            receita.Tipo = "Doce";
            tblDoces.ItemsSource = dao.CarregarReceitas("Doce");
        }


        private void tblSalgados_Loaded(object sender, RoutedEventArgs e)
        {
            receita.Tipo = "Salgado";
            tblSalgados.ItemsSource = dao.CarregarReceitas("Salgado");
        }

        private void tblLanches_Loaded(object sender, RoutedEventArgs e)
        {
            receita.Tipo = "Lanche";
            tblLanches.ItemsSource = dao.CarregarReceitas("Lanche");
        }

        private void btnNovoSalgado_Click(object sender, RoutedEventArgs e)
        {
            ViewCadastro cadastro = new ViewCadastro();
            cadastro.ShowDialog();
            tblSalgados.ItemsSource = dao.CarregarReceitas(receita.Tipo);
        }

        private void btnviewSalgado_Click(object sender, RoutedEventArgs e)
        {
            if (TableSalgado(0) != null)
            {

                ModelReceita r = new ModelReceita();
                r = dao.Selection(TableSalgado(0));
                ViewCadastro c = new ViewCadastro(r);
                c.ShowDialog();
                tblSalgados.ItemsSource = dao.CarregarReceitas(receita.Tipo);
            }
        }

        private void btnDeleteSalgado_Click(object sender, RoutedEventArgs e)
        {
            if (TableSalgado(0) != null)
            {
                MessageBoxResult result = MessageBox.Show("Você tem certeza de que gostaria de excluir a receita selecionada?",
               "Aviso!", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {

                    Model.ModelReceita receita = new Model.ModelReceita();
                    receita = dao.Selection(TableSalgado(0));
                    if (dao.DeletarReceita(TableSalgado(0)))
                    {
                        string path = @"D:\CookYourself";
                        string filesToDelete = receita.Titulo + ".png";
                        string[] fileList = Directory.GetFiles(path, filesToDelete);
                        if (Directory.Exists(@"D:\CookYourself"))
                        {
                            foreach (string file in fileList)
                            {
                                File.Delete(file);
                            }
                        }

                        MessageBox.Show("A receita foi deletada com sucesso!", "Sucesso!", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                    }
                    else
                    {
                        MessageBox.Show("Algo errado aconteceu ao deletar a receita. Por favor, tente novamente mais tarde.", "Oops!", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    }
                }
                else
                {

                }
            }
            tblSalgados.ItemsSource = dao.CarregarReceitas(receita.Tipo);
        }

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblSalgados.ItemsSource = dao.Filtrar(txtFilter.Text, "Salgado");
        }

        private void btnNovoLanche_Click(object sender, RoutedEventArgs e)
        {
            ViewCadastro cadastro = new ViewCadastro();
            cadastro.ShowDialog();
            tblLanches.ItemsSource = dao.CarregarReceitas(receita.Tipo);
        }

        private void btnNovoDoce_Click(object sender, RoutedEventArgs e)
        {
            ViewCadastro cadastro = new ViewCadastro();
            cadastro.ShowDialog();
            tblDoces.ItemsSource = dao.CarregarReceitas(receita.Tipo);
        }

        private void btnNovaBebida_Click(object sender, RoutedEventArgs e)
        {
            ViewCadastro cadastro = new ViewCadastro();
            cadastro.ShowDialog();
            tblBebidas.ItemsSource = dao.CarregarReceitas(receita.Tipo);
        }

        private void btnDeleteLanche_Click(object sender, RoutedEventArgs e)
        {
            if (TableLanches(0) != null)
            {
                MessageBoxResult result = MessageBox.Show("Você tem certeza de que gostaria de excluir a receita selecionada?",
               "Aviso!", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {

                    Model.ModelReceita receita = new Model.ModelReceita();
                    receita = dao.Selection(TableLanches(0));
                    if (dao.DeletarReceita(TableLanches(0)))
                    {
                        string path = @"D:\CookYourself";
                        string filesToDelete = receita.Titulo + ".png";
                        string[] fileList = Directory.GetFiles(path, filesToDelete);
                        if (Directory.Exists(@"D:\CookYourself"))
                        {
                            foreach (string file in fileList)
                            {
                                File.Delete(file);
                            }
                        }
                        MessageBox.Show("A receita foi deletada com sucesso!", "Sucesso!", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                    }
                    else
                    {
                        MessageBox.Show("Algo errado aconteceu ao deletar a receita. Por favor, tente novamente mais tarde.", "Oops!", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    }
                }
                else
                {

                }
            }
            tblLanches.ItemsSource = dao.CarregarReceitas(receita.Tipo);
        }

        private void btnDeleteDoce_Click(object sender, RoutedEventArgs e)
        {
            if (TableDoces(0) != null)
            {
                MessageBoxResult result = MessageBox.Show("Você tem certeza de que gostaria de excluir a receita selecionada?",
               "Aviso!", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {

                    Model.ModelReceita receita = new Model.ModelReceita();
                    receita = dao.Selection(TableDoces(0));
                    if (dao.DeletarReceita(TableDoces(0)))
                    {
                        string path = @"D:\CookYourself";
                        string filesToDelete = receita.Titulo + ".png";
                        string[] fileList = Directory.GetFiles(path, filesToDelete);
                        if (Directory.Exists(@"D:\CookYourself"))
                        {
                            foreach (string file in fileList)
                            {
                                File.Delete(file);
                            }
                        }
                        MessageBox.Show("A receita foi deletada com sucesso!", "Sucesso!", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                    }
                    else
                    {
                        MessageBox.Show("Algo errado aconteceu ao deletar a receita. Por favor, tente novamente mais tarde.", "Oops!", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    }
                }
                else
                {

                }
            }
            tblDoces.ItemsSource = dao.CarregarReceitas(receita.Tipo);
        }

        private void btnDeleteBebida_Click(object sender, RoutedEventArgs e)
        {
            if (TableBebidas(0) != null)
            {
                MessageBoxResult result = MessageBox.Show("Você tem certeza de que gostaria de excluir a receita selecionada?",
               "Aviso!", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {

                    Model.ModelReceita receita = new Model.ModelReceita();
                    receita = dao.Selection(TableBebidas(0));
                    if (dao.DeletarReceita(TableBebidas(0)))
                    {
                        string path = @"D:\CookYourself";
                        string filesToDelete = receita.Titulo + ".png";
                        string[] fileList = Directory.GetFiles(path, filesToDelete);
                        if (Directory.Exists(@"D:\CookYourself"))
                        {
                            foreach (string file in fileList)
                            {
                                File.Delete(file);
                            }
                        }
                        MessageBox.Show("A receita foi deletada com sucesso!", "Sucesso!", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                    }
                    else
                    {
                        MessageBox.Show("Algo errado aconteceu ao deletar a receita. Por favor, tente novamente mais tarde.", "Oops!", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                    }
                }
                else
                {

                }
            }
            tblBebidas.ItemsSource = dao.CarregarReceitas(receita.Tipo);
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                txtFilter.Visibility = Visibility.Visible;
                i = 1;
            }
            else if (i == 1)
            {
                txtFilter.Visibility = Visibility.Hidden;
                txtFilter.Text = "";
                tblSalgados.ItemsSource = dao.CarregarReceitas(receita.Tipo);
                i = 0;

            }
        }

        private void btnFiltrarLanche_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                txtFiltrarLanche.Visibility = Visibility.Visible;
                i = 1;
            }
            else if (i == 1)
            {
                txtFiltrarLanche.Visibility = Visibility.Hidden;
                txtFiltrarLanche.Text = "";
                tblLanches.ItemsSource = dao.CarregarReceitas(receita.Tipo);
                i = 0;

            }
        }

        private void btnFiltrarDoce_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                txtFiltrarDoce.Visibility = Visibility.Visible;
                i = 1;
            }
            else if (i == 1)
            {
                txtFiltrarDoce.Visibility = Visibility.Hidden;
                txtFiltrarDoce.Text = "";
                tblDoces.ItemsSource = dao.CarregarReceitas(receita.Tipo);
                i = 0;

            }

        }

        private void btnFiltrarBebida_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                txtFiltrarBebida.Visibility = Visibility.Visible;
                i = 1;
            }
            else if (i == 1)
            {
                txtFiltrarBebida.Visibility = Visibility.Hidden;
                txtFiltrarBebida.Text = "";
                tblBebidas.ItemsSource = dao.CarregarReceitas(receita.Tipo);
                i = 0;

            }
        }

        private void txtFiltrarLanche_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblLanches.ItemsSource = dao.Filtrar(txtFilter.Text, "Lanche");
        }

        private void txtFiltrarDoce_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblDoces.ItemsSource = dao.Filtrar(txtFilter.Text, "Doce");
        }

        private void txtFiltrarBebida_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblBebidas.ItemsSource = dao.Filtrar(txtFilter.Text, "Bebida");
        }

        private void btnViewBebida_Click(object sender, RoutedEventArgs e)
        {
            if (TableBebidas(0) != null)
            {

                ModelReceita r = new ModelReceita();
                r = dao.Selection(TableBebidas(0));
                ViewCadastro c = new ViewCadastro(r);
                c.ShowDialog();
                tblBebidas.ItemsSource = dao.CarregarReceitas(receita.Tipo);
            }
        }

        private void btnViewDoce_Click(object sender, RoutedEventArgs e)
        {
            if (TableDoces(0) != null)
            {

                ModelReceita r = new ModelReceita();
                r = dao.Selection(TableDoces(0));
                ViewCadastro c = new ViewCadastro(r);
                c.ShowDialog();
                tblDoces.ItemsSource = dao.CarregarReceitas(receita.Tipo);
            }
        }

        private void btnViewLanche_Click(object sender, RoutedEventArgs e)
        {
            if (TableLanches(0) != null)
            {

                ModelReceita r = new ModelReceita();
                r = dao.Selection(TableLanches(0));
                ViewCadastro c = new ViewCadastro(r);
                c.ShowDialog();
                tblLanches.ItemsSource = dao.CarregarReceitas(receita.Tipo);
            }
        }

        private void tblSalgados_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (TableSalgado(0) != null)
            {

                ModelReceita r = new ModelReceita();
                r = dao.Selection(TableSalgado(0));
                ViewCadastro c = new ViewCadastro(r);
                c.ShowDialog();
                tblSalgados.ItemsSource = dao.CarregarReceitas(receita.Tipo);
            }
        }

        private void tblLanches_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (TableLanches(0) != null)
            {

                ModelReceita r = new ModelReceita();
                r = dao.Selection(TableLanches(0));
                ViewCadastro c = new ViewCadastro(r);
                c.ShowDialog();
                tblLanches.ItemsSource = dao.CarregarReceitas(receita.Tipo);
            }
        }

        private void tblDoces_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (TableDoces(0) != null)
            {

                ModelReceita r = new ModelReceita();
                r = dao.Selection(TableDoces(0));
                ViewCadastro c = new ViewCadastro(r);
                c.ShowDialog();
                tblDoces.ItemsSource = dao.CarregarReceitas(receita.Tipo);
            }
        }

        private void Bebidas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (TableBebidas(0) != null)
            {

                ModelReceita r = new ModelReceita();
                r = dao.Selection(TableBebidas(0));
                ViewCadastro c = new ViewCadastro(r);
                c.ShowDialog();
                tblBebidas.ItemsSource = dao.CarregarReceitas(receita.Tipo);
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Salgados.Focus();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Lanches.Focus();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Doces.Focus();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Bebidas.Focus();
        }

        private void lblLasanha_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ModelReceita r = new ModelReceita();
            r = dao.Selection(lblLasanha.Content.ToString());
            ViewCadastro c = new ViewCadastro(r);
            c.ShowDialog();
        }

        private void lblMargarita_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ModelReceita r = new ModelReceita();
            r = dao.Selection(lblMargarita.Content.ToString());
            ViewCadastro c = new ViewCadastro(r);
            c.ShowDialog();
        }

        private void lblPudim_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ModelReceita r = new ModelReceita();
            r = dao.Selection(lblPudim.Content.ToString());
            ViewCadastro c = new ViewCadastro(r);
            c.ShowDialog();
        }

        private void lblLanche_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ModelReceita r = new ModelReceita();
            r = dao.Selection(lblLanche.Content.ToString());
            ViewCadastro c = new ViewCadastro(r);
            c.ShowDialog();
        }

        private void tblMensagens_Loaded(object sender, RoutedEventArgs e)
        {
            tblMensagens.ItemsSource = dao.CarregarMensagens();
        }
    }
}
