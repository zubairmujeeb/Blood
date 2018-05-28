using bloodsaver.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace bloodsaver.Controllers
{
    [System.Runtime.InteropServices.GuidAttribute("34215C98-6691-4C85-A1E3-3A53736D4C97")]
    public class HomeController : Controller
    {
        //
        // GET: /Home/


        public ActionResult Index()
        {



            connectioncontext k = new connectioncontext();
            ViewBag.country = new SelectList(k.allcountry, "id", "country");
            ViewBag.city = new SelectList(k.allcities, "city", "city");
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult Indexs(registration r) //
        {
            connectioncontext k = new connectioncontext();
            ViewBag.country = new SelectList(k.allcountry, "id", "country");
            ViewBag.city = new SelectList(k.allcities, "city", "city");
            bussinesclass l = new bussinesclass();
            l.create(r);
            return View();
        }

        public string Details(string s)
        {
            //connectioncontext c = new connectioncontext();
            //registration b = c.employess.Single(x => x.email == s);

            //Session["valueofimages"] = b.filenames.ToString();
            //Response.Write(b.filenames);
            return s;
            //Response.Write(Session["valueofimages"]);
            // Response.Write( b.filenames);
            // Response.Write("backend"+ Session["ss"]);

        }


        public ActionResult log()
        {
            //Response.Write(Session["vallllue"]);


            return View();
        }
        [HttpPost]
        public ActionResult log(registration k)
        {


            if (ModelState.IsValid)
            {
                connectioncontext hjx = new connectioncontext();
                var kk = hjx.employess.Where(x => x.email.Equals(k.email) && x.password.Equals(k.password)).FirstOrDefault();

                if (kk != null)
                {
                    Session["io"] = kk.id.ToString();
                    Session["st"] = kk.status.ToString();
                    Session["na"] = kk.name.ToString();

                    Session["em"] = kk.email.ToString();
                    string val = Session["em"].ToString();
                    Session["vallllue"] = kk.filenames.ToString();
                    //if (kk.filenames != null)
                    //{
                    //    Session["vallllue"] = kk.filenames.ToString();

                    //}
                    //else
                    //{
                    //    Session["vallllue"] = null;
                    //}
                    return RedirectToAction("Home");
                }
                else
                {

                    Response.Write("Please enter the Correct Credentionals please");
                }


            }
            return View(k);
        }


        //public ActionResult logout()
        //{
        //    //string path = System.IO.Path.Combine(
        //    //                        Server.MapPath("~/images/profile"), pic);
        //    //// file is uploaded
        //    //file.SaveAs(path);
        //    Session.Remove("na");
        //    Session.Remove("em");
        //    Session.Remove("ff");
        //    Session.Remove("vallllue");
        //    return RedirectToAction("log");
        //}


        public ActionResult Home()
        {
            // Response.Write( Session["vallllue"]);




            //if (Session["em"] != null) { 



            retriving h = new retriving();
            connectioncontext emp = new connectioncontext();

            ViewBag.stid = new SelectList(h.con, "id", "country");
            ViewBag.uid = new SelectList(h.conx, "id", "city");
            HomeViewModel HomeViewModel = new HomeViewModel
            {

                Country = h.con,
                Cities = h.conx,
                registration = emp.employess.ToList()

            };

            return View(HomeViewModel);





        }

        [HttpPost]
        public ActionResult Home(string stid, string uid)  //retriving r  string stid, string uid
        {
            retriving h = new retriving();
            ViewBag.stid = new SelectList(h.con, "id", "country");
            ViewBag.uid = new SelectList(h.conx, "id", "city");
            connectioncontext p = new connectioncontext();




            string hj = "Donner";

            var values = new HomeViewModel
            {
                registration = p.employess
            .Where(x => x.country.Equals(stid) && x.city.Equals(uid) && x.status.Equals(hj))



            };




            return View(values);



        }



        [HttpPost]
        public ActionResult get(int stid)  //retriving r
        {

            connectioncontext hj = new connectioncontext();
            retriving k = new retriving();
            hj.Configuration.ProxyCreationEnabled = false;

            ViewBag.uid = new SelectList(k.conx, "id", "city");

            List<SelectListItem> districtNames = new List<SelectListItem>();

            retriving r = new retriving();

            List<string> o = r.conx.Where(x => x.countryid.Equals(stid)).Select(d => d.city).ToList();

            return Json(r.conx.Where(x => x.countryid.Equals(stid)).Select(d => d.city).ToList(), JsonRequestBehavior.AllowGet);  //r.conx.Where(x => x.countryid == r.stid)

        }
        [HttpGet]
        public ActionResult Message(int id)  //retriving r
        {
            if (Session["em"] != null)
            {

                connectioncontext c = new connectioncontext();

                var MessageHomeView = new MessageHomeViewModel
                {
                    Employes = c.employess.Single(x => x.id == id)
                };

                return View(MessageHomeView);
            }
            else
            {
                return RedirectToAction("popup");
            }
        }
        [HttpPost]
        [ActionName("Message")]
        public ActionResult Messages(MessageHomeViewModel j)  //retriving r
        {
            if (Session["em"] != null)

            {

                registration k = new registration
                {
                    cellno = j.cellno,
                    textarea = j.textarea


                };
                //bussinesclass l = new bussinesclass();
                //l.msginsert(k);

                Response.Write(k.textarea + "cell" + k.cellno);
                return View(j);
            }
            else
            {
                return RedirectToAction("popup");
            }
        }
        [HttpGet]
        public ActionResult mail(int id)  //retriving r
        {

            connectioncontext c = new connectioncontext();

            return View(c.employess.Single(x => x.id == id));

        }
        [HttpPost]
        [ActionName("mail")]
        public ActionResult mail(string from, string email, string subject, string textarea)  //retriving r
        {

            MailMessage x = new MailMessage();
            x.From = new MailAddress("zubairmujeeb387@gmail.com");
            x.To.Add(email);
            x.Subject = "This is testing Email";
            x.Body = textarea;
            SmtpClient smp = new SmtpClient("smtp.gmail.com");
            smp.Port = 587;
            smp.Credentials = new NetworkCredential("zubairmujeeb387@gmail.com", "zubair007");
            smp.EnableSsl = true;
            smp.Send(x);
            Response.Write("mail send");
            Response.Write(email);
            Response.Write(textarea);

            return View();


        }
        public ActionResult popup()
        {

            return View();

        }

        public JsonResult checkemail(string email)
        {
            connectioncontext d = new connectioncontext();
            return Json(!d.employess.Any(x => x.email == email), JsonRequestBehavior.AllowGet);
        }

        public JsonResult checkcnic(string cnic)
        {
            connectioncontext d = new connectioncontext();
            return Json(!d.employess.Any(x => x.cnic == cnic), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Myprofile(int id)
        {
            connectioncontext d = new connectioncontext();
            Response.Write(Session["pathge"]);
            return View(d.employess.Single(x => x.id == id));
        }


        [HttpPost]
        public ActionResult Myprofile(registration k, HttpPostedFileBase filename) //, , HttpPostedFileBase filenames
        {

            if (ModelState.IsValid)
            {


                bussinesclass b = new bussinesclass();

                b.updae(k);

            }
            Myprofilex(filename);
            return View();

        }


        [HttpPost]
        public ActionResult Myprofilex(HttpPostedFileBase filename)
        {
            try
            {


                if (filename.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(filename.FileName).ToString();

                    Session["ff"] = fileName;
                    var path = Path.Combine(Server.MapPath("~/images"), fileName);
                    filename.SaveAs(path);
                    Response.Write("Upload successful");
                }



                return View("Myprofile");

            }
            catch
            {
                ViewBag.Message = "Upload failed";
                return View("Myprofile");
            }


        }



        public string g()
        {
            registration k = new registration();
            Response.Write("va" + k.filenames);

            return "zubair.";

        }






    }
}
