using System;
using ConsoleApp;
using FluentValidation.Results;
namespace DELEGATES_NULLABLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validando Cliente");

            Cliente cliente = new Cliente() { Nome = ""};
            ClienteValidator clienteValidator = new ClienteValidator();
            ValidationResult validationResult = clienteValidator.Validate(cliente);

            Console.WriteLine("Resultado validação: " + validationResult.IsValid);

            if(!validationResult.IsValid )
            {
                foreach(var erro in validationResult.Errors )
                {
                    //Console.WriteLine("Propriedade: " + erro.PropertyName + "Msg: " + erro.ErrorMessage);
                    Console.WriteLine(erro.ErrorMessage);
                }
            }
        }
    }
}