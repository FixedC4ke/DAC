namespace lab3SovrIS
{
    partial class AuthForm
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
            this.userPickListBox = new System.Windows.Forms.ListBox();
            this.passtextBox = new System.Windows.Forms.TextBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userPickListBox
            // 
            this.userPickListBox.FormattingEnabled = true;
            this.userPickListBox.Location = new System.Drawing.Point(12, 29);
            this.userPickListBox.Name = "userPickListBox";
            this.userPickListBox.Size = new System.Drawing.Size(241, 95);
            this.userPickListBox.TabIndex = 0;
            this.userPickListBox.SelectedIndexChanged += new System.EventHandler(this.userPickListBox_SelectedIndexChanged);
            // 
            // passtextBox
            // 
            this.passtextBox.Enabled = false;
            this.passtextBox.Location = new System.Drawing.Point(12, 152);
            this.passtextBox.Name = "passtextBox";
            this.passtextBox.PasswordChar = '*';
            this.passtextBox.Size = new System.Drawing.Size(241, 20);
            this.passtextBox.TabIndex = 1;
            // 
            // submitbutton
            // 
            this.submitbutton.Enabled = false;
            this.submitbutton.Location = new System.Drawing.Point(73, 185);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(120, 23);
            this.submitbutton.TabIndex = 2;
            this.submitbutton.Text = "Войти";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите пароль:";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 220);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.passtextBox);
            this.Controls.Add(this.userPickListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Activated += new System.EventHandler(this.AuthForm_Activated);
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userPickListBox;
        private System.Windows.Forms.TextBox passtextBox;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

