using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace w_test.Models
{

    public class BaseData
    {
        public static List<Privs> privs;

        static BaseData()
        {
            privs = new List<Privs>()
            {
                // yg
                new Privs() { id = 1, name = "验光首页", yflb = "yg", url = "yg/index", label = "yg-index" },
                new Privs() { id = 2, name = "当日验光", yflb = "yg", url = "yg/today", label = "yg-today" },
                new Privs() { id = 3, name = "添加验光", yflb = "yg", url = "yg/add", label = "yg-add" , display=false },
                new Privs() { id = 4, name = "综合查询", yflb = "yg", url = "yg/all", label = "yg-all" },

                // dz
                new Privs() { id = 5, name = "验光首页", yflb = "dz", url = "yg/index", label = "yg-index" },
                new Privs() { id = 6, name = "当日验光", yflb = "dz", url = "yg/today", label = "yg-today" },
                new Privs() { id = 7, name = "添加验光", yflb = "dz", url = "yg/add", label = "yg-add" },
                new Privs() { id = 8, name = "综合查询", yflb = "dz", url = "yg/all", label = "yg-all" },

                // zj
                new Privs() { id = 9, name = "验光首页", yflb = "zj", url = "yg/index", label = "yg-index" },
                new Privs() { id = 10, name = "当日验光", yflb = "zj", url = "yg/today", label = "yg-today" },
                new Privs() { id = 11, name = "修改验光", yflb = "zj", url = "yg/edit", label = "yg-edit" },
                new Privs() { id = 12, name = "综合查询", yflb = "zj", url = "yg/all", label = "yg-all" },

                // hf
                new Privs() { id = 13, name = "验光首页", yflb = "hf", url = "yg/index", label = "yg-index" },
                new Privs() { id = 14, name = "当日验光", yflb = "hf", url = "yg/today", label = "yg-today" },
                new Privs() { id = 15, name = "综合查询", yflb = "hf", url = "yg/all", label = "yg-all" },

                // null 管理员
                new Privs() { id = 16, name = "验光首页", yflb = "null", url = "yg/index", label = "yg-index" },
                new Privs() { id = 17, name = "当日验光", yflb = "null", url = "yg/today", label = "yg-today" },
                new Privs() { id = 18, name = "添加验光", yflb = "null", url = "yg/add", label = "yg-add" },
                new Privs() { id = 19, name = "综合查询", yflb = "null", url = "yg/all", label = "yg-all" },
                new Privs() { id = 20, name = "用户列表", yflb = "null", url = "user/index", label = "user-index" },
                new Privs() { id = 21, name = "添加用户", yflb = "null", url = "user/add", label = "user-add" },
                new Privs() { id = 22, name = "修改用户", yflb = "null", url = "user/edit", label = "user-edit" },
                new Privs() { id = 23, name = "删除用户", yflb = "null", url = "user/delete", label = "user-delete" , display=false},
                
            };
        }

    }
}