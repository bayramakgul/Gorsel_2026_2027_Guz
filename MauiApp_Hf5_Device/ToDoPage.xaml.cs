using System.Collections.ObjectModel;

namespace MauiApp_Hf5_Device;

public partial class ToDoPage : ContentPage
{
	public ToDoPage()
	{

		InitializeComponent();
        this.BindingContext = this;
        this.Listem.ItemsSource = ToDoList;
    }

	ObservableCollection<ToDoItem> ToDoList = [
        new ToDoItem("Alışveriş", "Süt, Ekmek, Yumurta", DateTime.Now.AddDays(1)),
        new ToDoItem("Ödev", "Matematik ödevini yap", DateTime.Now.AddDays(2)),
        new ToDoItem("Spor", "Koşu yap", DateTime.Now.AddDays(3)),
        new ToDoItem("Kitap Oku", "Yeni kitabı oku", DateTime.Now.AddDays(4)),
        new ToDoItem("Film İzle", "Yeni filmi izle", DateTime.Now.AddDays(5)),
    ];

    private void OnLabelTapped(object sender, TappedEventArgs e)
    {
        var item = (sender as Label).BindingContext as ToDoItem;
        item.IsCompleted = !item.IsCompleted;
    }
}