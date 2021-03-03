using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proxy.System_user
{
    public interface ISystemUser
    {
        List<SystemUserAddressProtocol> GetAddresses();
    }
}