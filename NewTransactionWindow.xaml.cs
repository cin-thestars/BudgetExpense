using BudgetExpense.ViewModel;
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
    /// Interaction logic for NewTransactionWindow.xaml
    /// </summary>
    public partial class NewTransactionWindow : Window
    {
        public decimal Balance { get; internal set; }
        public decimal Saving { get; internal set; }

        public NewTransactionWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*var ExpenseCategoryCb = sender as ComboBox;
            if(ExpenseCategoryCb != null)
            {
                var gt = ExpenseCategoryCb.SelectedItem as ExpenseCategoryModel;
            }*/
        }

        private void ExpenseCategoryComboBox_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void DoCancelBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void DoSaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var dc = Resources["incomeVM"] as TransactionDataViewModel;
            if (dc.TransactionData.CategoryType == "Expense" && (Balance - dc.TransactionData.Amount) < Saving)
            {
                var res = MessageBox.Show("You have exceeded your saving money. Do you want to continue?","Warning", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
                if (res == MessageBoxResult.Yes)
                {
                    DialogResult = true;
                }
                else
                    DialogResult = false;
            }
            else
            {
                DialogResult = true;
            }
            Close();
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
