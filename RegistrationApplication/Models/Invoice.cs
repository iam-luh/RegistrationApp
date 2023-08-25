using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApplication.Models
{
    public class Invoice
    {
     

        public DateTime InvoiceDate {get; set;}
        public string Invoicetype {get; set;}

        public string Invoicebrief {get; set;}

        public int Price {get; set;}

        public string date;
        public string Date { get { return date; } 
                             set {
                switch (int.Parse(value))
                {
                    case 1:
                        date = $"{InvoiceDate.Day} JANUARY {InvoiceDate.Year}";
                        break;
                    case 2:
                        date = $"{InvoiceDate.Day} FEBRUARY {InvoiceDate.Year}";
                        break;
                    case 3:
                        date = $"{InvoiceDate.Day} MARCH {InvoiceDate.Year}";
                        break;
                    case 4:
                        date = $"{InvoiceDate.Day} APRIL {InvoiceDate.Year}";
                        break;
                    case 5:
                        date = $"{InvoiceDate.Day} MAY {InvoiceDate.Year}";
                        break;
                    case 6:
                        date = $"{InvoiceDate.Day} JUNE {InvoiceDate.Year}";
                        break;
                    case 7:
                        date = $"{InvoiceDate.Day} JULY {InvoiceDate.Year}";
                        break;
                    case 8:
                        date = $"{InvoiceDate.Day} AUGUST {InvoiceDate.Year}";
                        break;
                    case 9:
                        date = $"{InvoiceDate.Day} SEPTEMBER{InvoiceDate.Year}";
                        break;
                    case 10:
                        date = $"{InvoiceDate.Day} OCTOBER {InvoiceDate.Year}";
                        break;
                    case 11:
                        date = $"{InvoiceDate.Day} NOVEMBER {InvoiceDate.Year}";
                        break;
                    case 12:
                        date = $"{InvoiceDate.Day} DECEMBER {InvoiceDate.Year}";
                        break;
                }
            }
        }
    }
}
