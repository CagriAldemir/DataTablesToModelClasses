namespace Data_to_Class
{
    partial class MainForm
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
            this.cmbDatabaseName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConnectAndGetTableNames = new System.Windows.Forms.Button();
            this.cmbConvertLanguage = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConvertAndSave = new System.Windows.Forms.Button();
            this.lstTableNames = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTabloSayisi = new System.Windows.Forms.Label();
            this.lblSavePath = new System.Windows.Forms.TextBox();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.panelSave = new System.Windows.Forms.Panel();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.panelSave.SuspendLayout();
            this.panelConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDatabaseName
            // 
            this.cmbDatabaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabaseName.FormattingEnabled = true;
            this.cmbDatabaseName.Items.AddRange(new object[] {
            "MSSQL"});
            this.cmbDatabaseName.Location = new System.Drawing.Point(102, 2);
            this.cmbDatabaseName.Name = "cmbDatabaseName";
            this.cmbDatabaseName.Size = new System.Drawing.Size(180, 21);
            this.cmbDatabaseName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "VERİTABANI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SUNUCU ADRESİ:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(102, 29);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(180, 20);
            this.txtServerName.TabIndex = 3;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(102, 55);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(180, 20);
            this.txtDatabaseName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "VERİTABANI ADI:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(102, 81);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(180, 20);
            this.txtUserName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "KULLANICI ADI:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(102, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ŞİFRE:";
            // 
            // btnConnectAndGetTableNames
            // 
            this.btnConnectAndGetTableNames.Location = new System.Drawing.Point(102, 133);
            this.btnConnectAndGetTableNames.Name = "btnConnectAndGetTableNames";
            this.btnConnectAndGetTableNames.Size = new System.Drawing.Size(180, 23);
            this.btnConnectAndGetTableNames.TabIndex = 10;
            this.btnConnectAndGetTableNames.Text = "BAĞLAN VE TABLOLARI GETİR";
            this.btnConnectAndGetTableNames.UseVisualStyleBackColor = true;
            this.btnConnectAndGetTableNames.Click += new System.EventHandler(this.btnConnectAndGetTableNames_Click);
            // 
            // cmbConvertLanguage
            // 
            this.cmbConvertLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConvertLanguage.FormattingEnabled = true;
            this.cmbConvertLanguage.Items.AddRange(new object[] {
            "C#",
            "VB.NET",
            "JAVA"});
            this.cmbConvertLanguage.Location = new System.Drawing.Point(99, 36);
            this.cmbConvertLanguage.Name = "cmbConvertLanguage";
            this.cmbConvertLanguage.Size = new System.Drawing.Size(174, 21);
            this.cmbConvertLanguage.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "ÇEVRİLECEK DİL:";
            // 
            // btnConvertAndSave
            // 
            this.btnConvertAndSave.Location = new System.Drawing.Point(99, 69);
            this.btnConvertAndSave.Name = "btnConvertAndSave";
            this.btnConvertAndSave.Size = new System.Drawing.Size(174, 21);
            this.btnConvertAndSave.TabIndex = 18;
            this.btnConvertAndSave.Text = "ÇEVİR VE KAYDET";
            this.btnConvertAndSave.UseVisualStyleBackColor = true;
            this.btnConvertAndSave.Click += new System.EventHandler(this.btnConvertAndSave_Click);
            // 
            // lstTableNames
            // 
            this.lstTableNames.FormattingEnabled = true;
            this.lstTableNames.Location = new System.Drawing.Point(330, 25);
            this.lstTableNames.Name = "lstTableNames";
            this.lstTableNames.Size = new System.Drawing.Size(282, 342);
            this.lstTableNames.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "TABLO İSİMLERİ:";
            // 
            // lblTabloSayisi
            // 
            this.lblTabloSayisi.AutoSize = true;
            this.lblTabloSayisi.Location = new System.Drawing.Point(509, 9);
            this.lblTabloSayisi.Name = "lblTabloSayisi";
            this.lblTabloSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblTabloSayisi.TabIndex = 21;
            // 
            // lblSavePath
            // 
            this.lblSavePath.BackColor = System.Drawing.Color.White;
            this.lblSavePath.Location = new System.Drawing.Point(0, 0);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.ReadOnly = true;
            this.lblSavePath.Size = new System.Drawing.Size(241, 20);
            this.lblSavePath.TabIndex = 22;
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(247, 0);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(26, 20);
            this.btnChoosePath.TabIndex = 23;
            this.btnChoosePath.Text = "...";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // panelSave
            // 
            this.panelSave.Controls.Add(this.cmbConvertLanguage);
            this.panelSave.Controls.Add(this.btnChoosePath);
            this.panelSave.Controls.Add(this.label7);
            this.panelSave.Controls.Add(this.lblSavePath);
            this.panelSave.Controls.Add(this.btnConvertAndSave);
            this.panelSave.Location = new System.Drawing.Point(8, 208);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(301, 159);
            this.panelSave.TabIndex = 24;
            this.panelSave.Visible = false;
            // 
            // panelConnection
            // 
            this.panelConnection.Controls.Add(this.label1);
            this.panelConnection.Controls.Add(this.cmbDatabaseName);
            this.panelConnection.Controls.Add(this.label2);
            this.panelConnection.Controls.Add(this.txtServerName);
            this.panelConnection.Controls.Add(this.btnConnectAndGetTableNames);
            this.panelConnection.Controls.Add(this.label3);
            this.panelConnection.Controls.Add(this.txtPassword);
            this.panelConnection.Controls.Add(this.txtDatabaseName);
            this.panelConnection.Controls.Add(this.label5);
            this.panelConnection.Controls.Add(this.label4);
            this.panelConnection.Controls.Add(this.txtUserName);
            this.panelConnection.Location = new System.Drawing.Point(8, 5);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(301, 181);
            this.panelConnection.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 376);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.lblTabloSayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstTableNames);
            this.Controls.Add(this.panelConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Tables to Model Classes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            this.panelConnection.ResumeLayout(false);
            this.panelConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDatabaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConnectAndGetTableNames;
        private System.Windows.Forms.ComboBox cmbConvertLanguage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConvertAndSave;
        private System.Windows.Forms.ListBox lstTableNames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTabloSayisi;
        private System.Windows.Forms.TextBox lblSavePath;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.Panel panelConnection;
    }
}

