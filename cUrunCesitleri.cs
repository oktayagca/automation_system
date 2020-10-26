using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Royal_Resteurant_Oto
{
    class cUrunCesitleri
    {
        cGenel gnl = new cGenel();

        private int _UrunTurNo;
        private string _KategoriAd;
        private string _Aciklama;



        #region properties
        public int UrunTurNo
        {
            get
            {
                return _UrunTurNo;
            }

            set
            {
                _UrunTurNo = value;
            }
        }

        public string KategoriAd
        {
            get
            {
                return _KategoriAd;
            }

            set
            {
                _KategoriAd = value;
            }
        }

        public string Aciklama
        {
            get
            {
                return _Aciklama;
            }

            set
            {
                _Aciklama = value;
            }
        }

        #endregion

        public void getByProductTypes (ListView Cesitler, Button btn)
        {
            Cesitler.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select URUNAD, FIYAT, urunler.ID From kategoriler Inner Join urunler on kategoriler.ID=urunler.KATEGORIID where urunler.KATEGORIID=@KATEGORIID", conn);


            string aa = btn.Name;
            int uzunluk = aa.Length;

            comm.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while(dr.Read())
            {
                Cesitler.Items.Add(dr["URUNAD"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }

            dr.Close();
            conn.Dispose();



        }

        public void urunCesitleriniGetir(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from kategoriler where DURUM=0", con);

            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cUrunCesitleri uc = new cUrunCesitleri();
                    uc._UrunTurNo = Convert.ToInt32(dr["ID"]);
                    uc._KategoriAd = dr["KATEGORIADI"].ToString();
                    uc._Aciklama = dr["ACIKLAMA"].ToString();

                    cb.Items.Add(uc);
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

        public void urunCesitleriniGetir(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from kategoriler  where DURUM=0", con);

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
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
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

        public int urunCesitleriEkle(cUrunCesitleri u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into kategoriler(KATEGORIADI,ACIKLAMA) values(@KATEGORIADI,@ACIKLAMA)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@KATEGORIADI", SqlDbType.VarChar).Value = u._KategoriAd;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = u._Aciklama;
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

        public int urunKategoriBilgileriGüncelle(cUrunCesitleri u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update  kategoriler set KATEGORIADI=@KATEGORIADI,ACIKLAMA=@ACIKLAMA where ID=@katID", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@KATEGORIADI", SqlDbType.VarChar).Value = u._KategoriAd;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = u._Aciklama;
                cmd.Parameters.Add("@katID", SqlDbType.Int).Value = u._UrunTurNo;
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

        public int urunKategoriSil(int id)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update  kategoriler set DURUM=1 where ID=@katID", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@katID", SqlDbType.Int).Value =id;
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

        public override string ToString()
        {
            return KategoriAd;
        }
    }

}
