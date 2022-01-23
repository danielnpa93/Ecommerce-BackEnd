using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Utils
{
    public class ResponseEnvelope<T> where T : class
    {
        [JsonProperty("data")]
        public T Data { get; }

        [JsonProperty("isValid")]
        public bool IsValid { get; }

        [JsonProperty("error")]
        public object Error { get; }

        [JsonProperty("data")]
        public string Message { get; }

        private ResponseEnvelope(T data, object error,bool isValid, string message)
        {
            Data = data;
            Error = error;
            IsValid = isValid;
            Message = message;
        }

        public static ResponseEnvelope<T> CreateSucess(T data)
        {
            return new ResponseEnvelope<T>(data, null, true, null);
        }
        public static ResponseEnvelope<T> CreateSucess(T data, string message)
        {
            return new ResponseEnvelope<T>(data, null,true, message);
        }

        public static ResponseEnvelope<T> CreateFailure(object error, string message)
        {
            return new ResponseEnvelope<T>(null, error, false, message);
        }
    }
}
