using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Royal_Resteurant_Oto
{
    class cPEersonelGorev
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _PersonelGorevId;
        private string _Tanim;
        #endregion

        #region Properties
        public int PersonelGorevId
        {
            get
            {
                return _PersonelGorevId;
            }

            set
            {
                _PersonelGorevId = value;
            }
        } 
        #endregion

        public void PersonelGorevGetir(ComboBox cb)
        {
            cb.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from personelGorevleri", con);

            SqlDataReader dr = null;

            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cPEersonelGorev c = new cPEersonelGorev();
                    c._PersonelGorevId = Convert.ToInt32(dr["ID"].ToString());
                    c._Tanim = dr["GOREV"].ToString();
                    cb.Items.Add(c);

                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            dr.Close();
            con.Close();
        }

        public string PersonelGorevTanim(int per)
        {
            string sonuc="" ;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select GOREV from personelGorevleri where ID=@perId", con);

            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = per;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                sonuc = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            con.Close();

            return sonuc;
        }

        public override string ToString()
        {
            return _Tanim;
        }
    }
}
