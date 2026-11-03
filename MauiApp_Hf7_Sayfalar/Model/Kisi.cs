using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp_Hf7_Sayfalar.Model
{
    public class Kisi
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string FullName => $"{Name} {Surname}";
        public string UserImage => "user.png";
    }
}
