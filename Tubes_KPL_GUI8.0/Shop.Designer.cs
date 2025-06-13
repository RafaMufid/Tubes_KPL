namespace Tubes_KPL_GUI8._0
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            colNamaProduk = new DataGridViewTextBoxColumn();
            colHarga = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Wide Latin", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(223, 40);
            label1.Name = "label1";
            label1.Size = new Size(141, 34);
            label1.TabIndex = 0;
            label1.Text = "Shop";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNamaProduk, colHarga, colStok });
            dataGridView1.Location = new Point(91, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(431, 81);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // colNamaProduk
            // 
            colNamaProduk.HeaderText = "Nama Produk";
            colNamaProduk.MinimumWidth = 6;
            colNamaProduk.Name = "colNamaProduk";
            colNamaProduk.Width = 125;
            // 
            // colHarga
            // 
            colHarga.HeaderText = "Harga";
            colHarga.MinimumWidth = 6;
            colHarga.Name = "colHarga";
            colHarga.Width = 125;
            // 
            // colStok
            // 
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 6;
            colStok.Name = "colStok";
            colStok.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 64, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(91, 220);
            button1.Name = "button1";
            button1.Size = new Size(210, 41);
            button1.TabIndex = 2;
            button1.Text = "Tambah Keranjang";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 64, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(307, 220);
            button2.Name = "button2";
            button2.Size = new Size(215, 41);
            button2.TabIndex = 3;
            button2.Text = "Checkout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Wide Latin", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(241, 182);
            label2.Name = "label2";
            label2.Size = new Size(121, 24);
            label2.TabIndex = 4;
            label2.Text = "Total: ";
            label2.Click += label2_Click;
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(620, 357);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Shop";
            Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colNamaProduk;
        private DataGridViewTextBoxColumn colHarga;
        private DataGridViewTextBoxColumn colStok;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}