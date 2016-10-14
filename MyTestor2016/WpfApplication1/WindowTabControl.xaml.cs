using System;
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
using System.Windows.Shapes;
using WpfApplication1.ViewModels;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for WindowTabControl.xaml
    /// </summary>
    public partial class WindowTabControl : Window
    {
        public WindowTabControl()
        {
            Label lable = new Label();
            TextBlock tb = new TextBlock();

            StackPanel sp;
           

            var ts=DateTime.Now- DateTime.Now.AddDays( -2 );
            Console.WriteLine( ts );

            TabControl tc=new TabControl();
   
            InitializeComponent();
            DistanceResults = new ObservableCollection<DistanceResultViewModel>();
            DistanceResults.Add( new DistanceResultViewModel()
            {
                DistanceName = "1k",
                ResultDetail = new DistanceResultDetailViewModel()
                {
                    ContestResults = new ObservableCollection<ContestResult>()
                    {
                       new ContestResult(){ ElapsedTime=TimeSpan.FromTicks(12000), regiestrationId=1},
                       new ContestResult(){ ElapsedTime=TimeSpan.FromTicks(17000), regiestrationId=2}
                    }
                }
            } );

            DistanceResults.Add( new DistanceResultViewModel()
            {
                DistanceName = "2k",
                ResultDetail = new DistanceResultDetailViewModel()
                {
                    ContestResults = new ObservableCollection<ContestResult>()
                    {
                       new ContestResult(){ ElapsedTime=TimeSpan.FromTicks(12000), regiestrationId=3},
                       new ContestResult(){ ElapsedTime=TimeSpan.FromTicks(17000), regiestrationId=4}
                    }
                }
            } );

            this.DataContext = this;

        }

        private ObservableCollection<DistanceResultViewModel> distanceResults;

        public ObservableCollection<DistanceResultViewModel> DistanceResults
        {
            get
            {
                return distanceResults;
            }
            set
            {
                distanceResults = value;
            }
        }
        
    }
}
