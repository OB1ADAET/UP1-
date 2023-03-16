using System; 
using System.Collections.Generic;
using System.Data;
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
using mysql1.mysql1DataSetTableAdapters;

namespace mysql1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        usersTableAdapter usersTableAdapter = new usersTableAdapter ();
        public MainWindow()
        {
            InitializeComponent();
            datatop.ItemsSource = usersTableAdapter.GetData();
            sas1.ItemsSource = usersTableAdapter.GetData ();
            sas1.DisplayMemberPath = "fname";
        }

        private void sas1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show((sas1.SelectedItem as DataRowView).Row[2].ToString());
        }
    }
}
