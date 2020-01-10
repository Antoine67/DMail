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

namespace DMail
{
    /// <summary>
    /// Logique d'interaction pour TabValidation.xaml
    /// </summary>
    public partial class TabValidation : UserControl
    {
        public TabValidation()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            Grid gridPanel = (Grid)Window.GetWindow(this).Content;
            TabControl tabControl = (TabControl)gridPanel.FindName("TAB_Control");
            tabControl.SelectedIndex = tabControl.SelectedIndex - 1;
        }

        private void Next_Button_Click(object sender, RoutedEventArgs e)
        {
           //TODO 
        }
    }
}
