namespace BarberShop.WindowFormPL
{
    partial class Result_AddRequest
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
            this.label_resultAdding = new System.Windows.Forms.Label();
            this.button_okok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_resultAdding
            // 
            this.label_resultAdding.AutoSize = true;
            this.label_resultAdding.Location = new System.Drawing.Point(42, 27);
            this.label_resultAdding.Name = "label_resultAdding";
            this.label_resultAdding.Size = new System.Drawing.Size(70, 13);
            this.label_resultAdding.TabIndex = 0;
            this.label_resultAdding.Text = "Coming Soon";
            // 
            // button_okok
            // 
            this.button_okok.Location = new System.Drawing.Point(127, 82);
            this.button_okok.Name = "button_okok";
            this.button_okok.Size = new System.Drawing.Size(75, 23);
            this.button_okok.TabIndex = 1;
            this.button_okok.Text = "OK";
            this.button_okok.UseVisualStyleBackColor = true;
            this.button_okok.Click += new System.EventHandler(this.button_okok_Click);
            // 
            // Result_AddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 150);
            this.Controls.Add(this.button_okok);
            this.Controls.Add(this.label_resultAdding);
            this.Name = "Result_AddRequest";
            this.Text = "Result_AddRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_resultAdding;
        private System.Windows.Forms.Button button_okok;
    }
}