namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCountry = new System.Windows.Forms.DataGridView();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.saveInfo = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textDes = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).BeginInit();
            this.viewPanel.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCountry
            // 
            this.dgvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountry.Location = new System.Drawing.Point(-2, 27);
            this.dgvCountry.Name = "dgvCountry";
            this.dgvCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCountry.Size = new System.Drawing.Size(339, 495);
            this.dgvCountry.TabIndex = 0;
            this.dgvCountry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCountry_CellContentClick);
            this.dgvCountry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCountry_CellContentClick);
            // 
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.label7);
            this.viewPanel.Controls.Add(this.label3);
            this.viewPanel.Controls.Add(this.label6);
            this.viewPanel.Controls.Add(this.label2);
            this.viewPanel.Location = new System.Drawing.Point(343, 134);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(586, 373);
            this.viewPanel.TabIndex = 2;
            this.viewPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "testDescription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "testCountryName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CountryName";
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.cancel);
            this.EditPanel.Controls.Add(this.saveInfo);
            this.EditPanel.Controls.Add(this.dateTimePicker);
            this.EditPanel.Controls.Add(this.textDes);
            this.EditPanel.Controls.Add(this.textBox1);
            this.EditPanel.Controls.Add(this.textName);
            this.EditPanel.Controls.Add(this.label9);
            this.EditPanel.Controls.Add(this.label12);
            this.EditPanel.Controls.Add(this.label10);
            this.EditPanel.Controls.Add(this.label11);
            this.EditPanel.Location = new System.Drawing.Point(340, 312);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(586, 195);
            this.EditPanel.TabIndex = 3;
            this.EditPanel.Visible = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Goldenrod;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.cancel.Location = new System.Drawing.Point(475, 158);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(90, 30);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // saveInfo
            // 
            this.saveInfo.BackColor = System.Drawing.Color.Gold;
            this.saveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveInfo.ForeColor = System.Drawing.Color.White;
            this.saveInfo.Location = new System.Drawing.Point(372, 158);
            this.saveInfo.Name = "saveInfo";
            this.saveInfo.Size = new System.Drawing.Size(97, 30);
            this.saveInfo.TabIndex = 3;
            this.saveInfo.Text = "SAVE";
            this.saveInfo.UseVisualStyleBackColor = false;
            this.saveInfo.Click += new System.EventHandler(this.saveInfo_Click_1);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(131, 161);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(225, 21);
            this.dateTimePicker.TabIndex = 2;
            // 
            // textDes
            // 
            this.textDes.Location = new System.Drawing.Point(131, 120);
            this.textDes.Name = "textDes";
            this.textDes.Size = new System.Drawing.Size(100, 21);
            this.textDes.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(131, 79);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 21);
            this.textName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "CountryID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "CreatedDate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "CountryName";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Description";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertMenu,
            this.editMenu,
            this.deleteMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertMenu
            // 
            this.insertMenu.BackColor = System.Drawing.Color.DarkGreen;
            this.insertMenu.ForeColor = System.Drawing.Color.White;
            this.insertMenu.Name = "insertMenu";
            this.insertMenu.Padding = new System.Windows.Forms.Padding(4, 0, 50, 0);
            this.insertMenu.Size = new System.Drawing.Size(91, 20);
            this.insertMenu.Text = "NEW";
            this.insertMenu.Click += new System.EventHandler(this.insertMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.editMenu.ForeColor = System.Drawing.Color.White;
            this.editMenu.MergeIndex = 10;
            this.editMenu.Name = "editMenu";
            this.editMenu.Padding = new System.Windows.Forms.Padding(4, 0, 50, 0);
            this.editMenu.Size = new System.Drawing.Size(88, 20);
            this.editMenu.Text = "EDIT";
            this.editMenu.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // deleteMenu
            // 
            this.deleteMenu.BackColor = System.Drawing.Color.Red;
            this.deleteMenu.ForeColor = System.Drawing.Color.White;
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Padding = new System.Windows.Forms.Padding(4, 0, 50, 0);
            this.deleteMenu.Size = new System.Drawing.Size(103, 20);
            this.deleteMenu.Text = "DELETE";
            this.deleteMenu.Click += new System.EventHandler(this.deleteMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.dgvCountry);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Country Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).EndInit();
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCountry;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textDes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button saveInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMenu;
        private System.Windows.Forms.Button cancel;
    }
}

