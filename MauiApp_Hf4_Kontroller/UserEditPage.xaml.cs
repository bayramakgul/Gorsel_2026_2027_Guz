namespace MauiApp_Hf4_Kontroller;

public partial class UserEditPage : ContentPage
{
	public UserEditPage()
	{
		InitializeComponent();
	}

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
		var result = await DisplayAlertAsync("Bilgi", "Kullanıcı bilgileri kaydedildi.", "Tamam", "İptal");

		if (result == true)
		{
			await Navigation.PushModalAsync(new MainPage());
        }
		else
		{
            var res =await DisplayActionSheetAsync("İşlem iptal edildi. Neden iptal ettin?", 
				null,
				null,
				"Çünkü Hazır Değildi",
				"Bağlantı Koptu",
				"Keyfim Öyle İstedi",
				"İstediğimi Ekleyebilirim");

			if(res == "Çünkü Hazır Değildi")
			{
				var res2 = await DisplayPromptAsync("Bilgi", 
					"Lütfen hazır olduğunda tekrar kaydetmeyi deneyin.",
					"Tamam",null, "kaç gün sonra hazır olursun?", 30, keyboard: Keyboard.Text);
            
				await DisplayAlertAsync("Bilgi", $"Tamam," +
					$" {res2} gün sonra tekrar kaydetmeyi deneyin.", 
					"Tamam");

            }
        }
    }
}