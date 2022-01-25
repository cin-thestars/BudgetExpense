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
                var dc = ntw.Resources["incomeVM"] as Transaction_Add_View_Model;
                if (dc != null)
                {
                    var tvm = DataContext as Transaction_Add_View_Model;
                    if (tvm != null)
                    {
                        if (dc.Transaction_Add.Type == "Expense")
                        {
                            tvm.AddExpense(dc.Transaction_Add);
                        }
                        else if (dc.Transaction_Add.Type == "Income")
                        {
                            tvm.AddIncome(dc.Transaction_Add);
                        }
                        else if (dc.Transaction_Add.Type == "Saving")
                        {
                            tvm.AddSaving(dc.Transaction_Add);
                        }
                    }
                }
            }
        }

        private void Language_ButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
