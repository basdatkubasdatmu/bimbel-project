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

        public void insertDataSiswa(string kodeJadwalSiswa, string noSiswa, string waktuPresensi)
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

        public void insertDataPengajar(string kodeJadwalSiswa, string noSiswa, string waktuPresensi)
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

        public void insertDataPegawai(string kodeJadwalSiswa, string noSiswa, string waktuPresensi)
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

        public void insertDataKelas(string kodeJadwalSiswa, string noSiswa, string waktuPresensi)
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
    }
}


