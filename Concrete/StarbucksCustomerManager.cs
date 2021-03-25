using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
   public class StarbucksCustomerManager:BaseCustomerManager
    {
       private  ICustomerCheckService customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            this.customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (customerCheckService.CheckIfRealPerson(customer))//mernis implement doğrulaması
            {
                base.Save(customer); 
            }
            else
            {
                throw new Exception("Not a valid person");
            }
           
          
        }

       
    }
}
