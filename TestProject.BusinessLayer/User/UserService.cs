using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.BusinessEntities;
using TestProject.Model;

namespace TestProject.BusinessLayer.User
{
    public class UserService : IUser
    {

        #region Users
        public ReturnMessageModel UserDel(int UserId)
        {
            ReturnMessageModel result = new ReturnMessageModel();
            ObjectParameter returnMessaage = new ObjectParameter("ReturnMessage", typeof(String));
            using (TestDBEntities db = new TestDBEntities())
            {
                db.SpUserDel(UserId, returnMessaage);
                result.ReturnMessage = returnMessaage.Value.ToString();
                return result;
            }
        }

        public ReturnMessageModel UserIns(UserModel model)
        {
            ReturnMessageModel result = new ReturnMessageModel();
            ObjectParameter returnMessaage = new ObjectParameter("ReturnMessage", typeof(String));
            using (TestDBEntities db = new TestDBEntities())
            {
                db.SpUserIns(model.UserName, returnMessaage);
                result.ReturnMessage = returnMessaage.Value.ToString();
                return result;
            }
        }

        public List<SpUserSel_Result> UserList()
        {
            List<SpUserSel_Result> UserList = new List<SpUserSel_Result>();
            using (TestDBEntities db = new TestDBEntities())
            {
                UserList = db.SpUserSel().ToList();
            }
            return UserList;

        }

        public List<SpUserSelById_Result> UserListById(int UserId)
        {
            List<SpUserSelById_Result> userlist = new List<SpUserSelById_Result>();
            using (TestDBEntities db = new TestDBEntities())
            {
                userlist = db.SpUserSelById(UserId).ToList();
            }
            return userlist;
        }

        public ReturnMessageModel UserUpd(UserModel model)
        {
            ReturnMessageModel result = new ReturnMessageModel();
            ObjectParameter returnMessage = new ObjectParameter("ReturnMessage", typeof(String));
            using (TestDBEntities db = new TestDBEntities())
            {
                db.SpUserUpd(model.Id, model.UserName, returnMessage);
                result.ReturnMessage = returnMessage.Value.ToString();
            }
            return result;
        }
        #endregion

        #region Orders
        public ReturnMessageModel OrderDel(int Id)
        {
            ReturnMessageModel result = new ReturnMessageModel();
            ObjectParameter returnMessage = new ObjectParameter("ReturnMessage", typeof(String));
            using (TestDBEntities db = new TestDBEntities())
            {
                db.SpOrderDel(Id, returnMessage);
                result.ReturnMessage = returnMessage.Value.ToString();
                return result;
            }
        }

        public ReturnMessageModel OrderIns(OrderModel model)
        {
            ReturnMessageModel result = new ReturnMessageModel();
            ObjectParameter returnMessage = new ObjectParameter("ReturnMessage", typeof(String));
            using (TestDBEntities db = new TestDBEntities())
            {
                db.SpOrderIns(model.UserId, model.SupplyName, model.UnitCost, model.UnitPrice, model.Markup, model.Qty, model.TotalPrice, returnMessage);
                result.ReturnMessage = returnMessage.Value.ToString();
                return result;
            }
        }

        public List<SpOrderSel_Result> OrderSel()
        {
            List<SpOrderSel_Result> orderlst = new List<SpOrderSel_Result>();
            using (TestDBEntities db = new TestDBEntities())
            {
                orderlst = db.SpOrderSel().ToList();
                return orderlst;
            }
        }

        public List<SpOrderSelbyId_Result> OrderSelById(int id)
        {
            List<SpOrderSelbyId_Result> Orderlst = new List<SpOrderSelbyId_Result>();
            using (TestDBEntities db = new TestDBEntities())
            {
                Orderlst = db.SpOrderSelbyId(id).ToList();
                return Orderlst;
            }
        }

        public ReturnMessageModel OrderUpd(OrderModel model)
        {
            ReturnMessageModel result = new ReturnMessageModel();
            ObjectParameter returnMessage = new ObjectParameter("ReturnMessage", typeof(String));
            using (TestDBEntities db = new TestDBEntities())
            {
                db.SpOrderUpd(model.Id, model.UserId, model.SupplyName, model.UnitCost, model.UnitPrice, model.Markup, model.Qty, model.TotalPrice, returnMessage);
                result.ReturnMessage = returnMessage.Value.ToString();
                return result;
            }
        }


        #endregion

        #region DropDownList
        public List<SpDropDownlistForUsersel_Result> DropDownListforUser()
        {
            List<SpDropDownlistForUsersel_Result> userlist = new List<SpDropDownlistForUsersel_Result>();
            using (TestDBEntities db = new TestDBEntities())
            {
                userlist = db.SpDropDownlistForUsersel().ToList();
                return userlist;

            }


        }
        #endregion
    }
}
