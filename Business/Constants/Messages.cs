using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants {
    public static class Messages {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Kategoride bulunabilecek en fazla ürün limiti doldu";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceeded = "Bulunabilecek maksimum kategori sayısı aşıldı";
        public static string AuthorizationDenied = "Yetkiniz yok";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}
