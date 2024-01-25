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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {

        }

        private void inputKey()
        {
        
            string[] alphabet = { "A", "a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f", "G", "g", "H", "h", "I", "i", "J", "j", "K", "k", "L", "l", "M", "m", "N", "n", "O", "o", "P", "p", "Q", "q", "R", "r", "S", "s", "T", "t", "U", "u", "V", "v", "W", "w", "X", "x", "Y", "y", "Z", "z" };
            string x = inputBox.Text;
            string codeString = "";
            for (int i = 0; i< 52; i++){
                int value = Convert.ToInt32([i]);
                value = value + shift.code;
                value = value % 26;
            }
        }



    char A = (char)65;
    Console.WriteLine(A);

        //Array.setvalue
        //int[] alphabet = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16, 17, 17, 18, 18, 19, 19, 20, 20, 21, 21, 22, 22, 23, 23, 24, 24, 25, 25, 26, 26 };
        // string[] stringArray = new string[26];








        /*letters = Console.ReadLine();

        int res;
        res = Convert.ToInt32(letters);

        string inputNum = (Console.ReadLine());
        inputNum = Console.ReadLine();

        int num;
        num = Convert.ToInt32(inputNum);



        Console.WriteLine(newLetters);
        InitializeComponent();*/
    }
}
