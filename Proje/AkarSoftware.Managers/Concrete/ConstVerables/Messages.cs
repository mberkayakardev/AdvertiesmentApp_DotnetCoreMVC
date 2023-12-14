namespace AkarSoftware.Managers.Concrete.ConstVerables
{
    public static class Messages
    {
        public static class Result
        {
            public static string NotFound = "Herhangi bir kayıt bulunamadı";
            public static string ValidatonError = "Validasyona uygun olmayan veriler mevcut";
        }

        public static class CRUD
        {
            public static string Read = "Okuma işlemi başarı ile gerçekleştirildi. ";
            public static string Added = "Ekleme işlemi başarı ile gerçekleştirildi";
            public static string Deleted = "Silme işlemi başarı ile gerçekleştirildi";
            public static string Updated = "Güncelleme işlemi başarı ile gerçekleştirildi";
            public static string SoftDelete = Deleted;
        }


    }
}
