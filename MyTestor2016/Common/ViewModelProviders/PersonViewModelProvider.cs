using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModelProviders
{
    public class PersonViewModelProvider
    {
        public static List<PersonViewModel> GetFakePersonViewModels()
        {
            List<PersonViewModel> result = new List<PersonViewModel>();
            for (int i = 0; i < 100; i++)
            {
                PersonViewModel vm = new PersonViewModel()
                {
                    Age = i,
                    Name = "Wang" + i.ToString()
                  
                };
                result.Add(vm);
            }
            return result;
        }
    }
}
