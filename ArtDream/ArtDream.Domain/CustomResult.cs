using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtDream.Domain
{
    public class CustomResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public void Fail(string message)
        {
            this.Success = false;
            this.Message = message;
        }

        public void Succeed(string message)
        {
            this.Success = true;
            this.Message = message;
        }
    }

    public class CustomResult<T> : CustomResult
    {
        public T Value { get; set; }

        public void Succeed(T value)
        {
            this.Success = true;
            this.Value = value;
        }
    }
}
