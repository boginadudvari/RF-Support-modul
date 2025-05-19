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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(194, 156, 61);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(194, 156, 61);
            dataGridViewCellStyle1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(33, 44, 40);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(194, 156, 61);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(33, 44, 40);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(28, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(833, 466);
            dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBox1.BackColor = Color.FromArgb(194, 156, 61);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(886, 197);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(206, 404);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBox2.BackColor = Color.FromArgb(194, 156, 61);
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(1125, 197);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(206, 404);
            listBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(194, 156, 61);
            textBox1.Location = new Point(886, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(194, 156, 61);
            textBox2.Location = new Point(1125, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 4;
            // 
            // ujButton
            // 
            ujButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ujButton.Font = new Font("Georgia", 12F);
            ujButton.Location = new Point(28, 650);
            ujButton.Name = "ujButton";
            ujButton.Size = new Size(227, 44);
            ujButton.TabIndex = 5;
            ujButton.Text = "Új termék felvétele";
            ujButton.UseVisualStyleBackColor = true;
            // 
            // szerkButton
            // 
            szerkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            szerkButton.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            szerkButton.Location = new Point(280, 651);
            szerkButton.Name = "szerkButton";
            szerkButton.Size = new Size(227, 43);
            szerkButton.TabIndex = 6;
            szerkButton.Text = "Termék mentése";
            szerkButton.UseVisualStyleBackColor = true;
            // 
            // torlesButton
            // 
            torlesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            torlesButton.Font = new Font("Georgia", 12F);
            torlesButton.Location = new Point(532, 651);
            torlesButton.Name = "torlesButton";
            torlesButton.Size = new Size(189, 44);
            torlesButton.TabIndex = 7;
            torlesButton.Text = "Termék törlése";
            torlesButton.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            exportButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exportButton.Font = new Font("Georgia", 12F);
            exportButton.Location = new Point(1125, 650);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(206, 43);
            exportButton.TabIndex = 8;
            exportButton.Text = "Tábla exportálása";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 36F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 36);
            label1.Name = "label1";
            label1.Size = new Size(870, 69);
            label1.TabIndex = 9;
            label1.Text = "Termék karbantartó alkalmazás";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(28, 114);
            label2.Name = "label2";
            label2.Size = new Size(149, 24);
            label2.TabIndex = 10;
            label2.Text = "Termékek tábla";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(886, 114);
            label3.Name = "label3";
            label3.Size = new Size(179, 24);
            label3.TabIndex = 11;
            label3.Text = "Kategóriák szűrése";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(1125, 114);
            label4.Name = "label4";
            label4.Size = new Size(210, 24);
            label4.TabIndex = 12;
            label4.Text = "Rendelésszám szűrése";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 44, 40);
            ClientSize = new Size(1361, 741);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
