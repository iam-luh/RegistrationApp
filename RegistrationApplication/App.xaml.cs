namespace RegistrationApplication;

public partial class App : Application
{
	public App()
	{
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjU1NTEwMUAzMjMyMmUzMDJlMzBSL2NZbytYYkhvMVRPM2pJcHhEYTdXRjZFTHVtUkRwWFRnV2JVVDdBZkRRPQ==");
        InitializeComponent();

		MainPage = new AppShell();
	
	}
}
