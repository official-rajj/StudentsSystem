namespace StudentsSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblbranch = new System.Windows.Forms.Label();
            this.lblsem = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.grpgender = new System.Windows.Forms.GroupBox();
            this.rbtnfemale = new System.Windows.Forms.RadioButton();
            this.rbtnmale = new System.Windows.Forms.RadioButton();
            this.grpchoice = new System.Windows.Forms.GroupBox();
            this.rbtnc = new System.Windows.Forms.RadioButton();
            this.rbtnnet = new System.Windows.Forms.RadioButton();
            this.btnregis = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtbranch = new System.Windows.Forms.TextBox();
            this.txtsem = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.btndisplay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpgender.SuspendLayout();
            this.grpchoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENTS  RECORDS ";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(84, 98);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(20, 16);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(84, 152);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(46, 16);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "NAME";
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.Location = new System.Drawing.Point(84, 215);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(64, 16);
            this.lblbranch.TabIndex = 3;
            this.lblbranch.Text = "BRANCH";
            // 
            // lblsem
            // 
            this.lblsem.AutoSize = true;
            this.lblsem.Location = new System.Drawing.Point(84, 275);
            this.lblsem.Name = "lblsem";
            this.lblsem.Size = new System.Drawing.Size(82, 16);
            this.lblsem.TabIndex = 4;
            this.lblsem.Text = "SEMESTER";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(84, 324);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(37, 16);
            this.lblcity.TabIndex = 5;
            this.lblcity.Text = "CITY";
            // 
            // grpgender
            // 
            this.grpgender.Controls.Add(this.rbtnfemale);
            this.grpgender.Controls.Add(this.rbtnmale);
            this.grpgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpgender.Location = new System.Drawing.Point(72, 375);
            this.grpgender.Name = "grpgender";
            this.grpgender.Size = new System.Drawing.Size(193, 103);
            this.grpgender.TabIndex = 6;
            this.grpgender.TabStop = false;
            this.grpgender.Text = "Gender";
            // 
            // rbtnfemale
            // 
            this.rbtnfemale.AutoSize = true;
            this.rbtnfemale.Location = new System.Drawing.Point(31, 66);
            this.rbtnfemale.Name = "rbtnfemale";
            this.rbtnfemale.Size = new System.Drawing.Size(78, 22);
            this.rbtnfemale.TabIndex = 7;
            this.rbtnfemale.TabStop = true;
            this.rbtnfemale.Text = "Female";
            this.rbtnfemale.UseVisualStyleBackColor = true;
            // 
            // rbtnmale
            // 
            this.rbtnmale.AutoSize = true;
            this.rbtnmale.Location = new System.Drawing.Point(31, 23);
            this.rbtnmale.Name = "rbtnmale";
            this.rbtnmale.Size = new System.Drawing.Size(61, 22);
            this.rbtnmale.TabIndex = 0;
            this.rbtnmale.TabStop = true;
            this.rbtnmale.Text = "Male";
            this.rbtnmale.UseVisualStyleBackColor = true;
            // 
            // grpchoice
            // 
            this.grpchoice.Controls.Add(this.rbtnc);
            this.grpchoice.Controls.Add(this.rbtnnet);
            this.grpchoice.Location = new System.Drawing.Point(71, 502);
            this.grpchoice.Name = "grpchoice";
            this.grpchoice.Size = new System.Drawing.Size(200, 100);
            this.grpchoice.TabIndex = 7;
            this.grpchoice.TabStop = false;
            this.grpchoice.Text = "Choice";
            // 
            // rbtnc
            // 
            this.rbtnc.AutoSize = true;
            this.rbtnc.Location = new System.Drawing.Point(16, 58);
            this.rbtnc.Name = "rbtnc";
            this.rbtnc.Size = new System.Drawing.Size(44, 20);
            this.rbtnc.TabIndex = 8;
            this.rbtnc.TabStop = true;
            this.rbtnc.Text = "C#";
            this.rbtnc.UseVisualStyleBackColor = true;
            // 
            // rbtnnet
            // 
            this.rbtnnet.AutoSize = true;
            this.rbtnnet.Location = new System.Drawing.Point(16, 21);
            this.rbtnnet.Name = "rbtnnet";
            this.rbtnnet.Size = new System.Drawing.Size(86, 20);
            this.rbtnnet.TabIndex = 0;
            this.rbtnnet.TabStop = true;
            this.rbtnnet.Text = "ASP.NET";
            this.rbtnnet.UseVisualStyleBackColor = true;
            // 
            // btnregis
            // 
            this.btnregis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregis.Location = new System.Drawing.Point(72, 636);
            this.btnregis.Name = "btnregis";
            this.btnregis.Size = new System.Drawing.Size(118, 35);
            this.btnregis.TabIndex = 8;
            this.btnregis.Text = "Register";
            this.btnregis.UseVisualStyleBackColor = true;
            this.btnregis.Click += new System.EventHandler(this.btnregis_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(213, 636);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(118, 35);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(364, 636);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(118, 35);
            this.btndel.TabIndex = 10;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Location = new System.Drawing.Point(227, 92);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(140, 22);
            this.txtid.TabIndex = 11;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(227, 152);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(140, 22);
            this.txtname.TabIndex = 12;
            // 
            // txtbranch
            // 
            this.txtbranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbranch.Location = new System.Drawing.Point(227, 215);
            this.txtbranch.Name = "txtbranch";
            this.txtbranch.Size = new System.Drawing.Size(140, 22);
            this.txtbranch.TabIndex = 13;
            // 
            // txtsem
            // 
            this.txtsem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsem.Location = new System.Drawing.Point(227, 275);
            this.txtsem.Name = "txtsem";
            this.txtsem.Size = new System.Drawing.Size(140, 22);
            this.txtsem.TabIndex = 14;
            // 
            // txtcity
            // 
            this.txtcity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcity.Location = new System.Drawing.Point(227, 324);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(140, 22);
            this.txtcity.TabIndex = 15;
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(561, 535);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(129, 45);
            this.btndisplay.TabIndex = 16;
            this.btndisplay.Text = "Display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(414, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(370, 323);
            this.dataGridView1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(796, 683);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtsem);
            this.Controls.Add(this.txtbranch);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnregis);
            this.Controls.Add(this.grpchoice);
            this.Controls.Add(this.grpgender);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.lblsem);
            this.Controls.Add(this.lblbranch);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "REGISTER PAGE";
            this.grpgender.ResumeLayout(false);
            this.grpgender.PerformLayout();
            this.grpchoice.ResumeLayout(false);
            this.grpchoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.Label lblsem;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.GroupBox grpgender;
        private System.Windows.Forms.RadioButton rbtnfemale;
        private System.Windows.Forms.RadioButton rbtnmale;
        private System.Windows.Forms.GroupBox grpchoice;
        private System.Windows.Forms.RadioButton rbtnc;
        private System.Windows.Forms.RadioButton rbtnnet;
        private System.Windows.Forms.Button btnregis;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtbranch;
        private System.Windows.Forms.TextBox txtsem;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

