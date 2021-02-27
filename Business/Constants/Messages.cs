using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";

        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string ProductListed = "Ürünler listelendi";

        public static string ProductCountofCategoryError = "bir kategoride en fazla 15 ürün olabilir";

        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserAlreadyExists = "Ürün ismi zaten mevcut";

        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string SuccessfulLogin = "Sisteme giriş başarılı";

        public static string PasswordError = "Şifre hatalı";
    }
}
