using System;
using System.Collections.Generic;
using System.Text;

namespace NIS.Common.Tools
{
    /// <summary>
    /// 日期相关扩展类
    /// </summary>
    public static class DateTimeExtension
    {
        #region 时间戳转换

        /// <summary>
        /// 获取从指定时间(UTC时间)到UTC的秒数
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static long GetUtcSeconds(this DateTime datetime)
        {
            DateTime utc = new DateTime(1970, 1, 1);
            return (long)(datetime.ToUniversalTime() - utc).TotalSeconds;
        }

        /// <summary>
        /// 获取从指定时间(本地时间)到UTC的秒数
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static long GetSeconds(this DateTime datetime)
        {
            DateTime utc = new DateTime(1970, 1, 1);
            return (long)(datetime - utc).TotalSeconds;
        }

        /// <summary>
        /// 将秒数转换成对应的UTC时间
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static DateTime ToUtcTime(this long seconds)
        {
            DateTime utc = new DateTime(1970, 1, 1);
            return utc.AddSeconds(seconds);
        }

        #endregion

        #region 时间转换

        /// <summary>
        /// 将字符串转换为时间，如果转换失败，则为NULL
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime? ParseToDateTime(this string str)
        {
            //数据校验
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            DateTime dt;
            var result = DateTime.TryParse(str, out dt);
            if (result)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将对象转换为时间，如果转换失败，则为NULL
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static DateTime? ParseToDateTime(this object obj)
        {
            if (obj == null)
            {
                return null;
            }
            return ParseToDateTime(obj.ToString());
        }

        #endregion
    }
}
