using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace LeoErrorMessage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            VM = new ActiveEventViewModel();
            InitializeComponent();
            this.DataContext = VM;
        }
        public ActiveEventViewModel VM
        {
            get;
            set;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            List<System.ComponentModel.DataAnnotations.ValidationResult> results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            if (Validator.TryValidateObject(this.VM, new ValidationContext(this.VM), results))
            {
            }
            else
            {
            }
        }
    }


    public class ActiveEventViewModel : BaseViewModel
    {
        private string distanceName;

        public string DistanceName
        {
            get
            {
                return distanceName;
            }
            set
            {
                distanceName = value;
                base.OnPropertyChanged("DistanceName");
            }
        }

        private string eventName;
        [Required]
        public string EventName
        {
            get
            {
                return eventName;
            }
            set
            {
                eventName = value;
                base.OnPropertyChanged("EventName");
            }
        }
        

        
    }
}
