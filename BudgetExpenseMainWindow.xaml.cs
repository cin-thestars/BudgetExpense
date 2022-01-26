﻿using System;
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

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NewTransactionWindow ntw = new NewTransactionWindow();
            if(ntw.ShowDialog() == true)
            {
                
                var dc = ntw.Resources["incomeVM"] as TransactionDataViewModel;
                if(dc != null)
                {
                    var tvm = DataContext as TransactionDataViewModel;
                    if(tvm != null)
                    {
                        
                        if(dc.TransactionData.CategoryType == "Expense")
                        {
                            tvm.AddExpense(dc.TransactionData);
                            tvm.TransactionData.Amount = tvm.TotalExpense();
                        }
                        else if (dc.TransactionData.CategoryType == "Income")
                        {
                            tvm.AddIncome(dc.TransactionData);
                            tvm.TransactionData.Expenses = tvm.TotalIncome();
                        }
                        else if(dc.TransactionData.CategoryType == "Saving")
                        {
                            tvm.AddSaving(dc.TransactionData);
                        }
                        
                    }
                    
                }
            }
        }
    }
}
