using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ErrorModel
    {
        public ErrorModel()
        {
        }

        public ErrorModel(string error, string errorDescription)
        {
            Error = error;
            ErrorDescription = errorDescription;
        }

        /// <summary>An error code for this type of error</summary>
        [JsonProperty("error",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        /// <summary>A human readable description of the error</summary>
        [JsonProperty("error_description",
            NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorDescription { get; set; }
    }
}