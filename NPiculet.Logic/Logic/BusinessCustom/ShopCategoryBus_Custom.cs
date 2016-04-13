using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using NPiculet.Logic.Data;

namespace NPiculet.Logic.Business
{
	/// <summary>
	/// 自定义逻辑
	/// </summary>
	public partial class ShopCategoryBus :IBusiness
	{
        #region 自定义业务逻辑

        /// <summary>
        /// 获取主菜单
        /// </summary>
        /// <returns></returns>
        public List<ShopCategory> GetMainMenu()
        {
            var dao = CreateDao();
            return dao.QueryList<ShopCategory>("RootId=0", "OrderBy");
        }

        /// <summary>
        /// 获取子菜单
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        public DataTable GetSubMenu(int parentId)
        {
            string where = " IsEnabled=1 and IsDel=0";
            where += " and RootId=" + parentId;
            var dao = CreateDao();
            return dao.Query(where, "OrderBy");
        }

        public ShopCategory GetMenuItem(int id)
        {
            var dao = CreateDao();
            return dao.QueryModel("Id=" + id);
        }

        /// <summary>
        /// 修复菜单项路径及层次信息。
        /// </summary>
        public int FixMenuPath()
        {
            var dao = CreateDao();
            var data = dao.QueryList("IsDel=0");
            var updateList = new List<ShopCategory>();
            //修复第一层
            var root = (from a in data where a.ParentId == 0 select a);
            for (int i = 0; i < root.Count(); i++)
            {
                var menu = root.ElementAt(i);
                if (!(menu.Depth == 0 && menu.RootId == 0 && menu.Path == ""))
                {
                    menu.Depth = 0;
                    menu.RootId = 0;
                    menu.Path = "";

                    updateList.Add(menu);
                }
                //检查下层菜单
                FixSubMenuPath(data, menu, updateList);
            }
            dao.UpdateList(updateList);
            return updateList.Count;
        }

        private static void FixSubMenuPath(List<ShopCategory> data, ShopCategory parent, List<ShopCategory> updateList)
        {
            var layer = (from a in data where a.ParentId == parent.Id select a);
            foreach (ShopCategory menu in layer)
            {
                string curPath = parent.Path + "/" + parent.Id;
                if (parent.RootId != null)
                {
                    int curRootId = parent.RootId == 0 ? parent.Id : parent.RootId.Value;
                    if (parent.Depth != null)
                    {
                        int curDepth = parent.Depth.Value + 1;

                        if (!(menu.Depth == curDepth && menu.RootId == curRootId && menu.Path == curPath))
                        {
                            menu.Depth = curDepth;
                            menu.RootId = curRootId;
                            menu.Path = curPath;

                            updateList.Add(menu);
                        }
                    }
                }
                FixSubMenuPath(data, menu, updateList);
            }
        }

        #endregion
	}

}
