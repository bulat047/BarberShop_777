namespace BarberShop.WindowFormPL
{
    partial class AuthorizationUser
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
            this.button_authorization = new System.Windows.Forms.Button();
            this.textBox_authorization = new System.Windows.Forms.TextBox();
            this.ladel_authorization = new System.Windows.Forms.Label();
            this.errorProvider_name = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).BeginInit();
            this.SuspendLayout();
            // 
            // button_authorization
            // 
            this.button_authorization.Location = new System.Drawing.Point(116, 109);
            this.button_authorization.Name = "button_authorization";
            this.button_authorization.Size = new System.Drawing.Size(144, 23);
            this.button_authorization.TabIndex = 0;
            this.button_authorization.Text = "OK";
            this.button_authorization.UseVisualStyleBackColor = true;
            this.button_authorization.Click += new System.EventHandler(this.button_authorization_Click);
            // 
            // textBox_authorization
            // 
            this.textBox_authorization.Location = new System.Drawing.Point(60, 58);
            this.textBox_authorization.Name = "textBox_authorization";
            this.textBox_authorization.Size = new System.Drawing.Size(267, 20);
            this.textBox_authorization.TabIndex = 1;
            this.textBox_authorization.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_authorization_Validating);
            // 
            // ladel_authorization
            // 
            this.ladel_authorization.AutoSize = true;
            this.ladel_authorization.Location = new System.Drawing.Point(57, 9);
            this.ladel_authorization.Name = "ladel_authorization";
            this.ladel_authorization.Size = new System.Drawing.Size(167, 26);
            this.ladel_authorization.TabIndex = 2;
            this.ladel_authorization.Text = "Авторизируйтесь в программе!\r\nВведите ФИО:";
            this.ladel_authorization.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider_name
            // 
            this.errorProvider_name.ContainerControl = this;
            // 
            // AuthorizationUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 155);
            this.Controls.Add(this.ladel_authorization);
            this.Controls.Add(this.textBox_authorization);
            this.Controls.Add(this.button_authorization);
            this.Name = "AuthorizationUser";
            this.Text = "RegistrationUser";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_authorization;
        private System.Windows.Forms.TextBox textBox_authorization;
        private System.Windows.Forms.Label ladel_authorization;
        private System.Windows.Forms.ErrorProvider errorProvider_name;
    }
}