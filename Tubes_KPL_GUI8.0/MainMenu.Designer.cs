namespace Tubes_KPL_GUI8._0
{
    partial class MainMenu
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
            labelTitle = new Label();
            labelSubTitle = new Label();
            buttonStart = new Button();
            buttonSettings = new Button();
            buttonExit = new Button();
            buttonCredits = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Papyrus", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Maroon;
            labelTitle.Location = new Point(71, 98);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(472, 74);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Simplest Text RPG";
            // 
            // labelSubTitle
            // 
            labelSubTitle.AutoSize = true;
            labelSubTitle.BackColor = Color.Transparent;
            labelSubTitle.Font = new Font("Papyrus", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSubTitle.ForeColor = Color.Maroon;
            labelSubTitle.Location = new Point(87, 172);
            labelSubTitle.Name = "labelSubTitle";
            labelSubTitle.Size = new Size(438, 37);
            labelSubTitle.TabIndex = 1;
            labelSubTitle.Text = "*  *  *  Made for Assesment KPL  *  *  *";
            labelSubTitle.Click += labelSubTitle_Click;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Maroon;
            buttonStart.FlatStyle = FlatStyle.Popup;
            buttonStart.Font = new Font("Viner Hand ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.ForeColor = Color.White;
            buttonStart.Location = new Point(216, 236);
            buttonStart.Margin = new Padding(3, 4, 3, 4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(165, 53);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = false;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.Maroon;
            buttonSettings.FlatStyle = FlatStyle.Popup;
            buttonSettings.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSettings.ForeColor = Color.White;
            buttonSettings.Location = new Point(232, 312);
            buttonSettings.Margin = new Padding(3, 4, 3, 4);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(137, 43);
            buttonSettings.TabIndex = 3;
            buttonSettings.Text = "SETTINGS";
            buttonSettings.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Maroon;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(246, 380);
            buttonExit.Margin = new Padding(2, 3, 2, 3);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(110, 37);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonCredits
            // 
            buttonCredits.BackColor = Color.Transparent;
            buttonCredits.FlatStyle = FlatStyle.Popup;
            buttonCredits.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCredits.ForeColor = Color.White;
            buttonCredits.Location = new Point(813, 492);
            buttonCredits.Margin = new Padding(2, 3, 2, 3);
            buttonCredits.Name = "buttonCredits";
            buttonCredits.Size = new Size(101, 37);
            buttonCredits.TabIndex = 5;
            buttonCredits.Text = "CREDITS";
            buttonCredits.UseVisualStyleBackColor = false;
            buttonCredits.Click += buttonCredits_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(942, 553);
            Controls.Add(buttonCredits);
            Controls.Add(buttonExit);
            Controls.Add(buttonSettings);
            Controls.Add(buttonStart);
            Controls.Add(labelSubTitle);
            Controls.Add(labelTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelSubTitle;
        private Button buttonStart;
        private Button buttonSettings;
        private Button buttonExit;
        private Button buttonCredits;
    }
}