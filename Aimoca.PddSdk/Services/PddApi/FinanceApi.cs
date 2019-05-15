using Aimoca.PddSdk.Models.Request.Finance;
using Aimoca.PddSdk.Models.Response.Finance;
using System.Threading.Tasks;
namespace Aimoca.PddSdk.Services.PddApi
{
    public class FinanceApi : PddCommonApi
    {
        /// <summary>
        /// 商家货款日账单下载链接查询接口
        /// </summary>
        public async Task<GetFinanceBalanceDailyBillUrlResponseModel> GetFinanceBalanceDailyBillUrlAsync(GetFinanceBalanceDailyBillUrlRequestModel getFinanceBalanceDailyBillUrl)
        {
            var result = await PostAsync<GetFinanceBalanceDailyBillUrlRequestModel, GetFinanceBalanceDailyBillUrlResponseModel>("pdd.finance.balance.daily.bill.url.get", getFinanceBalanceDailyBillUrl);
            return result;
        }

    }
}
