namespace Kvíz_WinForm
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
            this.txtbA = new System.Windows.Forms.TextBox();
            this.txtbB = new System.Windows.Forms.TextBox();
            this.txtbC = new System.Windows.Forms.TextBox();
            this.txtbD = new System.Windows.Forms.TextBox();
            this.rtbKerdes = new System.Windows.Forms.RichTextBox();
            this.btnFelezes = new System.Windows.Forms.Button();
            this.btnKozonseg = new System.Windows.Forms.Button();
            this.btnTelefon = new System.Windows.Forms.Button();
            this.rtbSegitseg = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAValasz = new System.Windows.Forms.Button();
            this.btnBValasz = new System.Windows.Forms.Button();
            this.btnCValasz = new System.Windows.Forms.Button();
            this.btnDValasz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbA
            // 
            this.txtbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbA.Location = new System.Drawing.Point(66, 203);
            this.txtbA.Name = "txtbA";
            this.txtbA.Size = new System.Drawing.Size(177, 24);
            this.txtbA.TabIndex = 0;
            this.txtbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbB
            // 
            this.txtbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbB.Location = new System.Drawing.Point(310, 203);
            this.txtbB.Name = "txtbB";
            this.txtbB.Size = new System.Drawing.Size(177, 24);
            this.txtbB.TabIndex = 1;
            this.txtbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbC
            // 
            this.txtbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbC.Location = new System.Drawing.Point(540, 203);
            this.txtbC.Name = "txtbC";
            this.txtbC.Size = new System.Drawing.Size(177, 24);
            this.txtbC.TabIndex = 2;
            this.txtbC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbD
            // 
            this.txtbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbD.Location = new System.Drawing.Point(771, 203);
            this.txtbD.Name = "txtbD";
            this.txtbD.Size = new System.Drawing.Size(177, 24);
            this.txtbD.TabIndex = 3;
            this.txtbD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbKerdes
            // 
            this.rtbKerdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbKerdes.Location = new System.Drawing.Point(66, 77);
            this.rtbKerdes.Name = "rtbKerdes";
            this.rtbKerdes.Size = new System.Drawing.Size(882, 96);
            this.rtbKerdes.TabIndex = 8;
            this.rtbKerdes.Text = "";
            // 
            // btnFelezes
            // 
            this.btnFelezes.Location = new System.Drawing.Point(114, 309);
            this.btnFelezes.Name = "btnFelezes";
            this.btnFelezes.Size = new System.Drawing.Size(141, 23);
            this.btnFelezes.TabIndex = 9;
            this.btnFelezes.Text = "Felezés";
            this.btnFelezes.UseVisualStyleBackColor = true;
            this.btnFelezes.Click += new System.EventHandler(this.btnFelezes_Click);
            // 
            // btnKozonseg
            // 
            this.btnKozonseg.Location = new System.Drawing.Point(114, 350);
            this.btnKozonseg.Name = "btnKozonseg";
            this.btnKozonseg.Size = new System.Drawing.Size(141, 23);
            this.btnKozonseg.TabIndex = 10;
            this.btnKozonseg.Text = "Közönség";
            this.btnKozonseg.UseVisualStyleBackColor = true;
            this.btnKozonseg.Click += new System.EventHandler(this.btnKozonseg_Click);
            // 
            // btnTelefon
            // 
            this.btnTelefon.Location = new System.Drawing.Point(114, 396);
            this.btnTelefon.Name = "btnTelefon";
            this.btnTelefon.Size = new System.Drawing.Size(141, 23);
            this.btnTelefon.TabIndex = 11;
            this.btnTelefon.Text = "Telefonos segítség";
            this.btnTelefon.UseVisualStyleBackColor = true;
            this.btnTelefon.Click += new System.EventHandler(this.btnTelefon_Click);
            // 
            // rtbSegitseg
            // 
            this.rtbSegitseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbSegitseg.Location = new System.Drawing.Point(288, 311);
            this.rtbSegitseg.Name = "rtbSegitseg";
            this.rtbSegitseg.Size = new System.Drawing.Size(666, 108);
            this.rtbSegitseg.TabIndex = 12;
            this.rtbSegitseg.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // btnAValasz
            // 
            this.btnAValasz.Location = new System.Drawing.Point(113, 246);
            this.btnAValasz.Name = "btnAValasz";
            this.btnAValasz.Size = new System.Drawing.Size(75, 23);
            this.btnAValasz.TabIndex = 18;
            this.btnAValasz.Text = "A";
            this.btnAValasz.UseVisualStyleBackColor = true;
            this.btnAValasz.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // btnBValasz
            // 
            this.btnBValasz.Location = new System.Drawing.Point(366, 246);
            this.btnBValasz.Name = "btnBValasz";
            this.btnBValasz.Size = new System.Drawing.Size(75, 23);
            this.btnBValasz.TabIndex = 19;
            this.btnBValasz.Text = "B";
            this.btnBValasz.UseVisualStyleBackColor = true;
            this.btnBValasz.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // btnCValasz
            // 
            this.btnCValasz.Location = new System.Drawing.Point(588, 246);
            this.btnCValasz.Name = "btnCValasz";
            this.btnCValasz.Size = new System.Drawing.Size(75, 23);
            this.btnCValasz.TabIndex = 20;
            this.btnCValasz.Text = "C";
            this.btnCValasz.UseVisualStyleBackColor = true;
            this.btnCValasz.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // btnDValasz
            // 
            this.btnDValasz.Location = new System.Drawing.Point(822, 246);
            this.btnDValasz.Name = "btnDValasz";
            this.btnDValasz.Size = new System.Drawing.Size(75, 23);
            this.btnDValasz.TabIndex = 21;
            this.btnDValasz.Text = "D";
            this.btnDValasz.UseVisualStyleBackColor = true;
            this.btnDValasz.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(978, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(273, 342);
            this.dataGridView1.TabIndex = 24;
            // 
            // s
            // 
            this.s.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.s.HeaderText = " ";
            this.s.Name = "s";
            this.s.Width = 21;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Nyereményösszege";
            this.Column1.Name = "Column1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDValasz);
            this.Controls.Add(this.btnCValasz);
            this.Controls.Add(this.btnBValasz);
            this.Controls.Add(this.btnAValasz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbSegitseg);
            this.Controls.Add(this.btnTelefon);
            this.Controls.Add(this.btnKozonseg);
            this.Controls.Add(this.btnFelezes);
            this.Controls.Add(this.rtbKerdes);
            this.Controls.Add(this.txtbD);
            this.Controls.Add(this.txtbC);
            this.Controls.Add(this.txtbB);
            this.Controls.Add(this.txtbA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbA;
        private System.Windows.Forms.TextBox txtbB;
        private System.Windows.Forms.TextBox txtbC;
        private System.Windows.Forms.TextBox txtbD;
        private System.Windows.Forms.RichTextBox rtbKerdes;
        private System.Windows.Forms.Button btnFelezes;
        private System.Windows.Forms.Button btnKozonseg;
        private System.Windows.Forms.Button btnTelefon;
        private System.Windows.Forms.RichTextBox rtbSegitseg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAValasz;
        private System.Windows.Forms.Button btnBValasz;
        private System.Windows.Forms.Button btnCValasz;
        private System.Windows.Forms.Button btnDValasz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn s;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

