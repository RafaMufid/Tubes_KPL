namespace Tubes_KPL_GUI8._0
{
    partial class Compendium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compendium));
            label1 = new Label();
            buttonMonster = new Button();
            buttonWeapon = new Button();
            buttonCharm = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Papyrus", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 96);
            label1.Name = "label1";
            label1.Size = new Size(716, 94);
            label1.TabIndex = 0;
            label1.Text = "C O M P E N D I U M";
            label1.Click += label1_Click;
            // 
            // buttonMonster
            // 
            buttonMonster.BackColor = Color.Tan;
            buttonMonster.FlatStyle = FlatStyle.Popup;
            buttonMonster.Font = new Font("Modern No. 20", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMonster.Location = new Point(120, 218);
            buttonMonster.Name = "buttonMonster";
            buttonMonster.Size = new Size(200, 200);
            buttonMonster.TabIndex = 1;
            buttonMonster.Text = "Monsters";
            buttonMonster.UseVisualStyleBackColor = false;
            buttonMonster.Click += buttonMonster_Click;
            // 
            // buttonWeapon
            // 
            buttonWeapon.BackColor = Color.Tan;
            buttonWeapon.FlatStyle = FlatStyle.Popup;
            buttonWeapon.Font = new Font("Modern No. 20", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonWeapon.Location = new Point(380, 218);
            buttonWeapon.Name = "buttonWeapon";
            buttonWeapon.Size = new Size(200, 200);
            buttonWeapon.TabIndex = 2;
            buttonWeapon.Text = "Weapons";
            buttonWeapon.UseVisualStyleBackColor = false;
            // 
            // buttonCharm
            // 
            buttonCharm.BackColor = Color.Tan;
            buttonCharm.FlatStyle = FlatStyle.Popup;
            buttonCharm.Font = new Font("Modern No. 20", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCharm.Location = new Point(640, 218);
            buttonCharm.Name = "buttonCharm";
            buttonCharm.Size = new Size(200, 200);
            buttonCharm.TabIndex = 3;
            buttonCharm.Text = "Charms";
            buttonCharm.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Tan;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Modern No. 20", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(77, 473);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 4;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // Compendium
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 553);
            Controls.Add(buttonBack);
            Controls.Add(buttonCharm);
            Controls.Add(buttonWeapon);
            Controls.Add(buttonMonster);
            Controls.Add(label1);
            Name = "Compendium";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compendium";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonMonster;
        private Button buttonWeapon;
        private Button buttonCharm;
        private Button buttonBack;
    }
}