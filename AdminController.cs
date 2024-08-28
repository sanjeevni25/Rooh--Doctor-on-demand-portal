using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Rooh.Models;


namespace Rooh.Controllers
{
    public class AdminController : Controller
    {



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DashboardAdmin()
        {
            return View();

        }

        public ActionResult Doctor()
        {
            return View();
        }

        public ActionResult UploadDocuments()
        {
            return View();
        }
        public ActionResult Availabledays()
        {
            return View();
        }
        
        public ActionResult CounsellerDashboard()
        {
            return View();
        }

        public ActionResult Counsellor()
        {
            return View();
        }
        
        public JsonResult AdminLogin(string email, string Password)
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.AdminLogin(email, Password);
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }
        
         public JsonResult bind_doctor_Speciality(string email, string Password)
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.bind_doctor_Speciality(email, Password);
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }
        public JsonResult bind_doctor_Qualification()
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.bind_doctor_Qualification();
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }
        
        public JsonResult getstate(int countrycd)
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.getstate(countrycd);
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getcity(int statecd)
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.getcity(statecd);
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }
        public JsonResult getcountry()
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.getcountry();
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }
      
              public JsonResult getPsychiatric_doc()
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.getPsychiatric_doc();
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }
        public JsonResult getPschologist_doc()
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.getPschologist_doc();
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }
       
        
        public string SaveService(string srv_desc,string crtuser)
        {
            DoctorCRUD model2 = new DoctorCRUD();
            string str = model2.SaveService(srv_desc,crtuser);
            return str;
        }
        public JsonResult getService()
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.getService();
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }
        public JsonResult select_sub_service(string serv_code)
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.select_sub_service(serv_code);
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }
        public JsonResult select_doc_link_serv(string serv_code)
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.select_doc_link_serv(serv_code);
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }
        
        public JsonResult getdays(string pl,string pc)
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.getdays(pl,pc);
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }
        
             public JsonResult getdoctor_available_days(string Pschologist_doc)
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.getdoctor_available_days(Pschologist_doc);
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }
        public JsonResult save_Appointment(Int64 Rpt_No, int Country, int State, int City, string pin_cod, string pt_uploadhis, string pt_Symptoms, string pt_anyrelinfo, int serv_code, int sub_serv_code, Int64 Pschologist_doc, Int64 Psychiatric_Doctor, string appoint_date, string ftime, string ttime, Int64 councilorstatus, string councilorMeetid, Int64 termscondition, int crt_id, string crtusr, int act_status,string address)
        {
            DoctorCRUD model2 = new DoctorCRUD();
            DataTable dtlogin = model2.save_Appointment( Rpt_No,  Country,  State,  City,  pin_cod, pt_uploadhis,  pt_Symptoms,pt_anyrelinfo,  serv_code,  sub_serv_code,  Pschologist_doc,  Psychiatric_Doctor,  appoint_date,  ftime,  ttime,  councilorstatus,  councilorMeetid,  termscondition,  crt_id,  crtusr, act_status,address);
            List<Dictionary<string, object>> lstvisitlist = model2.GetTableRows(dtlogin);
            return Json(lstvisitlist, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult UploadLectureMaterial()
        {
            string Result = string.Empty; 
            if (Request.Files.Count > 0)
            {
                try
                {
                    string fname;
                    string lecnature = "";
                    HttpFileCollectionBase files = Request.Files;
                    for (int i = 0; i < files.Count; i++)
                    {
                        //string path = AppDomain.CurrentDomain.BaseDirectory + "Uploads/";  
                        //string filename = Path.GetFileName(Request.Files[i].FileName);  
                        HttpPostedFileBase file = files[i];

                        // Checking for Internet Explorer  
                        if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                        {
                            string[] testfiles = file.FileName.Split(new char[] { '\\' });
                            fname = testfiles[testfiles.Length - 1];
                        }
                        else
                        {
                            fname = file.FileName;
                            lecnature = Path.GetFileName(fname);
                        }
                      
                        string empid = Request.Form["pt_rhid"];

                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), Server.MapPath("~/Content/PatientHistory/"), lecnature);
                        if (System.IO.File.Exists(filePath))
                        {
                            System.IO.File.Delete(filePath);

                            fname = Path.Combine(Server.MapPath("~/Content/PatientHistory/"), fname);
                            file.SaveAs(fname); 
                            Result = "Pass";
                        }
                        else
                        {
                            fname = Path.Combine(Server.MapPath("~/Content/PatientHistory/"), fname);
                            file.SaveAs(fname);
                           
                            Result = "Pass";
                        }
                    }
                    return Json(Result);
                }
                catch (Exception ex)
                {
                    return Json("Error occurred. Error details: " + ex.Message);
                }
            }
            else
            {
                return Json("No files selected.");
            }
        }

    }
}
