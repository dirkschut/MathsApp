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
            // MathsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
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

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.PictureBox pb_Github;
        private System.Windows.Forms.Panel pn_Title;
        private System.Windows.Forms.Label lbl_Title;
    }
}

