using Common.ViewModelProviders;
using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for WindowAttachedPropertyForScrollIntoView.xaml
    /// </summary>
    public partial class WindowAttachedPropertyForScrollIntoView : Window, INotifyPropertyChanged
    {
        public WindowAttachedPropertyForScrollIntoView()
        {
            InitializeComponent();
            ListPerson = new ObservableCollection<PersonViewModel>(PersonViewModelProvider.GetFakePersonViewModels());
            DataContext = this;
        }

        private ObservableCollection<PersonViewModel> list;

        public ObservableCollection<PersonViewModel> ListPerson
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
            }
        }

        private PersonViewModel selectedPersion;

        public PersonViewModel SelectedPerson
        {
            get
            {
                return selectedPersion;
            }
            set
            {
                selectedPersion = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedPerson"));
                }
                //SelectingItem = selectedPersion;
            }
        }

      
        public event PropertyChangedEventHandler PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int i = int.Parse(txtInput.Text);
            this.SelectedPerson = this.ListPerson[i];
        }
    }


   
}
