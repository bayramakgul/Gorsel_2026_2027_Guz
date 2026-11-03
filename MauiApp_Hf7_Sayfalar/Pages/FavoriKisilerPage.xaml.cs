using MauiApp_Hf7_Sayfalar.ViewModel;

namespace MauiApp_Hf7_Sayfalar.Pages
{
    public partial class FavoriKisilerPage : ContentPage
    {
        public FavoriKisilerPage()
        {
            InitializeComponent();
            this.BindingContext = MauiProgram.kisiViewModel;
            ;
        }
    }
}
