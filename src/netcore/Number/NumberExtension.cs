using System;
using System.Linq.Expressions;

namespace NIS.Common.Tools
{
    /// <summary>
    /// 数字相关扩展方法
    /// </summary>
    public static class NumberExtension
    {
        /// <summary>
        /// 将对象转换为整形
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int? ToInt32(this object obj)
        {
            //判断对象是否为null
            if (obj == null)
            {
                return null;
            }

            var parse = int.TryParse(obj.ToString(), out var result);
            if (parse)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将字符串转换为整形
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int? ToInt32(this string str)
        {
            //判断字符串是否为空
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            var parse = int.TryParse(str, out int result);
            if (parse)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将对象转换为长整形
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static long? ToInt64(this object obj)
        {
            //判断对象是否为null
            if (obj == null)
            {
                return null;
            }

            var parse = long.TryParse(obj.ToString(), out long result);
            if (parse)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将字符串转换为长整形
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static long? ToInt64(this string str)
        {
            //判断字符串是否为空
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            var parse = long.TryParse(str, out long result);
            if (parse)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将对象转换为单精度浮点数
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static float? ToFloat(this object obj)
        {
            //判断对象是否为空
            if (obj == null)
            {
                return null;
            }
            
            var parse = float.TryParse(obj.ToString(), out float result);
            if (parse)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将字符串转换为单精度浮点数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static float? ToFloat(this string str)
        {
            //判断字符串是否为空
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            var parse = float.TryParse(str, out float result);
            if (parse)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将对象转换为双精度浮点数
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double? ToDouble(this object obj)
        {
            //判断对象是否为空
            if (obj == null)
            {
                return null;
            }
            
            var parse = double.TryParse(obj.ToString(), out double result);
            if (parse)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将字符串转换为双精度浮点数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static double? ToDouble(this string str)
        {
            //判断字符串是否为空
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            var parse = double.TryParse(str, out double result);
            if (parse)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}