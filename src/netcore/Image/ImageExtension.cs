using System;
using System.IO;

namespace NIS.Common.Tools.Image
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
        
        public static 
    }
}