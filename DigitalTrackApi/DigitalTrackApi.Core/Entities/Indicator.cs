using System;
using Furion.DatabaseAccessor;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace DigitalTrackApi.Core
{

    [SqlSugar.SugarTable("Indicator")]
    public class Indicator
    {
        [SqlSugar.SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }
        public int StepId { get; set; }
    }
}
