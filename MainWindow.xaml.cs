using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
  
public partial class MainWindow : Window
    {
        
            

            
        
        public MainWindow()
        {
            InitializeComponent();

            // генерируем случайную строку заданной длинны
            int length = 20;
            string s1 = GenStr.Str1(length);
            GeneratedLabel.Content = s1;
        }
        
        public void ProcessButton_Click(object sender, RoutedEventArgs e)
        {   
            //Получаем строки
            string CurentKey = GeneratedLabel.Content.ToString();
            string text = GetKey.Text;

            //Проверяем строку, полученную от пользователя
            if (string.IsNullOrEmpty(CurentKey) || string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Введите строку и символы для поиска!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            ResultPanel.Children.Clear();

            //Создание массива строк, разбитого согласно взходящей подстроки
            string[] parts = CurentKey.Split(new[] { text }, StringSplitOptions.None);



            for (int i = 0; i < parts.Length; i++)
            {
                //Добавление текстового объекта в рузультирующий элемент
                TextBlock textBlock = new TextBlock
                {
                    Text = parts[i],
                    Margin = new Thickness(0, 0, 5, 5)
                };
                ResultPanel.Children.Add(textBlock);

                if (i < parts.Length - 1)
                {
                    //Добавление редактиремого объекта в рузультирующий элемент
                    TextBox textBox = new TextBox
                    {
                        Text = text,
                        Width = 50,
                        Margin = new Thickness(0, 0, 5, 5)
                    };
                    ResultPanel.Children.Add(textBox);
                }
            }




        }
           

    }


}