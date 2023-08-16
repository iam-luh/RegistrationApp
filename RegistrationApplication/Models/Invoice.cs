using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApplication.Models
{
    public class Invoice
    {
        public DateOnly InvoiceDate { get; set; }
        public string Invoicetype { get; set; }

        public string Invoicebrief { get; set; }

        public int Price { get; set; }
    }
}
