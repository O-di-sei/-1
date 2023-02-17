namespace МиСПИСиТ__лаба1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBa = new System.Windows.Forms.TextBox();
            this.tBb = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.share = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "A =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "B =";
            // 
            // tBa
            // 
            this.tBa.Location = new System.Drawing.Point(80, 43);
            this.tBa.Name = "tBa";
            this.tBa.Size = new System.Drawing.Size(101, 22);
            this.tBa.TabIndex = 2;
            this.tBa.Text = "1";
            // 
            // tBb
            // 
            this.tBb.Location = new System.Drawing.Point(80, 70);
            this.tBb.Name = "tBb";
            this.tBb.Size = new System.Drawing.Size(101, 22);
            this.tBb.TabIndex = 3;
            this.tBb.Text = "1";
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(51, 109);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(28, 25);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(85, 109);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(28, 25);
            this.minus.TabIndex = 5;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(119, 109);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(28, 25);
            this.multiply.TabIndex = 6;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // share
            // 
            this.share.Location = new System.Drawing.Point(153, 109);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(28, 25);
            this.share.TabIndex = 7;
            this.share.Text = "/";
            this.share.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ответ:";
            // 
            // tB
            // 
            this.tB.Location = new System.Drawing.Point(51, 169);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(130, 22);
            this.tB.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 241);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.share);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.tBb);
            this.Controls.Add(this.tBa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBa;
        private System.Windows.Forms.TextBox tBb;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button share;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB;
    }
}

