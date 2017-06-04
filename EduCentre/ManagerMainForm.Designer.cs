namespace EduCentre
{
    partial class ManagerMainForm
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
            this.buttonRequests = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonCourses = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRequests
            // 
            this.buttonRequests.Location = new System.Drawing.Point(15, 63);
            this.buttonRequests.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRequests.Name = "buttonRequests";
            this.buttonRequests.Size = new System.Drawing.Size(264, 44);
            this.buttonRequests.TabIndex = 0;
            this.buttonRequests.Text = "Заявки";
            this.buttonRequests.UseVisualStyleBackColor = true;
            this.buttonRequests.Click += new System.EventHandler(this.buttonRequests_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(15, 121);
            this.buttonClients.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(264, 44);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.Location = new System.Drawing.Point(15, 178);
            this.buttonTeachers.Margin = new System.Windows.Forms.Padding(6);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(264, 44);
            this.buttonTeachers.TabIndex = 2;
            this.buttonTeachers.Text = "Преподаватели";
            this.buttonTeachers.UseVisualStyleBackColor = true;
            // 
            // buttonCourses
            // 
            this.buttonCourses.Location = new System.Drawing.Point(15, 236);
            this.buttonCourses.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCourses.Name = "buttonCourses";
            this.buttonCourses.Size = new System.Drawing.Size(264, 44);
            this.buttonCourses.TabIndex = 3;
            this.buttonCourses.Text = "Курсы";
            this.buttonCourses.UseVisualStyleBackColor = true;
            // 
            // buttonGroups
            // 
            this.buttonGroups.Location = new System.Drawing.Point(15, 294);
            this.buttonGroups.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(264, 44);
            this.buttonGroups.TabIndex = 4;
            this.buttonGroups.Text = "Группы";
            this.buttonGroups.UseVisualStyleBackColor = true;
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Location = new System.Drawing.Point(15, 351);
            this.buttonSchedule.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(264, 44);
            this.buttonSchedule.TabIndex = 5;
            this.buttonSchedule.Text = "Расписание";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 409);
            this.button7.Margin = new System.Windows.Forms.Padding(6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(264, 44);
            this.button7.TabIndex = 6;
            this.button7.Text = "Обмен сообщениями";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(15, 467);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(264, 44);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Выход";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 550);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.buttonGroups);
            this.Controls.Add(this.buttonCourses);
            this.Controls.Add(this.buttonTeachers);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonRequests);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ManagerMainForm";
            this.Text = "ManagerMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRequests;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonCourses;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonBack;
    }
}