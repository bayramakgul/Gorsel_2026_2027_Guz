using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MauiApp_Hf5_Device
{
    public class ToDoItem :INotifyPropertyChanged
    {
        bool isComp;

        public string Title { get; set; }

        public string Details { get; set; }

        public DateTime DueDate { get; set; } = DateTime.Now;
        public bool IsCompleted
        {
            get => isComp;
            set { isComp = value; 
                OnPropertyChanged();
                OnPropertyChanged(nameof(Durum)); }
        }

        public string Durum => IsCompleted ? "Yapıldı" : "Yapılmadı";

        public ToDoItem(
            string title, string details,DateTime dueDate, 
            bool isCompleted=false)
        {
            Title = title;
            Details = details;
            DueDate = dueDate;
            IsCompleted = isCompleted;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
