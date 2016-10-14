using Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.ViewModels
{
    public class DistanceResultViewModel:BaseViewModel
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
                base.OnPropertyChanged( "DistanceName" );
            }
        }

        private DistanceResultDetailViewModel resultDetail;

        public DistanceResultDetailViewModel ResultDetail
        {
            get
            {
                return resultDetail;
            }
            set
            {
                resultDetail = value;
                base.OnPropertyChanged( "ResultDetail" );
            }
        }
        
       
    }

    public class DistanceResultDetailViewModel : BaseViewModel
    {
        private ObservableCollection<ContestResult> results;

        public ObservableCollection<ContestResult> ContestResults
        {
            get
            {
                return results;
            }
            set
            {
                results = value;
                base.OnPropertyChanged( "ContestResults" );
            }
        }
        
    }


    public class ContestResult
    {
        public int regiestrationId
        {
            get;
            set;
        }

        public TimeSpan ElapsedTime
        {
            get;
            set;
        }
    }
}
