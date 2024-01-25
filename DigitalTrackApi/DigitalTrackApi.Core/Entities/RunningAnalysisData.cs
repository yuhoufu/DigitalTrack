using System;
using Furion.DatabaseAccessor;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using SqlSugar;


namespace DigitalTrackApi.Core
{

    [SqlSugar.SugarTable("RunningAnalysisData")]
    public class RunningAnalysisData
    {
        //private Guid _uuid = Guid.NewGuid() ;

        [SqlSugar.SugarColumn(IsPrimaryKey = true)]
        public string Uuid { get; set; }
        //{
        //    get => _uuid.ToString();
        //    set
        //    {
        //        // 检查value是否是空的Guid或者无效的Guid
        //        //_uuid = value == Guid.Empty || !Guid.TryParse(value.ToString(), out _) ? Guid.NewGuid() : value;

        //        try
        //        {
        //            // 尝试将传入的值转换为Guid
        //            _uuid = Guid.Parse(value.ToString());
        //        }
        //        catch
        //        {
        //            // 如果转换失败，使用一个新的Guid
        //            _uuid = Guid.NewGuid();
        //        }
        //    }
        //}
        public string PeopleName { get; set; }
        public string PeopleNum { get; set; }
        public double Weight { get; set; }
        public string TestModule { get; set; }
        public DateTime TestTime { get; set; }

        [SqlSugar.SugarColumn(IsIgnore = true)]
        public List<Step> Steps { get; set; }
    }

}
