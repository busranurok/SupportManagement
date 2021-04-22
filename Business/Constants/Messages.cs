using System;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        //Burada property oluşturup karşılığını veritabanından da getirebiliriz.
        public static string UserAdded = "Kullanıcı başarılı bir şekilde eklendi.";
        public static string UserUpdated = "Kullanıcı başarılı bir şekilde güncellendi.";
        public static string UserDeleted = "Kullanıcı başarılı bir şekilde silindi.";

        public static string TicketAdded = "Bilet başarılı bir şekilde eklendi.";
        public static string TicketUpdated = "Bilet başarılı bir şekilde güncellendi.";
        public static string TicketDeleted = "Bilet başarılı bir şekilde silindi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";

        public static string PasswordError = "Şifre hatalıdır.";

        public static string SuccessfullLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcuttur.";

        public static string UserEmailAvailable = "Bu kullanıcı adı uygundur.";

        public static string UserRegistered = "Kullanıcı başarılı bir şekilde oluşturuldu.";

        public static string AccessTokenCreated = "Access token başarılı bir şekilde oluşturuldu.";

        public static string CustomerAdded = "Müşteri başarılı bir şekilde eklendi.";
        public static string CustomerUpdated = "Müşteri başarılı bir şekilde güncellendi.";
        public static string CustomerDeleted = "Müşteri başarılı bir şekilde silindi.";
        public static string TicketStatusAdd = "Kayıt durumu başarılı bir şekilde eklendi.";
        public static string TicketStatusUpdated = "Kayıt durumu başarılı bir şekilde güncellendi.";
        public static string TicketStatusDeleted = "Kayıt durumu başarılı bir şekilde silindi.";
    }
}
