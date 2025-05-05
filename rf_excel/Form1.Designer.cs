namespace rf_excel
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
            dataGridView1 = new DataGridView();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ujButton = new Button();
            szerkButton = new Button();
            torlesButton = new Button();
            exportButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(520, 307);
            dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(648, 154);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(140, 184);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(853, 154);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(125, 184);
            listBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(648, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(853, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // ujButton
            // 
            ujButton.Location = new Point(30, 399);
            ujButton.Name = "ujButton";
            ujButton.Size = new Size(103, 44);
            ujButton.TabIndex = 5;
            ujButton.Text = "Új felvétele";
            ujButton.UseVisualStyleBackColor = true;
            // 
            // szerkButton
            // 
            szerkButton.Location = new Point(210, 399);
            szerkButton.Name = "szerkButton";
            szerkButton.Size = new Size(103, 44);
            szerkButton.TabIndex = 6;
            szerkButton.Text = "Szerkesztés";
            szerkButton.UseVisualStyleBackColor = true;
            // 
            // torlesButton
            // 
            torlesButton.Location = new Point(386, 399);
            torlesButton.Name = "torlesButton";
            torlesButton.Size = new Size(103, 44);
            torlesButton.TabIndex = 7;
            torlesButton.Text = "Törlés";
            torlesButton.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(834, 399);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(129, 43);
            exportButton.TabIndex = 8;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 498);
            Controls.Add(exportButton);
            Controls.Add(torlesButton);
            Controls.Add(szerkButton);
            Controls.Add(ujButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button ujButton;
        private Button szerkButton;
        private Button torlesButton;
        private Button exportButton;
        private OpenFileDialog openFileDialog1;
    }
}
