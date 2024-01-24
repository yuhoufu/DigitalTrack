using System;
using Furion.DatabaseAccessor;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace DigitalTrackApi.Core
{

    [SqlSugar.SugarTable("Step")]
    public class Step
    {
        [SqlSugar.SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public int Index { get; set; }
        public string RunningAnalysisDataUuid { get; set; }

        [SqlSugar.SugarColumn(IsIgnore = true)]
        public List<Indicator> Indicators { get; set; }
    }

}
