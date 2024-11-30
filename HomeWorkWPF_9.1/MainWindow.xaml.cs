using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace HomeWorkWPF_9._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод разделение строки на слова
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] Split(string text)
        {
            return text.Split();
        }
        /// <summary>
        /// Метод перестановки текста
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string Reverse(string text)
        {
            return string.Join("", text.Reverse());
        }
        /// <summary>
        /// Кнопка Разделить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Split(object sender, RoutedEventArgs e)
        {
                SplitText.ItemsSource = new List<string>(Split(TextBox1.Text));
        }
        /// <summary>
        /// Кнопка перестановка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Reverse(object sender, RoutedEventArgs e)
        {
                //LabelReverse.Content = Reverse(TextBox1.Text); Пробовал так текст переставить, но он вылезал за рамки окна
                ReverseText.Text = Reverse(TextBox2.Text);
        }
        
    }
}
