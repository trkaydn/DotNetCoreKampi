using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Web;

namespace CoreDemo.Models
{
    public class RegisterCityViewModel
    {
        public List<SelectListItem> Cities { get; set; }
        public Writer Writer { get; set; }

        //ctor'da veriler statik olarak eklendi
        public RegisterCityViewModel()
        {
            List<string> cities = new List<string>()
                {
                "Adana","Adıyaman","Afyonkarahisar","Ağrı","Aksaray","Amasya","Ankara","Antalya","Ardahan","Artvin","Aydın",
                "Balıkesir","Bartın","Batman","Bayburt","Bilecik","Bingöl","Bitlis","Bolu","Burdur","Bursa","Çanakkale","Çankırı",
                "Çorum","Denizli","Diyarbakır","Düzce","Edirne","Elâzığ","Erzincan","Erzurum","Eskişehir","Gaziantep","Giresun","Gümüşhane",
                "Hakkâri","Hatay","Iğdır","Isparta","İstanbul","İzmir","Kahramanmaraş","Karabük","Karaman","Kars","Kastamonu","Kayseri",
                "Kırıkkale","Kırklareli","Kırşehir","Kilis","Kocaeli","Konya","Kütahya","Malatya","Manisa","Mardin","Mersin","Muğla","Muş",
                "Nevşehir","Niğde","Ordu","Osmaniye","Rize","Sakarya","Samsun","Siirt","Sinop","Sivas","Şanlıurfa","Şırnak","Tekirdağ",
                "Tokat","Trabzon","Tunceli","Uşak","Van","Yalova","Yozgat","Zonguldak"
            };

            this.Cities = new List<SelectListItem>();

            foreach (var city in cities)
            {
                Cities.Add(new SelectListItem() { Text = city, Value = city });
            }

        }

    }

}
