namespace MauiAppTask1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private async void OnNavigationClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
        private void OnUpdateClicked(object sender, EventArgs e)
        {
            string enteredText = inputField.Text;

            if (string.IsNullOrWhiteSpace(enteredText))
            {
                lblOutput.Text = "Please enter some text!";
            }
            else
            {
                lblOutput.Text = $"You entered: {enteredText}";
            }
        }

    }

}
