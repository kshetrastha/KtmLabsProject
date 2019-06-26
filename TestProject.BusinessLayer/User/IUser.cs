using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.BusinessEntities;
using TestProject.Model;

namespace TestProject.BusinessLayer.User
{
    public interface IUser
    {
        #region User
        List<SpUserSel_Result> UserList();
        List<SpUserSelById_Result> UserListById(int UserId);
        ReturnMessageModel UserIns(UserModel model);
        ReturnMessageModel UserUpd(UserModel model);
        ReturnMessageModel UserDel(int UserId);
        #endregion

        #region Order
        ReturnMessageModel OrderIns(OrderModel model);
        ReturnMessageModel OrderUpd(OrderModel model);
        ReturnMessageModel OrderDel(int Id);
        List<SpOrderSel_Result> OrderSel();
        List<SpOrderSelbyId_Result> OrderSelById(int id);
        #endregion

        #region dropdownlist 
        List<SpDropDownlistForUsersel_Result> DropDownListforUser();
        #endregion

    }
}
