using System;

namespace resultPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var success = Result.SuccessResult();
            var failWithMessage = Result.FailureResult("fallo inesperado");
            var excep = Result.ExceptionResult(new Exception("falla interceptada"));

            var successData = Result<string>.SuccessResult("Resultado exitoso");

            Console.WriteLine($"Success value: {success.Success}, isExeption: {success.IsException()}");
            Console.WriteLine($"Fail > success: {failWithMessage.Success}, failmessage: {failWithMessage.FailureMessage}, isExeption: {success.IsException()}");
            Console.WriteLine($"Fail > success: {excep.Success}, failmessage: {excep.FailureMessage}, except: {excep.Exception}, isExeption: {excep.IsException()}");
            Console.WriteLine($"Fail > success: {successData.Success} failmessage: {successData.FailureMessage}, except: {successData.Exception}, isExeption: {successData.IsException()}, payload: {successData}");

        }
    }
}

