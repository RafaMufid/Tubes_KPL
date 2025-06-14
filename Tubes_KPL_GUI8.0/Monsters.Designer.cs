namespace Tubes_KPL_GUI8._0
{
    partial class Monsters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monsters));
            labelMonster = new Label();
            labelInfo = new Label();
            labelName = new Label();
            labelHealth = new Label();
            labelRace = new Label();
            labelDamage = new Label();
            buttonBack = new Button();
            dataGridViewMonsters = new DataGridView();
            columnID = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnHealth = new DataGridViewTextBoxColumn();
            columnRace = new DataGridViewTextBoxColumn();
            columnDamage = new DataGridViewTextBoxColumn();
            textBoxName = new MaskedTextBox();
            textBoxHealth = new TextBox();
            textBoxRace = new TextBox();
            textBoxDamage = new TextBox();
            buttonAdd = new Button();
            buttonDel = new Button();
            buttonUpd = new Button();
            buttonClr = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonsters).BeginInit();
            SuspendLayout();
            // 
            // labelMonster
            // 
            labelMonster.AutoSize = true;
            labelMonster.BackColor = Color.Transparent;
            labelMonster.Font = new Font("Papyrus", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelMonster.Location = new Point(352, 66);
            labelMonster.Name = "labelMonster";
            labelMonster.Size = new Size(224, 69);
            labelMonster.TabIndex = 1;
            labelMonster.Text = "Monsters";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = Color.Transparent;
            labelInfo.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(58, 349);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(163, 30);
            labelInfo.TabIndex = 3;
            labelInfo.Text = "Monster Info";
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
            labelName.TabIndex = 4;
            labelName.Text = "Name : ";
            // 
            // labelHealth
            // 
            labelHealth.AutoSize = true;
            labelHealth.BackColor = Color.Transparent;
            labelHealth.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHealth.ImageAlign = ContentAlignment.TopLeft;
            labelHealth.Location = new Point(58, 430);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new Size(81, 22);
            labelHealth.TabIndex = 5;
            labelHealth.Text = "Health : ";
            // 
            // labelRace
            // 
            labelRace.AutoSize = true;
            labelRace.BackColor = Color.Transparent;
            labelRace.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRace.ImageAlign = ContentAlignment.MiddleLeft;
            labelRace.Location = new Point(283, 397);
            labelRace.Name = "labelRace";
            labelRace.Size = new Size(64, 22);
            labelRace.TabIndex = 6;
            labelRace.Text = "Race : ";
            labelRace.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDamage
            // 
            labelDamage.AutoSize = true;
            labelDamage.BackColor = Color.Transparent;
            labelDamage.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDamage.ImageAlign = ContentAlignment.MiddleLeft;
            labelDamage.Location = new Point(283, 430);
            labelDamage.Name = "labelDamage";
            labelDamage.Size = new Size(90, 22);
            labelDamage.TabIndex = 7;
            labelDamage.Text = "Damage : ";
            labelDamage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Tan;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Modern No. 20", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(40, 44);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // dataGridViewMonsters
            // 
            dataGridViewMonsters.BackgroundColor = Color.Tan;
            dataGridViewMonsters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMonsters.Columns.AddRange(new DataGridViewColumn[] { columnID, columnName, columnHealth, columnRace, columnDamage });
            dataGridViewMonsters.GridColor = Color.Tan;
            dataGridViewMonsters.Location = new Point(58, 149);
            dataGridViewMonsters.Name = "dataGridViewMonsters";
            dataGridViewMonsters.RowHeadersWidth = 51;
            dataGridViewMonsters.Size = new Size(487, 184);
            dataGridViewMonsters.TabIndex = 11;
            dataGridViewMonsters.SelectionChanged += dataGridViewMonsters_SelectionChanged;
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
            // columnHealth
            // 
            columnHealth.DataPropertyName = "health";
            columnHealth.HeaderText = "Health";
            columnHealth.MinimumWidth = 6;
            columnHealth.Name = "columnHealth";
            columnHealth.Width = 72;
            // 
            // columnRace
            // 
            columnRace.DataPropertyName = "race";
            columnRace.HeaderText = "Race";
            columnRace.MinimumWidth = 6;
            columnRace.Name = "columnRace";
            columnRace.Width = 125;
            // 
            // columnDamage
            // 
            columnDamage.DataPropertyName = "damage";
            columnDamage.HeaderText = "Damage";
            columnDamage.MinimumWidth = 6;
            columnDamage.Name = "columnDamage";
            columnDamage.Width = 72;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(135, 394);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 29);
            textBoxName.TabIndex = 12;
            // 
            // textBoxHealth
            // 
            textBoxHealth.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxHealth.Location = new Point(135, 427);
            textBoxHealth.Name = "textBoxHealth";
            textBoxHealth.Size = new Size(125, 29);
            textBoxHealth.TabIndex = 13;
            // 
            // textBoxRace
            // 
            textBoxRace.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRace.Location = new Point(379, 394);
            textBoxRace.Name = "textBoxRace";
            textBoxRace.Size = new Size(125, 29);
            textBoxRace.TabIndex = 14;
            // 
            // textBoxDamage
            // 
            textBoxDamage.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDamage.Location = new Point(379, 427);
            textBoxDamage.Name = "textBoxDamage";
            textBoxDamage.Size = new Size(125, 29);
            textBoxDamage.TabIndex = 15;
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
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
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
            buttonDel.TabIndex = 17;
            buttonDel.Text = "Delete";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
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
            buttonUpd.TabIndex = 18;
            buttonUpd.Text = "Update";
            buttonUpd.UseVisualStyleBackColor = false;
            buttonUpd.Click += buttonUpd_Click;
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
            buttonClr.TabIndex = 19;
            buttonClr.Text = "Clear";
            buttonClr.UseVisualStyleBackColor = false;
            buttonClr.Click += buttonClr_Click;
            // 
            // Monsters
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 553);
            Controls.Add(buttonClr);
            Controls.Add(buttonUpd);
            Controls.Add(buttonDel);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDamage);
            Controls.Add(textBoxRace);
            Controls.Add(textBoxHealth);
            Controls.Add(textBoxName);
            Controls.Add(dataGridViewMonsters);
            Controls.Add(buttonBack);
            Controls.Add(labelDamage);
            Controls.Add(labelRace);
            Controls.Add(labelHealth);
            Controls.Add(labelName);
            Controls.Add(labelInfo);
            Controls.Add(labelMonster);
            Name = "Monsters";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monsters";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonsters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelMonster;
        private Label labelInfo;
        private Label labelName;
        private Label labelHealth;
        private Label labelRace;
        private Label labelDamage;
        private Button buttonBack;
        private DataGridView dataGridViewMonsters;
        private MaskedTextBox textBoxName;
        private TextBox textBoxHealth;
        private TextBox textBoxRace;
        private TextBox textBoxDamage;
        private Button buttonAdd;
        private Button buttonDel;
        private Button buttonUpd;
        private Button buttonClr;
        private DataGridViewTextBoxColumn columnID;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnHealth;
        private DataGridViewTextBoxColumn columnRace;
        private DataGridViewTextBoxColumn columnDamage;
    }
}