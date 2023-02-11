namespace REMS
{
    partial class LoginForm1cs
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelErrorr = new System.Windows.Forms.Label();
            this.labelUsernameAstrikk = new System.Windows.Forms.Label();
            this.labelPasswordAstrikk = new System.Windows.Forms.Label();
            this.buttonLoginn = new System.Windows.Forms.Button();
            this.buttonshut = new System.Windows.Forms.Button();
            this.textBoxUsernamee = new System.Windows.Forms.TextBox();
            this.textBoxPasswordd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Agency FB", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(587, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 55);
            this.label4.TabIndex = 0;
            this.label4.Text = "USER LOGIN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(403, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "USERNAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(398, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 40);
            this.label6.TabIndex = 2;
            this.label6.Text = "PASSWORD";
            // 
            // labelErrorr
            // 
            this.labelErrorr.AutoSize = true;
            this.labelErrorr.BackColor = System.Drawing.Color.Black;
            this.labelErrorr.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorr.ForeColor = System.Drawing.Color.Red;
            this.labelErrorr.Location = new System.Drawing.Point(530, 336);
            this.labelErrorr.Name = "labelErrorr";
            this.labelErrorr.Size = new System.Drawing.Size(300, 36);
            this.labelErrorr.TabIndex = 3;
            this.labelErrorr.Text = "*INVALID USERNAME OR PASSWORD";
            this.labelErrorr.Visible = false;
            this.labelErrorr.Click += new System.EventHandler(this.labelErrorr_Click);
            // 
            // labelUsernameAstrikk
            // 
            this.labelUsernameAstrikk.AutoSize = true;
            this.labelUsernameAstrikk.BackColor = System.Drawing.Color.Transparent;
            this.labelUsernameAstrikk.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameAstrikk.ForeColor = System.Drawing.Color.Red;
            this.labelUsernameAstrikk.Location = new System.Drawing.Point(903, 163);
            this.labelUsernameAstrikk.Name = "labelUsernameAstrikk";
            this.labelUsernameAstrikk.Size = new System.Drawing.Size(30, 38);
            this.labelUsernameAstrikk.TabIndex = 4;
            this.labelUsernameAstrikk.Text = "*";
            this.labelUsernameAstrikk.Visible = false;
            this.labelUsernameAstrikk.Click += new System.EventHandler(this.labelUsernameAstrikk_Click);
            // 
            // labelPasswordAstrikk
            // 
            this.labelPasswordAstrikk.AutoSize = true;
            this.labelPasswordAstrikk.BackColor = System.Drawing.Color.Transparent;
            this.labelPasswordAstrikk.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordAstrikk.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordAstrikk.Location = new System.Drawing.Point(903, 268);
            this.labelPasswordAstrikk.Name = "labelPasswordAstrikk";
            this.labelPasswordAstrikk.Size = new System.Drawing.Size(30, 38);
            this.labelPasswordAstrikk.TabIndex = 5;
            this.labelPasswordAstrikk.Text = "*";
            this.labelPasswordAstrikk.Visible = false;
            // 
            // buttonLoginn
            // 
            this.buttonLoginn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoginn.FlatAppearance.BorderSize = 0;
            this.buttonLoginn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonLoginn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonLoginn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginn.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLoginn.Location = new System.Drawing.Point(615, 438);
            this.buttonLoginn.Name = "buttonLoginn";
            this.buttonLoginn.Size = new System.Drawing.Size(140, 47);
            this.buttonLoginn.TabIndex = 6;
            this.buttonLoginn.Text = "LOGIN";
            this.buttonLoginn.UseVisualStyleBackColor = false;
            this.buttonLoginn.Click += new System.EventHandler(this.buttonLoginn_Click);
            // 
            // buttonshut
            // 
            this.buttonshut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonshut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonshut.FlatAppearance.BorderSize = 0;
            this.buttonshut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonshut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonshut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonshut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonshut.Location = new System.Drawing.Point(1257, 12);
            this.buttonshut.Name = "buttonshut";
            this.buttonshut.Size = new System.Drawing.Size(59, 50);
            this.buttonshut.TabIndex = 7;
            this.buttonshut.Text = "x";
            this.buttonshut.UseVisualStyleBackColor = false;
            this.buttonshut.Click += new System.EventHandler(this.buttonshut_Click);
            // 
            // textBoxUsernamee
            // 
            this.textBoxUsernamee.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernamee.Location = new System.Drawing.Point(536, 158);
            this.textBoxUsernamee.Name = "textBoxUsernamee";
            this.textBoxUsernamee.Size = new System.Drawing.Size(361, 43);
            this.textBoxUsernamee.TabIndex = 8;
            this.textBoxUsernamee.Text = "user";
            // 
            // textBoxPasswordd
            // 
            this.textBoxPasswordd.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordd.Location = new System.Drawing.Point(547, 263);
            this.textBoxPasswordd.Name = "textBoxPasswordd";
            this.textBoxPasswordd.Size = new System.Drawing.Size(350, 43);
            this.textBoxPasswordd.TabIndex = 9;
            this.textBoxPasswordd.Text = "12345";
            // 
            // LoginForm1cs
            // 
            this.BackgroundImage = global::REMS.Properties.Resources.P1;
            this.ClientSize = new System.Drawing.Size(1317, 743);
            this.Controls.Add(this.textBoxPasswordd);
            this.Controls.Add(this.textBoxUsernamee);
            this.Controls.Add(this.buttonshut);
            this.Controls.Add(this.buttonLoginn);
            this.Controls.Add(this.labelPasswordAstrikk);
            this.Controls.Add(this.labelUsernameAstrikk);
            this.Controls.Add(this.labelErrorr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "LoginForm1cs";
            this.Load += new System.EventHandler(this.LoginForm1cs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelUsernameAstrik;
        private System.Windows.Forms.Label labelPasswordAstrik;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelErrorr;
        private System.Windows.Forms.Label labelUsernameAstrikk;
        private System.Windows.Forms.Label labelPasswordAstrikk;
        private System.Windows.Forms.Button buttonLoginn;
        private System.Windows.Forms.Button buttonshut;
        private System.Windows.Forms.TextBox textBoxUsernamee;
        private System.Windows.Forms.TextBox textBoxPasswordd;
    }
}