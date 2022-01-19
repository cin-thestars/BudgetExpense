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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_NewTransaction(object sender, RoutedEventArgs e)
        {
            AddTransaction at = new AddTransaction();
            if (at.ShowDialog() == true)
            {
                var dc = at.Resources["incomeVM"] as CategoryAddViewModel;
                if(dc != null)
                {
                    MessageBox.Show(""+dc.ExpData.Amount);
                    var tvm = DataContext as TransactionViewModel;
                    if(tvm != null)
                    {
                        tvm.AddExpanse(dc.ExpData);
                    }
                }
            }
        }
    }
}
