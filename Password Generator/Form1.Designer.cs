namespace Password_Generator
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
            GnrtBttn = new Button();
            label1 = new Label();
            pswrd = new Label();
            textBox1 = new TextBox();
            lblCopied = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            chckLL = new CheckBox();
            chckUL = new CheckBox();
            chckN = new CheckBox();
            chckS = new CheckBox();
            SuspendLayout();
            // 
            // GnrtBttn
            // 
            GnrtBttn.Font = new Font("Cascadia Code", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            GnrtBttn.Location = new Point(233, 456);
            GnrtBttn.Name = "GnrtBttn";
            GnrtBttn.Size = new Size(250, 120);
            GnrtBttn.TabIndex = 0;
            GnrtBttn.Text = "Oluştur";
            GnrtBttn.UseVisualStyleBackColor = true;
            GnrtBttn.Click += GnrtBttn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Cascadia Code", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(71, 129);
            label1.Name = "label1";
            label1.Size = new Size(317, 43);
            label1.TabIndex = 1;
            label1.Text = "Şifre Uzunluğu";
            // 
            // pswrd
            // 
            pswrd.Font = new Font("Cascadia Code", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            pswrd.Location = new Point(1, 369);
            pswrd.Name = "pswrd";
            pswrd.Size = new Size(722, 32);
            pswrd.TabIndex = 2;
            pswrd.TextAlign = ContentAlignment.TopCenter;
            pswrd.UseMnemonic = false;
            pswrd.Click += pswrd_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cascadia Code", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(375, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 39);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCopied
            // 
            lblCopied.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCopied.ForeColor = Color.FromArgb(0, 192, 0);
            lblCopied.Location = new Point(1, 411);
            lblCopied.Name = "lblCopied";
            lblCopied.Size = new Size(722, 32);
            lblCopied.TabIndex = 4;
            lblCopied.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;
            // 
            // chckLL
            // 
            chckLL.AutoSize = true;
            chckLL.Font = new Font("Cascadia Code", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chckLL.Location = new Point(71, 175);
            chckLL.Name = "chckLL";
            chckLL.Size = new Size(255, 39);
            chckLL.TabIndex = 5;
            chckLL.Text = "Küçük Harfler";
            chckLL.UseVisualStyleBackColor = true;
            // 
            // chckUL
            // 
            chckUL.AutoSize = true;
            chckUL.Font = new Font("Cascadia Code", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chckUL.Location = new Point(71, 220);
            chckUL.Name = "chckUL";
            chckUL.Size = new Size(255, 39);
            chckUL.TabIndex = 6;
            chckUL.Text = "Büyük Harfler";
            chckUL.UseVisualStyleBackColor = true;
            // 
            // chckN
            // 
            chckN.AutoSize = true;
            chckN.Font = new Font("Cascadia Code", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chckN.Location = new Point(71, 265);
            chckN.Name = "chckN";
            chckN.Size = new Size(159, 39);
            chckN.TabIndex = 7;
            chckN.Text = "Sayılar";
            chckN.UseVisualStyleBackColor = true;
            // 
            // chckS
            // 
            chckS.AutoSize = true;
            chckS.Font = new Font("Cascadia Code", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chckS.Location = new Point(71, 310);
            chckS.Name = "chckS";
            chckS.Size = new Size(191, 39);
            chckS.TabIndex = 8;
            chckS.Text = "Semboller";
            chckS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 679);
            Controls.Add(chckS);
            Controls.Add(chckN);
            Controls.Add(chckUL);
            Controls.Add(chckLL);
            Controls.Add(lblCopied);
            Controls.Add(textBox1);
            Controls.Add(pswrd);
            Controls.Add(label1);
            Controls.Add(GnrtBttn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Şifre Oluşturucu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GnrtBttn;
        private Label label1;
        private Label pswrd;
        private TextBox textBox1;
        private Label lblCopied;
        private System.Windows.Forms.Timer timer1;
        private CheckBox chckLL;
        private CheckBox chckUL;
        private CheckBox chckN;
        private CheckBox chckS;
    }
}
