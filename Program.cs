using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomermanager();
            customerManager.Save(new Customer { DateOfBirth = new System.DateTime(1998, 6, 7), FirstName = "Merve", LasttName = "ALKAN", NationalityId = "52753464950" });
         
        }
    }
}
