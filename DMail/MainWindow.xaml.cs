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

namespace DMail
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            string[] arr = GetAllCommands();
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }

        }

        private void BT_New_Mail_Click(object sender, RoutedEventArgs e)
        {
            EmailManager emailManager = new EmailManager();
            emailManager.Owner = this;
            this.Hide();
            emailManager.ShowDialog();
        }


        public string[] GetAllCommands()
        {
            return (
              from assembly in AppDomain.CurrentDomain.GetAssemblies()
              from type in assembly.GetTypes()
              from prop in type.GetProperties()
              where
                typeof(ICommand).IsAssignableFrom(prop.PropertyType) &&
                prop.GetAccessors()[0].IsStatic
              orderby type.Name, prop.Name
              select type.Name + "." + prop.Name
            ).ToArray();
        }
    }
}
