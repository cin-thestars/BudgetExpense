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
using BudgetExpense.ViewModel;
using BudgetExpense.Model;

namespace BudgetExpense
{
    /// <summary>
    /// Interaction logic for BudgetExpenseMainWindow.xaml
    /// </summary>
    public partial class BudgetExpenseMainWindow : Window
    {
        public BudgetExpenseMainWindow()
        {
            InitializeComponent();
        }

        private void Add_NewTransaction_Button(object sender, RoutedEventArgs e)
        {
            AddTransaction ntw = new AddTransaction();
            if (ntw.ShowDialog() == true)
            {
                var dc = DataContext as Transaction_Add_View_Model;
                if (dc != null)
                {
                    var tvm = DataContext as Transaction_Add;
                    MessageBox.Show("" + tvm.Amount);
                }
            }
        }

        private void Language_ButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
