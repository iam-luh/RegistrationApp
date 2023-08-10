using RegistrationApplication.Pages;
namespace RegistrationApplication;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(HomePage),typeof(HomePage));
	}
}
