using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Request.Ad
{
    public partial class DeleteAdCreativeRequestModel : PddRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creative_id")]
        public long CreativeId { get; set; }
        /// <summary>
        /// 0:搜索广告
        /// </summary>
        [JsonProperty("scene_type")]
        public int SceneType { get; set; }

    }

}
