using System;
using System.Collections.Generic;
using System.IO;
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
    /// Logique d'interaction pour TabWriteMail.xaml
    /// </summary>
    public partial class TabWriteMail : UserControl
    {
        public TabWriteMail()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private void Next_Button_Click(object sender, RoutedEventArgs e)
        {
            Grid gridPanel = (Grid)Window.GetWindow(this).Content;
            TabControl tabControl = (TabControl)gridPanel.FindName("TAB_Control");
            tabControl.SelectedIndex = tabControl.SelectedIndex + 1;
        }

        private void Save_Email_Content(object sender, RoutedEventArgs e)
        {
            RichTextBox emailRTB = (RichTextBox)TE_Email.FindName("RTB_Email_Content");
            TextRange textRange = new TextRange(emailRTB.Document.ContentStart, emailRTB.Document.ContentEnd);
            MemoryStream ms = new MemoryStream();
            textRange.Save(ms, DataFormats.Rtf);

            string emailContent = Encoding.Default.GetString(ms.ToArray());
            Window.GetWindow(this).Tag = emailContent;
        }
    }
}
