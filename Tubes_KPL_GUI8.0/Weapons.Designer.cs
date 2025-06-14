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
            SuspendLayout();
            // 
            // labelWeapon
            // 
            labelWeapon.AutoSize = true;
            labelWeapon.BackColor = Color.Transparent;
            labelWeapon.Font = new Font("Papyrus", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelWeapon.Location = new Point(352, 66);
            labelWeapon.Name = "labelWeapon";
            labelWeapon.Size = new Size(221, 69);
            labelWeapon.TabIndex = 2;
            labelWeapon.Text = "Weapons";
            // 
            // Weapons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.med_bg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 553);
            Controls.Add(labelWeapon);
            ForeColor = SystemColors.ControlText;
            Name = "Weapons";
            Text = "Weapons";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWeapon;
    }
}