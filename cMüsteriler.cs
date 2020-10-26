using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Royal_Resteurant_Oto
{
    class cMüsteriler
    {
        cGenel gnl = new cGenel();


        #region Fields
        private int _musteriId;
        private string _musteriAd;
        private string _musteriSoyad;
        private string _telefon;
        private string _adres;
        private string _email; 
        #endregion

        #region Properties
        public int MusteriId
        {
            get
            {
                return _musteriId;
            }

            set
            {
                _musteriId = value;
            }
        }

        public string MusteriAd
        {
            get
            {
                return _musteriAd;
            }

            set
            {
                _musteriAd = value;
            }
        }

        public string MusteriSoyad
        {
            get
            {
                return _musteriSoyad;
            }

            set
            {
                _musteriSoyad = value;
            }
        }

        public string Telefon
        {
            get
            {
                return _telefon;
            }

            set
            {
                _telefon = value;
            }
        }

        public string Adres
        {
            get
            {
                return _adres;
            }

            set
            {
                _adres = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
            #endregion

        public bool MusteriVarmi(string tlf)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "MusteriVarmi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = tlf;
            cmd.Parameters.Add("@sonuc", SqlDbType.Int);
            cmd.Parameters["@sonuc"].Direction = ParameterDirection.Output;

            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                cmd.ExecuteNonQuery();
                sonuc = Convert.ToBoolean(cmd.Parameters["@sonuc"].Value);
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

            return sonuc;
            
        }

        public int musteriEkle(cMüsteriler m)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Musteriler(AD,SOYAD,TELEFON,ADRES,EMAIL) values(@ad,@soyad,@telefon,@adres,@email); select SCOPE_IDENTITY()", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = m._musteriAd;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = m._musteriSoyad;
                cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = m._telefon;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = m._adres;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = m._email;
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

        public bool musteriBilgileriGüncelle(cMüsteriler m)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update  musteriler set AD=@ad,SOYAD=@soyad,TELEFON=@telefon,ADRES=@adres,EMAIL=@email where ID=@musteriId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = m._musteriAd;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = m._musteriSoyad;
                cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = m._telefon;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = m._adres;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = m._email;
                cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = m._musteriId;
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

        public void musterileriGetir(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from musteriler", con);

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
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());

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

        public void musterileriGetirId(int musteriId,TextBox ad,TextBox soyad,TextBox tlf,TextBox adres,TextBox email)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from musteriler where ID=@musteriID ",con);

            SqlDataReader dr=null;
            cmd.Parameters.Add("musteriID", SqlDbType.Int).Value = musteriId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ad.Text = dr["AD"].ToString();
                    soyad.Text = dr["SOYAD"].ToString();
                    tlf.Text = dr["TELEFON"].ToString();
                    adres.Text = dr["ADRES"].ToString();
                    email.Text = dr["EMAIL"].ToString();

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

    }
}
