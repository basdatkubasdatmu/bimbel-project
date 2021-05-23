using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;
using System.Windows.Forms;


namespace bimbel
{
    public class DataAccess
    {
        string strConnString = "Server = localhost; Port = 5432; User id = postgres; Password = bismillah; Database = Bimbel";

        public DataTable getAllJadwalSiswa()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from jadwalsiswa";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jadwal siswa gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllJadwalPengajar()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from jadwalpengajar";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jadwal pengajar gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllKelas()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from kelas";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kelas gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllMatpel()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from matapelajaran";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Daftar mata pelajaran gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllNilai()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from nilai";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data nilai gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllPegawai()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from pegawai";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data pegawai gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllPembayaran()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from pembayaran";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data transaksi pembayaran gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllPengajar()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from pengajar";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Daftar pengajar gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllPresensi()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from presensi";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Daftar kehadiran gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllZoom()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from ruangzoom";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Daftar ruang zoom gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllSiswa()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from siswa";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data barang gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable getAllUjian()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = strConnString;
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from ujian";
                cmd.CommandType = CommandType.Text;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Daftar ujian gagal dibaca :" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public void insertDataMapel(string kodePelajaran, string pelajaran)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into matpel(kodepelajaran, pelajaran) values('" + kodePelajaran + "', '" + pelajaran + "');";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }

        public void insertDataPembayaran(string kodePembayaran, string noSiswa, string kodeKelas, string tanggalPembayaran, string status)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into pembayaran(kodepembayaran, nosiswa, kodekelas, tanggalpembayaran, status) values('" + kodePembayaran + "', '" + noSiswa + "', '" + kodeKelas + "', '" + tanggalPembayaran + "', '" + status + "');";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }

        public void insertDataRuang(string kodeZoom, string link, string idMeeting, string passcode)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ruangzoom(kodezoom, link, meetingid, passcode) values('" + kodeZoom + "', '" + link + "', '" + idMeeting + "', '" + passcode +"');";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }

        public void insertDataNilai(string kodeUjian, string nosiswa, string noPengajar, string kodePelajaran, string nilai)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into nilai(kodeujian, nosiswa, nopengajar, kodepelajaran, nilai) values('" + kodeUjian + "', '" + nosiswa + "', '" + noPengajar + "', '" + kodePelajaran + "', '" + nilai + "');";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }

        public void insertDataUjian(string kodeUjian, string nama, string kodePelajaran, string tanggal, string jamMulai, string durasi)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ujian(kodeujian, nama, kodepelajaran, tanggal, jammulai, durasi) values('" + kodeUjian + "', '" + nama + "', '" + kodePelajaran + "', '" + tanggal + "', '" + jamMulai + "', '" + durasi + "');";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }

        public void insertDataPresensi(string kodeJadwalSiswa, string noSiswa, string waktuPresensi)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into presensi(kodejadwalsiswa, nosiswa, waktupresensi) values('" + kodeJadwalSiswa + "', '" + noSiswa + "', '" + waktuPresensi + "');";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }

        public void insertDataSiswa(string noSiswa, string nama, string jenisKelamin, string kodeKelas, string noHP, string email, string asalDaerah)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into siswa(nosiswa, nama, jeniskelamin, kodekelas, nohp, email, asaldaerah) values('" + noSiswa + "', '" + nama + "', '" + jenisKelamin + "', '" + kodeKelas + "', '" + noHP + "', '" + email + "', '" + asalDaerah + "');";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }

        public void insertDataPengajar(string noPengajar, string kodePelajaran, string noPegawai)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into pengajar(nopengajar, kodepelajaran, nopegawai) values('" + noPengajar + "', '" + kodePelajaran + "', '" + noPegawai + "');";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }

        public void insertDataPegawai(string noPegawai, string nama, string jenisKelamin, string noHP, string email, string posisi)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into pegawai(nopegawai, nama, jeniskelamin, nohp, email, posisi) values('" + noPegawai + "', '" + nama + "', '" + jenisKelamin + "', '" + noHP + "', '" + email + "', '" + posisi + "');";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }

        public void insertDataKelas(string kodeKelas, string nama, string biaya, string kuota, string fasilitas)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into kelas(kodekelas, nama, biaya, kuota, fasilitas) values('" + kodeKelas + "', '" + nama + "', '" + biaya + "', '" + kuota + "', '" + fasilitas + "');";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }

        public void insertDataJadwalPengajar(string kodeJadwalPengajar, string kodeKelas, string noPengajar, string kodePelajaran, string tanggal, string jamMulai, string durasi, string kodeZoom)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into jadwalpengajar(kodejadwalpengajar, kodekelas, nopengajar, kodepelajaran, tanggal, jammulai, durasi, kodezoom) values('" + kodeJadwalPengajar + "', '" + kodeKelas + "', '" + noPengajar + "', '" + kodePelajaran + "', '" + tanggal + "', '" + jamMulai + "', '" + durasi + "');";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }

