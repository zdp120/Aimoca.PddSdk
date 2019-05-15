using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Request.Ddkoauth
{
    public partial class GetDdkOauthOrderDetailRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

    }

}
