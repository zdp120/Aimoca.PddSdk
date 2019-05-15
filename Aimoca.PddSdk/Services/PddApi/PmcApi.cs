using Aimoca.PddSdk.Models.Request.Pmc;
using Aimoca.PddSdk.Models.Response.Pmc;
using System.Threading.Tasks;
namespace Aimoca.PddSdk.Services.PddApi
{
    public class PmcApi : PddCommonApi
    {
        /// <summary>
        /// 取消用户的消息服务
        /// </summary>
        public async Task<CancelPmcUserResponseModel> CancelPmcUserAsync(CancelPmcUserRequestModel cancelPmcUser)
        {
            var result = await PostAsync<CancelPmcUserRequestModel, CancelPmcUserResponseModel>("pdd.pmc.user.cancel", cancelPmcUser);
            return result;
        }
        /// <summary>
        /// 获取用户已开通消息
        /// </summary>
        public async Task<GetPmcUserResponseModel> GetPmcUserAsync(GetPmcUserRequestModel getPmcUser)
        {
            var result = await PostAsync<GetPmcUserRequestModel, GetPmcUserResponseModel>("pdd.pmc.user.get", getPmcUser);
            return result;
        }
        /// <summary>
        /// 为已授权的用户开通消息服务
        /// </summary>
        public async Task<PermitPmcUserResponseModel> PermitPmcUserAsync(PermitPmcUserRequestModel permitPmcUser)
        {
            var result = await PostAsync<PermitPmcUserRequestModel, PermitPmcUserResponseModel>("pdd.pmc.user.permit", permitPmcUser);
            return result;
        }

    }
}
