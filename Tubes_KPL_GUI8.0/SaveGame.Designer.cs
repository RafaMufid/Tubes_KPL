namespace Tubes_KPL_GUI8._0
{
    partial class SaveGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveGame));
            label1 = new Label();
            textBoxPlayer = new TextBox();
            label2 = new Label();
            textBoxSave = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxDialog = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Calligraphy", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 73);
            label1.Name = "label1";
            label1.Size = new Size(255, 52);
            label1.TabIndex = 0;
            label1.Text = "Save Game";
            // 
            // textBoxPlayer
            // 
            textBoxPlayer.Location = new Point(138, 170);
            textBoxPlayer.Name = "textBoxPlayer";
            textBoxPlayer.Size = new Size(148, 27);
            textBoxPlayer.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 147);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Nama Player";
            // 
            // textBoxSave
            // 
            textBoxSave.Location = new Point(138, 232);
            textBoxSave.Name = "textBoxSave";
            textBoxSave.Size = new Size(148, 27);
            textBoxSave.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(138, 209);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 4;
            label3.Text = "ID Save";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 274);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 5;
            label4.Text = "ID Dialog";
            label4.Click += label4_Click;
            // 
            // textBoxDialog
            // 
            textBoxDialog.Location = new Point(138, 297);
            textBoxDialog.Name = "textBoxDialog";
            textBoxDialog.Size = new Size(148, 27);
            textBoxDialog.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(214, 348);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // SaveGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(542, 408);
            Controls.Add(button1);
            Controls.Add(textBoxDialog);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxSave);
            Controls.Add(label2);
            Controls.Add(textBoxPlayer);
            Controls.Add(label1);
            Name = "SaveGame";
            Text = "SaveGame";
            Load += SaveGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPlayer;
        private Label label2;
        private TextBox textBoxSave;
        private Label label3;
        private Label label4;
        private TextBox textBoxDialog;
        private Button button1;
    }
}