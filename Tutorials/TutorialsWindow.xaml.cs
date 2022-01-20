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
using System.IO;
using System.Collections.ObjectModel;
using System.Reflection;

namespace BudgetExpense.Tutorials
{
    /// <summary>
    /// Interaction logic for TutortialsWindow.xaml
    /// </summary>
    public partial class TutortialsWindow : Window
    {
        public TutortialsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void OpenLink(object sender, RoutedEventArgs e)
        {
            var uiEl = sender as Hyperlink;
            if(uiEl != null && uiEl.Tag != null)
            {
                var t = uiEl.Tag as Tutorial;
                if(t != null)
                {
                    var obj = Activator.CreateInstance(Assembly.GetExecutingAssembly().GetType(t.Namespace));
                    if (obj != null)
                    {
                        Window w = obj as Window;
                        w?.ShowDialog();
                    }
                }
            }
        }
    }
    public class TutorialsViewModel
    {
        public ObservableCollection<Tutorial> Tutorials { get; set; } = new ObservableCollection<Tutorial>();
        public TutorialsViewModel()
        {
            DirectoryInfo directory = new DirectoryInfo(@"D:\STEP\2021\FT_SD_A_2\WPF\BudgetExpense\Tutorials\");
            foreach (var t in directory.GetDirectories()){
                Tutorials.Add(new Tutorial { Namespace = "BudgetExpense.Tutorials."+t.Name+"."+t.Name+"Window", Title=t.Name });
            }
        }
    }
    public class Tutorial
    {
        public string Title { get; set; } = "";
        public string Namespace { get; set; } = "";
    }
}
