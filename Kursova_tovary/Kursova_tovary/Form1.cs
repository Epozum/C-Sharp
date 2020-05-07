using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Tutorial.SqlConn;
using System.IO;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;

namespace Kursova_tovary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose image(*.JPG;*.PNG;*.GIF)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDGV("");
        }

        public void FillDGV(string valueToSearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM product WHERE CONCAT (ID, NAME, DESCRIPTION, NUMBER) LIKE '%" + valueToSearch + "%'", DBUtils.GetDBConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol = (DataGridViewImageColumn)dataGridView1.Columns[4];
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxDesc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxNumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void BTN_INSERT_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("INSERT INTO product(ID, NAME, DESCRIPTION, NUMBER, IMAGE) VALUES (@id, @name, @desc, @numb, @img)", DBUtils.GetDBConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = textBoxDesc.Text;
            command.Parameters.Add("@numb", MySqlDbType.VarChar).Value = textBoxDesc.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
            ExecMyQuery(command, "Data Inserted");
        }
        
        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            mcomd.Connection.Open();
            if(mcomd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(myMsg) ;
            }
            else
            {
                MessageBox.Show("Message not Executed");
            }
            mcomd.Connection.Close();
            FillDGV(""); 
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE product SET NAME=@name ,DESCRIPTION=@desc, NUMBER = @numb, IMAGE=@img WHERE ID = @id", DBUtils.GetDBConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = textBoxDesc.Text;
            command.Parameters.Add("@numb", MySqlDbType.VarChar).Value = textBoxNumber.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
            ExecMyQuery(command, "Data Updated");
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM product WHERE ID=@id", DBUtils.GetDBConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;

            ExecMyQuery(command, "Data Deleted");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FillDGV(textBoxSearch.Text); 
        }

        private void BTN_CLEAT_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void ClearFields()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxDesc.Text = "";
            textBoxNumber.Text = "";
            pictureBox1.Image = null;
        }
    }
}
