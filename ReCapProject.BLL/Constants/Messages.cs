using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.BLL.Constants
{
	public static class Messages
	{
        public static string CarAdded = "Araç eklendi";
        public static string SameCarNameAndSameBrandId = "Aynı markadan aynı isimle araç eklenemez.";
        public static string CarBrandCountLimitError = "10'dan fazla aynı markada araç eklenemez.";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Araçler listelendi";
        public static string CarCountOfCategoryError = "Bir kategoride en fazla 10 Araç olabilir";
        public static string CarNameAlreadyExists = "Bu isimde zaten başka bir Araç var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni Araç eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
