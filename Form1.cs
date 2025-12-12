using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Npgsql;

namespace ResponsiJunpro
{
    public partial class Form1 : Form // inheritance dari form
    {
        // encapsulation dengan access modifier
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi-2025;";
        private NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi-2025;");
        private NpgsqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            conn.Open();
            LoadDatabase();
            conn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // encapsulation
        private void LoadDatabase()
        {
            try
            {
                DataTable dataTable = new DataTable();
                cmd = new NpgsqlCommand("select *" +
                    "from developer d left join proyek p on d.id_proyek = p.id_proyek;", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dataTable.Load(dr);
                
                // Tambahkan kolom skor
                dataTable.Columns.Add("skor", typeof(double));
                
                // Hitung skor untuk setiap baris
                foreach (DataRow row in dataTable.Rows)
                {
                    string status = row["status_kontrak"].ToString().ToLower();
                    int fitur = Convert.ToInt32(row["fitur_selesai"]);
                    int bug = Convert.ToInt32(row["jumlah_bug"]);
                    double skor = 0;
                    
                    if (status == "full time")
                    {
                        // Skor = 10 x fitur - 5 x bug
                        skor = (10 * fitur) - (5 * bug);
                    }
                    else if (status == "freelance")
                    {
                        // Skor = 100 * (1 - (2 * bug) / (3 * fitur))
                        if (fitur > 0) // Hindari pembagian dengan nol
                        {
                            skor = 100 * (1 - (2.0 * bug) / (3.0 * fitur));
                        }
                        else
                        {
                            skor = 0;
                        }
                    }
                    
                    row["skor"] = skor;
                }
                
                dtgv.DataSource = dataTable;
                dtgv.Columns["id_proyek"].Visible = false;
                dtgv.Columns["id_proyek1"].Visible = false;
                
            }
            catch { }
        }

        private int GetLength()
        {
            try
            {
                return dtgv.Rows.Count;
            }
            catch
            {
                return 0;
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string bug = txtBug.Text;
                string nama = txtNama.Text;
                string proyek = txtProyek.Text;
                string status = txtStatus.Text;
                if (proyek != "1" && proyek != "2" && proyek != "3" && proyek != "4" && proyek != "5")
                {
                    MessageBox.Show("ID Proyek tidak valid!", "Gagal", MessageBoxButtons.OK);
                    conn.Close();
                    return;
                }

                if (status != "freelance" && status != "full time")
                {
                    MessageBox.Show("Status tidak valid!", "Gagal", MessageBoxButtons.OK);
                    conn.Close();
                    return;
                }
                string fitur = txtFitur.Text;
                DataTable dt = new DataTable();
                Console.WriteLine(GetLength());
                cmd = new NpgsqlCommand(
                    "insert into developer(id_dev, id_proyek, nama_dev, fitur_selesai, jumlah_bug, status_kontrak)"
                    + "VALUES ('" + GetLength() + "', '" + proyek + "', '" + nama + "', " + fitur + ", " + bug + ", '" + status + "');", conn);
                cmd.ExecuteNonQuery();
                LoadDatabase();
                conn.Close();

                MessageBox.Show("Berhasil Menambahkan Data!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK);
                conn.Close();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string id_dev = to_delete.Text;
                cmd = new NpgsqlCommand(
                   "delete from developer where id_dev ='" + id_dev + "\'", conn);
                cmd.ExecuteNonQuery();
                LoadDatabase();
                conn.Close();
                MessageBox.Show("Berhasil Hapus Data!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK);
                conn.Close();
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string bug = txtBug.Text;
                string nama = txtNama.Text;
                string proyek = txtProyek.Text;
                string status = txtStatus.Text;
                string fitur = txtFitur.Text;
                string id_dev = to_update.Text;

                if (proyek != "1" && proyek != "2" && proyek != "3" && proyek != "4" && proyek != "5")
                {
                    MessageBox.Show("ID Proyek tidak valid!", "Gagal", MessageBoxButtons.OK);
                    conn.Close();
                    return;
                }

                if (status != "freelance" && status != "full time")
                {
                    MessageBox.Show("Status tidak valid!", "Gagal", MessageBoxButtons.OK);
                    conn.Close();
                    return;
                }

                // masukin ulang
                DataTable dt = new DataTable();
                Console.WriteLine(GetLength());
                string command = "";
                if(bug .Length > 0)
                {
                    if (command.Length > 0) command += ",";
                    command += "jumlah_bug=" + bug;
                }
                if(fitur.Length > 0)
                {
                    if (command.Length > 0) command += ",";
                    command += "fitur_selesai=" + fitur;
                }
                if(proyek.Length > 0)
                {
                    if (command.Length > 0) command += ",";
                    command += "id_proyek=" + proyek;
                }
                if(status.Length > 0)
                {
                    if (command.Length > 0) command += ",";
                    command += "status_kontrak='" + status + "'";
                }
                if(nama.Length > 0)
                {
                    if (command.Length > 0) command += ",";
                    command += "nama_dev='" + nama + "'";
                }
                cmd = new NpgsqlCommand(
                    "update developer set " +
                  command + " where id_dev=" + to_update.Text + ";", conn);
                cmd.ExecuteNonQuery();
                LoadDatabase();
                conn.Close();

                MessageBox.Show("Berhasil Mengedit Data!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK);
                conn.Close();
            }
        }
    }
}
