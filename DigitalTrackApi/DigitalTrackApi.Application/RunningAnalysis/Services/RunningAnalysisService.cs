using DigitalTrackApi.Application.RunningAnalysis.Services;

namespace DigitalTrackApi.Application.RunningAnalysis.Services
{
    public class RunningAnalysisService : IRunningAnalysisService, ITransient
    {
        public string GetDescription()
        {
            return "获取数字跑道数据。";
        }

        public string AddRunningAnalysis(RunningAnalysisData data)
        {
            return "增加数据";
        }
    }
}
