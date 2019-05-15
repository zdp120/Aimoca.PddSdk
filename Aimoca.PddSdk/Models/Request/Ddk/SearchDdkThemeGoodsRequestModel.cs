using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Request.Ddk
{
    public partial class SearchDdkThemeGoodsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 主题ID
        /// </summary>
        [JsonProperty("theme_id")]
        public long ThemeId { get; set; }

    }

}
