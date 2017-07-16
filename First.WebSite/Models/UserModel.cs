using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First.WebSite.Models
{
    public class UserModel:BaseModel
    {
        /// <summary>
        /// 登录账号
        /// </summary>
        public string LoginId { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string LoginPwd { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }

    }
}