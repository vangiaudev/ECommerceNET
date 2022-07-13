using System;
using PayPalCheckoutSdk.Core;
using PayPalHttp;

using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
using Microsoft.Extensions.Configuration;

namespace ECommerceNET.Controllers
{
    public class PayPalClient
    {
        /**
           Set up PayPal environment with sandbox credentials.
           In production, use LiveEnvironment.
        */
       

        public static PayPalEnvironment environment()
        {
      
            return new SandboxEnvironment("AUvWp87M5Gy_05sywQlBiTTqxDnbiLDMNQILpdD_FlEXWhPC0oybVCwY3rdJ30lydUxbtwzYdHOZ7x8u",
                "EGoVvsf-KlGUzuyUq_O1rCf0M6D5rMK7PSXyGkR40H9A32xwq-1-DMQrPusWQ4KC8MC7URVJzEhHIIHx");
        }

        /**
            Returns PayPalHttpClient instance to invoke PayPal APIs.
         */
        public static HttpClient client()
        {
            return new PayPalHttpClient(environment());
        }

        public static HttpClient client(string refreshToken)
        {
            return new PayPalHttpClient(environment(), refreshToken);
        }

        /**
            Use this method to serialize Object to a JSON string.
        */
        public static String ObjectToJSONString(Object serializableObject)
        {
            MemoryStream memoryStream = new MemoryStream();
            var writer = JsonReaderWriterFactory.CreateJsonWriter(
                        memoryStream, Encoding.UTF8, true, true, "  ");
            DataContractJsonSerializer ser = new DataContractJsonSerializer(serializableObject.GetType(), new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true });
            ser.WriteObject(writer, serializableObject);
            memoryStream.Position = 0;
            StreamReader sr = new StreamReader(memoryStream);
            return sr.ReadToEnd();
        }
    }
}
