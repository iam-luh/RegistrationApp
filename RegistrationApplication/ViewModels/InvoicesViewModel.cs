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
        private double val = -5;

        public  ObservableCollection<Invoice> invoices { get; set; } = new ObservableCollection<Invoice>();

        public InvoicesViewModel()
        {
            //List of Invoices on 15 AUGUST 2023
            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today,
                Price = 6000,
                Invoicetype = "Food&Beverages",
                Invoicebrief = "Lunch",
                Date=$"{DateTime.Today.Month}"
            });

            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today,
                Price = 2000,
                Invoicetype = "Transportation",
                Invoicebrief = "Lunch",
                Date = $"{DateTime.Today.Month}"
            });

            invoices.Add(new Invoice
            {
                InvoiceDate = DateTime.Today,
                Price = 60000,
                Invoicetype = "Rent",
                Invoicebrief = "Monthly",
                Date = $"{DateTime.Today.Month}"
            });

            invoices.Add(new Invoice
        {
            InvoiceDate = DateTime.Today,
            Price = 16000,
            Invoicetype = "Electricity",
            Invoicebrief = "Monthly Payment",
            Date = $"{DateTime.Today.Month}"
            });

            //List of Invoices on 14 AUGUST 2023
            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(-1),
                Price = 6000,
                Invoicetype = "Food&Beverages",
                Invoicebrief = "Lunch",
                Date = $"{DateTime.Today.AddDays(-1).Month}"
            });

            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(-1),
                Price = 2000,
                Invoicetype = "Transportation",
                Invoicebrief = "Lunch",
                Date = $"{DateTime.Today.AddDays(-1).Month}"
            });

            invoices.Add(new Invoice
                        {
                InvoiceDate = DateTime.Today.AddDays(-1),
                Price = 60000,
                Invoicetype = "Rent",
                Invoicebrief = "Monthly",
                Date = $"{DateTime.Today.AddDays(-1).Month}"
            });

            invoices.Add(new Invoice
        {   InvoiceDate= DateTime.Today.AddDays(-1),
            Price=16000,
            Invoicetype="Electricity",
            Invoicebrief="Monthly Payment",
            Date = $"{DateTime.Today.AddDays(-1).Month}"
            });

            //List of Invoices on 13 AUGUST 2023
            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(-2),
                Price = 6000,
                Invoicetype = "Food&Beverages",
                Invoicebrief = "Lunch",
                Date = $"{DateTime.Today.AddDays(-2).Month}"
            });

            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(-2),
                Price = 2000,
                Invoicetype = "Transportation",
                Invoicebrief = "Lunch",
                Date = $"{DateTime.Today.AddDays(-2).Month}"
            });

            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(-2),
                Price = 60000,
                Invoicetype = "Rent",
                Invoicebrief = "Monthly",
                Date = $"{DateTime.Today.AddDays(-2).Month}"
            });

            invoices.Add(new Invoice
        {   InvoiceDate= DateTime.Today.AddDays(-2),
            Price=16000,
            Invoicetype="Electricity",
            Invoicebrief="Monthly Payment",
            Date = $"{DateTime.Today.AddDays(-2).Month}"
            });

            //List of Invoices on 13 AUGUST 2023
            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(-3),
                Price = 6000,
                Invoicetype = "Food&Beverages",
                Invoicebrief = "Lunch",
                Date = $"{DateTime.Today.AddDays(-3).Month}"
            });

            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(-3),
                Price = 2000,
                Invoicetype = "Transportation",
                Invoicebrief = "Lunch",
                Date = $"{DateTime.Today.AddDays(-3).Month}"
            });

            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(-3),
                Price = 60000,
                Invoicetype = "Rent",
                Invoicebrief = "Monthly",
                Date = $"{DateTime.Today.AddDays(-3).Month}"
            });

            invoices.Add(new Invoice
        {   InvoiceDate= DateTime.Today.AddDays(-3),
            Price=16000,
            Invoicetype="Electricity",
            Invoicebrief="Monthly Payment",
                Date = $"{DateTime.Today.AddDays(-3).Month}"
            });

            //List of Invoices on 13 AUGUST 2023
            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(-4),
                Price = 6000,
                Invoicetype = "Food&Beverages",
                Invoicebrief = "Lunch",
                Date = $"{DateTime.Today.AddDays(-4).Month}"
            });

            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(-4),
                Price = 2000,
                Invoicetype = "Transportation",
                Invoicebrief = "Lunch",
                Date = $"{DateTime.Today.AddDays(-4).Month}"
            });

            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(-4),
                Price = 60000,
                Invoicetype = "Rent",
                Invoicebrief = "Monthly",
                Date = $"{DateTime.Today.AddDays(-4).Month}"
            });

            invoices.Add(new Invoice
           {InvoiceDate= DateTime.Today.AddDays(-4),
            Price=16000,
            Invoicetype="Electricity",
            Invoicebrief="Monthly Payment",
            Date = $"{DateTime.Today.AddDays(-4).Month}"
            });
            
        }

        [RelayCommand]
        public void AddInvoice()
        {            
            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(val),
                Price = 6000,
                Invoicetype = "Food&Beverages",
                Invoicebrief = "Lunch",
                Date = $"{DateTime.Today.AddDays(val).Month}"
            });

            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(val),
                Price = 2000,
                Invoicetype = "Transportation",
                Invoicebrief = "Lunch",
                Date = $"{DateTime.Today.AddDays(val).Month}"
            });

            invoices.Add(new Invoice
            { InvoiceDate = DateTime.Today.AddDays(val),
                Price = 60000,
                Invoicetype = "Rent",
                Invoicebrief = "Monthly",
                Date = $"{DateTime.Today.AddDays(val).Month}"
            });

            invoices.Add(new Invoice
           {InvoiceDate= DateTime.Today.AddDays(val),
            Price=16000,
            Invoicetype="Electricity",
            Invoicebrief="Monthly Payment",
            Date = $"{DateTime.Today.AddDays(val).Month}"
            });
            --val;
            
        }


    }
}
