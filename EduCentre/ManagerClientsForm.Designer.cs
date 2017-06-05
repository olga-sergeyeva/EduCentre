namespace EduCentre
{
    partial class ManagerClientsForm
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
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.buttonAddClientInGroup = new System.Windows.Forms.Button();
            this.buttonDeleteClientFromGroup = new System.Windows.Forms.Button();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelSeeAllClients = new System.Windows.Forms.Label();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonDeleteFromGroup = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(193, 397);
            this.buttonAddClient.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(400, 44);
            this.buttonAddClient.TabIndex = 0;
            this.buttonAddClient.Text = "Добавить нового клиента";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Location = new System.Drawing.Point(193, 453);
            this.buttonEditClient.Margin = new System.Windows.Forms.Padding(6);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(400, 44);
            this.buttonEditClient.TabIndex = 1;
            this.buttonEditClient.Text = "Редактировать профиль клиента";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // buttonAddClientInGroup
            // 
            this.buttonAddClientInGroup.Location = new System.Drawing.Point(193, 562);
            this.buttonAddClientInGroup.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAddClientInGroup.Name = "buttonAddClientInGroup";
            this.buttonAddClientInGroup.Size = new System.Drawing.Size(400, 45);
            this.buttonAddClientInGroup.TabIndex = 2;
            this.buttonAddClientInGroup.Text = "Добавить клиента в группу";
            this.buttonAddClientInGroup.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteClientFromGroup
            // 
            this.buttonDeleteClientFromGroup.Location = new System.Drawing.Point(277, 858);
            this.buttonDeleteClientFromGroup.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDeleteClientFromGroup.Name = "buttonDeleteClientFromGroup";
            this.buttonDeleteClientFromGroup.Size = new System.Drawing.Size(138, 44);
            this.buttonDeleteClientFromGroup.TabIndex = 3;
            this.buttonDeleteClientFromGroup.Text = "Удалить клиента из группы";
            this.buttonDeleteClientFromGroup.UseVisualStyleBackColor = true;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(353, 22);
            this.comboBoxClients.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(408, 33);
            this.comboBoxClients.TabIndex = 4;
            this.comboBoxClients.SelectedIndexChanged += new System.EventHandler(this.comboBoxClients_SelectedIndexChanged);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(188, 93);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(91, 25);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(188, 149);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(49, 25);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "Имя";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(188, 203);
            this.labelSecondName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(93, 25);
            this.labelSecondName.TabIndex = 7;
            this.labelSecondName.Text = "Отчество";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(188, 262);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(158, 25);
            this.labelPhoneNumber.TabIndex = 8;
            this.labelPhoneNumber.Text = "Номер телефона";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(188, 317);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(58, 25);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Location = new System.Drawing.Point(353, 93);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(408, 33);
            this.textBoxLastName.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxFirstName.Enabled = false;
            this.textBoxFirstName.Location = new System.Drawing.Point(353, 149);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(408, 33);
            this.textBoxFirstName.TabIndex = 11;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxSecondName.Enabled = false;
            this.textBoxSecondName.Location = new System.Drawing.Point(353, 203);
            this.textBoxSecondName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(408, 33);
            this.textBoxSecondName.TabIndex = 12;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxPhoneNumber.Enabled = false;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(353, 262);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(408, 33);
            this.textBoxPhoneNumber.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(353, 317);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(408, 33);
            this.textBoxEmail.TabIndex = 14;
            // 
            // labelSeeAllClients
            // 
            this.labelSeeAllClients.AutoSize = true;
            this.labelSeeAllClients.Location = new System.Drawing.Point(22, 22);
            this.labelSeeAllClients.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSeeAllClients.Name = "labelSeeAllClients";
            this.labelSeeAllClients.Size = new System.Drawing.Size(259, 25);
            this.labelSeeAllClients.TabIndex = 15;
            this.labelSeeAllClients.Text = "Выберите клиента из списка";
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Location = new System.Drawing.Point(193, 509);
            this.buttonDeleteClient.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(400, 41);
            this.buttonDeleteClient.TabIndex = 16;
            this.buttonDeleteClient.Text = "Удалить клиента";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFromGroup
            // 
            this.buttonDeleteFromGroup.Location = new System.Drawing.Point(193, 617);
            this.buttonDeleteFromGroup.Name = "buttonDeleteFromGroup";
            this.buttonDeleteFromGroup.Size = new System.Drawing.Size(400, 40);
            this.buttonDeleteFromGroup.TabIndex = 17;
            this.buttonDeleteFromGroup.Text = "Удалить клиента из группы";
            this.buttonDeleteFromGroup.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(193, 675);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(400, 43);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "Вернуться в меню";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ManagerClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 741);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDeleteFromGroup);
            this.Controls.Add(this.buttonDeleteClient);
            this.Controls.Add(this.labelSeeAllClients);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.buttonDeleteClientFromGroup);
            this.Controls.Add(this.buttonAddClientInGroup);
            this.Controls.Add(this.buttonEditClient);
            this.Controls.Add(this.buttonAddClient);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ManagerClientsForm";
            this.Text = "ManagerClientsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Button buttonAddClientInGroup;
        private System.Windows.Forms.Button buttonDeleteClientFromGroup;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelSeeAllClients;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonDeleteFromGroup;
        private System.Windows.Forms.Button buttonBack;
    }
}