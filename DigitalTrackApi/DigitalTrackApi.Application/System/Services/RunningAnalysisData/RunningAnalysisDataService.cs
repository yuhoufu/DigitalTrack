﻿namespace DigitalTrackApi.Application
{
    public class RunningAnalysisDataService : ISystemService, ITransient
    {
        public string GetDescription()
        {
            return "让 .NET 开发更简单，更通用，更流行。";
        }
    }
}
