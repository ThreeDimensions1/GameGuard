namespace GameGuard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            imageList1 = new ImageList(components);
            panel2 = new Panel();
            progressPanel2 = new Panel();
            progressPanelDrink = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            panel12 = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            button11 = new Button();
            label4 = new Label();
            button8 = new Button();
            button7 = new Button();
            label3 = new Label();
            panel3 = new Panel();
            progressPanel = new Panel();
            progressPanelEat = new Panel();
            panel4 = new Panel();
            ProgressPanel3 = new Panel();
            progressPanelBreak = new Panel();
            label5 = new Label();
            button9 = new Button();
            button10 = new Button();
            label6 = new Label();
            About = new Panel();
            button12 = new Button();
            label9 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            progressPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            progressPanel.SuspendLayout();
            panel4.SuspendLayout();
            ProgressPanel3.SuspendLayout();
            About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // panel2
            // 
            panel2.Controls.Add(progressPanel2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 435);
            panel2.TabIndex = 8;
            // 
            // progressPanel2
            // 
            progressPanel2.Anchor = AnchorStyles.Top;
            progressPanel2.BackColor = Color.Bisque;
            progressPanel2.Controls.Add(progressPanelDrink);
            progressPanel2.Location = new Point(262, 174);
            progressPanel2.Margin = new Padding(4, 3, 4, 3);
            progressPanel2.Name = "progressPanel2";
            progressPanel2.Size = new Size(334, 40);
            progressPanel2.TabIndex = 8;
            // 
            // progressPanelDrink
            // 
            progressPanelDrink.Anchor = AnchorStyles.None;
            progressPanelDrink.BackColor = Color.FromArgb(176, 77, 0);
            progressPanelDrink.Location = new Point(0, 0);
            progressPanelDrink.Margin = new Padding(4, 3, 4, 3);
            progressPanelDrink.Name = "progressPanelDrink";
            progressPanelDrink.Size = new Size(334, 40);
            progressPanelDrink.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Script MT Bold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(176, 77, 0);
            label1.Location = new Point(252, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(384, 58);
            label1.TabIndex = 0;
            label1.Text = "Next Drinking In:";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Bisque;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(176, 77, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Script MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.restart;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(440, 361);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(175, 62);
            button1.TabIndex = 1;
            button1.Text = "I Had Drink";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Bisque;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(176, 77, 0);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Script MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = Properties.Resources.play;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(621, 361);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(175, 62);
            button2.TabIndex = 4;
            button2.Text = "Start Counting";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("MV Boli", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(604, 170);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 44);
            label2.TabIndex = 3;
            label2.Text = "30:00";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.DarkGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 90, 214, 252);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Poor Richard", 14.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.settings;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 384);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(170, 50);
            button3.TabIndex = 5;
            button3.Text = "Settings";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderColor = Color.DarkGray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 90, 214, 252);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Poor Richard", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Image = Properties.Resources.bottle_icon;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 69);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(170, 50);
            button4.TabIndex = 7;
            button4.Text = "Drink";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderColor = Color.DarkGray;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 90, 214, 252);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Poor Richard", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Black;
            button5.Image = Properties.Resources.apple_icon;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 117);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(170, 50);
            button5.TabIndex = 8;
            button5.Text = "Eat";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderColor = Color.DarkGray;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 90, 214, 252);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Poor Richard", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Black;
            button6.Image = Properties.Resources.clock_icon;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 168);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(170, 50);
            button6.TabIndex = 9;
            button6.Text = "Break";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 0, 0, 0);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 435);
            panel1.TabIndex = 6;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel12.BackColor = Color.Silver;
            panel12.Location = new Point(0, 433);
            panel12.Margin = new Padding(4, 3, 4, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(172, 2);
            panel12.TabIndex = 15;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel11.BackColor = Color.Silver;
            panel11.Location = new Point(0, 333);
            panel11.Margin = new Padding(4, 3, 4, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(172, 2);
            panel11.TabIndex = 14;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Silver;
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(168, 0);
            panel10.Margin = new Padding(4, 3, 4, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(2, 435);
            panel10.TabIndex = 14;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel9.BackColor = Color.Silver;
            panel9.Location = new Point(0, 384);
            panel9.Margin = new Padding(4, 3, 4, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(172, 2);
            panel9.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Poor Richard", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(176, 77, 0);
            label7.Location = new Point(55, 12);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(108, 23);
            label7.TabIndex = 14;
            label7.Text = "Game Guard";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 45);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Silver;
            panel8.Location = new Point(0, 69);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(172, 2);
            panel8.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Silver;
            panel7.Location = new Point(0, 216);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(172, 2);
            panel7.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Location = new Point(0, 165);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(172, 2);
            panel6.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Location = new Point(0, 117);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(172, 2);
            panel5.TabIndex = 10;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button11.BackColor = Color.Transparent;
            button11.FlatAppearance.BorderColor = Color.DarkGray;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 90, 214, 252);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Poor Richard", 14.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Image = Properties.Resources.settings;
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(0, 333);
            button11.Margin = new Padding(4, 3, 4, 3);
            button11.Name = "button11";
            button11.Size = new Size(170, 50);
            button11.TabIndex = 15;
            button11.Text = "About";
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("MV Boli", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(604, 168);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 44);
            label4.TabIndex = 3;
            label4.Text = "30:00";
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button8.BackColor = Color.Bisque;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = Color.FromArgb(176, 77, 0);
            button8.FlatAppearance.BorderSize = 2;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Script MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Image = Properties.Resources.play;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(621, 361);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(175, 62);
            button8.TabIndex = 4;
            button8.Text = "Start Counting";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button7.BackColor = Color.Bisque;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.FromArgb(176, 77, 0);
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Script MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Image = Properties.Resources.restart;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(440, 361);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(175, 62);
            button7.TabIndex = 1;
            button7.Text = "I Had Food";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Script MT Bold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(176, 77, 0);
            label3.Location = new Point(252, 87);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(310, 58);
            label3.TabIndex = 0;
            label3.Text = "Next Food In:";
            label3.TextAlign = ContentAlignment.BottomRight;
            // 
            // panel3
            // 
            panel3.Controls.Add(progressPanel);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(808, 435);
            panel3.TabIndex = 9;
            // 
            // progressPanel
            // 
            progressPanel.Anchor = AnchorStyles.Top;
            progressPanel.BackColor = Color.Bisque;
            progressPanel.Controls.Add(progressPanelEat);
            progressPanel.Location = new Point(258, 174);
            progressPanel.Margin = new Padding(4, 3, 4, 3);
            progressPanel.Name = "progressPanel";
            progressPanel.Size = new Size(334, 40);
            progressPanel.TabIndex = 5;
            // 
            // progressPanelEat
            // 
            progressPanelEat.Anchor = AnchorStyles.None;
            progressPanelEat.BackColor = Color.FromArgb(176, 77, 0);
            progressPanelEat.Location = new Point(0, 0);
            progressPanelEat.Margin = new Padding(4, 3, 4, 3);
            progressPanelEat.Name = "progressPanelEat";
            progressPanelEat.Size = new Size(334, 40);
            progressPanelEat.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(ProgressPanel3);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(808, 435);
            panel4.TabIndex = 10;
            // 
            // ProgressPanel3
            // 
            ProgressPanel3.Anchor = AnchorStyles.Top;
            ProgressPanel3.BackColor = Color.Bisque;
            ProgressPanel3.Controls.Add(progressPanelBreak);
            ProgressPanel3.Location = new Point(262, 169);
            ProgressPanel3.Margin = new Padding(4, 3, 4, 3);
            ProgressPanel3.Name = "ProgressPanel3";
            ProgressPanel3.Size = new Size(334, 40);
            ProgressPanel3.TabIndex = 9;
            // 
            // progressPanelBreak
            // 
            progressPanelBreak.Anchor = AnchorStyles.None;
            progressPanelBreak.BackColor = Color.FromArgb(176, 77, 0);
            progressPanelBreak.Location = new Point(0, 0);
            progressPanelBreak.Margin = new Padding(4, 3, 4, 3);
            progressPanelBreak.Name = "progressPanelBreak";
            progressPanelBreak.Size = new Size(334, 40);
            progressPanelBreak.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Script MT Bold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(176, 77, 0);
            label5.Location = new Point(252, 87);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(334, 58);
            label5.TabIndex = 0;
            label5.Text = "Next Break In:";
            label5.TextAlign = ContentAlignment.BottomRight;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button9.BackColor = Color.Bisque;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderColor = Color.FromArgb(176, 77, 0);
            button9.FlatAppearance.BorderSize = 2;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Script MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Image = Properties.Resources.restart;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(440, 361);
            button9.Margin = new Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new Size(175, 62);
            button9.TabIndex = 1;
            button9.Text = "I Had Break";
            button9.TextAlign = ContentAlignment.MiddleRight;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button10.BackColor = Color.Bisque;
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderColor = Color.FromArgb(176, 77, 0);
            button10.FlatAppearance.BorderSize = 2;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Script MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Image = Properties.Resources.play;
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(621, 361);
            button10.Margin = new Padding(4, 3, 4, 3);
            button10.Name = "button10";
            button10.Size = new Size(175, 62);
            button10.TabIndex = 4;
            button10.Text = "Start Counting";
            button10.TextAlign = ContentAlignment.MiddleRight;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.Font = new Font("MV Boli", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(604, 165);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(122, 44);
            label6.TabIndex = 3;
            label6.Text = "30:00";
            // 
            // About
            // 
            About.Controls.Add(button12);
            About.Controls.Add(label9);
            About.Controls.Add(label8);
            About.Controls.Add(pictureBox2);
            About.Dock = DockStyle.Fill;
            About.Location = new Point(0, 0);
            About.Margin = new Padding(4, 3, 4, 3);
            About.Name = "About";
            About.Size = new Size(808, 435);
            About.TabIndex = 9;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button12.BackColor = Color.Bisque;
            button12.Cursor = Cursors.Hand;
            button12.FlatAppearance.BorderColor = Color.FromArgb(176, 77, 0);
            button12.FlatAppearance.BorderSize = 2;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Poor Richard", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Image = Properties.Resources.github_mark;
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(620, 361);
            button12.Margin = new Padding(4, 3, 4, 3);
            button12.Name = "button12";
            button12.Size = new Size(175, 62);
            button12.TabIndex = 10;
            button12.Text = "GitHub Page";
            button12.TextAlign = ContentAlignment.MiddleRight;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Poor Richard", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(404, 333);
            label9.Name = "label9";
            label9.Size = new Size(170, 23);
            label9.TabIndex = 2;
            label9.Text = "Šimon Smorada 2025";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Poor Richard", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(176, 77, 0);
            label8.Location = new Point(379, 243);
            label8.Name = "label8";
            label8.Size = new Size(213, 47);
            label8.TabIndex = 1;
            label8.Text = "Game Guard";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackgroundImage = Properties.Resources.banner;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(349, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(275, 176);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 249, 243);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(808, 435);
            Controls.Add(panel1);
            Controls.Add(About);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(780, 456);
            Name = "Form1";
            Text = "Game Guard - Drink";
            TransparencyKey = Color.Cyan;
            Load += Form1_Load;
            Resize += Form1_Resize;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            progressPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            progressPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ProgressPanel3.ResumeLayout(false);
            About.ResumeLayout(false);
            About.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private ImageList imageList1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel1;
        private Label label4;
        private Button button8;
        private Button button7;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private Label label5;
        private Button button9;
        private Button button10;
        private Label label6;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel8;
        private PictureBox pictureBox1;
        private Label label7;
        private Panel panel9;
        private Panel progressPanel;
        private Panel progressPanelEat;
        private Panel progressPanelDrink;
        private Panel progressPanel2;
        private Panel ProgressPanel3;
        private Panel progressPanelBreak;
        private Panel panel10;
        private Button button11;
        private Panel panel11;
        private Panel panel12;
        private Panel About;
        private PictureBox pictureBox2;
        private Label label8;
        private Label label9;
        private Button button12;
    }
}
