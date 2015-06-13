using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TattooConsultant.Models;

namespace TattooConsultant.Controllers
{
    public class ChatController : Controller
    {
        //
        // GET: /Chat/

        AccesoriesContext Ac = new AccesoriesContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Chat(string name, string surname, string role)
        {
            List<User> U = new List<User>();
            List<User> U1 = new List<User>();
            List<User> U2 = new List<User>();
            List<User> U3 = new List<User>();

            int a1 = 0, b1 = 0, d1 = 0;
            if (name != "")//заполняем начальный список
            {
                U = Ac.Users.Where(b => b.Name == name).ToList();
            }
            else
            {
                if (surname != "")
                {
                    U = Ac.Users.Where(b => b.Surname == surname).ToList();
                }

                else
                {
                    if (role != "")
                    {
                        U = Ac.Users.Where(b => b.Role == role).ToList();
                    }

                }
            }


            if (name != "" && name != null)
            {
                foreach (var a in U)//проход по листу по имени
                {
                    if (a.Name == name)
                        a1++;
                }
                foreach (var a2 in U)
                {
                    if (a2.Name == name)
                        U1.Add(a2);
                }
            }
            else
                U1 = U;

            if (surname != "" && surname != null)
            {
                foreach (var z in U1)//проход по листу по фамилии
                {
                    if (z.Surname == surname)
                        b1++;
                }
                foreach (var b2 in U1)
                {
                    if (b2.Surname == surname)
                        U2.Add(b2);
                }
            }
            else
                U2 = U1;


            if (role != "" && role != null)
            {
                foreach (var d in U2)//проход по листу по полу
                {
                    if (d.Role == role)
                        d1++;
                }
                foreach (var d2 in U2)
                {
                    if (d2.Role == role)
                        U3.Add(d2);
                }
            }
            else
                U3 = U2;


            @ViewBag.Result = U3;
            return View("Chat");
        }

    }
}
