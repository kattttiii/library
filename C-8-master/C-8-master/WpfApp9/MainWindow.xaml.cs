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
using SerLib;

namespace WpfApp9
{
    public partial class MainWindow : Window
    {
        // Конструктор для инициализации компонентов окна.
        public MainWindow()
        {
            InitializeComponent();
        }

        // Метод, вызываемый при нажатии кнопки "Save".
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Сериализация текста из TextBox в файл "Save.json".
            Class1.MySerialize(Tbx.Text, "Save.json");
        }

        // Метод, вызываемый при нажатии кнопки "Load".
        private void Load_Click(object sender, RoutedEventArgs e)
        {
            // Десериализация текста из файла "Save.json" в TextBox.
            Tbx.Text = Class1.MyDeserialize<string>("Save.json");
        }

        // Метод, вызываемый при изменении выбранного элемента в ComboBox.
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Если выбран второй элемент (индекс 1), установить язык приложения на английский.
            if (LangCombo.SelectedIndex == 1)
            {
                App.Lang = "en-en";
            }
            // В противном случае установить язык приложения на русский.
            else
            {
                App.Lang = "ru-ru";
            }
        }
    }
}