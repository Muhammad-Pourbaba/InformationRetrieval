using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using contr;

namespace IR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Dict newDict=new Dict();
            
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                //Dict newDict=new Dict();
                string text = txtBox.Text;
                Query newQ = new Query(text);
                Thread.Sleep(5000);
                textlist.ItemsSource = newQ.Tokens;
            }
            catch (Exception ex) { textlist.Items.Add(ex.Message); }


        }
    }
}
