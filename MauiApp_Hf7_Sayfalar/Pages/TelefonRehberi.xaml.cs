using MauiApp_Hf7_Sayfalar.ViewModel;
using MauiApp_Hf7_Sayfalar.Model;

namespace MauiApp_Hf7_Sayfalar.Pages;

public partial class TelefonRehberi : ContentPage
{
	public TelefonRehberi()
	{
		InitializeComponent();

		this.BindingContext = MauiProgram.kisiViewModel;
	}
}