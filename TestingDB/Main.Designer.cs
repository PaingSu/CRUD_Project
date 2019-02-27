namespace TestingDB
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PageInsert = new System.Windows.Forms.TabPage();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtNrc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblNrc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.PageUpdate = new System.Windows.Forms.TabPage();
            this.dgResultUp = new System.Windows.Forms.DataGridView();
            this.btnShowUp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCityUp = new System.Windows.Forms.TextBox();
            this.txtNrcUp = new System.Windows.Forms.TextBox();
            this.txtNameUp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PageDelete = new System.Windows.Forms.TabPage();
            this.dgResultDel = new System.Windows.Forms.DataGridView();
            this.btnShowDel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCityDel = new System.Windows.Forms.TextBox();
            this.txtNrcDel = new System.Windows.Forms.TextBox();
            this.txtNameDel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.PageInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.PageUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultUp)).BeginInit();
            this.PageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultDel)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PageInsert);
            this.tabControl1.Controls.Add(this.PageUpdate);
            this.tabControl1.Controls.Add(this.PageDelete);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // PageInsert
            // 
            this.PageInsert.Controls.Add(this.dgResult);
            this.PageInsert.Controls.Add(this.btnShow);
            this.PageInsert.Controls.Add(this.btnInsert);
            this.PageInsert.Controls.Add(this.txtCity);
            this.PageInsert.Controls.Add(this.txtNrc);
            this.PageInsert.Controls.Add(this.txtName);
            this.PageInsert.Controls.Add(this.lblCity);
            this.PageInsert.Controls.Add(this.lblNrc);
            this.PageInsert.Controls.Add(this.lblName);
            this.PageInsert.Location = new System.Drawing.Point(4, 22);
            this.PageInsert.Name = "PageInsert";
            this.PageInsert.Padding = new System.Windows.Forms.Padding(3);
            this.PageInsert.Size = new System.Drawing.Size(629, 374);
            this.PageInsert.TabIndex = 0;
            this.PageInsert.Text = "Registration";
            this.PageInsert.UseVisualStyleBackColor = true;
            // 
            // dgResult
            // 
            this.dgResult.AllowUserToAddRows = false;
            this.dgResult.AllowUserToDeleteRows = false;
            this.dgResult.AllowUserToResizeColumns = false;
            this.dgResult.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgResult.Location = new System.Drawing.Point(40, 218);
            this.dgResult.MultiSelect = false;
            this.dgResult.Name = "dgResult";
            this.dgResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResult.Size = new System.Drawing.Size(545, 150);
            this.dgResult.TabIndex = 8;
            this.dgResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgResultUp_MouseClick);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(279, 165);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show All";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(158, 165);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(158, 126);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 5;
            // 
            // txtNrc
            // 
            this.txtNrc.Location = new System.Drawing.Point(158, 80);
            this.txtNrc.Name = "txtNrc";
            this.txtNrc.Size = new System.Drawing.Size(100, 20);
            this.txtNrc.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(37, 126);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City";
            // 
            // lblNrc
            // 
            this.lblNrc.AutoSize = true;
            this.lblNrc.Location = new System.Drawing.Point(37, 80);
            this.lblNrc.Name = "lblNrc";
            this.lblNrc.Size = new System.Drawing.Size(30, 13);
            this.lblNrc.TabIndex = 1;
            this.lblNrc.Text = "NRC";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // PageUpdate
            // 
            this.PageUpdate.Controls.Add(this.dgResultUp);
            this.PageUpdate.Controls.Add(this.btnShowUp);
            this.PageUpdate.Controls.Add(this.btnUpdate);
            this.PageUpdate.Controls.Add(this.txtCityUp);
            this.PageUpdate.Controls.Add(this.txtNrcUp);
            this.PageUpdate.Controls.Add(this.txtNameUp);
            this.PageUpdate.Controls.Add(this.label1);
            this.PageUpdate.Controls.Add(this.label2);
            this.PageUpdate.Controls.Add(this.label3);
            this.PageUpdate.Location = new System.Drawing.Point(4, 22);
            this.PageUpdate.Name = "PageUpdate";
            this.PageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.PageUpdate.Size = new System.Drawing.Size(629, 374);
            this.PageUpdate.TabIndex = 1;
            this.PageUpdate.Text = "Update";
            this.PageUpdate.UseVisualStyleBackColor = true;
            // 
            // dgResultUp
            // 
            this.dgResultUp.AllowUserToAddRows = false;
            this.dgResultUp.AllowUserToDeleteRows = false;
            this.dgResultUp.AllowUserToResizeColumns = false;
            this.dgResultUp.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgResultUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultUp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgResultUp.Location = new System.Drawing.Point(40, 218);
            this.dgResultUp.MultiSelect = false;
            this.dgResultUp.Name = "dgResultUp";
            this.dgResultUp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResultUp.Size = new System.Drawing.Size(545, 150);
            this.dgResultUp.TabIndex = 16;
            this.dgResultUp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgResultUp_MouseClick);
            // 
            // btnShowUp
            // 
            this.btnShowUp.Location = new System.Drawing.Point(279, 165);
            this.btnShowUp.Name = "btnShowUp";
            this.btnShowUp.Size = new System.Drawing.Size(75, 23);
            this.btnShowUp.TabIndex = 15;
            this.btnShowUp.Text = "Show All";
            this.btnShowUp.UseVisualStyleBackColor = true;
            this.btnShowUp.Click += new System.EventHandler(this.btnShowUp_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(158, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCityUp
            // 
            this.txtCityUp.Location = new System.Drawing.Point(158, 126);
            this.txtCityUp.Name = "txtCityUp";
            this.txtCityUp.Size = new System.Drawing.Size(100, 20);
            this.txtCityUp.TabIndex = 13;
            // 
            // txtNrcUp
            // 
            this.txtNrcUp.Location = new System.Drawing.Point(158, 80);
            this.txtNrcUp.Name = "txtNrcUp";
            this.txtNrcUp.Size = new System.Drawing.Size(100, 20);
            this.txtNrcUp.TabIndex = 12;
            // 
            // txtNameUp
            // 
            this.txtNameUp.Location = new System.Drawing.Point(158, 35);
            this.txtNameUp.Name = "txtNameUp";
            this.txtNameUp.Size = new System.Drawing.Size(100, 20);
            this.txtNameUp.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "NRC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // PageDelete
            // 
            this.PageDelete.Controls.Add(this.dgResultDel);
            this.PageDelete.Controls.Add(this.btnShowDel);
            this.PageDelete.Controls.Add(this.btnDelete);
            this.PageDelete.Controls.Add(this.txtCityDel);
            this.PageDelete.Controls.Add(this.txtNrcDel);
            this.PageDelete.Controls.Add(this.txtNameDel);
            this.PageDelete.Controls.Add(this.label4);
            this.PageDelete.Controls.Add(this.label5);
            this.PageDelete.Controls.Add(this.label6);
            this.PageDelete.Location = new System.Drawing.Point(4, 22);
            this.PageDelete.Name = "PageDelete";
            this.PageDelete.Size = new System.Drawing.Size(629, 374);
            this.PageDelete.TabIndex = 2;
            this.PageDelete.Text = "Delete";
            this.PageDelete.UseVisualStyleBackColor = true;
            // 
            // dgResultDel
            // 
            this.dgResultDel.AllowUserToAddRows = false;
            this.dgResultDel.AllowUserToDeleteRows = false;
            this.dgResultDel.AllowUserToResizeColumns = false;
            this.dgResultDel.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgResultDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultDel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgResultDel.Location = new System.Drawing.Point(40, 218);
            this.dgResultDel.MultiSelect = false;
            this.dgResultDel.Name = "dgResultDel";
            this.dgResultDel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResultDel.Size = new System.Drawing.Size(545, 150);
            this.dgResultDel.TabIndex = 24;
            this.dgResultDel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgResultDel_MouseClick);
            // 
            // btnShowDel
            // 
            this.btnShowDel.Location = new System.Drawing.Point(279, 165);
            this.btnShowDel.Name = "btnShowDel";
            this.btnShowDel.Size = new System.Drawing.Size(75, 23);
            this.btnShowDel.TabIndex = 23;
            this.btnShowDel.Text = "Show All";
            this.btnShowDel.UseVisualStyleBackColor = true;
            this.btnShowDel.Click += new System.EventHandler(this.btnShowDel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(158, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCityDel
            // 
            this.txtCityDel.Location = new System.Drawing.Point(158, 126);
            this.txtCityDel.Name = "txtCityDel";
            this.txtCityDel.Size = new System.Drawing.Size(100, 20);
            this.txtCityDel.TabIndex = 21;
            // 
            // txtNrcDel
            // 
            this.txtNrcDel.Location = new System.Drawing.Point(158, 80);
            this.txtNrcDel.Name = "txtNrcDel";
            this.txtNrcDel.Size = new System.Drawing.Size(100, 20);
            this.txtNrcDel.TabIndex = 20;
            // 
            // txtNameDel
            // 
            this.txtNameDel.Location = new System.Drawing.Point(158, 35);
            this.txtNameDel.Name = "txtNameDel";
            this.txtNameDel.Size = new System.Drawing.Size(100, 20);
            this.txtNameDel.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "NRC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Name";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 400);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.PageInsert.ResumeLayout(false);
            this.PageInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.PageUpdate.ResumeLayout(false);
            this.PageUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultUp)).EndInit();
            this.PageDelete.ResumeLayout(false);
            this.PageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PageInsert;
        private System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtNrc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblNrc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage PageUpdate;
        private System.Windows.Forms.TabPage PageDelete;
        private System.Windows.Forms.DataGridView dgResultUp;
        private System.Windows.Forms.Button btnShowUp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCityUp;
        private System.Windows.Forms.TextBox txtNrcUp;
        private System.Windows.Forms.TextBox txtNameUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgResultDel;
        private System.Windows.Forms.Button btnShowDel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCityDel;
        private System.Windows.Forms.TextBox txtNrcDel;
        private System.Windows.Forms.TextBox txtNameDel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

