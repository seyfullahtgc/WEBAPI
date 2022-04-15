using System.ComponentModel.DataAnnotations;

namespace WEBAPI.Model
{
    public class Personel
    {
        public Guid Id { get; set; }
        public string AdıveİkinciAdı { get; set; }
        public string Soyadı { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }

    }
}
