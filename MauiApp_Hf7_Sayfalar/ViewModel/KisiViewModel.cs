using MauiApp_Hf7_Sayfalar.Model;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace MauiApp_Hf7_Sayfalar.ViewModel
{
    public class KisiViewModel
    {
        public ICommand DeleteCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand FavoriCommand { get; }
        public ICommand UnFavoriCommand { get; }

        public KisiViewModel()
        {
            DeleteCommand = new Command<Kisi>(Delete);
            EditCommand = new Command<Kisi>(Edit);
            FavoriCommand = new Command<Kisi>(AddFavori);
            UnFavoriCommand = new Command<Kisi>(UnFavori);
        }

        public  ObservableCollection<Kisi> Kisiler { get; set; } = new ObservableCollection<Kisi>()
        {
                new Kisi(){Name = "Ali", Surname="Kara", Phone="0535 888 88 88", Email="alikara@mail.com"},
                new Kisi(){Name = "Ayşe", Surname="Yılmaz", Phone="0532 456 78 90", Email="ayseyilmaz@mail.com"},
                new Kisi(){Name = "Mehmet", Surname="Demir", Phone="0541 234 56 78", Email="mehmetdemir@mail.com"},
                new Kisi(){Name = "Zeynep", Surname="Çelik", Phone="0505 678 90 12", Email="zeynepc@mail.com"},
                new Kisi(){Name = "Ahmet", Surname="Şahin", Phone="0533 789 12 34", Email="ahmetsahin@mail.com"},
                new Kisi(){Name = "Elif", Surname="Kaya", Phone="0551 345 67 89", Email="elifkaya@mail.com"},
                new Kisi(){Name = "Mustafa", Surname="Arslan", Phone="0544 567 89 01", Email="mustafaa@mail.com"},
                new Kisi(){Name = "Fatma", Surname="Öztürk", Phone="0507 123 45 67", Email="fatmaozturk@mail.com"},
                new Kisi(){Name = "Emre", Surname="Aydın", Phone="0536 890 12 34", Email="emraydin@mail.com"},
                new Kisi(){Name = "Merve", Surname="Koç", Phone="0553 456 78 90", Email="mervekoc@mail.com"},
        };

        public  ObservableCollection<Kisi> Favoriler { get; set; } = new ObservableCollection<Kisi>();
        public async void Delete(Kisi k)
        {
            if (k == null)
                return;

            var result = await 
                Application.Current.MainPage.DisplayAlertAsync(
                    "Silmeyi onayla",
                    $"{k.FullName} Silinsin mi?",
                    "Evet", "İptal"
                );

            if (result)
                Kisiler.Remove(k);

            if (Favoriler.Contains(k))
                Favoriler.Remove(k);
        }

        public async void AddFavori(Kisi k)
        {
            if (k == null) return;

            Favoriler.Add(k);
        }

        public async void UnFavori(Kisi k)
        {
            if (k == null)
                return;

            Favoriler.Remove(k);
        }

        public void Edit(Kisi k)
        {
            if (k == null)
                return;


        }
    }
}
