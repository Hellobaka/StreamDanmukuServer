﻿using SqlSugar;
using System;

namespace StreamDanmaku_Server.Data
{
    [SugarTable("Log")]
    internal class RuntimeLog
    {
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int RowID { get; set; }
        public string Account { get; set; }
        public string ActionName { get; set; }
        public bool Status { get; set; }
        public string Action { get; set; }
        public DateTime Time { get; set; }

        public static void WriteSystemLog(string type, string content, bool status)
        {
            WriteLog("System", type, content, status, DateTime.Now);
        }
        public static void WriteUserLog(User user, string type, string content, bool status)
        {
            WriteLog(user.Email, type, content, status, DateTime.Now);
        }
        public static void WriteUserLog(string user, string type, string content, bool status)
        {
            WriteLog(user, type, content, status, DateTime.Now);
        }
        public static void WriteLog(string origin, string type, string content, bool status, DateTime time)
        {
            Console.WriteLine($"{(status ? "[+]" : "[-]")} [{time:yyyy-MM-dd HH:mm:ss}] Origin: {origin}, Type: {type}, Content: {content}");
            var o = new RuntimeLog
            {
                Account = origin,
                ActionName = type,
                Action = content,
                Status = status,
                Time = time
            };
            SQLHelper.GetInstance().Insertable(o).ExecuteCommandAsync();
        }
    }
}
