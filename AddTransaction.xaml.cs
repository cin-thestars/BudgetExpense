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
using System.Windows.Shapes;

namespace BudgetExpense
{
    /// <summary>
    /// Interaction logic for AddTransaction.xaml
    /// </summary>
    public partial class AddTransaction : Window
    {
        public AddTransaction()
        {
            InitializeComponent();
        }

        private void TabItemSelected(object sender, RoutedEventArgs e)
        {
            var tc = sender as TabControl;
            MessageBox.Show(""+tc.SelectedIndex);
        }

        private void Click_Save(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void Click_Cancel(object sender, RoutedEventArgs e)
        {
            DialogResult=false;
            Close();
        }
    }
}
