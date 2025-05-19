namespace rf_excel
{
    partial class NewProductForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(25, 69);
            label1.Name = "label1";
            label1.Size = new Size(154, 35);
            label1.TabIndex = 0;
            label1.Text = "Termék neve";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(238, 69);
            label2.Name = "label2";
            label2.Size = new Size(137, 35);
            label2.TabIndex = 1;
            label2.Text = "Termék ára";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(476, 69);
            label3.Name = "label3";
            label3.Size = new Size(60, 35);
            label3.TabIndex = 2;
            label3.Text = "SKU";
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(244, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(444, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 27);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(36, 288);
            button1.Name = "button1";
            button1.Size = new Size(114, 72);
            button1.TabIndex = 8;
            button1.Text = "Mentés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(244, 288);
            button2.Name = "button2";
            button2.Size = new Size(114, 72);
            button2.TabIndex = 9;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NewProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 395);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewProductForm";
            Text = "NewProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}