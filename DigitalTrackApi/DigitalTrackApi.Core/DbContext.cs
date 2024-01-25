using Furion;
using Furion.Logging.Extensions;
using Microsoft.Extensions.Logging;
using SqlSugar;
using System;
using System.Collections.Generic;

namespace DigitalTrackApi.Core
{
    /// <summary>
    /// 数据库上下文对象
    /// </summary>
    public static class DbContext
    {
        private static ILogger _logger;

        public static void Initialize(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// SqlSugar 数据库实例
        /// </summary>
        public static readonly SqlSugarScope Instance = new SqlSugarScope(
            // 读取 appsettings.json 中的 ConnectionConfigs 配置节点
            configs: App.GetConfig<List<ConnectionConfig>>("ConnectionConfigs")
            , configAction: db =>
            {
                // 这里配置全局事件，比如拦截执行 SQL
                db.Aop.OnLogExecuting = (sql, pars) =>
                {
                    // Console.WriteLine(sql);//输出sql,查看执行sql 性能无影响

                    // 使用ILogger记录SQL
                    if (_logger != null)
                    {
                        _logger.LogInformation(UtilMethods.GetNativeSql(sql, pars));
                    }

                    //获取原生SQL推荐 5.1.4.63  性能OK
                    //Console.WriteLine(UtilMethods.GetNativeSql(sql, pars));

                    //获取无参数化SQL 对性能有影响，特别大的SQL参数多的，调试使用
                    //UtilMethods.GetSqlString(DbType.SqlServer,sql,pars)


                   };
            });

        

    }
}
