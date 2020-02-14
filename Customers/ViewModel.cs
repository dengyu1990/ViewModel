using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    public class ViewModel
    {
        private List<Customer> customers;
        private int currentCustomer;
        public ViewModel()
        {
            this.currentCustomer = 0;
            this.customers = new List<Customer>
            {
                new Customer{
                    CustomerID=1,
                    Title="Mr",
                    FirstName="Yu",
                    LastName="Deng",
                    EmailAddress="jardy@live.cn",
                    Phone="15112505200"},
                new Customer{
                    CustomerID=2,
                    Title="Mrs",
                    FirstName="Zeyun",
                    LastName="Qiu",
                    EmailAddress="jardy@outlook.com",
                    Phone="13783924332"},
                new Customer{
                    CustomerID=3,
                    Title="Miss",
                    FirstName="Meng",
                    LastName="Deng",
                    EmailAddress="dengmeng@outlook.com",
                    Phone="15174833243"}
            };
        }

        public Customer Current
        {
            get => this.customers.Count > 0 ? this.customers[currentCustomer] : null;
        }
    }
}
