using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelCodePattern.Interfaces
{
    public interface ICustomer : IUser
    {
        public List<IAnimal> Animals { get; set; }

        public void SaveCustomers(ICustomer customer, List<ICustomer> customers);

        public void GetCustomers(List<ICustomer> customers);

        public void CreateNewCustomer(List<ICustomer> customers);
    }
}
