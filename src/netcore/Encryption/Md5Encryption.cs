using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace NIS.Common.Basic
{
    /// <summary>
    /// MD5加密
    /// </summary>
    public static class Md5Encryption
    {
        /// <summary>
        /// 获取字符串的md5值
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string Encrypt(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                return string.Empty;
            }

            byte[] buffer = Encoding.Default.GetBytes(content);
            //计算哈希值
            using (MD5 md5 = MD5.Create())
            {
                byte[] newBuffer = md5.ComputeHash(buffer);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < newBuffer.Length; i++)
                {
                    sb.Append(newBuffer[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

        /// <summary>
        /// 获取数据流的md5值
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static string Encrypt(Stream stream)
        {
            if (stream == null || stream.Length == 0)
            {
                return string.Empty;
            }

            using (MD5 md5 = MD5.Create())
            {
                byte[] buffer = md5.ComputeHash(stream);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < buffer.Length; i++)
                {
                    sb.Append(buffer[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}