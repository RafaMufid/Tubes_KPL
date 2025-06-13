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
            buttonCredits = new Button();
            buttonExit = new Button();
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
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonCredits
            // 
            buttonCredits.BackColor = Color.Maroon;
            buttonCredits.FlatStyle = FlatStyle.Popup;
            buttonCredits.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCredits.ForeColor = Color.White;
            buttonCredits.Location = new Point(232, 312);
            buttonCredits.Margin = new Padding(3, 4, 3, 4);
            buttonCredits.Name = "buttonCredits";
            buttonCredits.Size = new Size(137, 43);
            buttonCredits.TabIndex = 3;
            buttonCredits.Text = "CREDITS";
            buttonCredits.UseVisualStyleBackColor = false;
            buttonCredits.Click += buttonCredit_Click;
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
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 553);
            Controls.Add(buttonExit);
            Controls.Add(buttonCredits);
            Controls.Add(buttonStart);
            Controls.Add(labelSubTitle);
            Controls.Add(labelTitle);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            Load += MainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelSubTitle;
        private Button buttonStart;
        private Button buttonCredits;
        private Button buttonExit;
    }
}