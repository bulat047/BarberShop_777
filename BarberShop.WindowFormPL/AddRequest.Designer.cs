namespace BarberShop.WindowFormPL
{
    partial class AddRequest
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
            this.label_fio = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.errorProvider_fio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_date = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_date)).BeginInit();
            this.SuspendLayout();
            // 
            // label_fio
            // 
            this.label_fio.AutoSize = true;
            this.label_fio.Location = new System.Drawing.Point(54, 31);
            this.label_fio.Name = "label_fio";
            this.label_fio.Size = new System.Drawing.Size(81, 13);
            this.label_fio.TabIndex = 0;
            this.label_fio.Text = "ФИО клиента:";
            this.label_fio.Click += new System.EventHandler(this.label_fio_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(109, 189);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(131, 23);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // textBox_fio
            // 
            this.textBox_fio.Location = new System.Drawing.Point(57, 58);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(201, 20);
            this.textBox_fio.TabIndex = 2;
            this.textBox_fio.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_fio_Validating);
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(57, 142);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(201, 20);
            this.textBox_date.TabIndex = 3;
            this.textBox_date.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_date_Validating);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(57, 102);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(275, 26);
            this.label_date.TabIndex = 4;
            this.label_date.Text = "Назначенное время в формате ДД.ММ.ГГГГ ЧЧ:ММ\r\nПример 24.08.2020 13:49";
            // 
            // errorProvider_fio
            // 
            this.errorProvider_fio.ContainerControl = this;
            // 
            // errorProvider_date
            // 
            this.errorProvider_date.ContainerControl = this;
            // 
            // AddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 244);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_fio);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_fio);
            this.Name = "AddRequest";
            this.Text = "AddRequest";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_date)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_fio;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.ErrorProvider errorProvider_fio;
        private System.Windows.Forms.ErrorProvider errorProvider_date;
    }
}