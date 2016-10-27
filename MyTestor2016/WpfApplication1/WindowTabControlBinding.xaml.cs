using Common;
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
    /// Interaction logic for WindowTabControlBinding.xaml
    /// </summary>
    public partial class WindowTabControlBinding : Window
    {
        public WindowTabControlBinding()
        {           
            InitializeComponent();
            SelecteItem = tcResult.ItemContainerGenerator.Items[0];
            this.DataContext = this;
        }

        private List<int> _Tabs;

        public List<int> Tabs
        {
            get
            {
                return _Tabs;
            }
            set
            {
                _Tabs = value;
            }
        }

        private object selecteitem;

        public object SelecteItem
        {
            get
            {
                return selecteitem;
            }
            set
            {
                selecteitem = value;
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            tcResult.Items.Insert(0, new TabItem()
            {
                Name = "new",
                Tag = new
                {
                    Name = "new"
                },
                HeaderTemplate = (DataTemplate)this.gridRoot.FindResource("headerTemp"),
                Header= new TabControlViewModel()
                {
                     Name="haha,header"
                },
                ContentTemplate = (DataTemplate)this.gridRoot.FindResource("headerTemp"),
                Content = new TabControlViewModel()
                {
                     Name="haha,binding"
                }
            });
         }

        private void tcResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newTab=(TabItem) e.AddedItems[0];
            if (newTab != null)
            {

            }

            var obj = (TabItem)tcResult.ItemContainerGenerator.ContainerFromIndex(1);
            if (obj != null)
            {
               
            }
            
        }
    }

    public class TabControlViewModel : BaseViewModel
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                base.OnPropertyChanged("Name");
            }
        }
        
    }
}
