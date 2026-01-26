using Crud_operations.Model;
using Microsoft.Win32;
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
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private Product selectedProduct;

        public EditWindow(Product selectedProduct)
        {
            InitializeComponent();
            this.selectedProduct = selectedProduct;
            DataContext = selectedProduct;// Привязываем товар к контексту данных окна для реализации вывода значений в элементах управления.

            CatCmb.ItemsSource = App.context.Category.ToList();//Загружаем список категорий
            CatCmb.DisplayMemberPath = "name";//Отображаем у элемента название
            CatCmb.SelectedValuePath = "id";//При выборе элемента копируем ID
            CatCmb.SelectedIndex = 0;//Выбираем первый элемент списта по умолчанию

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            App.context.SaveChanges();

            MessageBox.Show("Продукт успешно отредоктирован!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

            DialogResult = true;
        }

        private void LoadFromPCBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                PhotoTB.Text = openFileDialog.FileName;
            }
        }
    }
}
