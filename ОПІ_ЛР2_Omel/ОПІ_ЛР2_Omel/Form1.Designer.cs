namespace ОПІ_ЛР2_Omel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            label4 = new Label();
            label5 = new Label();
            CalcHypotenyse = new Button();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(131, 56);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(118, 23);
            textBoxA.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 23);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 1;
            label1.Text = "Введіть довжину катетів";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(106, 54);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 2;
            label2.Text = "a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(105, 99);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 3;
            label3.Text = "b";
            label3.Click += label3_Click;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(131, 100);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(118, 23);
            textBoxB.TabIndex = 4;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(131, 204);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(118, 23);
            textBoxC.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(107, 201);
            label4.Name = "label4";
            label4.Size = new Size(21, 25);
            label4.TabIndex = 6;
            label4.Text = "c";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 186);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 7;
            label5.Text = "Довжина гіпотенузи:";
            // 
            // CalcHypotenyse
            // 
            CalcHypotenyse.BackColor = Color.DodgerBlue;
            CalcHypotenyse.Location = new Point(131, 146);
            CalcHypotenyse.Margin = new Padding(0);
            CalcHypotenyse.Name = "CalcHypotenyse";
            CalcHypotenyse.Size = new Size(118, 23);
            CalcHypotenyse.TabIndex = 8;
            CalcHypotenyse.Text = "Обрахувати ";
            CalcHypotenyse.UseVisualStyleBackColor = false;
            CalcHypotenyse.Click += CalcHypotenyse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 303);
            Controls.Add(CalcHypotenyse);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Label label4;
        private Label label5;
        private Button CalcHypotenyse;
    }
}