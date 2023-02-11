using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BAL;
namespace DAL
{
    public class Interactionmethod
    {
        public void InsertDemoVolunteer(propertiesvol p)
        {
            SqlParameter[] para = new SqlParameter[12];
            para[0] = new SqlParameter("@Mode", "insert");
            para[1] = new SqlParameter("@fname", p.fname);
            para[2] = new SqlParameter("lname", p.lname);
            para[3] = new SqlParameter("gender", p.gender);

            para[4] = new SqlParameter("email", p.email);
            para[5] = new SqlParameter("address", p.address);
            para[6] = new SqlParameter("mobile", p.mobile);
            para[7] = new SqlParameter("password", p.password);
            para[8] = new SqlParameter("edu", p.edu);
            para[9] = new SqlParameter("bdate", p.bdate);
            para[10] = new SqlParameter("created_date", p.created_date);
            para[11] = new SqlParameter("@flag", p.flag);

            dbc obj = new dbc();
            obj.IUD("sp_tblvol", para);
        }
        public DataSet SelectDemovol()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblvol", para);
            return ds;
        }
        public void InsertDemongo(propertiesngo p)
        {
            SqlParameter[] para = new SqlParameter[13];
            para[0] = new SqlParameter("@Mode", "insert");
            para[1] = new SqlParameter("@name", p.name);
            para[2] = new SqlParameter("@email", p.email);
            para[3] = new SqlParameter("@contact", p.contact);
            para[4] = new SqlParameter("@address", p.address);
            para[5] = new SqlParameter("@city", p.city);
            para[6] = new SqlParameter("@pincode", p.pincode);
            para[7] = new SqlParameter("@logo", p.logo);
            para[8] = new SqlParameter("@fb_url", p.fb_url);
            para[9] = new SqlParameter("@google_url", p.google_url);
            para[10] = new SqlParameter("@twitter_url", p.twitter_url);
            para[11] = new SqlParameter("@created_date", p.created_date=DateTime.Now);
            para[12] = new SqlParameter("@flag", p.flag='a');

            dbc obj = new dbc();
            obj.IUD("sp_tblngo", para);

        }

        public void UpdateDemongo(propertiesngo p)
        {
            SqlParameter[] para = new SqlParameter[11];

            para[0] = new SqlParameter("@Mode", "update");
         //  para[1] = new SqlParameter("@id", p.n_id);
            para[1] = new SqlParameter("@name", p.name);
            para[2] = new SqlParameter("@email", p.email);
            para[3] = new SqlParameter("@contact", p.contact);

            para[4] = new SqlParameter("@address", p.address);
            para[5] = new SqlParameter("@city", p.city);
            para[6] = new SqlParameter("@pincode", p.pincode);
            para[7] = new SqlParameter("@logo", p.logo);
          // para[9] = new SqlParameter("@fb_url", p.fb_url);
           // para[10] = new SqlParameter("@google_url", p.google_url);
           // para[11] = new SqlParameter("@twitter_url", p.twitter_url);
            para[8] = new SqlParameter("@flag", p.flag);
            para[9] = new SqlParameter("@created_date", p.created_date);
           // para[15] = new SqlParameter("@updated_date", p.updated_date);

            dbc obj = new dbc();
            obj.IUD("sp_tblngo", para);
        }

