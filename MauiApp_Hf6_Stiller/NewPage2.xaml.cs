using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp_Hf6_Stiller;

public partial class NewPage2 : ContentPage, INotifyPropertyChanged
{
	public NewPage2()
	{
		InitializeComponent();
        this.BindingContext = this;
    }

    public string _systemTheme = "";
	public bool IsLightTheme => Application.Current.RequestedTheme == AppTheme.Light;
	public bool IsDarkTheme => Application.Current.RequestedTheme == AppTheme.Dark;

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		Application.Current.UserAppTheme = e.Value ? AppTheme.Dark : AppTheme.Light;
        _systemTheme = Application.Current.RequestedTheme == AppTheme.Dark ? "Koyu" : "Açık";
        OnPropertyChanged(nameof(SystemTheme));
    }

    public string SystemTheme => _systemTheme;
    // INotifyPropertyChanged için gerekli tetikleyici metot
    public new event PropertyChangedEventHandler PropertyChanged;
    protected new void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}