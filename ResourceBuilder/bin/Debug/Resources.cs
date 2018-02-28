using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources.Abstract;
using Resources.Concrete;
    
namespace Resources {
        public class Resources {
            private static IResourceProvider resourceProvider = new DbResourceProvider();

                
        /// <summary>Anasayfaya Hoş Geldiniz</summary>
        public static string PageTitle {
               get {
                   return (string) resourceProvider.GetResource("PageTitle", CultureInfo.CurrentUICulture.Name);
               }
            }
            
        /// <summary>Kullanıcı Adı</summary>
        public static string UserName {
               get {
                   return (string) resourceProvider.GetResource("UserName", CultureInfo.CurrentUICulture.Name);
               }
            }

        }        
}
