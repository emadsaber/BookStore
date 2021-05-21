using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Utilities.Commands.Implementations
{
    public class Request
    {
        #region props

        public DateTime RequestedAt { get; set; }
        public Guid? UserId { get; set; }
        public object Data { get; set; }

        #endregion

        #region helpers

        public static Request<T> Compose<T>(T data, Guid? userId)
        {
            return new Request<T>(data, userId);
        }

        public static Request<T> Compose<T>(T data)
        {
            return new Request<T>(data, null);
        }

        public bool Validate()
        {
            if (this == null) return false;
            if (this.Data == null) return false;
            return true;
        }
        #endregion
    }
    public class Request<T> : Request
    {
        #region ctor

        public Request(T data, Guid? userId = null)
        {
            Data = data;
            base.Data = data;
            UserId = userId;
            RequestedAt = DateTime.Now;
        }

        #endregion

        #region props
        
        public new T Data { get; set; }
        
        #endregion
    }
}
