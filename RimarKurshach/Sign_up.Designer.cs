using System;

namespace RimarKurshach
{
    partial class Sign_up
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
            this.regPassField = new System.Windows.Forms.TextBox();
            this.regPassField2 = new System.Windows.Forms.TextBox();
            this.regLoginField = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.regGroupField = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // regPassField
            // 
            this.regPassField.Location = new System.Drawing.Point(177, 108);
            this.regPassField.Name = "regPassField";
            this.regPassField.Size = new System.Drawing.Size(140, 22);
            this.regPassField.TabIndex = 0;
            // 
            // regPassField2
            // 
            this.regPassField2.Location = new System.Drawing.Point(177, 147);
            this.regPassField2.Name = "regPassField2";
            this.regPassField2.Size = new System.Drawing.Size(140, 22);
            this.regPassField2.TabIndex = 1;
            // 
            // regLoginField
            // 
            this.regLoginField.Location = new System.Drawing.Point(177, 33);
            this.regLoginField.Name = "regLoginField";
            this.regLoginField.Size = new System.Drawing.Size(140, 28);
            this.regLoginField.TabIndex = 2;
            this.regLoginField.Text = "";
            this.regLoginField.TextChanged += new System.EventHandler(this.regLoginField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повторите пароль";
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(130, 220);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(162, 40);
            this.regButton.TabIndex = 6;
            this.regButton.Text = "Зарегестрироваться";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Группа";
            // 
            // regGroupField
            // 
            this.regGroupField.Location = new System.Drawing.Point(177, 67);
            this.regGroupField.Name = "regGroupField";
            this.regGroupField.Size = new System.Drawing.Size(140, 29);
            this.regGroupField.TabIndex = 8;
            this.regGroupField.Text = "";
            this.regGroupField.TextChanged += new System.EventHandler(this.regGroupField_TextChanged);
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 396);
            this.Controls.Add(this.regGroupField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regLoginField);
            this.Controls.Add(this.regPassField2);
            this.Controls.Add(this.regPassField);
            this.Name = "Sign_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

 

        #endregion

        private System.Windows.Forms.TextBox regPassField;
        private System.Windows.Forms.TextBox regPassField2;
        private System.Windows.Forms.RichTextBox regLoginField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox regGroupField;
    }
}