
namespace Form_Z04_2
{
    partial class Form1
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
            this.textBoxZXC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxKeK = new System.Windows.Forms.CheckBox();
            this.pictureBoxZXC = new System.Windows.Forms.PictureBox();
            this.pictureBoxZXC1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZXC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZXC1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxZXC
            // 
            this.textBoxZXC.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxZXC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxZXC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxZXC.Location = new System.Drawing.Point(9, 4);
            this.textBoxZXC.Multiline = true;
            this.textBoxZXC.Name = "textBoxZXC";
            this.textBoxZXC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxZXC.Size = new System.Drawing.Size(308, 153);
            this.textBoxZXC.TabIndex = 10;
            this.textBoxZXC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxZXC.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перевод чисола из 10 в 2 систему.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите число";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(131, 43);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(76, 20);
            this.textBoxNumber.TabIndex = 2;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(132, 72);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 3;
            this.buttonResult.Text = "Перевод";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Location = new System.Drawing.Point(91, 101);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(155, 52);
            this.textBoxResult.TabIndex = 4;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Утин Д. С.";
            // 
            // checkBoxKeK
            // 
            this.checkBoxKeK.AutoSize = true;
            this.checkBoxKeK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxKeK.Location = new System.Drawing.Point(75, 158);
            this.checkBoxKeK.Name = "checkBoxKeK";
            this.checkBoxKeK.Size = new System.Drawing.Size(50, 17);
            this.checkBoxKeK.TabIndex = 6;
            this.checkBoxKeK.Text = "ZXC";
            this.checkBoxKeK.UseVisualStyleBackColor = true;
            this.checkBoxKeK.CheckedChanged += new System.EventHandler(this.checkBoxKeK_CheckedChanged);
            // 
            // pictureBoxZXC
            // 
            this.pictureBoxZXC.ImageLocation = "C:\\Users\\Dmitryi Gick\\source\\repos\\Form_Z04_2\\zxc-cat.gif";
            this.pictureBoxZXC.Location = new System.Drawing.Point(13, 23);
            this.pictureBoxZXC.Name = "pictureBoxZXC";
            this.pictureBoxZXC.Size = new System.Drawing.Size(96, 118);
            this.pictureBoxZXC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxZXC.TabIndex = 11;
            this.pictureBoxZXC.TabStop = false;
            this.pictureBoxZXC.Visible = false;
            this.pictureBoxZXC.WaitOnLoad = true;
            // 
            // pictureBoxZXC1
            // 
            this.pictureBoxZXC1.ImageLocation = "C:\\Users\\Dmitryi Gick\\source\\repos\\Form_Z04_2\\zxc-cat.gif";
            this.pictureBoxZXC1.Location = new System.Drawing.Point(200, 23);
            this.pictureBoxZXC1.Name = "pictureBoxZXC1";
            this.pictureBoxZXC1.Size = new System.Drawing.Size(96, 118);
            this.pictureBoxZXC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxZXC1.TabIndex = 12;
            this.pictureBoxZXC1.TabStop = false;
            this.pictureBoxZXC1.Visible = false;
            this.pictureBoxZXC1.WaitOnLoad = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 181);
            this.Controls.Add(this.pictureBoxZXC1);
            this.Controls.Add(this.pictureBoxZXC);
            this.Controls.Add(this.textBoxZXC);
            this.Controls.Add(this.checkBoxKeK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form Z04.2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZXC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZXC1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxZXC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxKeK;
        private System.Windows.Forms.PictureBox pictureBoxZXC;
        private System.Windows.Forms.PictureBox pictureBoxZXC1;
    }
}

