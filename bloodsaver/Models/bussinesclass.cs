using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace bloodsaver.Models
{
    public class bussinesclass
    {
        public void create(registration k)
        {

            string connection = ConfigurationManager.ConnectionStrings["connectioncontext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {

                SqlCommand cmd = new SqlCommand("reg", con);
                
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter namep = new SqlParameter();
                namep.ParameterName = "@name";
                namep.Value = k.name;
                cmd.Parameters.Add(namep);

                SqlParameter cnicp = new SqlParameter();
                cnicp.ParameterName = "@cnic";
                cnicp.Value = k.cnic;
                cmd.Parameters.Add(cnicp);

                SqlParameter emailp = new SqlParameter();
                emailp.ParameterName = "@email";
                emailp.Value = k.email;
                cmd.Parameters.Add(emailp);

                SqlParameter passwordp = new SqlParameter();
                passwordp.ParameterName = "@password";
                passwordp.Value = k.password;
                cmd.Parameters.Add(passwordp);

                SqlParameter genderp = new SqlParameter();
                genderp.ParameterName = "@gender";
                genderp.Value = k.gender;
                cmd.Parameters.Add(genderp);

                SqlParameter statusp = new SqlParameter();
                statusp.ParameterName = "@status";
                statusp.Value = k.status;
                cmd.Parameters.Add(statusp);


                SqlParameter bloodgroupp = new SqlParameter();
                bloodgroupp.ParameterName = "@bloodgroup";
                bloodgroupp.Value = k.bloodgroup;
                cmd.Parameters.Add(bloodgroupp);

                SqlParameter cellnop = new SqlParameter();
                cellnop.ParameterName = "@cellno";
                cellnop.Value = k.cellno;
                cmd.Parameters.Add(cellnop);


                SqlParameter statuscellp = new SqlParameter();
                statuscellp.ParameterName = "@statuscell";
                statuscellp.Value = k.statuscell;
                cmd.Parameters.Add(statuscellp);


                SqlParameter statuscellpx = new SqlParameter();
                statuscellpx.ParameterName = "@country";
                statuscellpx.Value = k.country;
                cmd.Parameters.Add(statuscellpx);

                SqlParameter statuscellps = new SqlParameter();
                statuscellps.ParameterName = "@city";
                statuscellps.Value = k.city;
                cmd.Parameters.Add(statuscellps);



                con.Open();
                cmd.ExecuteNonQuery();
            }

        }
        public void msginsert(registration j)
        {
            registration k = new registration();

            string connection = ConfigurationManager.ConnectionStrings["connectioncontext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {

                SqlCommand cmd = new SqlCommand("msgwala", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter namep = new SqlParameter();
                namep.ParameterName = "@cellno";
                namep.Value = j.cellno;
                cmd.Parameters.Add(namep);

                SqlParameter cnicp = new SqlParameter();
                cnicp.ParameterName = "@textarea";
                cnicp.Value = j.textarea;
                cmd.Parameters.Add(cnicp);

              

                con.Open();
                cmd.ExecuteNonQuery();
            }

        }

        public void updae(registration h)
        {
            //registration k = new registration();

            string connection = ConfigurationManager.ConnectionStrings["connectioncontext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {

                SqlCommand cmd = new SqlCommand("updates", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter namep = new SqlParameter();
                namep.ParameterName = "@name";
                namep.Value = h.name;
                cmd.Parameters.Add(namep);

               

                SqlParameter pas = new SqlParameter();
                pas.ParameterName = "@password";
                pas.Value = h.password;
                cmd.Parameters.Add(pas);

                SqlParameter fi = new SqlParameter();
                fi.ParameterName = "@filenames";
                fi.Value = h.filenames;
                cmd.Parameters.Add(fi);

                SqlParameter emailp = new SqlParameter();
                emailp.ParameterName = "@email";
                emailp.Value = h.email;
                cmd.Parameters.Add(emailp);

               



                con.Open();
                cmd.ExecuteNonQuery();
            }

        }


        



        //public void updaetfile(string f, string email)
        //{
        //    registration h = new registration();

        //    string connection = ConfigurationManager.ConnectionStrings["connectioncontext"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(connection))
        //    {

        //        SqlCommand cmd = new SqlCommand("fileu", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlParameter namep = new SqlParameter();
        //        namep.ParameterName = "@filenames";
        //        namep.Value = h.filenames;
        //        cmd.Parameters.Add(namep);



        //        SqlParameter emailp = new SqlParameter();
        //        emailp.ParameterName = "@email";
        //        emailp.Value = h.email;
        //        cmd.Parameters.Add(emailp);





        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //    }

        //}






      

      

    }
}