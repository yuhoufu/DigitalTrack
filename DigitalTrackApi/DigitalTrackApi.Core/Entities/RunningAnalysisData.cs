using System;
using Furion.DatabaseAccessor;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace DigitalTrackApi.Core
{

    [SqlSugar.SugarTable("RunningAnalysisData")]
    public class RunningAnalysisData
    {
        [SqlSugar.SugarColumn(IsPrimaryKey = true)]
        public string Uuid { get; set; }
        public string PeopleName { get; set; }
        public string PeopleNum { get; set; }
        public double Weight { get; set; }
        public string TestModule { get; set; }
        public DateTime TestTime { get; set; }

        [SqlSugar.SugarColumn(IsIgnore = true)]
        public List<Step> Steps { get; set; }
    }

}
