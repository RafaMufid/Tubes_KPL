namespace Tubes_KPL_GUI8._0
{
    partial class Charms
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
            labelCharm = new Label();
            buttonBack = new Button();
            dataGridViewCharms = new DataGridView();
            columnID = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnPrice = new DataGridViewTextBoxColumn();
            columnEffect = new DataGridViewTextBoxColumn();
            textBoxPrice = new TextBox();
            textBoxEffect = new TextBox();
            textBoxName = new MaskedTextBox();
            labelPrice = new Label();
            labelEffect = new Label();
            labelName = new Label();
            labelInfo = new Label();
            buttonClr = new Button();
            buttonUpd = new Button();
            buttonDel = new Button();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCharms).BeginInit();
            SuspendLayout();
            // 
            // labelCharm
            // 
            labelCharm.AutoSize = true;
            labelCharm.BackColor = Color.Transparent;
            labelCharm.Font = new Font("Papyrus", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCharm.Location = new Point(362, 70);
            labelCharm.Name = "labelCharm";
            labelCharm.Size = new Size(190, 69);
            labelCharm.TabIndex = 3;
            labelCharm.Text = "Charms";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Tan;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Modern No. 20", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = SystemColors.WindowText;
            buttonBack.Location = new Point(40, 44);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 4;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // dataGridViewCharms
            // 
            dataGridViewCharms.BackgroundColor = Color.Tan;
            dataGridViewCharms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCharms.Columns.AddRange(new DataGridViewColumn[] { columnID, columnName, columnPrice, columnEffect });
            dataGridViewCharms.GridColor = Color.Tan;
            dataGridViewCharms.Location = new Point(58, 149);
            dataGridViewCharms.Name = "dataGridViewCharms";
            dataGridViewCharms.RowHeadersWidth = 51;
            dataGridViewCharms.Size = new Size(407, 184);
            dataGridViewCharms.TabIndex = 13;
            dataGridViewCharms.SelectionChanged += dataGridViewCharms_SelectionChanged_1;
            // 
            // columnID
            // 
            columnID.DataPropertyName = "id";
            columnID.HeaderText = "ID";
            columnID.MinimumWidth = 6;
            columnID.Name = "columnID";
            columnID.Width = 32;
            // 
            // columnName
            // 
            columnName.DataPropertyName = "name";
            columnName.HeaderText = "Name";
            columnName.MinimumWidth = 6;
            columnName.Name = "columnName";
            columnName.Width = 125;
            // 
            // columnPrice
            // 
            columnPrice.DataPropertyName = "price";
            columnPrice.HeaderText = "Price";
            columnPrice.MinimumWidth = 6;
            columnPrice.Name = "columnPrice";
            columnPrice.Width = 80;
            // 
            // columnEffect
            // 
            columnEffect.DataPropertyName = "effect";
            columnEffect.HeaderText = "Effect";
            columnEffect.MinimumWidth = 6;
            columnEffect.Name = "columnEffect";
            columnEffect.Width = 92;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPrice.Location = new Point(363, 394);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 29);
            textBoxPrice.TabIndex = 30;
            // 
            // textBoxEffect
            // 
            textBoxEffect.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEffect.Location = new Point(135, 427);
            textBoxEffect.Name = "textBoxEffect";
            textBoxEffect.Size = new Size(125, 29);
            textBoxEffect.TabIndex = 29;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(135, 394);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 29);
            textBoxName.TabIndex = 28;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.BackColor = Color.Transparent;
            labelPrice.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.ImageAlign = ContentAlignment.MiddleLeft;
            labelPrice.Location = new Point(283, 397);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(68, 22);
            labelPrice.TabIndex = 27;
            labelPrice.Text = "Price : ";
            labelPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelEffect
            // 
            labelEffect.AutoSize = true;
            labelEffect.BackColor = Color.Transparent;
            labelEffect.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEffect.ImageAlign = ContentAlignment.TopLeft;
            labelEffect.Location = new Point(58, 430);
            labelEffect.Name = "labelEffect";
            labelEffect.Size = new Size(75, 22);
            labelEffect.TabIndex = 26;
            labelEffect.Text = "Effect : ";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ImageAlign = ContentAlignment.TopLeft;
            labelName.Location = new Point(58, 397);
            labelName.Name = "labelName";
            labelName.Size = new Size(71, 22);
            labelName.TabIndex = 25;
            labelName.Text = "Name : ";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = Color.Transparent;
            labelInfo.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(58, 349);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(156, 30);
            labelInfo.TabIndex = 24;
            labelInfo.Text = "Charms Info";
            // 
            // buttonClr
            // 
            buttonClr.BackColor = Color.Tan;
            buttonClr.FlatStyle = FlatStyle.Popup;
            buttonClr.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClr.ForeColor = Color.SaddleBrown;
            buttonClr.Location = new Point(721, 437);
            buttonClr.Name = "buttonClr";
            buttonClr.Size = new Size(123, 50);
            buttonClr.TabIndex = 34;
            buttonClr.Text = "Clear";
            buttonClr.UseVisualStyleBackColor = false;
            // 
            // buttonUpd
            // 
            buttonUpd.BackColor = Color.Tan;
            buttonUpd.FlatStyle = FlatStyle.Popup;
            buttonUpd.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpd.ForeColor = Color.SaddleBrown;
            buttonUpd.Location = new Point(550, 437);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(134, 50);
            buttonUpd.TabIndex = 33;
            buttonUpd.Text = "Update";
            buttonUpd.UseVisualStyleBackColor = false;
            buttonUpd.Click += buttonUpd_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.Tan;
            buttonDel.FlatStyle = FlatStyle.Popup;
            buttonDel.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDel.ForeColor = Color.SaddleBrown;
            buttonDel.Location = new Point(723, 369);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(121, 50);
            buttonDel.TabIndex = 32;
            buttonDel.Text = "Delete";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Tan;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.SaddleBrown;
            buttonAdd.Location = new Point(554, 369);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(121, 50);
            buttonAdd.TabIndex = 31;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Charms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.med_bg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 553);
            Controls.Add(buttonClr);
            Controls.Add(buttonUpd);
            Controls.Add(buttonDel);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxEffect);
            Controls.Add(textBoxName);
            Controls.Add(labelPrice);
            Controls.Add(labelEffect);
            Controls.Add(labelName);
            Controls.Add(labelInfo);
            Controls.Add(dataGridViewCharms);
            Controls.Add(buttonBack);
            Controls.Add(labelCharm);
            Name = "Charms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Charms";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCharms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCharm;
        private Button buttonBack;
        private DataGridView dataGridViewCharms;
        private DataGridViewTextBoxColumn columnID;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnPrice;
        private DataGridViewTextBoxColumn columnEffect;
        private TextBox textBoxPrice;
        private TextBox textBoxEffect;
        private MaskedTextBox textBoxName;
        private Label labelPrice;
        private Label labelEffect;
        private Label labelName;
        private Label labelInfo;
        private Button buttonClr;
        private Button buttonUpd;
        private Button buttonDel;
        private Button buttonAdd;
    }
}