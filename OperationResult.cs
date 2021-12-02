

using System;

namespace resultPattern
{
    // 
    public class OperationResult
    {
        public bool Success { get; protected set; }
        public string FailureMessage { get; protected set; }
        public Exception Exception { get; protected set; }
        
        // Constructor para caso de exito
        protected OperationResult()
        {
            this.Success = true;
        }

        // Constructor para situacion de fallo
        protected OperationResult(string message)
        {
            this.Success = false;
            this.FailureMessage = message;
        }

        // Constructor para Exception
        protected OperationResult(Exception ex)
        {
            this.Success = false;
            this.Exception = ex;
        }
        
        // Metodo estatico para resultado de exito
        public static OperationResult SuccessResult()
        {
            return new OperationResult();
        }

        // Metodo estatico para situacion de fallo con mensaje
        public static OperationResult FailureResult(string message)
        {
            return new OperationResult(message);
        }

        // Metodo estatico para fallo con exception
        public static OperationResult ExceptionResult(Exception ex)
        {
            return new OperationResult(ex);
        }
        public bool IsException()
        {
            return this.Exception != null;
        }
    }
}
