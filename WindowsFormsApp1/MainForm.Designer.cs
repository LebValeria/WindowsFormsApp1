namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменаПаспортаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получениеПаспорта14ЛетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(394, 287);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(252, 25);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(394, 153);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(252, 22);
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(394, 231);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(252, 22);
            this.textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вы не авторизованы";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(12, 110);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(252, 25);
            this.buttonQuit.TabIndex = 6;
            this.buttonQuit.Text = "Выйти из учетной записи";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Visible = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заявкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заменаПаспортаToolStripMenuItem,
            this.оформлениеToolStripMenuItem,
            this.получениеПаспорта14ЛетToolStripMenuItem});
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.заявкиToolStripMenuItem.Text = "Заявки";
            // 
            // заменаПаспортаToolStripMenuItem
            // 
            this.заменаПаспортаToolStripMenuItem.Name = "заменаПаспортаToolStripMenuItem";
            this.заменаПаспортаToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.заменаПаспортаToolStripMenuItem.Text = "Замена паспорта";
            // 
            // оформлениеToolStripMenuItem
            // 
            this.оформлениеToolStripMenuItem.Name = "оформлениеToolStripMenuItem";
            this.оформлениеToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.оформлениеToolStripMenuItem.Text = "Оформление загранпаспорта";
            // 
            // получениеПаспорта14ЛетToolStripMenuItem
            // 
            this.получениеПаспорта14ЛетToolStripMenuItem.Name = "получениеПаспорта14ЛетToolStripMenuItem";
            this.получениеПаспорта14ЛетToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.получениеПаспорта14ЛетToolStripMenuItem.Text = "Получение паспорта (14 лет)";
            this.получениеПаспорта14ЛетToolStripMenuItem.Click += new System.EventHandler(this.получениеПаспорта14ЛетToolStripMenuItem_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(12, 79);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(252, 25);
            this.buttonProfile.TabIndex = 8;
            this.buttonProfile.Text = "Моя учетная запись";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Visible = false;
            this.buttonProfile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(870, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Подать заявку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(870, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "Мои заявки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 558);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменаПаспортаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оформлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получениеПаспорта14ЛетToolStripMenuItem;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

