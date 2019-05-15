using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Response.Stock
{
    public partial class UpdateStockDepotPriorityResponseModel : PddResponseModel
    {
        /// <summary>
        /// 请求结果
        /// </summary>
        [JsonProperty("open_api_response")]
        public string OpenApiResponse { get; set; }

    }

}
