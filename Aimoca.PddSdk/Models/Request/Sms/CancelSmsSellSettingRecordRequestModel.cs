using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Request.Sms
{
    public partial class CancelSmsSellSettingRecordRequestModel : PddRequestModel
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

    }

}
