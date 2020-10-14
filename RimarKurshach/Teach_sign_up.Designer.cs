namespace RimarKurshach
{
    partial class Teach_sign_up
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
            this.Teacher_pass_field = new System.Windows.Forms.TextBox();
            this.Teacher_login_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Teacher_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Teacher_pass_field
            // 
            this.Teacher_pass_field.Location = new System.Drawing.Point(77, 157);
            this.Teacher_pass_field.Multiline = true;
            this.Teacher_pass_field.Name = "Teacher_pass_field";
            this.Teacher_pass_field.PasswordChar = '*';
            this.Teacher_pass_field.Size = new System.Drawing.Size(146, 22);
            this.Teacher_pass_field.TabIndex = 0;
            // 
            // Teacher_login_field
            // 
            this.Teacher_login_field.Location = new System.Drawing.Point(77, 120);
            this.Teacher_login_field.Multiline = true;
            this.Teacher_login_field.Name = "Teacher_login_field";
            this.Teacher_login_field.Size = new System.Drawing.Size(146, 22);
            this.Teacher_login_field.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // Teacher_button
            // 
            this.Teacher_button.Location = new System.Drawing.Point(104, 232);
            this.Teacher_button.Name = "Teacher_button";
            this.Teacher_button.Size = new System.Drawing.Size(75, 37);
            this.Teacher_button.TabIndex = 4;
            this.Teacher_button.Text = "Войти";
            this.Teacher_button.UseVisualStyleBackColor = true;
            this.Teacher_button.Click += new System.EventHandler(this.Teacher_button_Click);
            // 
            // Teach_sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 328);
            this.Controls.Add(this.Teacher_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Teacher_login_field);
            this.Controls.Add(this.Teacher_pass_field);
            this.Name = "Teach_sign_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход для преподавателей";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Teacher_pass_field;
        private System.Windows.Forms.TextBox Teacher_login_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Teacher_button;
    }
}