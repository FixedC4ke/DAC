namespace lab3SovrIS
{
    partial class ObjectsForm
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
            this.objectlistBox = new System.Windows.Forms.ListBox();
            this.readcheckBox = new System.Windows.Forms.CheckBox();
            this.writecheckBox = new System.Windows.Forms.CheckBox();
            this.owncheckBox = new System.Windows.Forms.CheckBox();
            this.tgcheckBox = new System.Windows.Forms.CheckBox();
            this.datarichTextBox = new System.Windows.Forms.RichTextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.createobjbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.changeaccbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delbutton = new System.Windows.Forms.Button();
            this.addUserbutton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectlistBox
            // 
            this.objectlistBox.FormattingEnabled = true;
            this.objectlistBox.Location = new System.Drawing.Point(12, 25);
            this.objectlistBox.Name = "objectlistBox";
            this.objectlistBox.Size = new System.Drawing.Size(211, 147);
            this.objectlistBox.TabIndex = 0;
            this.objectlistBox.SelectedIndexChanged += new System.EventHandler(this.objectlistBox_SelectedIndexChanged);
            // 
            // readcheckBox
            // 
            this.readcheckBox.AutoSize = true;
            this.readcheckBox.Enabled = false;
            this.readcheckBox.Location = new System.Drawing.Point(412, 52);
            this.readcheckBox.Name = "readcheckBox";
            this.readcheckBox.Size = new System.Drawing.Size(52, 17);
            this.readcheckBox.TabIndex = 1;
            this.readcheckBox.Text = "Read";
            this.readcheckBox.UseVisualStyleBackColor = true;
            // 
            // writecheckBox
            // 
            this.writecheckBox.AutoSize = true;
            this.writecheckBox.Enabled = false;
            this.writecheckBox.Location = new System.Drawing.Point(412, 75);
            this.writecheckBox.Name = "writecheckBox";
            this.writecheckBox.Size = new System.Drawing.Size(51, 17);
            this.writecheckBox.TabIndex = 2;
            this.writecheckBox.Text = "Write";
            this.writecheckBox.UseVisualStyleBackColor = true;
            // 
            // owncheckBox
            // 
            this.owncheckBox.AutoSize = true;
            this.owncheckBox.Enabled = false;
            this.owncheckBox.Location = new System.Drawing.Point(412, 98);
            this.owncheckBox.Name = "owncheckBox";
            this.owncheckBox.Size = new System.Drawing.Size(48, 17);
            this.owncheckBox.TabIndex = 3;
            this.owncheckBox.Text = "Own";
            this.owncheckBox.UseVisualStyleBackColor = true;
            // 
            // tgcheckBox
            // 
            this.tgcheckBox.AutoSize = true;
            this.tgcheckBox.Enabled = false;
            this.tgcheckBox.Location = new System.Drawing.Point(412, 121);
            this.tgcheckBox.Name = "tgcheckBox";
            this.tgcheckBox.Size = new System.Drawing.Size(41, 17);
            this.tgcheckBox.TabIndex = 4;
            this.tgcheckBox.Text = "TG";
            this.tgcheckBox.UseVisualStyleBackColor = true;
            // 
            // datarichTextBox
            // 
            this.datarichTextBox.Enabled = false;
            this.datarichTextBox.Location = new System.Drawing.Point(229, 64);
            this.datarichTextBox.Name = "datarichTextBox";
            this.datarichTextBox.Size = new System.Drawing.Size(177, 135);
            this.datarichTextBox.TabIndex = 5;
            this.datarichTextBox.Text = "";
            // 
            // nametextBox
            // 
            this.nametextBox.Enabled = false;
            this.nametextBox.Location = new System.Drawing.Point(229, 25);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(177, 20);
            this.nametextBox.TabIndex = 6;
            // 
            // createobjbutton
            // 
            this.createobjbutton.Location = new System.Drawing.Point(12, 178);
            this.createobjbutton.Name = "createobjbutton";
            this.createobjbutton.Size = new System.Drawing.Size(211, 23);
            this.createobjbutton.TabIndex = 7;
            this.createobjbutton.Text = "Новый объект";
            this.createobjbutton.UseVisualStyleBackColor = true;
            this.createobjbutton.Click += new System.EventHandler(this.createobjbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Enabled = false;
            this.savebutton.Location = new System.Drawing.Point(229, 205);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(177, 23);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "Запись";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(412, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 235);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(560, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // changeaccbutton
            // 
            this.changeaccbutton.Enabled = false;
            this.changeaccbutton.Location = new System.Drawing.Point(412, 205);
            this.changeaccbutton.Name = "changeaccbutton";
            this.changeaccbutton.Size = new System.Drawing.Size(138, 23);
            this.changeaccbutton.TabIndex = 11;
            this.changeaccbutton.Text = "Сохранить";
            this.changeaccbutton.UseVisualStyleBackColor = true;
            this.changeaccbutton.Click += new System.EventHandler(this.changeaccbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Доступные объекты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(226, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Имя объекта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(226, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Содержимое объекта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(409, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Настройка прав доступа:";
            // 
            // delbutton
            // 
            this.delbutton.Enabled = false;
            this.delbutton.Location = new System.Drawing.Point(12, 205);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(211, 23);
            this.delbutton.TabIndex = 16;
            this.delbutton.Text = "Удалить объект";
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // addUserbutton
            // 
            this.addUserbutton.Location = new System.Drawing.Point(412, 162);
            this.addUserbutton.Name = "addUserbutton";
            this.addUserbutton.Size = new System.Drawing.Size(136, 37);
            this.addUserbutton.TabIndex = 17;
            this.addUserbutton.Text = "Добавить пользователя";
            this.addUserbutton.UseVisualStyleBackColor = true;
            this.addUserbutton.Visible = false;
            this.addUserbutton.Click += new System.EventHandler(this.addUserbutton_Click);
            // 
            // ObjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 257);
            this.Controls.Add(this.addUserbutton);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeaccbutton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.createobjbutton);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.datarichTextBox);
            this.Controls.Add(this.tgcheckBox);
            this.Controls.Add(this.owncheckBox);
            this.Controls.Add(this.writecheckBox);
            this.Controls.Add(this.readcheckBox);
            this.Controls.Add(this.objectlistBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ObjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление объектами";
            this.Load += new System.EventHandler(this.ObjectsForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox objectlistBox;
        private System.Windows.Forms.CheckBox readcheckBox;
        private System.Windows.Forms.CheckBox writecheckBox;
        private System.Windows.Forms.CheckBox owncheckBox;
        private System.Windows.Forms.CheckBox tgcheckBox;
        private System.Windows.Forms.RichTextBox datarichTextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Button createobjbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button changeaccbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.Button addUserbutton;
    }
}