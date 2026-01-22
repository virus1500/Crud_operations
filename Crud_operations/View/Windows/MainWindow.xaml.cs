using Crud_operations.Model;
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

namespace Crud_operations.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ProductsLv.ItemsSource = App.context.Product.ToList();
        }
        
        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveProductBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsLv.SelectedItem != null)
            {
                Product selectedProduct = ProductsLv.SelectedItem as Product;   
            MessageBoxResult result = MessageBox.Show("Вы лействитеотно хотите удалить товар?","Вопрос",MessageBoxButton.YesNo,MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                    //DelZapic
                    App.context.Product.Remove(selectedProduct);

                    MessageBox.Show("Товар удалён", "Информайия", MessageBoxButton.OK,MessageBoxImage.Information);

                    App.context.SaveChanges();
                    
                    ProductsLv.ItemsSource = App.context.Product.ToList();
            }
            }
        }

        private void EditProductBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
