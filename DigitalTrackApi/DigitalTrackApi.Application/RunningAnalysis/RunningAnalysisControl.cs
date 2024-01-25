using DigitalTrackApi.Application.RunningAnalysis.Services;
using DigitalTrackApi.Core;
using DigitalTrackApi.Application.RunningAnalysis.Attributes;

namespace DigitalTrackApi.Application
{
    /// <summary>
    /// 跑道数据接口
    /// </summary>
   [UuidFilter] 
    public class RunningAnalysisControl : IDynamicApiController
    {
        private readonly IRunningAnalysisService _service;
        public RunningAnalysisControl(IRunningAnalysisService service)
        {
            _service = service;
        }

        /// <summary>
        /// 获取描述
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return _service.GetDescription();

        }

        [HttpPost]
        public ActionResult<string> Add([FromBody] RunningAnalysisData data)
        {
            var id = _service.AddRunningAnalysis(data);

            return new ActionResult<string>(id);

           
        }
    }
}
