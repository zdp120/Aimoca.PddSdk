using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Response.Stock
{
    public partial class InfoExpressChangeDepotResponseModel : PddResponseModel
    {
        /// <summary>
        /// 响应结果
        /// </summary>
        [JsonProperty("open_api_response")]
        public string OpenApiResponse { get; set; }

    }

}
