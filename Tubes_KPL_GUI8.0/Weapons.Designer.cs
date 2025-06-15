namespace Tubes_KPL_GUI8._0
{
    partial class Weapons
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
            labelWeapon = new Label();
            buttonBack = new Button();
            dataGridViewWeapons = new DataGridView();
            columnID = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnType = new DataGridViewTextBoxColumn();
            columnPrice = new DataGridViewTextBoxColumn();
            columnDamage = new DataGridViewTextBoxColumn();
            textBoxDamage = new TextBox();
            textBoxPrice = new TextBox();
            textBoxType = new TextBox();
            textBoxName = new MaskedTextBox();
            labelDamage = new Label();
            labelPrice = new Label();
            labelType = new Label();
            labelName = new Label();
            labelInfo = new Label();
            buttonClr = new Button();
            buttonUpd = new Button();
            buttonDel = new Button();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWeapons).BeginInit();
            SuspendLayout();
            // 
            // labelWeapon
            // 
            labelWeapon.AutoSize = true;
            labelWeapon.BackColor = Color.Transparent;
            labelWeapon.Font = new Font("Papyrus", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelWeapon.Location = new Point(342, 64);
            labelWeapon.Name = "labelWeapon";
            labelWeapon.Size = new Size(221, 69);
            labelWeapon.TabIndex = 2;
            labelWeapon.Text = "Weapons";
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
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // dataGridViewWeapons
            // 
            dataGridViewWeapons.BackgroundColor = Color.Tan;
            dataGridViewWeapons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWeapons.Columns.AddRange(new DataGridViewColumn[] { columnID, columnName, columnType, columnPrice, columnDamage });
            dataGridViewWeapons.GridColor = Color.Tan;
            dataGridViewWeapons.Location = new Point(58, 149);
            dataGridViewWeapons.Name = "dataGridViewWeapons";
            dataGridViewWeapons.RowHeadersWidth = 51;
            dataGridViewWeapons.Size = new Size(487, 184);
            dataGridViewWeapons.TabIndex = 12;
            dataGridViewWeapons.SelectionChanged += dataGridViewWeapons_SelectionChanged;
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
            // columnType
            // 
            columnType.DataPropertyName = "type";
            columnType.HeaderText = "Type";
            columnType.MinimumWidth = 6;
            columnType.Name = "columnType";
            columnType.Width = 92;
            // 
            // columnPrice
            // 
            columnPrice.DataPropertyName = "price";
            columnPrice.HeaderText = "Price";
            columnPrice.MinimumWidth = 6;
            columnPrice.Name = "columnPrice";
            columnPrice.Width = 80;
            // 
            // columnDamage
            // 
            columnDamage.DataPropertyName = "baseDamage";
            columnDamage.HeaderText = "Damage";
            columnDamage.MinimumWidth = 6;
            columnDamage.Name = "columnDamage";
            columnDamage.Width = 80;
            // 
            // textBoxDamage
            // 
            textBoxDamage.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDamage.Location = new Point(379, 427);
            textBoxDamage.Name = "textBoxDamage";
            textBoxDamage.Size = new Size(125, 29);
            textBoxDamage.TabIndex = 24;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPrice.Location = new Point(379, 394);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 29);
            textBoxPrice.TabIndex = 23;
            // 
            // textBoxType
            // 
            textBoxType.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxType.Location = new Point(135, 427);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(125, 29);
            textBoxType.TabIndex = 22;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(135, 394);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 29);
            textBoxName.TabIndex = 21;
            // 
            // labelDamage
            // 
            labelDamage.AutoSize = true;
            labelDamage.BackColor = Color.Transparent;
            labelDamage.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDamage.ImageAlign = ContentAlignment.MiddleLeft;
            labelDamage.Location = new Point(283, 430);
            labelDamage.Name = "labelDamage";
            labelDamage.Size = new Size(85, 22);
            labelDamage.TabIndex = 20;
            labelDamage.Text = "Damage: ";
            labelDamage.TextAlign = ContentAlignment.MiddleLeft;
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
            labelPrice.TabIndex = 19;
            labelPrice.Text = "Price : ";
            labelPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.BackColor = Color.Transparent;
            labelType.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelType.ImageAlign = ContentAlignment.TopLeft;
            labelType.Location = new Point(58, 430);
            labelType.Name = "labelType";
            labelType.Size = new Size(64, 22);
            labelType.TabIndex = 18;
            labelType.Text = "Type : ";
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
            labelName.TabIndex = 17;
            labelName.Text = "Name : ";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = Color.Transparent;
            labelInfo.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(58, 349);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(163, 30);
            labelInfo.TabIndex = 16;
            labelInfo.Text = "Weapon Info";
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
            buttonClr.TabIndex = 28;
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
            buttonUpd.TabIndex = 27;
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
            buttonDel.TabIndex = 26;
            buttonDel.Text = "Delete";
            buttonDel.UseVisualStyleBackColor = false;
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
            buttonAdd.TabIndex = 25;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Weapons
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
            Controls.Add(textBoxDamage);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxType);
            Controls.Add(textBoxName);
            Controls.Add(labelDamage);
            Controls.Add(labelPrice);
            Controls.Add(labelType);
            Controls.Add(labelName);
            Controls.Add(labelInfo);
            Controls.Add(dataGridViewWeapons);
            Controls.Add(buttonBack);
            Controls.Add(labelWeapon);
            ForeColor = SystemColors.ControlText;
            Name = "Weapons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weapons";
            ((System.ComponentModel.ISupportInitialize)dataGridViewWeapons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWeapon;
        private Button buttonBack;
        private DataGridView dataGridViewWeapons;
        private TextBox textBoxDamage;
        private TextBox textBoxPrice;
        private TextBox textBoxType;
        private MaskedTextBox textBoxName;
        private Label labelDamage;
        private Label labelPrice;
        private Label labelType;
        private Label labelName;
        private Label labelInfo;
        private Button buttonClr;
        private Button buttonUpd;
        private Button buttonDel;
        private Button buttonAdd;
        private DataGridViewTextBoxColumn columnID;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnType;
        private DataGridViewTextBoxColumn columnPrice;
        private DataGridViewTextBoxColumn columnDamage;
    }
}