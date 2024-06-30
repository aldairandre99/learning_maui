namespace MauiApp1;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		FirstName.TextChanged += FirstName_TextChanged;
		LastName.TextChanged += LastName_TextChanged;

	}

	private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
	{
		UpdateLabel();
	}

	private void LastName_TextChanged(object sender, TextChangedEventArgs e)
	{
		UpdateLabel();
	}

	void UpdateLabel()
	{
		FullName.Text = $"{FirstName.Text} {LastName.Text}";
	}

	private void ButtonCliked(object sender, EventArgs e)
	{
		JoinBtn.IsEnabled = false;

		Console.WriteLine(FullName.Text);

		JoinBtn.IsEnabled = true;
	}

}

