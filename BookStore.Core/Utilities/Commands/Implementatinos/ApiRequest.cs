using System;

namespace BookStore.Core.Utilities.Commands.Implementations
{
    public class ApiRequest
    {
        public ApiRequest() { }
        #region props

        public DateTime RequestedAt { get; set; }
        public Guid? UserId { get; set; }

        #endregion

        #region helpers

        public static ApiRequest<T> Compose<T>(T data, Guid? userId)
        {
            return new ApiRequest<T>(data, userId);
        }

        public static ApiRequest<T> Compose<T>(T data)
        {
            return new ApiRequest<T>(data, null);
        }

        public static ApiRequest<T> Compose<T>()
        {
            return new ApiRequest<T>(default, default);
        }

        public bool Validate()
        {
            if (this == null) return false;
            return true;
        }
        #endregion
    }
    public class ApiRequest<T> : ApiRequest
    {
        #region ctor
        public ApiRequest() { }
        public ApiRequest(T data, Guid? userId = null)
        {
            Data = data;
            UserId = userId;
            RequestedAt = DateTime.Now;
        }

        #endregion

        #region props
        
        public T Data { get; set; }
        
        #endregion
    }
}
