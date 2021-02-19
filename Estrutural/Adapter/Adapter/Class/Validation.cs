using Adapter.Interface;

namespace Adapter.Class
{
    public class Validation : IValidation
    {
        public bool ValidateEmail(string email)
        {
            return true;
        }
    }
}