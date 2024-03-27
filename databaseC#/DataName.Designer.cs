namespace databaseC_
{
    partial class DataName
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
            this.components = new System.ComponentModel.Container();
            this.textid = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textFirst = new System.Windows.Forms.TextBox();
            this.textLast = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtSimpan = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.Button();
            this.DataNama = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataNama)).BeginInit();
            this.SuspendLayout();
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(291, 12);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(92, 22);
            this.textid.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textFirst
            // 
            this.textFirst.Location = new System.Drawing.Point(291, 54);
            this.textFirst.Name = "textFirst";
            this.textFirst.Size = new System.Drawing.Size(240, 22);
            this.textFirst.TabIndex = 2;
            // 
            // textLast
            // 
            this.textLast.Location = new System.Drawing.Point(291, 99);
            this.textLast.Name = "textLast";
            this.textLast.Size = new System.Drawing.Size(240, 22);
            this.textLast.TabIndex = 3;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(291, 157);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(240, 22);
            this.textEmail.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(170, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(20, 16);
            this.txtId.TabIndex = 5;
            this.txtId.Text = "ID";
            // 
            // txtLast
            // 
            this.txtLast.AutoSize = true;
            this.txtLast.Location = new System.Drawing.Point(170, 114);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(69, 16);
            this.txtLast.TabIndex = 6;
            this.txtLast.Text = "LastName";
            // 
            // txtFirst
            // 
            this.txtFirst.AutoSize = true;
            this.txtFirst.Location = new System.Drawing.Point(170, 60);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(69, 16);
            this.txtFirst.TabIndex = 7;
            this.txtFirst.Text = "FirstName";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(170, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(41, 16);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "Email";
            // 
            // txtSimpan
            // 
            this.txtSimpan.Location = new System.Drawing.Point(276, 233);
            this.txtSimpan.Name = "txtSimpan";
            this.txtSimpan.Size = new System.Drawing.Size(139, 23);
            this.txtSimpan.TabIndex = 9;
            this.txtSimpan.Text = "Simpan Data";
            this.txtSimpan.UseVisualStyleBackColor = true;
            this.txtSimpan.Click += new System.EventHandler(this.txtSimpan_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(308, 302);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(75, 23);
            this.txtUpdate.TabIndex = 10;
            this.txtUpdate.Text = "Update";
            this.txtUpdate.UseVisualStyleBackColor = true;
            this.txtUpdate.Click += new System.EventHandler(this.txtUpdate_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(308, 357);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(75, 23);
            this.txtDelete.TabIndex = 11;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // DataNama
            // 
            this.DataNama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNama.Location = new System.Drawing.Point(600, 12);
            this.DataNama.Name = "DataNama";
            this.DataNama.RowHeadersWidth = 51;
            this.DataNama.RowTemplate.Height = 24;
            this.DataNama.Size = new System.Drawing.Size(601, 394);
            this.DataNama.TabIndex = 12;
            this.DataNama.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNama_CellClick);
            this.DataNama.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 450);
            this.Controls.Add(this.DataNama);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.txtSimpan);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textLast);
            this.Controls.Add(this.textFirst);
            this.Controls.Add(this.textid);
            this.Name = "DataName";
            this.Text = "DataName";
            ((System.ComponentModel.ISupportInitialize)(this.DataNama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textFirst;
        private System.Windows.Forms.TextBox textLast;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label txtLast;
        private System.Windows.Forms.Label txtFirst;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Button txtSimpan;
        private System.Windows.Forms.Button txtUpdate;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.DataGridView DataNama;
    }
}