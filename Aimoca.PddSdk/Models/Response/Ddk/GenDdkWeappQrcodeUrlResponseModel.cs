using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Response.Ddk
{
    public partial class GenDdkWeappQrcodeUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("weapp_qrcode_generate_response")]
        public WeappQrcodeGenerateResponseResponseModel WeappQrcodeGenerateResponse { get; set; }
        public partial class WeappQrcodeGenerateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 单品推广小程序二维码url
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }

        }

    }

}
