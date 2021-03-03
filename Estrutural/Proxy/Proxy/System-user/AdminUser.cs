using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy.System_user
{
    public class AdminUser : ISystemUser
    {
        public string FirstName { get; set; }
        public string UserName { get; set; }

        public AdminUser(string firstName, string userName)
        {
            FirstName = firstName;
            UserName = userName;
        }

        public List<SystemUserAddressProtocol> GetAddresses()
        {
            var userAddresses = new List<SystemUserAddressProtocol>
            {
                new SystemUserAddressProtocol 
                {
                    Street = "Av. Brasil",
                    Number = 50
                },
                new SystemUserAddressProtocol
                {
                    Street = "Rua A.",
                    Number = 40
                }
            };
            Thread.Sleep(2000);
            return userAddresses;
        }
    }
}