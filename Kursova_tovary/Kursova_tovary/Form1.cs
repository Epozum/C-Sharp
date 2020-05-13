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
        static private string Category;

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
            MySqlCommand command = new MySqlCommand("SELECT PER_CENT FROM per_cent_index WHERE 1", DBUtils.GetDBConnection());

            command.Connection.Open();
            textBoxPerCent.Text = command.ExecuteScalar().ToString();
            command.Connection.Close();

            Category = "";
            FillDGV("");
        }

        public void FillDGV(string valueToSearch)//Пошук значень через поле Search
        {   
            MySqlCommand command = new MySqlCommand("SELECT * FROM product WHERE CONCAT(ID, NAME, DESCRIPTION, NUMBER, PRICE) LIKE '%" + valueToSearch + "%' AND(ID) LIKE '" + Category + "%'", DBUtils.GetDBConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_Click(object sender, EventArgs e)//Автоматичне заповнення полів даними з таблиці
        {
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxDesc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxNumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxPrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void BTN_INSERT_Click(object sender, EventArgs e)//Додавання нових записів
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("INSERT INTO product(ID, NAME, DESCRIPTION, NUMBER, PRICE, IMAGE) VALUES (@id, @name, @desc, @numb, @pr, @img)", DBUtils.GetDBConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = textBoxDesc.Text;
            command.Parameters.Add("@numb", MySqlDbType.VarChar).Value = textBoxNumber.Text;
            command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = textBoxPrice.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
            ExecMyQuery(command, "Data Inserted");
        }
        
        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)//Повідомлення про успішність вбо неуспішність введення даних
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

        private void BTN_UPDATE_Click(object sender, EventArgs e)//Оноалення записів
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE product SET NAME=@name ,DESCRIPTION=@desc, NUMBER = @numb, PRICE = @pr, IMAGE=@img WHERE ID = @id", DBUtils.GetDBConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = textBoxDesc.Text;
            command.Parameters.Add("@numb", MySqlDbType.VarChar).Value = textBoxNumber.Text;
            command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = textBoxPrice.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
            ExecMyQuery(command, "Data Updated");
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)//Видалення записів
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM product WHERE ID=@id", DBUtils.GetDBConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;

            ExecMyQuery(command, "Data Deleted");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FillDGV(textBoxSearch.Text); 
        }

        private void BTN_CLEAT_Click(object sender, EventArgs e)//Очищення полів
        {
            ClearFields();
        }

        public void ClearFields()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxDesc.Text = "";
            textBoxNumber.Text = "";
            textBoxPrice.Text = "";
            pictureBox1.Image = null;
        }

        private void keyRad_CheckedChanged(object sender, EventArgs e)//Пошук в категорії клавіатур
        {
            if (keyRad.Checked)
            {
                textBoxSearch.Text = "";
                Category = "K";
                FillDGV("");
            }
        }

        private void gameRad_CheckedChanged(object sender, EventArgs e)//Пошук в категорії геймпадів
        {
            if (gameRad.Checked)
            {
                textBoxSearch.Text = "";
                Category = "G";
                FillDGV("");
            }
        }

        private void mouseRad_CheckedChanged(object sender, EventArgs e)//Пошук в категорії комп'ютерних мишок
        {
            if (mouseRad.Checked)
            {
                textBoxSearch.Text = "";
                Category = "M";
                FillDGV("");
            }
        }

        private void allRad_CheckedChanged(object sender, EventArgs e)//Всі категорії
        {
            if (allRad.Checked)
            {
                textBoxSearch.Text = "";
                Category = "";
                FillDGV("");
            }
        }

        private void PerCentChange_Click(object sender, EventArgs e)//Внесення значень проценту надбавки
        {
            MySqlCommand command = new MySqlCommand("UPDATE per_cent_index SET PER_CENT=@per_cent WHERE ID = 1", DBUtils.GetDBConnection());
            command.Parameters.Add("@per_cent", MySqlDbType.Int32).Value = Int32.Parse(textBoxPerCent.Text);
            ExecMyQuery(command, "Data Updated");
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)//Вирахування ціни з урахуванням надбавки
        {
            double percent = Double.Parse(textBoxPrice.Text) + (Double.Parse(textBoxPrice.Text) * Double.Parse(textBoxPerCent.Text) / 100);
            textBoxMarkupPrice.Text = percent.ToString();
        }
    }
}
