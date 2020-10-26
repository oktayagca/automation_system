using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal_Resteurant_Oto
{
    class cMasa
    {

        #region Fields
        private int _ID;
        private int _KAPASİTE;
        private int _SERVİSTURU;
        private int _DURUM;
        private int _ONAY;
        #endregion


        #region Properties
        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public int KAPASİTE
        {
            get
            {
                return _KAPASİTE;
            }

            set
            {
                _KAPASİTE = value;
            }
        }

        public int SERVİSTURU
        {
            get
            {
                return _SERVİSTURU;
            }

            set
            {
                _SERVİSTURU = value;
            }
        }

        public int DURUM
        {
            get
            {
                return _DURUM;
            }

            set
            {
                _DURUM = value;
            }
        }

        public int ONAY
        {
            get
            {
                return _ONAY;
            }

            set
            {
                _ONAY = value;
            }
        }
        #endregion

        cGenel gnl = new cGenel();
        public string SessionSum(int state, string masaId)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select TARIH, MasaId From adisyonlar Right Join Masalar on adisyonlar.MasaId= Masalar. ID Where Masalar. DURUM=@durum and adisyonlar.Durum=0 and masalar.ID=masaId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = Convert.ToInt32(masaId);

            try
            {
                if(con.State== ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    dt = Convert.ToDateTime(dr["TARIH"]).ToString();
            
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;

        }

        public int TableGetByNumber(string TableValue)
        {
            string aa = TableValue;
            int length = aa.Length;
            return Convert.ToInt32(aa.Substring(length - 1, 1));
        }

        public bool TableGetByState(int ButtonName, int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select DURUM From masalar Where Id =@TableId and DURUM =@state",con);
            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                result = Convert.ToBoolean(cmd.ExecuteScalar());


            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            finally
            {
                con.Dispose();
                con.Close();
            }

            return result;
        }

        public void setChangeTableState(string ButtonName, int state)
        {


            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update masalar Set DURUM = @Durum where ID=@MasaNo", con);

            if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            string aa = ButtonName;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
            
        }
    }
}
