using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeoErrorMessage
{
    public abstract class BaseViewModel : Object, INotifyPropertyChanged
    {
        #region Constants
        #endregion

        #region Event Handlers
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        public void OnPropertyChanged(object sender, string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(sender, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region Properties


        public string Error
        {
            get
            {
                return i_Error;
            }
            set
            {
                i_Error = value;
                OnPropertyChanged("Error");
            }
        }
        #endregion

        #region Private Methods

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));// new ModelChangedEventArgs(propertyName,null,null));
            }
        }
        #endregion

        #region Private Properties

        #endregion

        #region Construction and Finalization
        public BaseViewModel()
        {
        }
        #endregion

        #region Data Elements
        private string i_Error;
        #endregion

    }
}
