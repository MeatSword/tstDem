using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace WpfApp1.pAGES
{
    /// <summary>
    /// Логика взаимодействия для list.xaml
    /// </summary>
    public partial class list : Page
    {
        public ObservableCollection<Tovari> Tv = new ObservableCollection<Tovari>();
        public versh_dbEntities db= new versh_dbEntities();
        public list()
        {
        
            InitializeComponent();
            this.DataContext = this;
            foreach (Tovari Itm in db.Tovari.ToList())
            {
                Tv.Add(Itm);
                
            }
            lbList.ItemsSource = Tv;
        }
    }
}
