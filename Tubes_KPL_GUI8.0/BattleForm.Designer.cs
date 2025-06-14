namespace Tubes_KPL_GUI8._0
{
    partial class BattleForm
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
            BattleTurn = new Label();
            PlayerHP = new Label();
            EnemyHP = new Label();
            pictureBox1 = new PictureBox();
            lstInventory = new ListBox();
            AttackButton = new Button();
            RunButton = new Button();
            txtWeaponName = new TextBox();
            battleLog = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BattleTurn
            // 
            BattleTurn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BattleTurn.Location = new Point(14, 12);
            BattleTurn.Name = "BattleTurn";
            BattleTurn.Size = new Size(234, 44);
            BattleTurn.TabIndex = 0;
            BattleTurn.Text = "Battle Turn : ";
            // 
            // PlayerHP
            // 
            PlayerHP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerHP.Location = new Point(66, 515);
            PlayerHP.Name = "PlayerHP";
            PlayerHP.Size = new Size(170, 37);
            PlayerHP.TabIndex = 1;
            PlayerHP.Text = "Player HP :";
            // 
            // EnemyHP
            // 
            EnemyHP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnemyHP.Location = new Point(752, 177);
            EnemyHP.Name = "EnemyHP";
            EnemyHP.Size = new Size(163, 40);
            EnemyHP.TabIndex = 2;
            EnemyHP.Text = "Enemy HP :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Location = new Point(0, 483);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1079, 265);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lstInventory
            // 
            lstInventory.Location = new Point(279, 515);
            lstInventory.Margin = new Padding(3, 4, 3, 4);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(524, 184);
            lstInventory.TabIndex = 0;
            lstInventory.SelectedIndexChanged += lstInventory_SelectedIndexChanged;
            // 
            // AttackButton
            // 
            AttackButton.Location = new Point(881, 577);
            AttackButton.Margin = new Padding(3, 4, 3, 4);
            AttackButton.Name = "AttackButton";
            AttackButton.Size = new Size(141, 51);
            AttackButton.TabIndex = 4;
            AttackButton.Text = "Attack";
            AttackButton.UseVisualStyleBackColor = true;
            AttackButton.Click += AttackButton_Click_1;
            // 
            // RunButton
            // 
            RunButton.Location = new Point(881, 649);
            RunButton.Margin = new Padding(3, 4, 3, 4);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(141, 51);
            RunButton.TabIndex = 5;
            RunButton.Text = "Run";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click_1;
            // 
            // txtWeaponName
            // 
            txtWeaponName.Location = new Point(850, 515);
            txtWeaponName.Margin = new Padding(3, 4, 3, 4);
            txtWeaponName.Name = "txtWeaponName";
            txtWeaponName.Size = new Size(171, 27);
            txtWeaponName.TabIndex = 0;
            // 
            // battleLog
            // 
            battleLog.BackColor = SystemColors.ControlDarkDark;
            battleLog.Location = new Point(14, 63);
            battleLog.Margin = new Padding(3, 4, 3, 4);
            battleLog.Multiline = true;
            battleLog.Name = "battleLog";
            battleLog.ReadOnly = true;
            battleLog.ScrollBars = ScrollBars.Vertical;
            battleLog.Size = new Size(325, 153);
            battleLog.TabIndex = 0;
            // 
            // BattleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.battleback10;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1079, 748);
            Controls.Add(battleLog);
            Controls.Add(txtWeaponName);
            Controls.Add(RunButton);
            Controls.Add(AttackButton);
            Controls.Add(lstInventory);
            Controls.Add(EnemyHP);
            Controls.Add(PlayerHP);
            Controls.Add(BattleTurn);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BattleForm";
            Text = "Form2";
            Load += BattleForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BattleTurn;
        private Label PlayerHP;
        private Label EnemyHP;
        private PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstInventory;
        private Button AttackButton;
        private Button RunButton;
        private TextBox txtWeaponName;
        private TextBox battleLog;
    }
}