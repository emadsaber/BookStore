using BookStore.Core.Utilities.Commands.Implementatinos;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace BookStore.Core.Utilities.Commands.Implementations
{
    public class ApiResponse
    {
        #region props
        
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        
        [JsonPropertyName("errors")]
        public ErrorItemCollection Errors { get; set; }

        #endregion

        #region helpers

        public static ApiResponse<T> SuccessResponse<T>(T data)
        {
            return new ApiResponse<T>(data, true, null);
        }
        public static ApiResponse<T> FailureResponse<T>(T data, params string[] errors)
        {
            return new ApiResponse<T>(data, success: false, ErrorItemCollection.Create(errors));
        }
        public static ApiResponse<T> FailureResponse<T>(params string[] errors)
        {
            return new ApiResponse<T>(default, success: false, ErrorItemCollection.Create(errors));
        }

        public static ApiResponse<T> FailureResponse<T>(List<ValidationFailure> errors)
        {
            if (errors == default) return default;

            var projected = errors.Select(x => $"Error Code: [{x.ErrorCode}], AttemptedValue: [{x.AttemptedValue?.ToString()}, Message: [{x.ErrorMessage}]]").ToArray();

            return new ApiResponse<T>(default, success: false, ErrorItemCollection.Create(projected));
        }
        public static ApiResponse<T> FailureResponse<T>(ValidationResult result)
        {
            return FailureResponse<T>(result?.Errors);
        }
        public static ApiResponse<T> FailureResponse<T>()
        {
            return new ApiResponse<T>(default, success: false, ErrorItemCollection.Create("Unknown error"));
        }
        public static ApiResponse<T> InvalidRequest<T>()
        {
            return new ApiResponse<T>(default, success: false, ErrorItemCollection.Create("Invalid Request"));
        }

        #endregion
    }
    public class ApiResponse<T> : ApiResponse
    {
        #region ctor
        
        public ApiResponse(T data, bool success, ErrorItemCollection errors)
        {
            Data = data;
            Success = success;
            Errors = errors;
        } 

        #endregion

        #region props

        [JsonPropertyName("data")]
        public T Data { get; set; }

        #endregion
    }
}
