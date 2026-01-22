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
    /// Логика взаимодействия для AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        public AddProductWindow()
        {
            InitializeComponent();
            CatCmb.ItemsSource = App.context.Category.ToList();//Загружаем список категорий
            CatCmb.DisplayMemberPath = "Name";//Отображаем у элемента название
            CatCmb.SelectedValuePath = "id";//При выборе элемента копируем ID
            CatCmb.SelectedIndex= 0;//Выбираем первый элемент списта по умолчанию

            DataDP.SelectedDate = DateTime.Now;//Выбираем текущую дату по умолчанию
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                PhotoTB.Text= openFileDialog.FileName;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
