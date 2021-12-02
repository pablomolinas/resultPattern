

using System;

namespace resultPattern
{
    // 
    public class Result
    {
        public bool Success { get; protected set; }
        public string FailureMessage { get; protected set; }
        public Exception Exception { get; protected set; }
                
        // Constructor para caso de exito
        protected Result()
        {
            this.Success = true;
        }

        // Constructor para situacion de fallo
        protected Result(string message)
        {
            this.Success = false;
            this.FailureMessage = message;
        }

        // Constructor para Exception
        protected Result(Exception ex)
        {
            this.Success = false;
            this.Exception = ex;
        }
        
        // Metodo estatico para resultado de exito
        public static Result SuccessResult()
        {
            return new Result();
        }

        // Metodo estatico para situacion de fallo con mensaje
        public static Result FailureResult(string message)
        {
            return new Result(message);
        }

        // Metodo estatico para fallo con exception
        public static Result ExceptionResult(Exception ex)
        {
            return new Result(ex);
        }
        public bool IsException()
        {
            return this.Exception != null;
        }
    }

    // Hereda de Result, siendo generico me permite incluir cualquier tipo de dato en SuccessResult
    public class Result<T> : Result
    {
        public T Payload { get; protected set; }

        protected Result(T t)
        {
            this.Success = true;
            this.Payload = t;
        }

        // Metodo estatico para resultado de exito
        public static Result SuccessResult(T t)
        {
            return new Result<T>(t);
        }
    }
}
