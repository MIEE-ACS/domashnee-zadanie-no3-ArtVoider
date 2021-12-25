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

namespace Work3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbotv.Text = "   ";
            int k = 0;
            for (int i = 0; i < TB.Text.Length; i++)
            {
                if (TB.Text[i] == '.' || TB.Text[i] == '!' || TB.Text[i] == '?' || TB.Text[i] == ';')
                    k += 1;
            }

            for (int i = 3; i < TB.Text.Length; i++)   
            {
                if (TB.Text[i] == '.' & TB.Text[i - 1] == '.' & TB.Text[i - 2] == '.')//Обработаем исключения - ...
                {
                    k -= 2;
                }
                if (TB.Text[i] == '!' & TB.Text[i - 1] == '?')//Обработаем исключения - !?
                { 
                    k -= 1;
                }
                if (TB.Text[i] == '!' & TB.Text[i - 1] == '?')//Обработаем ошибку исключения - ?!
                {
                    k -= 1;
                }
            }


            tbotv.Text = $"В тексте присутствуют {k} предложений!";

        }

    }
}