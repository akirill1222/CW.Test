using CW.Test.Core;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace CW.Test.View.Pages.PageTask
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task1Page());
        }
        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task2Page());
        }
        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task3Page());
        }
        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task4Page());
        }
        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task5Page());
        }
        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task6Page());
        }
        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task7Page());
        }
        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task8Page());
        }
        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task9Page());
        }
        private void BtnTask10_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task10Page());
        }
        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task11Page());
        }
        private void BtnTask12_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task12Page());
        }
        private void BtnTask13_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task13Page());
        }
        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?",
                "Системное сообщение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                CoreTest.TestFrame?.Navigate(new MainPage());
            }
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            string inputText = new TextRange(textInput.Document.ContentStart, textInput.Document.ContentEnd).Text;
            string manipulatedText = ManipulateText(inputText);
            textInput.Document.Blocks.Clear();

            Paragraph paragraph = new Paragraph(new Run(manipulatedText));
            resultOutput.Document.Blocks.Add(paragraph);
        }

        private string ManipulateText(string inputText)
        {
            char[] charArray = inputText.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 'я')
                    charArray[i] = ' ';
                else
                    charArray[i] = (char)(charArray[i] + 1);
            }
            inputText = new string(charArray);
            return inputText;
        }
        private void BtnAllTask_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new TaskPage());
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?",
               "Системное сообщение",
               MessageBoxButton.YesNo,
               MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

    }
}