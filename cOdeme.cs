using System;
using System.Data;
using System.Data.SqlClient;

namespace Royal_Resteurant_Oto
{
    class cOdeme
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _OdemeId;
        private int _AdisyonId;
        private int _OdemeTurId;
        private decimal _AraToplam;
        private decimal _Indirim;
        private decimal _Kdvtutari;
        private decimal _GenelToplam;
        private DateTime _Tarih;
        private int _MusteriId;
        #endregion

        #region Properties
        public int OdemeId
        {
            get
            {
                return _OdemeId;
            }

            set
            {
                _OdemeId = value;
            }
        }

        public int AdisyonId
        {
            get
            {
                return _AdisyonId;
            }

            set
            {
                _AdisyonId = value;
            }
        }

        public int OdemeTurId
        {
            get
            {
                return _OdemeTurId;
            }

            set
            {
                _OdemeTurId = value;
            }
        }

        public decimal AraToplam
        {
            get
            {
                return _AraToplam;
            }

            set
            {
                _AraToplam = value;
            }
        }

        public decimal Indirim
        {
            get
            {
                return _Indirim;
            }

            set
            {
                _Indirim = value;
            }
        }

        public decimal Kdvtutari
        {
            get
            {
                return _Kdvtutari;
            }

            set
            {
                _Kdvtutari = value;
            }
        }

        public decimal GenelToplam
        {
            get
            {
                return _GenelToplam;
            }

            set
            {
                _GenelToplam = value;
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

        public int MusteriId
        {
            get
            {
                return _MusteriId;
            }

            set
            {
                _MusteriId = value;
            }
        } 
        #endregion
        //Müsteri masa hesabını kapatıyoruz.
        public bool billClose(cOdeme bill)
        {
            
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into hesapOdemeleri(ADISYONID,ODEMETURID,MUSTERIID,ARATOPLAM,KDVTUTARI,TOPLAMTUTAR,INDIRIM) values (@ADISYONID,@ODEMETURID, @MUSTERIID,@ARATOPLAM,@KDVTUTARI,@TOPLAMTUTAR,@INDIRIM)", con);
            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("ADISYONID", SqlDbType.Int).Value = bill._AdisyonId;
                cmd.Parameters.Add("ODEMETURID", SqlDbType.Int).Value = bill._OdemeTurId;
                cmd.Parameters.Add("MUSTERIID", SqlDbType.Int).Value = bill._MusteriId;
                cmd.Parameters.Add("ARATOPLAM", SqlDbType.Money).Value = bill._AraToplam;
                cmd.Parameters.Add("KDVTUTARI", SqlDbType.Money).Value = bill._Kdvtutari;
                cmd.Parameters.Add("INDIRIM", SqlDbType.Money).Value = bill._Indirim;
                cmd.Parameters.Add("TOPLAMTUTAR", SqlDbType.Money).Value = bill._GenelToplam;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());


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
        //Müsteri toplam harcamasını buluyoruz
        public decimal sumtTotalForClientId(int clientId)
        {

            decimal total = 0;

            SqlConnection con = new SqlConnection(gnl.conString);

            SqlCommand cmd = new SqlCommand("Selecet sum(TOPLAMTUTAR) as total form hesapOdemeleri Where MUSTERIID=@clientId", con);

            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("clientId", SqlDbType.Int).Value = clientId;
                total = Convert.ToDecimal(cmd.ExecuteScalar());
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
            

            return total;

        }
    }
}
