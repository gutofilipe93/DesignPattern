using System.Collections.Generic;

namespace Proxy.System_user
{
    public class SystemUserProxy : ISystemUser
    {
        public string FirstName { get; set; }
        public string UserName { get; set; }

        private ISystemUser _realUser;
        private List<SystemUserAddressProtocol> _realUserAddresses;

        public SystemUserProxy(string firstName, string userName)
        {
            FirstName = firstName;
            UserName = userName;
        }

        /* Só a primeira execução vai demorar os dois segundos a outras 5 vai ser rapida, pois vai retornar da memória */
        public List<SystemUserAddressProtocol> GetAddresses()
        {
            if(_realUser == null)
                _realUser = new AdminUser(FirstName,UserName);

            if(_realUserAddresses ==  null)
                _realUserAddresses = _realUser.GetAddresses();

            return _realUserAddresses;     
        }
    }
}