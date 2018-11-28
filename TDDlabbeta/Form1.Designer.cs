namespace TDDlabbeta
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
            this.components = new System.ComponentModel.Container();
            this.AddButton = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.loginerr = new System.Windows.Forms.Label();
            this.passerr = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.patherr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(15, 64);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddUser);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(63, 12);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(197, 20);
            this.login.TabIndex = 1;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(63, 38);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(197, 20);
            this.pass.TabIndex = 2;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // loginerr
            // 
            this.loginerr.AutoSize = true;
            this.loginerr.BackColor = System.Drawing.Color.Transparent;
            this.loginerr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginerr.ForeColor = System.Drawing.Color.Red;
            this.loginerr.Location = new System.Drawing.Point(246, 15);
            this.loginerr.Name = "loginerr";
            this.loginerr.Size = new System.Drawing.Size(11, 13);
            this.loginerr.TabIndex = 5;
            this.loginerr.Text = "!";
            this.loginerr.Visible = false;
            // 
            // passerr
            // 
            this.passerr.AutoSize = true;
            this.passerr.BackColor = System.Drawing.Color.Transparent;
            this.passerr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passerr.ForeColor = System.Drawing.Color.Red;
            this.passerr.Location = new System.Drawing.Point(246, 41);
            this.passerr.Name = "passerr";
            this.passerr.Size = new System.Drawing.Size(11, 13);
            this.passerr.TabIndex = 6;
            this.passerr.Text = "!";
            this.passerr.Visible = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Enabled = false;
            this.LoginButton.Location = new System.Drawing.Point(100, 64);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginUser);
            // 
            // DelButton
            // 
            this.DelButton.Enabled = false;
            this.DelButton.Location = new System.Drawing.Point(185, 64);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 8;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DeleteUser);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Хранить в";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(76, 133);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(156, 20);
            this.pathTextBox.TabIndex = 10;
            this.pathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pathTextBox.TextChanged += new System.EventHandler(this.pathTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = ".txt";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(145, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Применить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.FindFile);
            // 
            // patherr
            // 
            this.patherr.AutoSize = true;
            this.patherr.BackColor = System.Drawing.Color.Transparent;
            this.patherr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patherr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patherr.ForeColor = System.Drawing.Color.Red;
            this.patherr.Location = new System.Drawing.Point(79, 136);
            this.patherr.Name = "patherr";
            this.patherr.Size = new System.Drawing.Size(11, 13);
            this.patherr.TabIndex = 13;
            this.patherr.Text = "!";
            this.patherr.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 192);
            this.Controls.Add(this.patherr);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.passerr);
            this.Controls.Add(this.loginerr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label loginerr;
        private System.Windows.Forms.Label passerr;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label patherr;
    }
}

