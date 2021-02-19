using Adapter.Interface;

namespace Adapter.Class
{
    public class ValidationAdapter : IValidation
    {
        private ValidationFramework validationFramework = new ValidationFramework();
        public bool ValidateEmail(string email)
        {
            var response = validationFramework.IsEmail(email);
            var isValidation = response.Contains("Não") ? false : true;
            return isValidation;
        }
    }
}