using Aimoca.PddSdk.Models.Request.Open;
using Aimoca.PddSdk.Models.Response.Open;
using System.Threading.Tasks;
namespace Aimoca.PddSdk.Services.PddApi
{
    public class OpenApi : PddCommonApi
    {
        /// <summary>
        /// 查询短信发送记录
        /// </summary>
        public async Task<RecordOpenMsgServiceQueryMsgResponseModel> RecordOpenMsgServiceQueryMsgAsync(RecordOpenMsgServiceQueryMsgRequestModel recordOpenMsgServiceQueryMsg)
        {
            var result = await PostAsync<RecordOpenMsgServiceQueryMsgRequestModel, RecordOpenMsgServiceQueryMsgResponseModel>("pdd.open.msg.service.query.msg.record", recordOpenMsgServiceQueryMsg);
            return result;
        }
        /// <summary>
        /// 短信批量发送接口
        /// </summary>
        public async Task<MsgOpenMsgServiceSendBatchResponseModel> MsgOpenMsgServiceSendBatchAsync(MsgOpenMsgServiceSendBatchRequestModel msgOpenMsgServiceSendBatch)
        {
            var result = await PostAsync<MsgOpenMsgServiceSendBatchRequestModel, MsgOpenMsgServiceSendBatchResponseModel>("pdd.open.msg.service.send.batch.msg", msgOpenMsgServiceSendBatch);
            return result;
        }
        /// <summary>
        /// 短信发送接口
        /// </summary>
        public async Task<MsgOpenMsgServiceSendResponseModel> MsgOpenMsgServiceSendAsync(MsgOpenMsgServiceSendRequestModel msgOpenMsgServiceSend)
        {
            var result = await PostAsync<MsgOpenMsgServiceSendRequestModel, MsgOpenMsgServiceSendResponseModel>("pdd.open.msg.service.send.msg", msgOpenMsgServiceSend);
            return result;
        }

    }
}
