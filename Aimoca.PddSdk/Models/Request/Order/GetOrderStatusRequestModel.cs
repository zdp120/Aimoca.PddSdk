using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Request.Order
{
    public partial class GetOrderStatusRequestModel : PddRequestModel
    {
        /// <summary>
        /// 20150909-452750051,20150909-452750134 用逗号分开
        /// </summary>
        [JsonProperty("order_sns")]
        public string OrderSns { get; set; }

    }

}
