﻿namespace WerewolfClient
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn2Player = new System.Windows.Forms.Button();
            this.Btn4Player = new System.Windows.Forms.Button();
            this.Btn16Player = new System.Windows.Forms.Button();
            this.TBServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // TbLogin
            // 
            this.TbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLogin.Location = new System.Drawing.Point(347, 310);
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.Size = new System.Drawing.Size(273, 29);
            this.TbLogin.TabIndex = 2;
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(347, 354);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(273, 29);
            this.TbPassword.TabIndex = 3;
            this.TbPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TbPassword_PreviewKeyDown);
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.Location = new System.Drawing.Point(526, 460);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(94, 45);
            this.BtnSignIn.TabIndex = 4;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = true;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.Location = new System.Drawing.Point(347, 460);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(94, 45);
            this.BtnSignUp.TabIndex = 5;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(440, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Btn2Player
            // 
            this.Btn2Player.Location = new System.Drawing.Point(298, 153);
            this.Btn2Player.Name = "Btn2Player";
            this.Btn2Player.Size = new System.Drawing.Size(88, 52);
            this.Btn2Player.TabIndex = 9;
            this.Btn2Player.Text = "2 Player";
            this.Btn2Player.UseVisualStyleBackColor = true;
            this.Btn2Player.Click += new System.EventHandler(this.Btn2Player_Click);
            // 
            // Btn4Player
            // 
            this.Btn4Player.Location = new System.Drawing.Point(440, 153);
            this.Btn4Player.Name = "Btn4Player";
            this.Btn4Player.Size = new System.Drawing.Size(100, 52);
            this.Btn4Player.TabIndex = 10;
            this.Btn4Player.Text = "4 Player";
            this.Btn4Player.UseVisualStyleBackColor = true;
            this.Btn4Player.Click += new System.EventHandler(this.Btn4Player_Click);
            // 
            // Btn16Player
            // 
            this.Btn16Player.Location = new System.Drawing.Point(616, 153);
            this.Btn16Player.Name = "Btn16Player";
            this.Btn16Player.Size = new System.Drawing.Size(82, 54);
            this.Btn16Player.TabIndex = 11;
            this.Btn16Player.Text = "16 Player";
            this.Btn16Player.UseVisualStyleBackColor = true;
            this.Btn16Player.Click += new System.EventHandler(this.Btn16Player_Click);
            // 
            // TBServer
            // 
            this.TBServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBServer.Location = new System.Drawing.Point(347, 270);
            this.TBServer.Name = "TBServer";
            this.TBServer.Size = new System.Drawing.Size(273, 29);
            this.TBServer.TabIndex = 8;
            this.TBServer.Text = "http://localhost:2343/werewolf/";
            this.TBServer.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "API Address";
            this.label3.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn16Player);
            this.groupBox1.Controls.Add(this.Btn4Player);
            this.groupBox1.Controls.Add(this.Btn2Player);
            this.groupBox1.Controls.Add(this.TBServer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.BtnSignUp);
            this.groupBox1.Controls.Add(this.BtnSignIn);
            this.groupBox1.Controls.Add(this.TbPassword);
            this.groupBox1.Controls.Add(this.TbLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 704);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1024, 724);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 685);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn2Player;
        private System.Windows.Forms.Button Btn4Player;
        private System.Windows.Forms.Button Btn16Player;
        private System.Windows.Forms.TextBox TBServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}