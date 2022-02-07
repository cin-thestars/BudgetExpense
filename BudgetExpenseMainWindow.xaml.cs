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
            var tvm = DataContext as TransactionDataViewModel;
            ntw.Balance = tvm.TransactionData.Balance;
            ntw.Saving = tvm.TransactionData.Saving;
            if (ntw.ShowDialog() == true)
            {
                var dc = ntw.Resources["incomeVM"] as TransactionDataViewModel;
                if (dc != null)
                {
                    
                    if (tvm != null)
                    {
                        if (dc.TransactionData.CategoryType == "Expense")
                        {
                            tvm.AddExpense(dc.TransactionData);
                            tvm.TransactionData.Amount = tvm.TotalExpense();
                            tvm.TransactionData.Balance = tvm.TotalBalance();
                        }
                        else if (dc.TransactionData.CategoryType == "Income")
                        {
                            tvm.AddIncome(dc.TransactionData);
                            tvm.TransactionData.Income = tvm.TotalIncome();
                            tvm.TransactionData.Balance = tvm.TotalBalance();
                        }
                        else if (dc.TransactionData.CategoryType == "Saving")
                        {
                            tvm.AddSaving(dc.TransactionData);
                            tvm.TransactionData.Saving = tvm.TotalSaving();
                            tvm.TransactionData.Balance = tvm.TotalBalance();
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
