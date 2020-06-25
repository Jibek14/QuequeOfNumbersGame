using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
namespace hw3_2
{
    public partial class MainWindow : Window
    {
        int userPoints = 0; int[] userAnswers = new int[SIZE]; int[] arr = new int[SIZE];
        int iteration = 0; int[] trueAnswers = new int[SIZE]; const int SIZE = 9;bool start = false;
        public MainWindow()
        {
            InitializeComponent();
            bool alreadyHave;
            for (int i = 0; i < SIZE;)
            {
                alreadyHave = false;
                Random randNum = new Random();
                int buttonNumbers = randNum.Next(1, 10);
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] == buttonNumbers)
                    {
                        alreadyHave = true;
                        break;
                    }
                }
                if (!alreadyHave)
                {
                    arr[i] = buttonNumbers;
                    trueAnswers[i] = i;
                    i++;
                }
            }
            NumberA.Content = arr[0];
            NumberB.Content = arr[1];
            NumberC.Content = arr[2];
            NumberD.Content = arr[3];
            NumberI.Content = arr[4];
            NumberE.Content = arr[5];
            NumberF.Content = arr[6];
            NumberH.Content = arr[7];
            NumberG.Content = arr[8];
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            start = true;
            NumberA.Content = string.Empty;
            NumberB.Content = string.Empty;
            NumberC.Content = string.Empty;
            NumberD.Content = string.Empty;
            NumberI.Content = string.Empty;
            NumberE.Content = string.Empty;
            NumberF.Content = string.Empty;
            NumberH.Content = string.Empty;
            NumberG.Content = string.Empty;
        }

        private void NumberA_Click(object sender, RoutedEventArgs e)//0
        {   if(start)
            {

         
            iteration++;
            if (iteration == 9)
            {
                if (userAnswers[iteration - 1] == trueAnswers[iteration-1])
                {
                    ++userPoints;
                }
                MessageBox.Show("верных ответов: " + userPoints); iteration=0;Close();
            }
            userAnswers[iteration] = arr[0];

        if (userAnswers[iteration] == trueAnswers[iteration])
                {
                    ++userPoints;
                }
          
     }
        }
        private void NumberB_Click(object sender, RoutedEventArgs e)//1
        {
            if (start)
            {

        
            iteration++;
            if (iteration == 9)
            {
                if (userAnswers[iteration-1] == trueAnswers[iteration-1])
                {
                    ++userPoints;
                }
                MessageBox.Show("верных ответов: " + userPoints); iteration=0;Close();
            }
            userAnswers[iteration] = arr[1];
            if (userAnswers[iteration] == trueAnswers[iteration])
            {
                ++userPoints;
            }
              }
       
        }
        private void NumberC_Click(object sender, RoutedEventArgs e)//2
        {
            if (start)
            {
                iteration++;
                if (iteration == 9)
                {
                    if (userAnswers[iteration - 1] == trueAnswers[iteration - 1])
                    {
                        ++userPoints;
                    }
                    MessageBox.Show("верных ответов: " + userPoints); iteration = 0; Close();
                }
                userAnswers[iteration] = arr[2];
                if (userAnswers[iteration] == trueAnswers[iteration])
                {
                    ++userPoints;
                }
            }
         
        }

        private void NumberD_Click(object sender, RoutedEventArgs e)//3
        {if (start)
            {
                iteration++;
                if (iteration == 9)
                {
                    if (userAnswers[iteration - 1] == trueAnswers[iteration - 1])
                    {
                        ++userPoints;
                    }
                    MessageBox.Show("верных ответов: " + userPoints);
                    iteration = 0; Close();
                }
                userAnswers[iteration] = arr[3];
                if (userAnswers[iteration] == trueAnswers[iteration])
                {
                    ++userPoints;
                }

            }
        }

        private void NumberF_Click(object sender, RoutedEventArgs e)//6
        { if (start)
            {
                iteration++;
                if (iteration == 9)
                {
                    if (userAnswers[iteration - 1] == trueAnswers[iteration - 1])
                    {
                        ++userPoints;
                    }
                    MessageBox.Show("верных ответов: " + userPoints); iteration = 0; Close();
                }
                userAnswers[iteration] = arr[6];
                if (userAnswers[iteration] == trueAnswers[iteration])
                {
                    ++userPoints;
                }
            }
        }

        private void NumberG_Click(object sender, RoutedEventArgs e)//8
        {  if (start)
            {
                iteration++;
                if (iteration == 9)
                {
                    if (userAnswers[iteration - 1] == trueAnswers[iteration - 1])
                    {
                        ++userPoints;
                    }
                    MessageBox.Show("верных ответов: " + userPoints); iteration = 0; Close();

                }

                userAnswers[iteration] = arr[8];
                if (userAnswers[iteration] == trueAnswers[iteration])
                {
                    ++userPoints;
                }
            }
        }

        private void NumberE_Click(object sender, RoutedEventArgs e)//5
        {  if (start)
            {
                iteration++;
                if (iteration == 9)
                {
                    if (userAnswers[iteration - 1] == trueAnswers[iteration - 1])
                    {
                        ++userPoints;
                    }
                    MessageBox.Show("верных ответов: " + userPoints); iteration = 0; Close();
                }
                userAnswers[iteration] = arr[5];
                if (userAnswers[iteration] == trueAnswers[iteration])
                {
                    ++userPoints;
                }

            }
        }

        private void NumberI_Click(object sender, RoutedEventArgs e)//4
        {   if (start)
            {
                iteration++;
                if (iteration == 9)
                {
                    if (userAnswers[iteration - 1] == trueAnswers[iteration - 1])
                    {
                        ++userPoints;
                    }
                    MessageBox.Show("верных ответов: " + userPoints); iteration = 0; Close();
                }
                userAnswers[iteration] = arr[4];
                if (userAnswers[iteration] == trueAnswers[iteration])
                {
                    ++userPoints;
                }
            }
        }
        private void NumberH_Click(object sender, RoutedEventArgs e)//7
        {
            if (start)
            {
                iteration++;
                if (iteration == 9)
                {
                    if (userAnswers[iteration - 1] == trueAnswers[iteration - 1])
                    {
                        ++userPoints;
                    }
                    MessageBox.Show("верных ответов: " + userPoints); iteration = 0; Close();
                }
                userAnswers[iteration] = arr[7];
                if (userAnswers[iteration] == trueAnswers[iteration])
                {
                    ++userPoints;
                }
            }
        }
    }
}