using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aimoca.PddSdk.AspNetCore;
using Aimoca.PddSdk.Models.Request.Ddk;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Aimoca.PddSdk.Web.Test.Controllers
{
    [Route("ddk")]
    public class DdkController : Controller
    {
        // GET: api/<controller>
        readonly PddService pdd;
        //readonly string AccessToken = "7b8c75b717044ddf8a7e1cd48f5b492212a3623e";
        public DdkController(PddService pdd)
        {
            this.pdd = pdd;
            //PddCommonApi.AccessToken = AccessToken;
        }
        // GET: api/<controller>
        [HttpGet]
        [Route("top/{pid}/{sorttype}/{page}/{pagesize}")]
        public async Task<IActionResult> GetTop(string pid, int sorttype, int page, int pagesize)
        {
            var model = new QueryDdkTopGoodsListRequestModel
            {
                PId = pid,
                SortType = sorttype,
                Offset = page * pagesize,
                Limit = pagesize
            };
            var result = JsonConvert.SerializeObject(await pdd.DdkApi.QueryDdkTopGoodsListAsync(model));
            //Console.WriteLine(result);
            return Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="good_id_list">商品ID</param>
        /// <param name="pid">推广位id</param>
        /// <param name="custom_parameters">自定义参数</param>
        /// <param name="zs_duo_id">招商多多客ID</param>
        /// <param name="plan_type">佣金优惠券对应推广类型，3：专属 4：招商</param>
        /// <returns></returns>
        [HttpGet]
        [Route("item/{good_id_list:long}/{pid?}/{custom_parameters?}/{zs_duo_id?}/{plan_type?}")]
        public async Task<IActionResult> GetItem(long good_id_list, string pid, string custom_parameters, long? zs_duo_id, int? plan_type)
        {
            List<long> list = new List<long>();
            list.Add(good_id_list);
            var model = new DetailDdkGoodsRequestModel
            {
                GoodsIdList = list
                
            };
            //model.Pid = "1942900_65185308";

            try
            {
                //var result = JsonConvert.DeserializeObject(await pdd.DdkApi.DetailDdkGoodsAsync(model));
                Console.WriteLine(model.GoodsIdList.First().ToString());
                var m = JsonConvert.SerializeObject(await pdd.DdkApi.DetailDdkGoodsAsync(model));
                Console.WriteLine(m);
                return Ok(m);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return NotFound();
            }
            
            
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