        public void DeleteDemongo(propertiesngo p)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Mode", "delete");
            para[1] = new SqlParameter("@id", p.n_id);
            dbc obj = new dbc();
            obj.IUD("sp_tblngo", para);
        }

        public DataSet SelectDemongo()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblngo", para);
            return ds;
        }
        public DataSet SelectDemongoById(propertiesngo p)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Mode", "selectbyId");
            para[1] = new SqlParameter("@id", p.n_id);
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblngo", para);
            return ds;
        }

        public void InsertDemoAlbum(propertiesalbum p)
        {
            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter("@Mode", "insert");
            para[1] = new SqlParameter("@albumId", p.albumId);
            para[2] = new SqlParameter("@title", p.title);
            para[3] = new SqlParameter("@coverphoto", p.coverphoto);
            para[4] = new SqlParameter("@flag", p.flag);
            para[5] = new SqlParameter("@created_date", p.created_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblalbum", para);

        }
        public void UpdateDemoAlbum(propertiesalbum p)
        {
            SqlParameter[] para = new SqlParameter[7];

            para[0] = new SqlParameter("@Mode", "update");
            para[1] = new SqlParameter("@albumId", p.albumId);
            para[2] = new SqlParameter("@title", p.title);
            para[3] = new SqlParameter("@coverphoto", p.coverphoto);
            para[4] = new SqlParameter("@flag", p.flag);
            para[5] = new SqlParameter("@created_date", p.created_date);
            para[6] = new SqlParameter("@updted_date", p.updated_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblalbum", para);
        }
        public void DeleteDemoAlbum(propertiesalbum p)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@Mode", "delete");
            para[1] = new SqlParameter("@albumId", p.albumId);
            dbc obj = new dbc();
            obj.IUD("sp_tblalbum", para);
        }
        public DataSet SelectDemoAlbum()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblalbum", para);
            return ds;
        }
        public void InsertDemorole(propertiesrole p)
        {
            SqlParameter[] para = new SqlParameter[4];

            para[0] = new SqlParameter("@Mode", "insert");
           // para[1] = new SqlParameter("@role_Id", p.role_id);
            para[1] = new SqlParameter("@role_type", p.role_type);
            para[2] = new SqlParameter("@flag", p.flag);
            para[3] = new SqlParameter("@created_date", p.created_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblrole", para);

        }
        public void UpdateDemorole(propertiesrole p)
        {
            SqlParameter[] para = new SqlParameter[5];

            para[0] = new SqlParameter("@Mode", "update");
            para[1] = new SqlParameter("@role_Id", p.role_id);
            para[2] = new SqlParameter("@role_type", p.role_type);
            para[3] = new SqlParameter("@flag", p.flag);
        
            para[4] = new SqlParameter("@updated_date", p.updated_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblrole", para);
        }
        public void DeleteDemorole(propertiesrole p)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@Mode", "delete");
            para[1] = new SqlParameter("@role_Id", p.role_id);
            dbc obj = new dbc();
            obj.IUD("sp_tblrole", para);
        }
        public DataSet SelectDemorole()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblrole", para);
            return ds;
        }
        public DataSet SelectDemorolebyId(propertiesrole p)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "selectbyId");
            para[1] = new SqlParameter("@id", p.role_id);
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblrole", para);
            return ds;
        }
        public void InsertDemophoto(propertiesphoto p)
        {
            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter("@Mode", "insert");
          //  para[1] = new SqlParameter("@photo_ID", p.photo_ID);
            para[1] = new SqlParameter("Album_ID", p.Album_ID);
            para[2] = new SqlParameter("title", p.title);
            para[3] = new SqlParameter("photo_path", p.photo_path);
            para[4] = new SqlParameter("flag", p.flag);
            para[5] = new SqlParameter("created_date", p.created_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblphoto", para);

        }
        public void UpdateDemophoto(propertiesphoto p)
        {
            SqlParameter[] para = new SqlParameter[7];

            para[0] = new SqlParameter("@Mode", "update");
            para[1] = new SqlParameter("@photo_ID", p.photo_ID);
            para[2] = new SqlParameter("@albumId", p.Album_ID);
            para[3] = new SqlParameter("@title", p.title);
            para[4] = new SqlParameter("@phoho_path", p.photo_path);
            para[5] = new SqlParameter("@flag", p.flag);
            
            para[6] = new SqlParameter("@updated_date", p.updated_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblphoto", para);

        }
        public void DeleteDemophoto(propertiesphoto p)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@Mode", "delete");
            para[1] = new SqlParameter("@photo_ID", p.photo_ID);
            dbc obj = new dbc();
            obj.IUD("sp_tblphoto", para);
        }
        public DataSet SelectDemophoto()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblphoto", para);
            return ds;
        }

        public void InsertDemopayment(propertiespayment p)
        {
            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter("@Mode", "insert");
            //  para[1] = new SqlParameter("@trans_id", p.trans_id);
          //  para[1] = new SqlParameter("p_mode", p.p_mode);
            para[1] = new SqlParameter("@status", p.status);
            para[2] = new SqlParameter("@amt", p.amt);
            para[3] = new SqlParameter("@user_id", p.user_id);
            para[4] = new SqlParameter("@flag", p.flag);
            para[5] = new SqlParameter("@created_date", p.created_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblpayment1", para);

        }
        public void UpdateDemopayment(propertiespayment p)
        {
            SqlParameter[] para = new SqlParameter[7];

            para[0] = new SqlParameter("@Mode", "update");
            para[1] = new SqlParameter("@trans_id", p.trans_id);
            para[2] = new SqlParameter("p_mode", p.p_mode);
            para[3] = new SqlParameter("@status", p.status);
            para[4] = new SqlParameter("@user_id", p.user_id);
            para[5] = new SqlParameter("@flag", p.flag);
           // para[6] = new SqlParameter("@created_date", p.created_date);
            para[6] = new SqlParameter("@updated_date", p.updated_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblpayment1", para);
        }
        public void DeleteDemopayment(propertiespayment p)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@Mode", "update");
            para[1] = new SqlParameter("@trans_id", p.trans_id);
            dbc obj = new dbc();
            obj.IUD("sp_tblpayment1", para);
        }
        public DataSet SelectDemopayment()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblpayment1", para);
            return ds;
        }

        public void InsertDemouser(propertiesuser p)
        {
            SqlParameter[] para = new SqlParameter[12];

            para[0] = new SqlParameter("@Mode", "insert");
          //  para[1] = new SqlParameter("@user_id", p.user_id);
            para[1] = new SqlParameter("role_id", p.role_id);
            para[2] = new SqlParameter("fname", p.fname);
            para[3] = new SqlParameter("lname", p.lname);
            para[4] = new SqlParameter("gender", p.gender);
            para[5] = new SqlParameter("email", p.email);
            para[6] = new SqlParameter("address", p.adress);
            para[7] = new SqlParameter("mobile", p.mobile);
            para[8] = new SqlParameter("password", p.password);
            //para[9] = new SqlParameter("@profile_photo", p.profile_photo);
            para[9] = new SqlParameter("birthdate", p.birthdate);
            para[10] = new SqlParameter("flag", p.flag);
            para[11] = new SqlParameter("@created_date", p.created_date);
            dbc obj = new dbc();
            obj.IUD("sp_tbluser", para);

        }
        public void UpdateDemouser(propertiesuser p)
        {
            SqlParameter[] para = new SqlParameter[14];

            para[0] = new SqlParameter("@Mode", "update");
           para[1] = new SqlParameter("@user_id", p.user_id);
            para[2] = new SqlParameter("@role_id", p.role_id);
            para[3] = new SqlParameter("@fname", p.fname);
            para[4] = new SqlParameter("@lname", p.lname);
            para[5] = new SqlParameter("@gender", p.gender);
            para[6] = new SqlParameter("@email", p.email);
            para[7] = new SqlParameter("@address", p.adress);
            para[8] = new SqlParameter("@mobile", p.mobile);
            para[9] = new SqlParameter("@password", p.password);
            para[10] = new SqlParameter("@profile_photo", p.profile_photo);
            para[11] = new SqlParameter("@birthdate", p.birthdate);
            para[12] = new SqlParameter("@flag", p.flag);
            //para[13] = new SqlParameter("@created_date", p.created_date);
            para[13] = new SqlParameter("@updated_date", p.updated_date);
            dbc obj = new dbc();
            obj.IUD("sp_tbluser", para);

        }
        public void DeleteDemouser(propertiesuser p)
        {
            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter("@Mode", "delete");
            para[1] = new SqlParameter("@user_id", p.user_id);
            dbc obj = new dbc();
            obj.IUD("sp_tbluser", para);
        }
        public DataSet SelectDemouser()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tbluser", para);
            return ds;
        }
        public DataSet SelectDemobyIdUser(propertiesuser p)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Mode", "select by Id");
            para[1] = new SqlParameter("@user_id", p.user_id);
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("SP_tbluser", para);
            return ds;
        }
        public DataSet SelectDemoLogin(propertiesuser p)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@Mode", "cmp");
            para[1] = new SqlParameter("@email", p.email);
            para[2] = new SqlParameter("password", p.password);
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds =obj.GetData("SP_tbluser", para);
            return ds;
        }

        public void InsertDemoevent(propertiesevent p)
        {
            SqlParameter[] para = new SqlParameter[8];

            para[0] = new SqlParameter("@Mode", "insert");
            // para[1] = new SqlParameter("@Ev_id", p.ev_id);
            para[1] = new SqlParameter("@ev_name", p.ev_name);
            para[2] = new SqlParameter("@ev_date", p.ev_date);
            para[3] = new SqlParameter("@place", p.place);
            para[4] = new SqlParameter("@photo_path", p.photo_path);
            para[5] = new SqlParameter("@descript", p.descript);
          
            para[6] = new SqlParameter("@flag", p.flag);
            para[7] = new SqlParameter("@created_date", p.created_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblevent", para);
        }
        public void UpdateDemoevent(propertiesevent p)
        {
            SqlParameter[] para = new SqlParameter[9];

            para[0] = new SqlParameter("@Mode", "update");
            para[1] = new SqlParameter("@Ev_ID", p.Ev_ID);
            para[2] = new SqlParameter("@ev_name", p.ev_name);
            para[3] = new SqlParameter("@ev_date", p.ev_date);
            para[4] = new SqlParameter("@place", p.place);
            para[5] = new SqlParameter("@photo_path", p.photo_path);
            para[6] = new SqlParameter("@descript", p.descript);
           
            para[7] = new SqlParameter("@flag", p.flag);
          //  para[7] = new SqlParameter("@created_date", p.created_date);
            para[8] = new SqlParameter("@updated_date", p.updated_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblevent", para);
        }
        public void DeleteDemoevent(propertiesevent p)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Mode", "delete");
            para[1] = new SqlParameter("@Ev_ID", p.Ev_ID);
            dbc obj = new dbc();
            obj.IUD("sp_tblevent", para);
        }
        public DataSet SelectDemoevent()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblevent", para);
            return ds;
        }
        public DataSet SelectDemobyIdevent(propertiesevent p)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[1] = new SqlParameter("@Ev_ID", p.Ev_ID);
            para[0] = new SqlParameter("@Mode", "select by id");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblevent", para);
            return ds;
        }

        public void InsertDemoadmin(propertiesadmin p)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@Mode", "insert");
            // para[1] = new SqlParameter("@Ev_id", p.ev_id);
            //   para[1] = new SqlParameter("@id", p.id);
            para[1] = new SqlParameter("@email", p.email);
            para[2] = new SqlParameter("@password", p.password);
            para[3] = new SqlParameter("@flag", p.flag);
            para[4] = new SqlParameter("@created_date", p.created_date);
            dbc obj = new dbc();
            obj.IUD("sp_tbladmin", para);

        }
        public void UpdateDemoadmin(propertiesadmin p)
        {
            SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@Mode", "update");
            // para[1] = new SqlParameter("@Ev_id", p.ev_id);
            para[1] = new SqlParameter("@id", p.id);
            para[2] = new SqlParameter("@email", p.email);
            para[3] = new SqlParameter("@password", p.password);
            para[4] = new SqlParameter("@flag", p.flag);
            //para[5] = new SqlParameter("@created_date", p.created_date.ToString("mm/dd/yyyy"));
            para[5] = new SqlParameter("@updated_date", p.updated_date.ToString("mm/dd/yyyy"));
            dbc obj = new dbc();
            obj.IUD("sp_tbladmin", para);

        }
        public void DeleteDemoadmin(propertiesadmin p)
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@Mode", "delete");
            para[1] = new SqlParameter("@id", p.id);
            dbc obj = new dbc();
            obj.IUD("sp_tbladmin", para);
        }
        public DataSet SelectDemoadmin()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tbladmin", para);
            return ds;

        }
        public DataSet SelectDemobyIdadmin(propertiesadmin p)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select by Id");
            para[1] = new SqlParameter("@id", p.id);
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tbladmin", para);
            return ds;

        }
        public DataSet SelectDemoAdminLogin(propertiesadmin p)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@Mode", "cmp");
            para[1] = new SqlParameter("@email", p.email);
            para[2] = new SqlParameter("@password", p.password);
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tbladmin", para);
            return ds;

        }
       
        public void DeleteDemoReport(propertiesreport p)
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@Mode", "delete");
            para[1] = new SqlParameter("@id", p.r_id);
            dbc obj = new dbc();
            obj.IUD("sp_tblreport", para);
        }
        public DataSet SelectDemoReport()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            DataSet ds = new DataSet();
            dbc obj = new dbc();
            ds = obj.GetData("sp_tblreports", para);
            return ds;

        }

        public void InsertDemoteam(propertiesteam p)
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@Mode", "insert");
          //  para[1] = new SqlParameter("@id", p.id);
            para[1] = new SqlParameter("profile_photo", p.profile_photo);
            para[2] = new SqlParameter("fname", p.fname);
            para[3] = new SqlParameter("lname", p.lname);
            para[4]= new SqlParameter("post", p.post);
            para[5] = new SqlParameter("role_type", p.role_type);
            para[6] = new SqlParameter("about", p.about);
            para[7] = new SqlParameter("mobile", p.mobile);
            para[8] = new SqlParameter("flag", p.flag);
            para[9] = new SqlParameter("created_date", p.created_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblteam", para);
        }

        public void UpdateDemoteam(propertiesteam p)
        {
            SqlParameter[] para = new SqlParameter[11];
            para[0] = new SqlParameter("@Mode", "update");
            para[1] = new SqlParameter("@id", p.id);
            para[2] = new SqlParameter("@profile_photo", p.profile_photo);
            para[3] = new SqlParameter("@fname", p.fname);
            para[4] = new SqlParameter("@lname", p.lname);
            para[5] = new SqlParameter("@post", p.post);
            para[6] = new SqlParameter("@role_type", p.role_type);
          para[7] = new SqlParameter("@about", p.about);
          
            para[8] = new SqlParameter("@mobile", p.mobile);
            para[9] = new SqlParameter("@flag", p.flag);
            para[10] = new SqlParameter("@updated_date", p.updated_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblteam", para);

        }
        public DataSet SelectDemoteam()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblteam", para);
            return ds;
        }
        public void DeleteDemoteam(propertiesteam p)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Mode", "delete");
            para[1] = new SqlParameter("id", p.id);
            dbc obj = new dbc();
            obj.IUD("sp_tblteam", para);
        }
        public DataSet SelectDemobyIdteam(propertiesteam p)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Mode", "selectbyid");
            para[1] = new SqlParameter("@id", p.id);
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblteam", para);
            return ds;
        }

        public void InsertDemofeedback(propertiesfeedback p)
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@Mode", "insert");
          //  para[1] = new SqlParameter("@fb_id", p.fb_id);
            para[1] = new SqlParameter("@user_name", p.user_name);
            para[2] = new SqlParameter("@email", p.email);
            para[3] = new SqlParameter("@subject", p.subject);
            para[4] = new SqlParameter("@msg", p.msg);
            para[5] = new SqlParameter("@flag", p.flag);
            para[6] = new SqlParameter("@created_date", p.created_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblfeedback", para);

        }
        public void UpdateDemofeedback(propertiesfeedback p)
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@Mode", "update");
            para[1] = new SqlParameter("@fb_id", p.fb_id);
            para[2] = new SqlParameter("@user_name", p.user_name);
            para[3] = new SqlParameter("@email", p.email);
            para[4] = new SqlParameter("@subject", p.subject);
            para[5] = new SqlParameter("@msg", p.msg);
            para[6] = new SqlParameter("@flag", p.flag);
            para[7] = new SqlParameter("@updated_date", p.updated_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblfeedback", para);

        }
        public void DeleteDemofeedback(propertiesfeedback p)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Mode", "delete");
            para[1] = new SqlParameter("@fb_id", p.fb_id);
            dbc obj = new dbc();
            obj.IUD("sp_tblfeedback", para);
        }
        public DataSet SelectDemofeedback()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblfeedback", para);
            return ds;
        }
        public DataSet SelectDemobyIdfeedback(propertiesfeedback p)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Mode", "selectbyId");
            para[1] = new SqlParameter("@fb_id", p.fb_id);
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblfeedback", para);
            return ds;
        }
        public void InsertDemofaq(propertiesfaq p)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@Mode", "insert");
            // para[1] = new SqlParameter("@Ev_id", p.ev_id);
            //   para[1] = new SqlParameter("@id", p.id);
            para[1] = new SqlParameter("@question", p.question);
            para[2] = new SqlParameter("@answer", p.answer);
            para[3] = new SqlParameter("@flag", p.flag);
            para[4] = new SqlParameter("@created_date", p.created_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblfaq", para);

        }
        public void UpdateDemofaq(propertiesfaq p)
        {
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@Mode", "update");
            para[1] = new SqlParameter("@faq_id", p.faq_id);
            para[2] = new SqlParameter("@question", p.question);
            para[3] = new SqlParameter("@answer", p.answer);
            para[4] = new SqlParameter("@flag", p.flag);
            para[5] = new SqlParameter("@created_date", p.created_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblfaq", para);

        }
        public void DeleteDemofaq(propertiesfaq p)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Mode", "delete");
            para[1] = new SqlParameter("@faq_id", p.faq_id);
            dbc obj = new dbc();
            obj.IUD("sp_tblfaq", para);
        }
        public DataSet SelectDemofaq()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblfaq", para);
            return ds;
        }
        public DataSet SelectDemobyIdfaq(propertiesfaq p)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Mode", "select by Id");
            para[1] = new SqlParameter("@faq_id", p.faq_id);
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblfaq", para);
            return ds;
        }

        public void InsertDemoforgot(propertiesforgot p)
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@Mode", "insert");
            //  para[1] = new SqlParameter("@fb_id", p.fb_id);
            para[1] = new SqlParameter("@user_id", p.user_id);
            para[2] = new SqlParameter("@email", p.email);
            para[3] = new SqlParameter("@token", p.token);
            para[4] = new SqlParameter("@exp_date", p.expire_date);
            para[5] = new SqlParameter("@n_pswd", p.n_pswd);
            para[6] = new SqlParameter("@flag", p.flag);
            para[7] = new SqlParameter("@created_date", p.created_date);
            dbc obj = new dbc();
            obj.IUD("sp_tblforgot", para);

        }
       
        public DataSet SelectDemoforgot()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Mode", "select");
            dbc obj = new dbc();
            DataSet ds = new DataSet();
            ds = obj.GetData("sp_tblforgot", para);
            return ds;
        }
        public string SelectDemobyIdforgot(propertiesadmin p)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Mode", "selectbyIDadmin");
            para[1] = new SqlParameter("@Email", p.email);
            dbc obj = new dbc();
            DataSet ds = new DataSet();
              ds=  obj.GetData("sp_tbladmin", para);
           string psw = (ds.Tables[0].Rows[0]["password"].ToString());
            return psw;
        }

    }
}