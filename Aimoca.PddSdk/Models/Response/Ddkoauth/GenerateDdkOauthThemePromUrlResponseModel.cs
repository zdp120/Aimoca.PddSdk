using Newtonsoft.Json;
using System.Collections.Generic;
namespace Aimoca.PddSdk.Models.Response.Ddkoauth
{
    public partial class GenerateDdkOauthThemePromUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// 主题活动推广链接返回对象
        /// </summary>
        [JsonProperty("theme_promotion_url_generate_response")]
        public ThemePromotionUrlGenerateResponseResponseModel ThemePromotionUrlGenerateResponse { get; set; }
        public partial class ThemePromotionUrlGenerateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// url_list
            /// </summary>
            [JsonProperty("url_list")]
            public List<UrlListResponseModel> UrlList { get; set; }
            public partial class UrlListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 主题活动推广链接
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; }
                /// <summary>
                /// 主题活动推广短链接
                /// </summary>
                [JsonProperty("short_url")]
                public string ShortUrl { get; set; }
                /// <summary>
                /// 主题活动推广移动链接
                /// </summary>
                [JsonProperty("mobile_url")]
                public string MobileUrl { get; set; }
                /// <summary>
                /// 主题活动推广移动短链接
                /// </summary>
                [JsonProperty("mobile_short_url")]
                public string MobileShortUrl { get; set; }
                /// <summary>
                /// 主题活动推广多人团链接
                /// </summary>
                [JsonProperty("multi_group_url")]
                public string MultiGroupUrl { get; set; }
                /// <summary>
                /// 主题活动推广多人团短链接
                /// </summary>
                [JsonProperty("multi_group_short_url")]
                public string MultiGroupShortUrl { get; set; }
                /// <summary>
                /// 主题活动推广多人团移动链接
                /// </summary>
                [JsonProperty("multi_group_mobile_url")]
                public string MultiGroupMobileUrl { get; set; }
                /// <summary>
                /// 主题活动推广多人团移动短链接
                /// </summary>
                [JsonProperty("multi_group_mobile_short_url")]
                public string MultiGroupMobileShortUrl { get; set; }

            }

        }

    }

}
