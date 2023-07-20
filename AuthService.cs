using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTHHApp_Blazor
{

        public interface IAuthService
        {
            Task SetCompania(string nombreCompania);
            string GetCompania();
        }

        public class AuthService : IAuthService
        {
            private string nombreCompania;

            public Task SetCompania(string nombreCompania)
            {
                this.nombreCompania = nombreCompania;
                return Task.CompletedTask;
            }

            public string GetCompania()
            {
                return nombreCompania;
            }
        }
    
}
