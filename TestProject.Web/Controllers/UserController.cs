using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject.BusinessEntities;
using TestProject.BusinessLayer.User;
using TestProject.Model;

namespace TestProject.Web.Controllers
{
    public class UserController : Controller
    {
        private IUser _ius;

        public UserController()
        {
            _ius = new UserService();
        }

        #region Users
        public JsonResult UserList()
        {
            var lstUser = _ius.UserList().ToList();
            return Json(lstUser, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(UserModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                    return Json(_ius.UserUpd(model), JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(_ius.UserIns(model), JsonRequestBehavior.AllowGet);
                }
            }
            return View(model);
        }

        public ActionResult GetUserbyUserId(int id)
        {
            var lstUser = _ius.UserListById(id);
            return Json(lstUser, JsonRequestBehavior.AllowGet);
        }


        public ActionResult DeleteUser(int id)
        {
            return Json(_ius.UserDel(id), JsonRequestBehavior.AllowGet);
        }

        #endregion


        #region Orders

        public JsonResult OrderList()
        {
            var list = _ius.OrderSel().ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreateOrder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateOrder(OrderModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                    return Json(_ius.OrderUpd(model));
                }
                else
                {
                    return Json(_ius.OrderIns(model), JsonRequestBehavior.AllowGet);
                }

            }
            return View(model);
        }
        public ActionResult GetOrderbyOrderrId(int id)
        {
            var ListOrder = _ius.OrderSelById(id);
            return Json(ListOrder, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteOrder(int Id)
        {
            return Json(_ius.OrderDel(Id), JsonRequestBehavior.AllowGet);
        }


        #endregion


        public ActionResult DropDownlistUser()
        {
            return Json(_ius.DropDownListforUser().ToList(), JsonRequestBehavior.AllowGet);
        }

    }
}