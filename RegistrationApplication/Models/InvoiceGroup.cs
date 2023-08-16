using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApplication.Models
{
    public class InvoiceGroup: ObservableCollection<Invoice>
    {
        public string Name { get; set; }

        public InvoiceGroup(string name ,ObservableCollection<Invoice> invoices):base(invoices) 
        {
        Name = name;
        }




    }
}
