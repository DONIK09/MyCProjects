namespace Haffman
{
    partial class HafForm
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
            this.pictureOut = new System.Windows.Forms.PictureBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOut)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOut
            // 
            this.pictureOut.Location = new System.Drawing.Point(12, 12);
            this.pictureOut.Name = "pictureOut";
            this.pictureOut.Size = new System.Drawing.Size(385, 317);
            this.pictureOut.TabIndex = 1;
            this.pictureOut.TabStop = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(412, 12);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(95, 24);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Обзор..";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(412, 109);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(35, 13);
            this.labelFileName.TabIndex = 3;
            this.labelFileName.Text = "label1";
            this.labelFileName.Visible = false;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(412, 42);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(95, 24);
            this.encryptButton.TabIndex = 4;
            this.encryptButton.Text = "Сжать";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(412, 72);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(95, 24);
            this.decryptButton.TabIndex = 5;
            this.decryptButton.Text = "Распаковать";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // HafForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 356);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HafForm";
            this.Text = "Haffman";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureOut;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
    }
}

