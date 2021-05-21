using BookStore.Core.Utilities.Commands.Implementatinos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Utilities.Commands.Implementations
{
    public class Response
    {
        #region props
        
        public bool Success { get; set; }
        public ErrorItemCollection Errors { get; set; }

        #endregion

        #region helpers

        public static Response<T> SuccessResponse<T>(T data)
        {
            return new Response<T>(data, true, null);
        }
        public static Response<T> FailureResponse<T>(T data, params string[] errors)
        {
            return new Response<T>(data, success: false, ErrorItemCollection.Create(errors));
        }
        public static Response<T> FailureResponse<T>(params string[] errors)
        {
            return new Response<T>(default, success: false, ErrorItemCollection.Create(errors));
        }
        public static Response<T> FailureResponse<T>()
        {
            return new Response<T>(default, success: false, ErrorItemCollection.Create("Unknown error"));
        }
        public static Response<T> InvalidRequest<T>()
        {
            return new Response<T>(default, success: false, ErrorItemCollection.Create("Invalid Request"));
        }

        #endregion
    }
    public class Response<T> : Response
    {
        #region ctor
        
        public Response(T data, bool success, ErrorItemCollection errors)
        {
            Data = data;
            Success = success;
            Errors = errors;
        } 

        #endregion

        #region props

        public T Data { get; set; }

        #endregion
    }
}
