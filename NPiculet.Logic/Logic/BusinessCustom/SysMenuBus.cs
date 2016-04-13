using System.Collections.Generic;
using System.Data;
using NPiculet.Logic.Data;

namespace NPiculet.Logic.Business
{
    public partial class SysMenuBusEx : SysMenuBus
    {
        /// <summary>
        /// 获取主菜单
        /// </summary>
        /// <returns></returns>
        public List<SysMenu> GetMainMenuByAuth(int userId)
        {
            string whereString = "RootId=0 and IsDel=0 and IsEnabled=1";
            if (userId > 2)
                whereString += @" and (
  EXISTS(SELECT * FROM npc_sys_authorization WHERE npc_sys_menu.Id=FunctionId AND TargetType='User' AND FunctionType='Menu' AND TargetId=" + userId + @")
  or EXISTS(SELECT * FROM npc_sys_authorization A
   INNER JOIN npc_sys_link_user_role R ON A.TargetId=R.RoleId AND R.UserId=" + userId + @"
  WHERE npc_sys_menu.Id=FunctionId AND A.TargetType='Role' AND A.FunctionType='Menu')
 )";
            return this.QueryList(whereString, "OrderBy");
        }

        /// <summary>
        /// 获取子菜单
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataTable GetSubMenuByAuth(int parentId, int userId)
        {
            string whereString = "IsExternal=0 and IsEnabled=1 and IsDel=0 and RootId=" + parentId;
            if (userId > 2)
                whereString += @" and (
  EXISTS(SELECT * FROM npc_sys_authorization WHERE npc_sys_menu.Id=FunctionId AND TargetType='User' AND FunctionType='Menu' AND TargetId=" + userId + @")
  or EXISTS(SELECT * FROM npc_sys_authorization A
   INNER JOIN npc_sys_link_user_role R ON A.TargetId=R.RoleId AND R.UserId=" + userId + @"
  WHERE npc_sys_menu.Id=FunctionId AND A.TargetType='Role' AND A.FunctionType='Menu')
 )";
            return this.Query(whereString, "OrderBy");
        }

    }
}