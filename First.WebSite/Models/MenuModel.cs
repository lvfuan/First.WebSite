using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First.WebSite.Models
{
    public class MenuModel:BaseModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
    }
}