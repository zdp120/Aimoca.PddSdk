using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Request.Goods
{
    public partial class DeleteGoodsLogisticsSerTemplateRequestModel : PddRequestModel
    {
        /// <summary>
        /// 模版id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

    }

}
