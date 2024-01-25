namespace DigitalTrackApi.Application.RunningAnalysis.Services
{
    public interface IRunningAnalysisService
    {
        string GetDescription();
        string AddRunningAnalysis(RunningAnalysisData data);
    }

    
}
