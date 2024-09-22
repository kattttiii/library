using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp9
{
    public partial class App : Application
    {
        // Поле для хранения текущего языка приложения.
        private static string lang;

        // Свойство для доступа к текущему языку приложения.
        public static string Lang
        {
            get { return lang; }
            set
            {
                // Устанавливаем значение поля lang.
                lang = value;

                // Создаем новый словарь ресурсов, основанный на выбранном языке.
                var dict = new ResourceDictionary { Source = new Uri($"/CustomLib;component/Dictionaries/lang.{value}.xaml", UriKind.Relative) };

                // Удаляем текущий словарь ресурсов (первый в списке).
                Current.Resources.MergedDictionaries.RemoveAt(0);

                // Добавляем новый словарь ресурсов на место удаленного.
                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }

        // Конструктор приложения.
        public App()
        {
            // Инициализируем компоненты приложения.
            InitializeComponent();
        }
    }
}
