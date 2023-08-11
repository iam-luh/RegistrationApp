namespace RegistrationApplication.Pages;

public partial class CreateInvoicePage : ContentPage
{
	public CreateInvoicePage()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }

    private void checkboxrecurring_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }

    private void btnSend_Clicked(object sender, EventArgs e)
    {

    }

    private async void btndraft_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");

    }
}