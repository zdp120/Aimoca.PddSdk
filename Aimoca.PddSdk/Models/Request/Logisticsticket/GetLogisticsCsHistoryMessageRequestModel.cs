using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Request.Logisticsticket
{
    public partial class GetLogisticsCsHistoryMessageRequestModel : PddRequestModel
    {
        /// <summary>
        /// pdd会话id
        /// </summary>
        [JsonProperty("session_id")]
        public string SessionId { get; set; }

    }

}
