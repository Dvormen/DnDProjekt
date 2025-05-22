namespace DnDProjekt
{
    partial class HomePage
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            vScrollBar1 = new VScrollBar();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home";
            // 
            // button1
            // 
            button1.Location = new Point(458, 3);
            button1.Name = "button1";
            button1.Size = new Size(29, 27);
            button1.TabIndex = 3;
            button1.Text = "🔍";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 4;
            label1.Text = "My Characters";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "My Dice";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(766, 47);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(25, 394);
            vScrollBar1.TabIndex = 8;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vScrollBar1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomePage";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private VScrollBar vScrollBar1;
    }
}