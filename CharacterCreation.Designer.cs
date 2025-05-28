namespace DnDProjekt
{
    partial class CharacterCreation
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            NameBox = new TextBox();
            SurnameBox = new TextBox();
            RaceBox = new ComboBox();
            ClassBox = new ComboBox();
            SubclassBox = new ComboBox();
            HeightBox = new NumericUpDown();
            vahaBox = new NumericUpDown();
            vekBox = new NumericUpDown();
            Hp = new NumericUpDown();
            Ac = new NumericUpDown();
            Str = new NumericUpDown();
            i = new NumericUpDown();
            dex = new NumericUpDown();
            wis = new NumericUpDown();
            con = new NumericUpDown();
            ch = new NumericUpDown();
            LoreBox = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            a = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            GenderBox = new ComboBox();
            label18 = new Label();
            Cm = new Label();
            label19 = new Label();
            label20 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeightBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vahaBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vekBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Hp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ac).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Str).BeginInit();
            ((System.ComponentModel.ISupportInitialize)i).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)con).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ch).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(32, 23);
            button1.TabIndex = 0;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.AllowDrop = true;
            pictureBox1.Location = new Point(602, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.DragDrop += pictureBox1_DragDrop;
            pictureBox1.DragEnter += pictureBox1_DragEnter;
            // 
            // NameBox
            // 
            NameBox.ForeColor = SystemColors.WindowText;
            NameBox.Location = new Point(413, 97);
            NameBox.Name = "NameBox";
            NameBox.RightToLeft = RightToLeft.No;
            NameBox.Size = new Size(128, 23);
            NameBox.TabIndex = 2;
            // 
            // SurnameBox
            // 
            SurnameBox.Location = new Point(413, 138);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(128, 23);
            SurnameBox.TabIndex = 3;
            // 
            // RaceBox
            // 
            RaceBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RaceBox.FormattingEnabled = true;
            RaceBox.Location = new Point(413, 189);
            RaceBox.Name = "RaceBox";
            RaceBox.Size = new Size(128, 23);
            RaceBox.TabIndex = 4;
            // 
            // ClassBox
            // 
            ClassBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassBox.FormattingEnabled = true;
            ClassBox.Location = new Point(413, 229);
            ClassBox.Name = "ClassBox";
            ClassBox.Size = new Size(128, 23);
            ClassBox.TabIndex = 5;
            // 
            // SubclassBox
            // 
            SubclassBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SubclassBox.FormattingEnabled = true;
            SubclassBox.Location = new Point(413, 277);
            SubclassBox.Name = "SubclassBox";
            SubclassBox.Size = new Size(128, 23);
            SubclassBox.TabIndex = 6;
            // 
            // HeightBox
            // 
            HeightBox.Location = new Point(413, 317);
            HeightBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(104, 23);
            HeightBox.TabIndex = 7;
            // 
            // vahaBox
            // 
            vahaBox.Location = new Point(413, 362);
            vahaBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            vahaBox.Name = "vahaBox";
            vahaBox.Size = new Size(104, 23);
            vahaBox.TabIndex = 8;
            // 
            // vekBox
            // 
            vekBox.Location = new Point(413, 406);
            vekBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            vekBox.Name = "vekBox";
            vekBox.Size = new Size(104, 23);
            vekBox.TabIndex = 9;
            // 
            // Hp
            // 
            Hp.Location = new Point(640, 218);
            Hp.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Hp.Name = "Hp";
            Hp.Size = new Size(44, 23);
            Hp.TabIndex = 10;
            // 
            // Ac
            // 
            Ac.Location = new Point(741, 218);
            Ac.Name = "Ac";
            Ac.Size = new Size(44, 23);
            Ac.TabIndex = 11;
            // 
            // Str
            // 
            Str.Location = new Point(640, 247);
            Str.Name = "Str";
            Str.Size = new Size(44, 23);
            Str.TabIndex = 12;
            // 
            // i
            // 
            i.Location = new Point(741, 247);
            i.Name = "i";
            i.Size = new Size(44, 23);
            i.TabIndex = 13;
            // 
            // dex
            // 
            dex.Location = new Point(640, 276);
            dex.Name = "dex";
            dex.Size = new Size(44, 23);
            dex.TabIndex = 14;
            // 
            // wis
            // 
            wis.Location = new Point(741, 272);
            wis.Name = "wis";
            wis.Size = new Size(44, 23);
            wis.TabIndex = 15;
            // 
            // con
            // 
            con.Location = new Point(640, 305);
            con.Name = "con";
            con.Size = new Size(44, 23);
            con.TabIndex = 16;
            // 
            // ch
            // 
            ch.Location = new Point(741, 305);
            ch.Name = "ch";
            ch.Size = new Size(44, 23);
            ch.TabIndex = 17;
            // 
            // LoreBox
            // 
            LoreBox.Location = new Point(104, 33);
            LoreBox.Multiline = true;
            LoreBox.Name = "LoreBox";
            LoreBox.Size = new Size(221, 397);
            LoreBox.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(645, 393);
            button2.Name = "button2";
            button2.Size = new Size(111, 45);
            button2.TabIndex = 19;
            button2.Text = "Přidat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 100);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 20;
            label1.Text = "Jméno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 146);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 21;
            label2.Text = "Příjmení";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 192);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 22;
            label3.Text = "Rasa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 232);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 23;
            label4.Text = "Classa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(350, 280);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 24;
            label5.Text = "Subclassa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 319);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 25;
            label6.Text = "Výška";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(377, 364);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 26;
            label7.Text = "Váha";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(382, 408);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 27;
            label8.Text = "Věk";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(611, 220);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 28;
            label9.Text = "Hp";
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(613, 249);
            a.Name = "a";
            a.Size = new Size(21, 15);
            a.TabIndex = 29;
            a.Text = "Str";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(608, 280);
            label11.Name = "label11";
            label11.Size = new Size(26, 15);
            label11.TabIndex = 30;
            label11.Text = "Dex";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(602, 307);
            label12.Name = "label12";
            label12.Size = new Size(29, 15);
            label12.TabIndex = 31;
            label12.Text = "Con";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(714, 220);
            label13.Name = "label13";
            label13.Size = new Size(21, 15);
            label13.TabIndex = 32;
            label13.Text = "Ac";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(714, 249);
            label14.Name = "label14";
            label14.Size = new Size(21, 15);
            label14.TabIndex = 33;
            label14.Text = "Int";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(709, 277);
            label15.Name = "label15";
            label15.Size = new Size(26, 15);
            label15.TabIndex = 34;
            label15.Text = "Wis";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(713, 307);
            label16.Name = "label16";
            label16.Size = new Size(22, 15);
            label16.TabIndex = 35;
            label16.Text = "Ch";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(72, 16);
            label17.Name = "label17";
            label17.Size = new Size(288, 15);
            label17.TabIndex = 36;
            label17.Text = "Lore, poznatky, poznámky, něco na přiblížení postavy";
            // 
            // GenderBox
            // 
            GenderBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderBox.FormattingEnabled = true;
            GenderBox.Location = new Point(413, 56);
            GenderBox.Name = "GenderBox";
            GenderBox.Size = new Size(128, 23);
            GenderBox.TabIndex = 37;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(363, 59);
            label18.Name = "label18";
            label18.Size = new Size(46, 15);
            label18.TabIndex = 38;
            label18.Text = "Pohlaví";
            // 
            // Cm
            // 
            Cm.AutoSize = true;
            Cm.Location = new Point(523, 319);
            Cm.Name = "Cm";
            Cm.Size = new Size(26, 15);
            Cm.TabIndex = 39;
            Cm.Text = "Cm";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(523, 364);
            label19.Name = "label19";
            label19.Size = new Size(21, 15);
            label19.TabIndex = 40;
            label19.Text = "Kg";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(523, 408);
            label20.Name = "label20";
            label20.Size = new Size(23, 15);
            label20.TabIndex = 41;
            label20.Text = "Let";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(640, 105);
            label10.Name = "label10";
            label10.Size = new Size(116, 15);
            label10.TabIndex = 42;
            label10.Text = "Sem Dropni obrázek!";
            // 
            // CharacterCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 451);
            Controls.Add(label10);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(Cm);
            Controls.Add(label18);
            Controls.Add(GenderBox);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(a);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(LoreBox);
            Controls.Add(ch);
            Controls.Add(con);
            Controls.Add(wis);
            Controls.Add(dex);
            Controls.Add(i);
            Controls.Add(Str);
            Controls.Add(Ac);
            Controls.Add(Hp);
            Controls.Add(vekBox);
            Controls.Add(vahaBox);
            Controls.Add(HeightBox);
            Controls.Add(SubclassBox);
            Controls.Add(ClassBox);
            Controls.Add(RaceBox);
            Controls.Add(SurnameBox);
            Controls.Add(NameBox);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CharacterCreation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CharacterCreation";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeightBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)vahaBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)vekBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Hp).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ac).EndInit();
            ((System.ComponentModel.ISupportInitialize)Str).EndInit();
            ((System.ComponentModel.ISupportInitialize)i).EndInit();
            ((System.ComponentModel.ISupportInitialize)dex).EndInit();
            ((System.ComponentModel.ISupportInitialize)wis).EndInit();
            ((System.ComponentModel.ISupportInitialize)con).EndInit();
            ((System.ComponentModel.ISupportInitialize)ch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private TextBox NameBox;
        private TextBox SurnameBox;
        private ComboBox RaceBox;
        private ComboBox ClassBox;
        private ComboBox SubclassBox;
        private NumericUpDown HeightBox;
        private NumericUpDown vahaBox;
        private NumericUpDown vekBox;
        private NumericUpDown Hp;
        private NumericUpDown Ac;
        private NumericUpDown Str;
        private NumericUpDown i;
        private NumericUpDown dex;
        private NumericUpDown wis;
        private NumericUpDown con;
        private NumericUpDown ch;
        private TextBox LoreBox;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label a;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private ComboBox GenderBox;
        private Label label18;
        private Label Cm;
        private Label label19;
        private Label label20;
        private Label label10;
    }
}