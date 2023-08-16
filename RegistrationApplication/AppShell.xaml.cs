using RegistrationApplication.Pages;
namespace RegistrationApplication;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(CreateInvoicePage),typeof(CreateInvoicePage));
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(InvoiceListPage), typeof(InvoiceListPage));

    }
}