        public void insertDataJadwalSiswa(string kodeJadwalSiswa, string noSiswa, string kodeJadwalPengajar)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into jadwalsiswa(kodejadwalsiswa, nosiswa, kodejadwalpengajar) values('" + kodeJadwalSiswa + "', '" + noSiswa + "', '" + kodeJadwalPengajar + "');";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
        public void updateDataPresensi(string kodejadwalsiswa, string nosiswa, string waktupresensi)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format(@"update presensisiswa set
                            nosiswa = '{0}', waktupresensi = '{1}' 
                            where kodejadwalsiswa = '" + kodejadwalsiswa + "';", nosiswa, waktupresensi);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
        public void updateDataPengajar(string nopengajar, string kodepelajaran, string nopegawai)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format(@"update pengajar set
                            kodepelajaran = '{0}', nopegawai = '{1}' 
                            where nopengajar = '" + nopengajar + "';", kodepelajaran, nopegawai);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
        public void updateDataSiswa(string nosiswa, string nama, string jeniskelamin, string kodekelas, string nohp, string email, string asaldaerah)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format(@"update siswa set
                            nama = '{0}', jeniskelamin = '{1}', kodekelas = '{2}', nohp = '{3}', email = '{4}', asaldaerah = '{5}' 
                            where nosiswa = '" + nosiswa + "';", nama, jeniskelamin, kodekelas, nohp, email, asaldaerah);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
        public void updateDataJadwalPengajar(string kodejadwalpengajar, string kodekelas, string nopengajar, string kodepelajaran, string tanggal, string jammulai, string durasi, string kodezoom)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format(@"update jadwalpengajar set
                           kodekelas = '{0}', nopengajar = '{1}', kodepelajaran = '{2}', tanggal = '{3}', jammulai = '{4}', durasi = '{5}', kodezoom = '{6}' 
                           where kodejadwalpengajar = '" + kodejadwalpengajar + "';", kodekelas, nopengajar, kodepelajaran, tanggal, jammulai, durasi, kodezoom);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
        public void updateDataJadwalSiswa(string kodejadwalsiswa, string nosiswa, string kodejadwalpengajar)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format(@"update jadwalsiswa set
                            nosiswa = '{0}', kodejadwalpengajar = '{1}' 
                            where kodejadwalsiswa = '" + kodejadwalsiswa + "';", nosiswa, kodejadwalpengajar);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
        public void updateDataJadwalUjian(string kodeujian, string nama, string kodepelajaran, string tanggal, string jammulai, string durasi)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format(@"update ujian set
                            nama = '{0}', kodepelajaran = '{1}', tanggal = '{2}', jammulai = '{3}', durasi = '{4}' 
                            where kodeujian = '" + kodeujian + "';", nama, kodepelajaran, tanggal, jammulai, durasi);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
        public void updateDataKelas(string kodekelas, string nama, string biaya, string kuota, string fasilitas)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format(@"update kelas set
                            nama = '{0}', biaya = '{1}', kuota = '{2}', fasilitas = '{3}' 
                            where kodekelas = '" + kodekelas + "';", nama, biaya, kuota, fasilitas);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
        public void updateDataMatPel(string kodepelajaran, string pelajaran)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format(@"update matapelajaran set
                            pelajaran = '{0}' 
                            where kodepelajaran = '" + kodepelajaran + "';", pelajaran);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
        public void updateDataNilai(string kodeujian, string nosiswa, string nopengajar, string kodepelajaran, string nilai)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format(@"update nilai set
                            nosiswa = '{0}', nopengajar = '{1}', kodepelajaran = '{2}', nilai = '{3}' 
                            where kodeujian = '" + kodeujian + "';", nosiswa, nopengajar, kodepelajaran, nilai);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
        public void updateDataPegawai(string nopegawai, string nama, string jeniskelamin, string nohp, string email, string posisi)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format(@"update pegawai set
                            nama = '{0}', jeniskelamin = '{1}', nohp = '{2}', email = '{3}', posisi = '{4}' 
                            where nopegawai = '" + nopegawai + "';", nama, jeniskelamin, nohp, email, posisi);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
        public void updateDataRuangZoom(string kodezoom, string link, string meetingid, string passcode)
        {
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format(@"update ruangzoom set
                            link = '{0}', meetingid = '{1}', kodepelajaran = '{2}', nilai = '{3}' 
                            where kodezoom = '" + kodezoom + "';", link, meetingid, passcode);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }
    }
}


