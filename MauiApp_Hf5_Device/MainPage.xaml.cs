namespace MauiApp_Hf5_Device
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            PlatformLabel.Text = DeviceInfo.Current.Platform.ToString();
            VersionLabel.Text = DeviceInfo.Current.Version.ToString();
            PhysicalTypeLabel.Text = DeviceInfo.Current.DeviceType.ToString();
            DeviceTypeLabel.Text = DeviceInfo.Current.Idiom.ToString();

            var _type = DeviceInfo.Current.Idiom.ToString();
            if(_type == "Phone")
            {
                // buraya birşeyler yap
            }
            else if (_type == "Tablet")
            {
                // buraya birşeyler yap
            }
            else if(_type == "Desktop")
            {
                // buraya birşeyler yap
            }
            //--------------------
            var _platform = DeviceInfo.Current.Platform.ToString();
            if(_platform == "WinUI")
            {
                // windows için kod yaz
            }
            else if (_platform == "Android")
            {
                // Android için kod yaz
            }
            else if (_platform == "iOS")
            {
                // iOS için kod yaz
            }
            else if (_platform == "MacCatalyst")
            {
                // MacCatalyst için kod yaz
            }

        }

        private async void OnBoxTapped(object sender, TappedEventArgs e)
        {
            await DisplayAlertAsync("Hops","Bak buraya dokundum :)", "OK");
        }
    }
}
