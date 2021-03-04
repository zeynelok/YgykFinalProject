using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime="Sistem Bakımda";
        internal static string ProductsListed="Ürünler Listelendi";

        public static string ProductCountOfCategoryError = "Bu kategori dolu";
        public static string ProductNameAlreadyExists="Bu isimde zaten bir ürün var";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
