using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIntro.Extension
{
    //BU CLASS SESSİONLAR SADECE STRİNG VE İNT OLABİLDİĞİ İÇİN NESNE TÜRÜNDE GÖNDERİRSEK VERİYİ STRİNG VE İNT ÇEVİRMEMİZE YARIYACAK
    public static class SessionExtensionMethod
    {
        public static void SetObject(this ISession session,string key,object value)
        {
            string objectstring = JsonConvert.SerializeObject(value);//OBJECT TÜRÜNDE(VALUE) OLDUĞU İÇİN ONU STRİNGE ÇEVİRDİM 
            session.SetString(key,objectstring);
        }

        public static T GetObject<T>(this ISession session,string key) where T : class
        {
            string objectString = session.GetString(key);
            if (string.IsNullOrEmpty(objectString))
            {
                return null;
            }
            else
            {
                T value = JsonConvert.DeserializeObject<T>(objectString);
                return value;
            }

        }
    }
}
