using System;
using System.IO;

namespace NIS.Common.Basic
{
    /// <summary>
    /// 图像转换扩展方法
    /// </summary>
    public static class ImageExtension
    {
        /// <summary>
        /// 将图片流转换为Base64字符串
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="err"></param>
        /// <returns></returns>
        public static string ToBase64(this Stream stream, out string err)
        {
            err = string.Empty;
            try
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, (int) stream.Length);
                return Convert.ToBase64String(buffer);
            }
            catch (Exception e)
            {
                err = e.Message;
                return null;
            }
        }

        /// <summary>
        /// 将base64字符串转换为图像
        /// </summary>
        /// <param name="source"></param>
        /// <param name="stream"></param>
        /// <param name="err"></param>
        /// <returns></returns>
        public static bool ToImage(this string source, Stream stream, out string err)
        {
            err = string.Empty;
            try
            {
                byte[] buffer = Convert.FromBase64String(source);
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
                return true;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        }
    }
}