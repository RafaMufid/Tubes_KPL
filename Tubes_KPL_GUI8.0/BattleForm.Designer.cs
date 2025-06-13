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
            BattleTurn.Location = new Point(12, 9);
            BattleTurn.Name = "BattleTurn";
            BattleTurn.Size = new Size(205, 33);
            BattleTurn.TabIndex = 0;
            BattleTurn.Text = "Battle Turn : ";
            // 
            // PlayerHP
            // 
            PlayerHP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerHP.Location = new Point(58, 386);
            PlayerHP.Name = "PlayerHP";
            PlayerHP.Size = new Size(149, 28);
            PlayerHP.TabIndex = 1;
            PlayerHP.Text = "Player HP :";
            // 
            // EnemyHP
            // 
            EnemyHP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnemyHP.Location = new Point(658, 133);
            EnemyHP.Name = "EnemyHP";
            EnemyHP.Size = new Size(143, 30);
            EnemyHP.TabIndex = 2;
            EnemyHP.Text = "Enemy HP :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Location = new Point(0, 362);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(944, 199);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lstInventory
            // 
            lstInventory.ItemHeight = 15;
            lstInventory.Location = new Point(301, 386);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(200, 139);
            lstInventory.TabIndex = 0;
            // 
            // AttackButton
            // 
            AttackButton.Location = new Point(559, 461);
            AttackButton.Name = "AttackButton";
            AttackButton.Size = new Size(123, 38);
            AttackButton.TabIndex = 4;
            AttackButton.Text = "Attack";
            AttackButton.UseVisualStyleBackColor = true;
            AttackButton.Click += AttackButton_Click_1;
            // 
            // RunButton
            // 
            RunButton.Location = new Point(732, 461);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(123, 38);
            RunButton.TabIndex = 5;
            RunButton.Text = "Run";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click_1;
            // 
            // txtWeaponName
            // 
            txtWeaponName.Location = new Point(559, 408);
            txtWeaponName.Name = "txtWeaponName";
            txtWeaponName.Size = new Size(150, 23);
            txtWeaponName.TabIndex = 0;
            // 
            // battleLog
            // 
            battleLog.BackColor = SystemColors.ControlDarkDark;
            battleLog.Location = new Point(12, 47);
            battleLog.Multiline = true;
            battleLog.Name = "battleLog";
            battleLog.ReadOnly = true;
            battleLog.ScrollBars = ScrollBars.Vertical;
            battleLog.Size = new Size(285, 116);
            battleLog.TabIndex = 0;
            // 
            // BattleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.battleback10;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(944, 561);
            Controls.Add(battleLog);
            Controls.Add(txtWeaponName);
            Controls.Add(RunButton);
            Controls.Add(AttackButton);
            Controls.Add(lstInventory);
            Controls.Add(EnemyHP);
            Controls.Add(PlayerHP);
            Controls.Add(BattleTurn);
            Controls.Add(pictureBox1);
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