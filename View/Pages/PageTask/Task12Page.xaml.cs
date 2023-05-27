﻿using CW.Test.Core;
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

namespace CW.Test.View.Pages.PageTask
{
    /// <summary>
    /// Логика взаимодействия для Task12Page.xaml
    /// </summary>
    public partial class Task12Page : Page
    {
        public Task12Page()
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
            char[] resultArray = new char[inputText.Length];
            resultArray = new char[inputText.Length * 2];
            int index = 0;
            for (int i = 0; i < inputText.Length; i++)
            {
                if (IsRussianLetter(inputText[i]))
                {
                    resultArray[index] = inputText[i];
                    resultArray[index + 1] = ' ';
                    resultArray[index + 2] = '(';
                    resultArray[index + 3] = ((int)inputText[i]).ToString()[0];
                    resultArray[index + 4] = ')';
                    index += 5;
                }
                else if (IsLatinLetter(inputText[i]))
                {
                    resultArray[index] = inputText[i];
                    resultArray[index + 1] = ' ';
                    index += 2;
                }
            }
            inputText = new string(resultArray) + Environment.NewLine;

            return inputText;
        }
        private bool IsRussianLetter(char c)
        {
            // Проверка, является ли символ русской буквой
            return c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я';
        }

        private bool IsLatinLetter(char c)
        {
            // Проверка, является ли символ латинской буквой
            return c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z';
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
