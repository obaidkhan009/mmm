
namespace calculator
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.ndot = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.nequal = new System.Windows.Forms.Button();
            this.nplus = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.nminus = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.nmultiply = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.ndivide = new System.Windows.Forms.Button();
            this.nc = new System.Windows.Forms.Button();
            this.nce = new System.Windows.Forms.Button();
            this.lcurrentOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 47);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(412, 92);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ndot
            // 
            this.ndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndot.Location = new System.Drawing.Point(12, 537);
            this.ndot.Name = "ndot";
            this.ndot.Size = new System.Drawing.Size(98, 92);
            this.ndot.TabIndex = 14;
            this.ndot.Text = ".";
            this.ndot.UseVisualStyleBackColor = true;
            this.ndot.Click += new System.EventHandler(this.n_click);
            // 
            // n0
            // 
            this.n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(116, 537);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(98, 92);
            this.n0.TabIndex = 16;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n_click);
            // 
            // nequal
            // 
            this.nequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nequal.Location = new System.Drawing.Point(220, 537);
            this.nequal.Name = "nequal";
            this.nequal.Size = new System.Drawing.Size(202, 92);
            this.nequal.TabIndex = 17;
            this.nequal.Text = "=";
            this.nequal.UseVisualStyleBackColor = true;
            this.nequal.Click += new System.EventHandler(this.nequal_Click);
            // 
            // nplus
            // 
            this.nplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nplus.Location = new System.Drawing.Point(324, 439);
            this.nplus.Name = "nplus";
            this.nplus.Size = new System.Drawing.Size(98, 92);
            this.nplus.TabIndex = 21;
            this.nplus.Text = "+";
            this.nplus.UseVisualStyleBackColor = true;
            this.nplus.Click += new System.EventHandler(this.op_click);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(116, 439);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(98, 92);
            this.n2.TabIndex = 20;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n_click);
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(220, 439);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(98, 92);
            this.n3.TabIndex = 19;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n_click);
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(12, 439);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(98, 92);
            this.n1.TabIndex = 18;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n_click);
            // 
            // nminus
            // 
            this.nminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nminus.Location = new System.Drawing.Point(324, 341);
            this.nminus.Name = "nminus";
            this.nminus.Size = new System.Drawing.Size(98, 92);
            this.nminus.TabIndex = 25;
            this.nminus.Text = "-";
            this.nminus.UseVisualStyleBackColor = true;
            this.nminus.Click += new System.EventHandler(this.op_click);
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(116, 341);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(98, 92);
            this.n5.TabIndex = 24;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n_click);
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(220, 341);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(98, 92);
            this.n6.TabIndex = 23;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n_click);
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(12, 341);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(98, 92);
            this.n4.TabIndex = 22;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n_click);
            // 
            // nmultiply
            // 
            this.nmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmultiply.Location = new System.Drawing.Point(324, 243);
            this.nmultiply.Name = "nmultiply";
            this.nmultiply.Size = new System.Drawing.Size(98, 92);
            this.nmultiply.TabIndex = 29;
            this.nmultiply.Text = "*";
            this.nmultiply.UseVisualStyleBackColor = true;
            this.nmultiply.Click += new System.EventHandler(this.op_click);
            // 
            // n8
            // 
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(116, 243);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(98, 92);
            this.n8.TabIndex = 28;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n_click);
            // 
            // n9
            // 
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(220, 243);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(98, 92);
            this.n9.TabIndex = 27;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n_click);
            // 
            // n7
            // 
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(12, 243);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(98, 92);
            this.n7.TabIndex = 26;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n_click);
            // 
            // ndivide
            // 
            this.ndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndivide.Location = new System.Drawing.Point(324, 145);
            this.ndivide.Name = "ndivide";
            this.ndivide.Size = new System.Drawing.Size(98, 92);
            this.ndivide.TabIndex = 33;
            this.ndivide.Text = "/";
            this.ndivide.UseVisualStyleBackColor = true;
            this.ndivide.Click += new System.EventHandler(this.op_click);
            // 
            // nc
            // 
            this.nc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nc.Location = new System.Drawing.Point(12, 145);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(202, 92);
            this.nc.TabIndex = 32;
            this.nc.Text = "Clear";
            this.nc.UseVisualStyleBackColor = true;
            this.nc.Click += new System.EventHandler(this.nc_Click);
            // 
            // nce
            // 
            this.nce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nce.Location = new System.Drawing.Point(220, 145);
            this.nce.Name = "nce";
            this.nce.Size = new System.Drawing.Size(98, 92);
            this.nce.TabIndex = 31;
            this.nce.Text = "CE";
            this.nce.UseVisualStyleBackColor = true;
            this.nce.Click += new System.EventHandler(this.nce_Click);
            // 
            // lcurrentOp
            // 
            this.lcurrentOp.AutoSize = true;
            this.lcurrentOp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lcurrentOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcurrentOp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lcurrentOp.Location = new System.Drawing.Point(12, 9);
            this.lcurrentOp.Name = "lcurrentOp";
            this.lcurrentOp.Size = new System.Drawing.Size(0, 32);
            this.lcurrentOp.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(436, 634);
            this.Controls.Add(this.lcurrentOp);
            this.Controls.Add(this.ndivide);
            this.Controls.Add(this.nc);
            this.Controls.Add(this.nce);
            this.Controls.Add(this.nmultiply);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.nminus);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.nplus);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.nequal);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.ndot);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button ndot;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button nequal;
        private System.Windows.Forms.Button nplus;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button nminus;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button nmultiply;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button ndivide;
        private System.Windows.Forms.Button nc;
        private System.Windows.Forms.Button nce;
        private System.Windows.Forms.Label lcurrentOp;
    }
}

