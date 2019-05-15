using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Response.Ad
{
    public partial class UpdateAdCreativeResponseModel : PddResponseModel
    {
        /// <summary>
        /// true or false
        /// </summary>
        [JsonProperty("open_api_response")]
        public bool? OpenApiResponse { get; set; }

    }

}
