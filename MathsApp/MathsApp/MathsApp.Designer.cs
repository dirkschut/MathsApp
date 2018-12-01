namespace MathsApp
{
    partial class MathsApp
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.pb_Github = new System.Windows.Forms.PictureBox();
            this.pn_Title = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tb_Decimal = new System.Windows.Forms.TextBox();
            this.lbl_Decimal = new System.Windows.Forms.Label();
            this.lbl_Hexadecimal = new System.Windows.Forms.Label();
            this.tb_Hexadecimal = new System.Windows.Forms.TextBox();
            this.lbl_Binary = new System.Windows.Forms.Label();
            this.tb_Binary = new System.Windows.Forms.TextBox();
            this.lbl_Latin = new System.Windows.Forms.Label();
            this.tb_Latin = new System.Windows.Forms.TextBox();
            this.lbl_Conversion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Github)).BeginInit();
            this.pn_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(746, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(55, 32);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pb_Github
            // 
            this.pb_Github.BackgroundImage = global::MathsApp.Properties.Resources.github;
            this.pb_Github.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Github.InitialImage = null;
            this.pb_Github.Location = new System.Drawing.Point(711, 0);
            this.pb_Github.Name = "pb_Github";
            this.pb_Github.Size = new System.Drawing.Size(32, 32);
            this.pb_Github.TabIndex = 1;
            this.pb_Github.TabStop = false;
            this.pb_Github.Click += new System.EventHandler(this.pb_Github_Click);
            // 
            // pn_Title
            // 
            this.pn_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pn_Title.Controls.Add(this.lbl_Title);
            this.pn_Title.Location = new System.Drawing.Point(-1, 41);
            this.pn_Title.Name = "pn_Title";
            this.pn_Title.Size = new System.Drawing.Size(510, 44);
            this.pn_Title.TabIndex = 2;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(19, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(164, 36);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Maths App";
            // 
            // tb_Decimal
            // 
            this.tb_Decimal.Location = new System.Drawing.Point(111, 125);
            this.tb_Decimal.Name = "tb_Decimal";
            this.tb_Decimal.Size = new System.Drawing.Size(100, 20);
            this.tb_Decimal.TabIndex = 3;
            this.tb_Decimal.Text = "0";
            // 
            // lbl_Decimal
            // 
            this.lbl_Decimal.AutoSize = true;
            this.lbl_Decimal.Location = new System.Drawing.Point(21, 128);
            this.lbl_Decimal.Name = "lbl_Decimal";
            this.lbl_Decimal.Size = new System.Drawing.Size(45, 13);
            this.lbl_Decimal.TabIndex = 4;
            this.lbl_Decimal.Text = "Decimal";
            // 
            // lbl_Hexadecimal
            // 
            this.lbl_Hexadecimal.AutoSize = true;
            this.lbl_Hexadecimal.Location = new System.Drawing.Point(21, 154);
            this.lbl_Hexadecimal.Name = "lbl_Hexadecimal";
            this.lbl_Hexadecimal.Size = new System.Drawing.Size(68, 13);
            this.lbl_Hexadecimal.TabIndex = 6;
            this.lbl_Hexadecimal.Text = "Hexadecimal";
            // 
            // tb_Hexadecimal
            // 
            this.tb_Hexadecimal.Enabled = false;
            this.tb_Hexadecimal.Location = new System.Drawing.Point(111, 151);
            this.tb_Hexadecimal.Name = "tb_Hexadecimal";
            this.tb_Hexadecimal.Size = new System.Drawing.Size(100, 20);
            this.tb_Hexadecimal.TabIndex = 5;
            this.tb_Hexadecimal.Text = "0";
            // 
            // lbl_Binary
            // 
            this.lbl_Binary.AutoSize = true;
            this.lbl_Binary.Location = new System.Drawing.Point(21, 180);
            this.lbl_Binary.Name = "lbl_Binary";
            this.lbl_Binary.Size = new System.Drawing.Size(36, 13);
            this.lbl_Binary.TabIndex = 8;
            this.lbl_Binary.Text = "Binary";
            // 
            // tb_Binary
            // 
            this.tb_Binary.Enabled = false;
            this.tb_Binary.Location = new System.Drawing.Point(111, 177);
            this.tb_Binary.Name = "tb_Binary";
            this.tb_Binary.Size = new System.Drawing.Size(100, 20);
            this.tb_Binary.TabIndex = 7;
            this.tb_Binary.Text = "0";
            // 
            // lbl_Latin
            // 
            this.lbl_Latin.AutoSize = true;
            this.lbl_Latin.Location = new System.Drawing.Point(21, 206);
            this.lbl_Latin.Name = "lbl_Latin";
            this.lbl_Latin.Size = new System.Drawing.Size(30, 13);
            this.lbl_Latin.TabIndex = 10;
            this.lbl_Latin.Text = "Latin";
            // 
            // tb_Latin
            // 
            this.tb_Latin.Enabled = false;
            this.tb_Latin.Location = new System.Drawing.Point(111, 203);
            this.tb_Latin.Name = "tb_Latin";
            this.tb_Latin.Size = new System.Drawing.Size(100, 20);
            this.tb_Latin.TabIndex = 9;
            this.tb_Latin.Text = "0";
            // 
            // lbl_Conversion
            // 
            this.lbl_Conversion.AutoSize = true;
            this.lbl_Conversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Conversion.Location = new System.Drawing.Point(19, 97);
            this.lbl_Conversion.Name = "lbl_Conversion";
            this.lbl_Conversion.Size = new System.Drawing.Size(121, 25);
            this.lbl_Conversion.TabIndex = 11;
            this.lbl_Conversion.Text = "Conversion";
            // 
            // MathsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Conversion);
            this.Controls.Add(this.lbl_Latin);
            this.Controls.Add(this.tb_Latin);
            this.Controls.Add(this.lbl_Binary);
            this.Controls.Add(this.tb_Binary);
            this.Controls.Add(this.lbl_Hexadecimal);
            this.Controls.Add(this.tb_Hexadecimal);
            this.Controls.Add(this.lbl_Decimal);
            this.Controls.Add(this.tb_Decimal);
            this.Controls.Add(this.pn_Title);
            this.Controls.Add(this.pb_Github);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MathsApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maths Application";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Github)).EndInit();
            this.pn_Title.ResumeLayout(false);
            this.pn_Title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.PictureBox pb_Github;
        private System.Windows.Forms.Panel pn_Title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox tb_Decimal;
        private System.Windows.Forms.Label lbl_Decimal;
        private System.Windows.Forms.Label lbl_Hexadecimal;
        private System.Windows.Forms.TextBox tb_Hexadecimal;
        private System.Windows.Forms.Label lbl_Binary;
        private System.Windows.Forms.TextBox tb_Binary;
        private System.Windows.Forms.Label lbl_Latin;
        private System.Windows.Forms.TextBox tb_Latin;
        private System.Windows.Forms.Label lbl_Conversion;
    }
}

