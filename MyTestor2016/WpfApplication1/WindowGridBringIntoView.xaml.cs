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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for WindowGridBringIntoView.xaml
    /// </summary>
    public partial class WindowGridBringIntoView : Window
    {
        public WindowGridBringIntoView()
        {
            InitializeComponent();

            DataGrid dg = new DataGrid();
            dg.InvalidateVisual();

            this.LostFocus+=WindowGridBringIntoView_LostFocus;
            
             
        }

        private void WindowGridBringIntoView_LostFocus(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.txt.BringIntoView();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            this.txt.BringIntoView();
        }
    }
}
