using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Request.Logistics
{
    public partial class QueryLogisticsOnlineStatusRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

    }

}
