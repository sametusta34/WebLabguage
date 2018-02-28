using System.Globalization;
using Resources.Abstract;
using Resources.Concrete;

namespace WebLanguage.Concrete
{
    public class Resources
    {
        private static IResourceProvider resourceProvider = new DbResourceProvider();


        /// <summary>Anasayfaya Hoş Geldiniz</summary>
        public static string PageTitle
        {
            get
            {
                return (string)resourceProvider.GetResource("PageTitle", CultureInfo.CurrentUICulture.Name);
            }
        }

        /// <summary>Kullanıcı Adı</summary>
        public static string UserName
        {
            get
            {
                return (string)resourceProvider.GetResource("UserName", CultureInfo.CurrentUICulture.Name);
            }
        }

    }
}
