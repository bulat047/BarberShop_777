namespace BarberShop.WindowFormPL
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
            this.button_addRequest = new System.Windows.Forms.Button();
            this.button_getAll = new System.Windows.Forms.Button();
            this.label_nameOrganization = new System.Windows.Forms.Label();
            this.label_nameUser = new System.Windows.Forms.Label();
            this.label_str = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_addRequest
            // 
            this.button_addRequest.Location = new System.Drawing.Point(122, 135);
            this.button_addRequest.Name = "button_addRequest";
            this.button_addRequest.Size = new System.Drawing.Size(140, 53);
            this.button_addRequest.TabIndex = 0;
            this.button_addRequest.Text = "Добавть запись";
            this.button_addRequest.UseVisualStyleBackColor = true;
            this.button_addRequest.Click += new System.EventHandler(this.button_addRequest_Click);
            // 
            // button_getAll
            // 
            this.button_getAll.Location = new System.Drawing.Point(401, 135);
            this.button_getAll.Name = "button_getAll";
            this.button_getAll.Size = new System.Drawing.Size(140, 53);
            this.button_getAll.TabIndex = 1;
            this.button_getAll.Text = "Просмотреть все текущие записи";
            this.button_getAll.UseVisualStyleBackColor = true;
            this.button_getAll.Click += new System.EventHandler(this.button_getAll_Click);
            // 
            // label_nameOrganization
            // 
            this.label_nameOrganization.AutoSize = true;
            this.label_nameOrganization.Location = new System.Drawing.Point(94, 32);
            this.label_nameOrganization.Name = "label_nameOrganization";
            this.label_nameOrganization.Size = new System.Drawing.Size(215, 13);
            this.label_nameOrganization.TabIndex = 2;
            this.label_nameOrganization.Text = "Название организации: \"BarberShop777\"";
            this.label_nameOrganization.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_nameUser
            // 
            this.label_nameUser.AutoSize = true;
            this.label_nameUser.Location = new System.Drawing.Point(398, 58);
            this.label_nameUser.Name = "label_nameUser";
            this.label_nameUser.Size = new System.Drawing.Size(70, 13);
            this.label_nameUser.TabIndex = 3;
            this.label_nameUser.Text = "Coming Soon";
            // 
            // label_str
            // 
            this.label_str.AutoSize = true;
            this.label_str.Location = new System.Drawing.Point(398, 32);
            this.label_str.Name = "label_str";
            this.label_str.Size = new System.Drawing.Size(106, 13);
            this.label_str.TabIndex = 4;
            this.label_str.Text = "Имя пользователя:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 282);
            this.Controls.Add(this.label_str);
            this.Controls.Add(this.label_nameUser);
            this.Controls.Add(this.label_nameOrganization);
            this.Controls.Add(this.button_getAll);
            this.Controls.Add(this.button_addRequest);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addRequest;
        private System.Windows.Forms.Button button_getAll;
        private System.Windows.Forms.Label label_nameOrganization;
        private System.Windows.Forms.Label label_nameUser;
        private System.Windows.Forms.Label label_str;
    }
}

