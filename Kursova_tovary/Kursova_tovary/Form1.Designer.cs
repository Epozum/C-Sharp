namespace Kursova_tovary
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_INSERT = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.BTN_CLEAT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.keyRad = new System.Windows.Forms.RadioButton();
            this.gameRad = new System.Windows.Forms.RadioButton();
            this.mouseRad = new System.Windows.Forms.RadioButton();
            this.allRad = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPerCent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMarkupPrice = new System.Windows.Forms.TextBox();
            this.PerCentChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxID.Location = new System.Drawing.Point(102, 35);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(151, 26);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.Tag = "TextBoxID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(634, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 577);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(102, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 26);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.Tag = "TextBoxName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDesc.Location = new System.Drawing.Point(102, 114);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(151, 104);
            this.textBoxDesc.TabIndex = 5;
            this.textBoxDesc.Tag = "TextBoxDesc";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(12, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(233, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 10;
            this.button1.Tag = "BTN_CHOOSE_IMG";
            this.button1.Text = "<<<>>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_INSERT
            // 
            this.BTN_INSERT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_INSERT.Location = new System.Drawing.Point(497, 78);
            this.BTN_INSERT.Name = "BTN_INSERT";
            this.BTN_INSERT.Size = new System.Drawing.Size(128, 36);
            this.BTN_INSERT.TabIndex = 11;
            this.BTN_INSERT.Text = "Insert";
            this.BTN_INSERT.UseVisualStyleBackColor = true;
            this.BTN_INSERT.Click += new System.EventHandler(this.BTN_INSERT_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_DELETE.Location = new System.Drawing.Point(497, 164);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(128, 36);
            this.BTN_DELETE.TabIndex = 12;
            this.BTN_DELETE.Text = "Delete";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_UPDATE.Location = new System.Drawing.Point(497, 121);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(128, 36);
            this.BTN_UPDATE.TabIndex = 13;
            this.BTN_UPDATE.Text = "Update";
            this.BTN_UPDATE.UseVisualStyleBackColor = true;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(631, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Search:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearch.Location = new System.Drawing.Point(696, 13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(521, 26);
            this.textBoxSearch.TabIndex = 14;
            this.textBoxSearch.Tag = "TextBoxID";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // BTN_CLEAT
            // 
            this.BTN_CLEAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_CLEAT.Location = new System.Drawing.Point(497, 35);
            this.BTN_CLEAT.Name = "BTN_CLEAT";
            this.BTN_CLEAT.Size = new System.Drawing.Size(128, 36);
            this.BTN_CLEAT.TabIndex = 16;
            this.BTN_CLEAT.Text = "Clear";
            this.BTN_CLEAT.UseVisualStyleBackColor = true;
            this.BTN_CLEAT.Click += new System.EventHandler(this.BTN_CLEAT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(16, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Number";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumber.Location = new System.Drawing.Point(102, 233);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(151, 26);
            this.textBoxNumber.TabIndex = 17;
            this.textBoxNumber.Tag = "TextBoxNumber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(16, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPrice.Location = new System.Drawing.Point(102, 273);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(151, 26);
            this.textBoxPrice.TabIndex = 19;
            this.textBoxPrice.Tag = "TextBoxPrice";
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // keyRad
            // 
            this.keyRad.AutoSize = true;
            this.keyRad.Location = new System.Drawing.Point(497, 206);
            this.keyRad.Name = "keyRad";
            this.keyRad.Size = new System.Drawing.Size(70, 17);
            this.keyRad.TabIndex = 21;
            this.keyRad.TabStop = true;
            this.keyRad.Text = "Keyboard";
            this.keyRad.UseVisualStyleBackColor = true;
            this.keyRad.CheckedChanged += new System.EventHandler(this.keyRad_CheckedChanged);
            // 
            // gameRad
            // 
            this.gameRad.AutoSize = true;
            this.gameRad.Location = new System.Drawing.Point(497, 229);
            this.gameRad.Name = "gameRad";
            this.gameRad.Size = new System.Drawing.Size(71, 17);
            this.gameRad.TabIndex = 22;
            this.gameRad.TabStop = true;
            this.gameRad.Text = "Gamepad";
            this.gameRad.UseVisualStyleBackColor = true;
            this.gameRad.CheckedChanged += new System.EventHandler(this.gameRad_CheckedChanged);
            // 
            // mouseRad
            // 
            this.mouseRad.AutoSize = true;
            this.mouseRad.Location = new System.Drawing.Point(497, 252);
            this.mouseRad.Name = "mouseRad";
            this.mouseRad.Size = new System.Drawing.Size(57, 17);
            this.mouseRad.TabIndex = 23;
            this.mouseRad.TabStop = true;
            this.mouseRad.Text = "Mouse";
            this.mouseRad.UseVisualStyleBackColor = true;
            this.mouseRad.CheckedChanged += new System.EventHandler(this.mouseRad_CheckedChanged);
            // 
            // allRad
            // 
            this.allRad.AutoSize = true;
            this.allRad.Location = new System.Drawing.Point(497, 273);
            this.allRad.Name = "allRad";
            this.allRad.Size = new System.Drawing.Size(36, 17);
            this.allRad.TabIndex = 24;
            this.allRad.TabStop = true;
            this.allRad.Text = "All";
            this.allRad.UseVisualStyleBackColor = true;
            this.allRad.CheckedChanged += new System.EventHandler(this.allRad_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(271, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Per cent";
            // 
            // textBoxPerCent
            // 
            this.textBoxPerCent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPerCent.Location = new System.Drawing.Point(367, 121);
            this.textBoxPerCent.Name = "textBoxPerCent";
            this.textBoxPerCent.Size = new System.Drawing.Size(124, 26);
            this.textBoxPerCent.TabIndex = 25;
            this.textBoxPerCent.Tag = "TextBoxPrice";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(271, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Markup price";
            // 
            // textBoxMarkupPrice
            // 
            this.textBoxMarkupPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMarkupPrice.Location = new System.Drawing.Point(367, 35);
            this.textBoxMarkupPrice.Name = "textBoxMarkupPrice";
            this.textBoxMarkupPrice.Size = new System.Drawing.Size(124, 26);
            this.textBoxMarkupPrice.TabIndex = 27;
            this.textBoxMarkupPrice.Tag = "TextBoxMarkupPrice";
            // 
            // PerCentChange
            // 
            this.PerCentChange.Location = new System.Drawing.Point(383, 153);
            this.PerCentChange.Name = "PerCentChange";
            this.PerCentChange.Size = new System.Drawing.Size(75, 23);
            this.PerCentChange.TabIndex = 29;
            this.PerCentChange.Text = "Change";
            this.PerCentChange.UseVisualStyleBackColor = true;
            this.PerCentChange.Click += new System.EventHandler(this.PerCentChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1229, 634);
            this.Controls.Add(this.PerCentChange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxMarkupPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPerCent);
            this.Controls.Add(this.allRad);
            this.Controls.Add(this.mouseRad);
            this.Controls.Add(this.gameRad);
            this.Controls.Add(this.keyRad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.BTN_CLEAT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.BTN_UPDATE);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.BTN_INSERT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_INSERT;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_UPDATE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button BTN_CLEAT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.RadioButton keyRad;
        private System.Windows.Forms.RadioButton gameRad;
        private System.Windows.Forms.RadioButton mouseRad;
        private System.Windows.Forms.RadioButton allRad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPerCent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMarkupPrice;
        private System.Windows.Forms.Button PerCentChange;
    }
}

