namespace DnDProjekt
{
    partial class MyDice
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
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pridat = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 18;
            label3.Text = "Ostatní";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(458, 3);
            button1.Name = "button1";
            button1.Size = new Size(29, 27);
            button1.TabIndex = 15;
            button1.Text = "🔍";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 20;
            label1.Text = "Mé Postavy";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(12, 67);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 15);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Mé Kostky";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(105, 39);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(717, 400);
            flowLayoutPanel1.TabIndex = 23;
            // 
            // pridat
            // 
            pridat.Location = new Point(8, 403);
            pridat.Name = "pridat";
            pridat.Size = new Size(91, 36);
            pridat.TabIndex = 22;
            pridat.Text = "Přidat kostku";
            pridat.UseVisualStyleBackColor = true;
            pridat.Click += pridat_Click;
            // 
            // MyDice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 451);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pridat);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "MyDice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mé Kostky";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private LinkLabel linkLabel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button pridat;
    }
}