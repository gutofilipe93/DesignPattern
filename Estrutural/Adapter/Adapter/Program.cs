using System;
using Adapter.Class;
using Adapter.Interface;

namespace Adapter
{
    class Program
    {
        /* Foi usado criado a classe Adapter para poder adaptar o framework com a forma que se usa no client */
        static void Main(string[] args)
        {
            IValidation validation = new Validation();
            Console.WriteLine($"Validação sem Framework  - {validation.ValidateEmail("gustavo@gmail.com")}");
            
            IValidation validationAdapter = new ValidationAdapter();
            Console.WriteLine($"Validação com Framework  - {validationAdapter.ValidateEmail("jkdfsg")}");
        }
    }
}
