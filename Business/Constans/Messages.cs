using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public class Messages //proje sabitlerini buraya yazıcam

    {
        public static string MovieNameInvalid = "Film ismi çok kısa";
        public static string MovieUpdated = "Film güncellendi";
        public static string MovieCountOfError = "Bellek taştı";
        public static string GenreDeleted = "Film türü silindi";
        public static string MovieAdded ="Film eklendi";
        public static string GenreNameInvalid ="Genre geçersiz";
        public static string GenreAdded="Genre eklendi";
        public static string MovieDeleted="Film silindi";
        public static string GenreUpdated="Tür güncellendi";
        public static List<Genre> MaintenanceTime;
        public static string GenresListed ="Türler listelendi";
    }
}
