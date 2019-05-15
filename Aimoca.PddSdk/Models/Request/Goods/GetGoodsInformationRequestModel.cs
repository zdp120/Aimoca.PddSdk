using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Request.Goods
{
    public partial class GetGoodsInformationRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }

    }

}
