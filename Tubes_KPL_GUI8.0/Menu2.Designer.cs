namespace Tubes_KPL_GUI8._0
{
    partial class Menu2
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
            label1 = new Label();
            buttonCompendium = new Button();
            buttonBattle = new Button();
            buttonShop = new Button();
            buttonMaze = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Viner Hand ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(59, 59);
            label1.Name = "label1";
            label1.Size = new Size(279, 65);
            label1.TabIndex = 0;
            label1.Text = "Test Features";
            // 
            // buttonCompendium
            // 
            buttonCompendium.BackColor = Color.Firebrick;
            buttonCompendium.FlatStyle = FlatStyle.Popup;
            buttonCompendium.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCompendium.ForeColor = Color.Transparent;
            buttonCompendium.Location = new Point(136, 160);
            buttonCompendium.Name = "buttonCompendium";
            buttonCompendium.Size = new Size(128, 32);
            buttonCompendium.TabIndex = 1;
            buttonCompendium.Text = "Compendium";
            buttonCompendium.UseVisualStyleBackColor = false;
            buttonCompendium.Click += buttonCompendium_Click;
            // 
            // buttonBattle
            // 
            buttonBattle.BackColor = Color.Firebrick;
            buttonBattle.FlatStyle = FlatStyle.Popup;
            buttonBattle.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBattle.ForeColor = Color.Transparent;
            buttonBattle.Location = new Point(160, 200);
            buttonBattle.Name = "buttonBattle";
            buttonBattle.Size = new Size(80, 28);
            buttonBattle.TabIndex = 2;
            buttonBattle.Text = "Battle";
            buttonBattle.UseVisualStyleBackColor = false;
            buttonBattle.Click += buttonBattle_Click;
            // 
            // buttonShop
            // 
            buttonShop.BackColor = Color.Firebrick;
            buttonShop.FlatStyle = FlatStyle.Popup;
            buttonShop.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonShop.ForeColor = Color.Transparent;
            buttonShop.Location = new Point(160, 236);
            buttonShop.Name = "buttonShop";
            buttonShop.Size = new Size(80, 28);
            buttonShop.TabIndex = 3;
            buttonShop.Text = "Shop";
            buttonShop.UseVisualStyleBackColor = false;
            // 
            // buttonMaze
            // 
            buttonMaze.BackColor = Color.Firebrick;
            buttonMaze.FlatStyle = FlatStyle.Popup;
            buttonMaze.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMaze.ForeColor = Color.Transparent;
            buttonMaze.Location = new Point(160, 272);
            buttonMaze.Name = "buttonMaze";
            buttonMaze.Size = new Size(80, 28);
            buttonMaze.TabIndex = 4;
            buttonMaze.Text = "Maze";
            buttonMaze.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Firebrick;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Modern No. 20", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = Color.Transparent;
            buttonBack.Location = new Point(11, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(59, 28);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // Menu2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(382, 353);
            Controls.Add(buttonBack);
            Controls.Add(buttonMaze);
            Controls.Add(buttonShop);
            Controls.Add(buttonBattle);
            Controls.Add(buttonCompendium);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonCompendium;
        private Button buttonBattle;
        private Button buttonShop;
        private Button buttonMaze;
        private Button buttonBack;
    }
}