namespace DnDProjekt
{
    partial class MyCharacters
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
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            pridat = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 11;
            label2.Text = "My Dice";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(458, 3);
            button1.Name = "button1";
            button1.Size = new Size(29, 27);
            button1.TabIndex = 9;
            button1.Text = "🔍";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 13;
            label3.Text = "Home";
            label3.Click += label3_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(12, 37);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(83, 15);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "My Characters";
            // 
            // pridat
            // 
            pridat.Location = new Point(12, 402);
            pridat.Name = "pridat";
            pridat.Size = new Size(112, 36);
            pridat.TabIndex = 15;
            pridat.Text = "Přidat postavu";
            pridat.UseVisualStyleBackColor = true;
            pridat.Click += pridat_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(130, 38);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 400);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // MyCharacters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pridat);
            Controls.Add(linkLabel2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MyCharacters";
            Text = "MyCharacters";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Label label3;
        private LinkLabel linkLabel2;
        private Button pridat;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}