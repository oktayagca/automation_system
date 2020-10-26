using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal_Resteurant_Oto
{
    class cAdisyon
    {
        cGenel gnl = new cGenel();

        #region fields
        private int _ID;
        private int _ServisTuru;
        private decimal _Tutar;
        private DateTime _Tarih;
        private int _PersonelId;
        private int _Durum;
        private int _MasaId;
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

        public int ServisTuru
        {
            get
            {
                return _ServisTuru;
            }

            set
            {
                _ServisTuru = value;
            }
        }

        public decimal Tutar
        {
            get
            {
                return _Tutar;
            }

            set
            {
                _Tutar = value;
            }
        }

        public DateTime Tarih
        {
            get
            {
                return _Tarih;
            }

            set
            {
                _Tarih = value;
            }
        }

        public int PersonelId
        {
            get
            {
                return _PersonelId;
            }

            set
            {
                _PersonelId = value;
            }
        }

        public int Durum
        {
            get
            {
                return _Durum;
            }

            set
            {
                _Durum = value;
            }
        }

        public int MasaId
        {
            get
            {
                return _MasaId;
            }

            set
            {
                _MasaId = value;
            }
        } 
        #endregion

        public int getByAddition(int MasaId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID From Adisyonlar Where MASAID = @MasaId Order by ID desc",con);
            cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = MasaId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MasaId = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            finally
            {
                con.Close();
            }

            return MasaId;
        }
        public bool setByAdditionNew(cAdisyon Bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into adisyonlar(SERVISTURNO,TARIH,PERSONELID,MASAID,DURUM) values(@ServisTurNO,@Tarih,@PersonelId,@MasaId,@Durum)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = Bilgiler._ServisTuru;
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Bilgiler._Tarih;
                cmd.Parameters.Add("@PersonelId", SqlDbType.Int).Value = Bilgiler._PersonelId;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = Bilgiler._MasaId;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = 0;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());

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
            return sonuc;

        }

        public void adisyonKapat(int adisyonId,int durum)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update adisyonlar set durum = @durum where ID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }

                cmd.Parameters.Add("adisyonId", SqlDbType.Int).Value = adisyonId;
                cmd.Parameters.Add("durum", SqlDbType.Int).Value = durum;
                cmd.ExecuteNonQuery();

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

        }
    }
}
