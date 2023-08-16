using CommunityToolkit.Mvvm.ComponentModel;
using RegistrationApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace RegistrationApplication.ViewModels
{
    
    public partial class InvoicesViewModel: ObservableObject
    {
        
        public  ObservableCollection<InvoiceGroup> invoices { get; set; } = new ObservableCollection<InvoiceGroup>();

        public InvoicesViewModel()
        {
            //List of Invoices on 15 AUGUST 2023
            invoices.Add(new InvoiceGroup("15 AUGUST 2023", new ObservableCollection<Invoice>
        { new Invoice
        {   InvoiceDate= DateOnly.FromDateTime(DateTime.Now),
            Price=6000,
            Invoicetype="Food&Beverages",
            Invoicebrief="Lunch"
        },
        new Invoice
        {   InvoiceDate= DateOnly.FromDateTime(DateTime.Now),
            Price=2000,
            Invoicetype="Transportation",
            Invoicebrief="Lunch"
        },
        new Invoice
        {
            InvoiceDate = DateOnly.FromDateTime(DateTime.Now),
            Price = 60000,
            Invoicetype = "Rent",
            Invoicebrief = "Monthly"
        },
        new Invoice
        {
            InvoiceDate = DateOnly.FromDateTime(DateTime.Now),
            Price = 16000,
            Invoicetype = "Electricity",
            Invoicebrief = "Monthly Payment"
        }
        }));

            //List of Invoices on 14 AUGUST 2023
            invoices.Add(new InvoiceGroup("14 AUGUST 2023", new ObservableCollection<Invoice>
        { new Invoice
        {   InvoiceDate= new DateOnly(2023,8,14),
            Price=6000,
            Invoicetype="Food&Beverages",
            Invoicebrief="Lunch"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,14),
            Price=2000,
            Invoicetype="Transportation",
            Invoicebrief="Lunch"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,14),
            Price=60000,
            Invoicetype="Rent",
            Invoicebrief="Monthly"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,14),
            Price=16000,
            Invoicetype="Electricity",
            Invoicebrief="Monthly Payment"
        }
        }));

            //List of Invoices on 13 AUGUST 2023
            invoices.Add(new InvoiceGroup("13 AUGUST 2023", new ObservableCollection<Invoice>
        { new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=6000,
            Invoicetype="Food&Beverages",
            Invoicebrief="Lunch"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=2000,
            Invoicetype="Transportation",
            Invoicebrief="Lunch"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=60000,
            Invoicetype="Rent",
            Invoicebrief="Monthly"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=16000,
            Invoicetype="Electricity",
            Invoicebrief="Monthly Payment"
        }
        }));

            //List of Invoices on 13 AUGUST 2023
            invoices.Add(new InvoiceGroup("12 AUGUST 2023", new ObservableCollection<Invoice>
        { new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=6000,
            Invoicetype="Food&Beverages",
            Invoicebrief="Lunch"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=2000,
            Invoicetype="Transportation",
            Invoicebrief="Lunch"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=60000,
            Invoicetype="Rent",
            Invoicebrief="Monthly"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=16000,
            Invoicetype="Electricity",
            Invoicebrief="Monthly Payment"
        }
        }));

            //List of Invoices on 13 AUGUST 2023
            invoices.Add(new InvoiceGroup("11 AUGUST 2023", new ObservableCollection<Invoice>
        { new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=6000,
            Invoicetype="Food&Beverages",
            Invoicebrief="Lunch"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=2000,
            Invoicetype="Transportation",
            Invoicebrief="Lunch"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=60000,
            Invoicetype="Rent",
            Invoicebrief="Monthly"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=16000,
            Invoicetype="Electricity",
            Invoicebrief="Monthly Payment"
        }
        }));
        }

        [RelayCommand]
        public void AddInvoice()
        {
            invoices.Add(new InvoiceGroup("11 AUGUST 2023", new ObservableCollection<Invoice>
        { new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=6000,
            Invoicetype="Food&Beverages",
            Invoicebrief="Lunch"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=2000,
            Invoicetype="Transportation",
            Invoicebrief="Lunch"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=60000,
            Invoicetype="Rent",
            Invoicebrief="Monthly"
        },
        new Invoice
        {   InvoiceDate= new DateOnly(2023,8,13),
            Price=16000,
            Invoicetype="Electricity",
            Invoicebrief="Monthly Payment"
        }
        }));
        }


    }
}
