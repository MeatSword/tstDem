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
using WpfApp1.pAGES;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public versh_dbEntities db = new versh_dbEntities();
        public MainWindow()
        {
            InitializeComponent();

            
            Page1 nextPage = new Page1();
            frame.Navigate(nextPage);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
