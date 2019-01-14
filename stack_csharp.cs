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

namespace stackApp
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
        
        int[] arr = new int[99];
        int tos = 99;
        bool isfull()
        {
            if(0 <= tos && tos < arr.Length)
                return true;
            else
                return false;
        }
        bool isempty()
        {
            if (99 >= tos && tos > arr.Length)
                return false;
            else
                return true;
        }
        void push(int tos)
        {
            if (isfull() == false)
            {
                arr[tos] = 5;
                tos--;
            }
        }
        int pops(){
            if (isempty() == false)
            {
                return arr[tos];
                tos++;
            }
            return 0;
        }
    }
}
