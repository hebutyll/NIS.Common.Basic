using System;
using System.Collections.Generic;
using System.Text;

namespace NIS.Common.Basic
{
    /// <summary>
    /// 分页结果通用对象
    /// </summary>
    public class PagingObject<T> where T : class
    { 
        /// <summary>
        /// 数据总数
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// 当前页数据列表
        /// </summary>
        public List<T> DataList { get; set; }
    }

    /// <summary>
    /// 执行操作时通用返回对象
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseModel<T>
    { 
        /// <summary>
        /// 操作结果， true-执行成功 false-执行失败
        /// </summary>
        public bool Result { get; set; }

        /// <summary>
        /// 执行结果码 0-成功 1-失败，结果码可以根据具体情况进行定义
        /// </summary>
        public int Code { get; set; }
    }
}
