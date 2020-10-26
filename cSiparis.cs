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
    class cSiparis
    {
        cGenel gnl = new cGenel();

        #region fields
        private int _Id;
        private int _adisyonId;
        private int _urunId;
        private int _adet;
        private int _masaId;
        #endregion

        #region Properties
        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public int AdisyonId
        {
            get
            {
                return _adisyonId;
            }

            set
            {
                _adisyonId = value;
            }
        }

        public int UrunId
        {
            get
            {
                return _urunId;
            }

            set
            {
                _urunId = value;
            }
        }

        public int Adet
        {
            get
            {
                return _adet;
            }

            set
            {
                _adet = value;
            }
        }

        public int MasaId
        {
            get
            {
                return _masaId;
            }

            set
            {
                _masaId = value;
            }
        } 
        #endregion

        public void getByOrder(ListView lv,int AdisyonId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From satislar Inner Join urunler on satislar.URUNID=Urunler.ID Where ADISYONID=@AdisyonId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = AdisyonId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["FIYAT"])* Convert.ToDecimal(dr["ADET"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());

                    sayac++;

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
        }

        public bool setSaveOrder(cSiparis Bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Satislar(ADISYONID,URUNID,ADET,MASAID) values(@AdisyonNo,@UrunId,@Adet,@masaId)",con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@AdisyonNo", SqlDbType.Int).Value = Bilgiler._adisyonId;
                cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = Bilgiler._urunId;
                cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = Bilgiler._adet;
                cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = Bilgiler._masaId;
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

        public void setDeleteOrder(int satisId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete From satislar Where ID=@SatisID", con);

            cmd.Parameters.Add("@SatisID", SqlDbType.Int).Value = satisId;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();

        }
    }
}
