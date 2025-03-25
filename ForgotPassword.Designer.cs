namespace WinFormsLogin
{
    partial class ForgotPassword
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
            linkLabel1 = new LinkLabel();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(350, 344);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(97, 15);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Перейти к входу";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox2
            // 
            textBox2.AllowDrop = true;
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(275, 244);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '1';
            textBox2.PlaceholderText = "Повторно введите пароль";
            textBox2.Size = new Size(250, 29);
            textBox2.TabIndex = 18;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(250, 89);
            label1.Name = "label1";
            label1.Size = new Size(304, 45);
            label1.TabIndex = 16;
            label1.Text = "Сбросить пароль";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.LightGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(275, 291);
            button1.Name = "button1";
            button1.Size = new Size(250, 35);
            button1.TabIndex = 15;
            button1.Text = "Сбросить";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox3
            // 
            textBox3.AllowDrop = true;
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(275, 154);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Введите свой логин";
            textBox3.Size = new Size(250, 29);
            textBox3.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(275, 199);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '1';
            textBox1.PlaceholderText = "Придумайте новый пароль";
            textBox1.Size = new Size(250, 29);
            textBox1.TabIndex = 21;
            textBox1.UseSystemPasswordChar = true;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            Load += ForgotPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        // Add the missing event handler method for linkLabel2_LinkClicked
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Add your logic here for handling the link click event
        }
        // Add the missing event handler method for textBox2_TextChanged
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Add your logic here for handling the text changed event
        }
        // Add the missing event handler method for textBox1_TextChanged
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Add your logic here for handling the text changed event
        }
        // Add the missing event handler method for label1_Click
        private void label1_Click(object sender, EventArgs e)
        {
            // Add your logic here for handling the label click event
        }

        #endregion
        private LinkLabel linkLabel1;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox1;
    }
}