namespace WinFormsLogin
{
    partial class Dashboard
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
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(44, 159);
            label2.Name = "label2";
            label2.Size = new Size(712, 45);
            label2.TabIndex = 7;
            label2.Text = "Извините, не реализовано еще :)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.LightGray;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(403, 234);
            button2.Name = "button2";
            button2.Size = new Size(250, 35);
            button2.TabIndex = 6;
            button2.Text = "Завершить процесс";
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.LightGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(139, 234);
            button1.Name = "button1";
            button1.Size = new Size(250, 35);
            button1.TabIndex = 8;
            button1.Text = "Повторить вход";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(68, 25);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 10;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button2);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}