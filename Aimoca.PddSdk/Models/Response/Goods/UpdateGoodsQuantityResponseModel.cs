using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Response.Goods
{
    public partial class UpdateGoodsQuantityResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_quantity_update_response")]
        public GoodsQuantityUpdateResponseResponseModel GoodsQuantityUpdateResponse { get; set; }
        public partial class GoodsQuantityUpdateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// true
            /// </summary>
            [JsonProperty("is_success")]
            public bool? IsSuccess { get; set; }

        }

    }

}
