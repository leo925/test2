using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
            Regex re=new Regex("00[A-z1-9]{1,}00");
            string input="003100";
            Match m=re.Match(input)  ;
            if( m.Success )
            {
              
            }
         * 
         * 
         *  Regex re=new Regex("01[0|A-z1-9]{2}00");
            string input="011000";
            Match m=re.Match(input)  ;
            if( m.Success )
            {
              
            }
         */
        public MainWindow()
        {
            InitializeComponent();

            //string str=@".\.\";
            //Regex rdf=new Regex(str);
            Regex re=new Regex("01[0|A-z1-9]{2}00$");
            string input="010000";
            Match m=re.Match(input)  ;
            if( m.Success )
            {
              
            }

            Regex rex2=new Regex(".{2}00[A-z1-9]{1,}");
            string input2="ad00A0";
            Match m2=rex2.Match(input2);
            if( m2.Success )
            {

            }
        }

        void M()
        {
            ManualResetEventSlim []manual=new ManualResetEventSlim[] { };
            ManualResetEvent []manualEvents=new ManualResetEvent[] { new ManualResetEvent(false) };
            if( WaitHandle.WaitAll(manualEvents,1000*5) )
            {

            }

        }
    }

    public class ReaderConnectionSessionManager
    {
        public Dictionary<string,ReaderConnectionSession> dicSession=new Dictionary<string, ReaderConnectionSession>();

    }

     public class ReaderConnectionSession
     {
         public Dictionary<string,ManualResetEvent> dicManualResetEvents=new Dictionary<string, ManualResetEvent>();


     }


     public class PaginationViewModel
     {
         private int totalPage;

         public int TotalPage
         {
             get
             {
                 return totalPage;
             }
             set
             {
                 totalPage = value;
             }
         }

         private int currentPage;

         public int CurrentPage
         {
             get
             {
                 return currentPage;
             }
             set
             {
                 currentPage = value;
             }
         }

         //comman next/previous page
         
     }

    //the whole live event page
     public class LiveEventViewModel
     {
         void Init()
         {
              
         }
         public PaginationViewModel PaginationVM
         {
             get;
             set;
         }

         public LiveEventPageViewModel CurrentPage
         {
             get;
             set;
         }
         public LiveEventSetting Settings
         {
             get;
             set;
         }
         //need ??
         public List<LiveEventPageViewModel> Pages
         {
             get;
             set;
         }

         public List<LiveEventPageViewModel> VisiblePages
         {
             get;
             set;
         }

     }

    //each screen/page
     public class LiveEventPageViewModel
     {
         bool IsVisible;//when pop out or turn to current page, it is true
         public string PageName  //Screen 1, Screen 2
         {
             get;
             set;
         }

         public List<LiveEventReadStationViewModel> LiveReadStationVMs
         {
             get;
             set;
         }

         void Init()
         {
             //init read station with setting
         }

     }

     public class LiveEventReadStationViewModel
     {
         public string ReadStationName
         {
             get;
             set;
         }

         private int passbyNumber;

         public int PassbyNumber
         {
             get
             {
                 return passbyNumber;
             }
             set
             {
                 passbyNumber = value;
             }
         }

         public List<TagReadItemViewModel> TagReads
         {
             get;
             set;
         }

         int DisplaMode;//live, top 10

         //data below come from setting

         public int GridColumn
         {
             get;
             set;
         }

         public int GridRow
         {
             get;
             set;
         }

         public int GridColumnSpan
         {
             get;
             set;
         }

         public int GridRowSpan
         {
             get;
             set;
         }

         //public string Width
         //{
         //    get;
         //    set;
         //}

         //public string Height
         //{
         //    get;
         //    set;
         //}
     }



    public  class TagReadItemViewModel
     {
        
     }


    //domain to persist
    public class LiveEventSetting
    {
        public LiveEventSettingPage[] Pages { get; set; }
    }
    public class LiveEventSettingPage
    {
        public LiveEventSettingStation[] Stations
        {
            get;
            set;
        }

    }

    public class LiveEventSettingStation
    {
        public string ReadStationId
        {
            get;
            set;
        }
    }

    /*
     <pages>
         <page>
            <readstations>
                <readstationid>1<readstationid>
                <readstationid>2<readstationid>
            </readstations>
         </page>
          <page>
            <readstations>
                <readstationid>1<readstationid>
                <readstationid>2<readstationid>
                <readstationid>3<readstationid>
                <readstationid>4<readstationid>
            </readstations>
        
         </page>
     </pages>
     */
}
