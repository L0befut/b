namespace MauiAppHotel.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnContratacaoHospedagemClicked(object sender, EventArgs e) =>
            Navigation.PushAsync(new HospedagemContratada());

        private void OnSobreClicked(object sender, EventArgs e) =>
            Navigation.PushAsync(new SobrePage());
    }
}
