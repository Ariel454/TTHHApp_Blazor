using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTHHApp_Blazor
{
    public class HttpClientSingleton
    {
        private static HttpClient instance;
        private static readonly object lockObject = new object();

        private HttpClientSingleton()
        {
            // Constructor privado para evitar la creación directa de instancias
        }

        public static HttpClient GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new HttpClient();
                    }
                }
            }

            return instance;
        }
    }
}
