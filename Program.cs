using System;

namespace resultPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var success = OperationResult.SuccessResult();
            var failWithMessage = OperationResult.FailureResult("fallo inesperado");
            var excep = OperationResult.ExceptionResult(new Exception("falla interceptada"));

            Console.WriteLine($"Success value: {success.Success}, isExeption: {success.IsException()}");
            Console.WriteLine($"Fail > success: {failWithMessage.Success}, failmessage: {failWithMessage.FailureMessage}, isExeption: {success.IsException()}");
            Console.WriteLine($"Fail > success: {excep.Success}, failmessage: {excep.FailureMessage}, except: {excep.Exception}, isExeption: {success.IsException()}");


        }
    }
}

