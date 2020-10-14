using System;

namespace RimarKurshach
{
    partial class Add_Ques
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
            this.rightAnswer = new System.Windows.Forms.RichTextBox();
            this.question = new System.Windows.Forms.RichTextBox();
            this.wrongAnswer = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wrongAnswer2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_quest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rightAnswer
            // 
            this.rightAnswer.Location = new System.Drawing.Point(298, 143);
            this.rightAnswer.Name = "rightAnswer";
            this.rightAnswer.Size = new System.Drawing.Size(296, 104);
            this.rightAnswer.TabIndex = 0;
            this.rightAnswer.Text = "";
            this.rightAnswer.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(298, 41);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(296, 96);
            this.question.TabIndex = 1;
            this.question.Text = "";
            this.question.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // wrongAnswer
            // 
            this.wrongAnswer.Location = new System.Drawing.Point(298, 253);
            this.wrongAnswer.Name = "wrongAnswer";
            this.wrongAnswer.Size = new System.Drawing.Size(296, 96);
            this.wrongAnswer.TabIndex = 2;
            this.wrongAnswer.Text = "";
            this.wrongAnswer.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добавление вопросов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(128, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вопрос";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(87, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Правильный ответ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(88, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Неправильный ответ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // wrongAnswer2
            // 
            this.wrongAnswer2.Location = new System.Drawing.Point(298, 355);
            this.wrongAnswer2.Name = "wrongAnswer2";
            this.wrongAnswer2.Size = new System.Drawing.Size(296, 96);
            this.wrongAnswer2.TabIndex = 7;
            this.wrongAnswer2.Text = "";
            this.wrongAnswer2.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(89, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Неправильный ответ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Add_quest
            // 
            this.Add_quest.Location = new System.Drawing.Point(233, 485);
            this.Add_quest.Name = "Add_quest";
            this.Add_quest.Size = new System.Drawing.Size(131, 36);
            this.Add_quest.TabIndex = 9;
            this.Add_quest.Text = "Добавить";
            this.Add_quest.UseVisualStyleBackColor = true;
            this.Add_quest.Click += new System.EventHandler(this.Add_quest_click);
            // 
            // Add_Ques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 533);
            this.Controls.Add(this.Add_quest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wrongAnswer2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wrongAnswer);
            this.Controls.Add(this.question);
            this.Controls.Add(this.rightAnswer);
            this.Name = "Add_Ques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rightAnswer;
        private System.Windows.Forms.RichTextBox question;
        private System.Windows.Forms.RichTextBox wrongAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox wrongAnswer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add_quest;
    }
}