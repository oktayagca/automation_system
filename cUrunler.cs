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
    class cUrunler
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _urunId;
        private int _urunTurNo;
        private string _urunAd;
        private decimal _fiyat;
        private string _acıklama;

        #endregion
        #region Properties
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

        public int UrunTurNo
        {
            get
            {
                return _urunTurNo;
            }

            set
            {
                _urunTurNo = value;
            }
        }

        public string UrunAd
        {
            get
            {
                return _urunAd;
            }

            set
            {
                _urunAd = value;
            }
        }

        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            }

            set
            {
                _fiyat = value;
            }
        }

        public string Acıklama
        {
            get
            {
                return _acıklama;
            }

            set
            {
                _acıklama = value;
            }
        } 
        #endregion

        public void urunleriListeleByurunAdı(ListView lv, string urunAdı)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from urunler where DURUM=0 and URUNADI like '&' +@urunAdı+ '%'", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("urunAdı", SqlDbType.VarChar).Value   = urunAdı;

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
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
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
                con.Dispose();
                con.Close();
            }

        }

        public int urunEkle(cUrunler u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into urunler(URUNAD,KATEGORIID,ACIKLAMA,FIYAT) values(@urunAd,@katId,@acıklama,@fiyat)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@urunAd", SqlDbType.VarChar).Value = u._urunAd;
                cmd.Parameters.Add("@katId", SqlDbType.Int).Value = u._urunTurNo;
                cmd.Parameters.Add("@acıklama", SqlDbType.VarChar).Value = u._acıklama;
                cmd.Parameters.Add("@fiyat", SqlDbType.Money).Value = u._fiyat;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());

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

        public void urunleriListele(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select urunler.* ,KATEGORIADI from urunler inner join kategoriler on kategoriler.ID=urunler.KATEGORIID where URUNLER.DURUM=0", con);

            SqlDataReader dr = null;

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
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
                    
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
                con.Dispose();
                con.Close();
            }

        }

        public int urunBilgileriGüncelle(cUrunler u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update  urunler set URUNAD=@urunad,KATEGORIID=@katId,ACIKLAMA=@acıklama,FIYAT=@fiyat where ID=@urunId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@urunad", SqlDbType.VarChar).Value = u._urunAd;
                cmd.Parameters.Add("@katId", SqlDbType.Int).Value = u._urunTurNo;
                cmd.Parameters.Add("@acıklama", SqlDbType.VarChar).Value = u._acıklama;
                cmd.Parameters.Add("@fiyat", SqlDbType.Money).Value = u._fiyat;
                cmd.Parameters.Add("@urunId", SqlDbType.Int).Value = u._urunId;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());

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

        public int urunSil(cUrunler u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update  urunler set DURUM=1 where ID=@urunId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@urunId", SqlDbType.Int).Value = u._urunId;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());

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

        public void urunleriListeleByurunID(ListView lv, int urunId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select urunler.* ,KATEGORIADI from urunler inner join kategoriler on kategoriler.ID=urunler.KATEGORIID where urunler.DURUM=0 and urunler.KATEGORIID=@urunId", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("urunId", SqlDbType.Int).Value = urunId;

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
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
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
                con.Dispose();
                con.Close();
            }

        }



    }
}
