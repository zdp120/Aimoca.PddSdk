using Newtonsoft.Json;
using System.Collections.Generic;
namespace Aimoca.PddSdk.Models.Response.Util
{
    public partial class ImageUtilDivideBase64ResponseModel : PddResponseModel
    {
        /// <summary>
        /// 切图后的地址列表
        /// </summary>
        [JsonProperty("open_api_response")]
        public List<string> OpenApiResponse { get; set; }

    }

}
