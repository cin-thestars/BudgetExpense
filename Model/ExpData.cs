using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetExpense.Model
{
    [Serializable]
    public class ExpData
    {
        public string Type { get; set; } = "Expense";
        public string Name { get; set; } = "";
        public string Category { get; set; } = string.Empty;
        public double Amount { get; set; } = 0;
        public DateTime Date { get; set; }= DateTime.Now;
    }
}
