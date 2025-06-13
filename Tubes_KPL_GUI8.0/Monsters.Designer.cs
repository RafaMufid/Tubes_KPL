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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonGoblin = new Button();
            labelInfo = new Label();
            labelName = new Label();
            labelHealth = new Label();
            labelRace = new Label();
            labelDamage = new Label();
            buttonFiend = new Button();
            buttonDragon = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelMonster
            // 
            labelMonster.AutoSize = true;
            labelMonster.BackColor = Color.Transparent;
            labelMonster.Font = new Font("Papyrus", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelMonster.Location = new Point(337, 71);
            labelMonster.Name = "labelMonster";
            labelMonster.Size = new Size(237, 74);
            labelMonster.TabIndex = 1;
            labelMonster.Text = "Monsters";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // buttonGoblin
            // 
            buttonGoblin.BackColor = Color.Transparent;
            buttonGoblin.BackgroundImage = Properties.Resources.Goblin;
            buttonGoblin.BackgroundImageLayout = ImageLayout.Stretch;
            buttonGoblin.Location = new Point(83, 159);
            buttonGoblin.Name = "buttonGoblin";
            buttonGoblin.Size = new Size(160, 160);
            buttonGoblin.TabIndex = 2;
            buttonGoblin.Text = "button1";
            buttonGoblin.UseVisualStyleBackColor = false;
            buttonGoblin.Click += buttonGoblin_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = Color.Transparent;
            labelInfo.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(83, 345);
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
            labelName.Location = new Point(83, 393);
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
            labelHealth.Location = new Point(83, 426);
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
            labelRace.Location = new Point(308, 393);
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
            labelDamage.Location = new Point(308, 426);
            labelDamage.Name = "labelDamage";
            labelDamage.Size = new Size(90, 22);
            labelDamage.TabIndex = 7;
            labelDamage.Text = "Damage : ";
            labelDamage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonFiend
            // 
            buttonFiend.BackgroundImage = Properties.Resources.Fiend;
            buttonFiend.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFiend.Location = new Point(461, 159);
            buttonFiend.Name = "buttonFiend";
            buttonFiend.Size = new Size(160, 160);
            buttonFiend.TabIndex = 8;
            buttonFiend.Text = "button1";
            buttonFiend.UseVisualStyleBackColor = true;
            buttonFiend.Click += buttonFiend_Click;
            // 
            // buttonDragon
            // 
            buttonDragon.BackgroundImage = Properties.Resources.Dragon;
            buttonDragon.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDragon.Location = new Point(269, 159);
            buttonDragon.Name = "buttonDragon";
            buttonDragon.Size = new Size(160, 160);
            buttonDragon.TabIndex = 9;
            buttonDragon.Text = "button2";
            buttonDragon.UseVisualStyleBackColor = true;
            buttonDragon.Click += buttonDragon_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Tan;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Modern No. 20", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(83, 89);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // Monsters
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 553);
            Controls.Add(buttonBack);
            Controls.Add(buttonDragon);
            Controls.Add(buttonFiend);
            Controls.Add(labelDamage);
            Controls.Add(labelRace);
            Controls.Add(labelHealth);
            Controls.Add(labelName);
            Controls.Add(labelInfo);
            Controls.Add(buttonGoblin);
            Controls.Add(labelMonster);
            Name = "Monsters";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monsters";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelMonster;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonGoblin;
        private Label labelInfo;
        private Label labelName;
        private Label labelHealth;
        private Label labelRace;
        private Label labelDamage;
        private Button buttonFiend;
        private Button buttonDragon;
        private Button buttonBack;
    }
}