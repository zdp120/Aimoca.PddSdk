using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Request.Pmc
{
    public partial class CancelPmcUserRequestModel : PddRequestModel
    {
        /// <summary>
        /// 用户唯一id
        /// </summary>
        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

    }

}
