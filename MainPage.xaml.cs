namespace SwiftPropsal
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void ToProposalClicked(object sender, EventArgs e) 
        {
            await Navigation.PushAsync(new ProposalPage());
        }

        private async void ToReportClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReportPage());
        }
    }

}
