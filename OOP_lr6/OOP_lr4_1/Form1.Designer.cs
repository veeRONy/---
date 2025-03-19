namespace OOP_lr4_1
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.chbCtrl = new System.Windows.Forms.CheckBox();
            this.chbSelectOnlyOne = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuBtnCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnTriangle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnColor = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.желтыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.черныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chbCtrl
            // 
            this.chbCtrl.AutoCheck = false;
            this.chbCtrl.AutoSize = true;
            this.chbCtrl.Location = new System.Drawing.Point(13, 58);
            this.chbCtrl.Name = "chbCtrl";
            this.chbCtrl.Size = new System.Drawing.Size(48, 20);
            this.chbCtrl.TabIndex = 1;
            this.chbCtrl.Text = "Ctrl";
            this.chbCtrl.UseVisualStyleBackColor = true;
            // 
            // chbSelectOnlyOne
            // 
            this.chbSelectOnlyOne.AutoSize = true;
            this.chbSelectOnlyOne.Location = new System.Drawing.Point(104, 58);
            this.chbSelectOnlyOne.Name = "chbSelectOnlyOne";
            this.chbSelectOnlyOne.Size = new System.Drawing.Size(269, 20);
            this.chbSelectOnlyOne.TabIndex = 2;
            this.chbSelectOnlyOne.Text = "Выделять 1 объект при пересечении";
            this.chbSelectOnlyOne.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnCircle,
            this.menuBtnSquare,
            this.menuBtnTriangle,
            this.menuBtnColor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 36);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(13, 100);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(856, 397);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // menuBtnCircle
            // 
            this.menuBtnCircle.AutoSize = false;
            this.menuBtnCircle.Image = global::OOP_lr4_1.Properties.Resources.circle;
            this.menuBtnCircle.Name = "menuBtnCircle";
            this.menuBtnCircle.Size = new System.Drawing.Size(32, 32);
            this.menuBtnCircle.Click += new System.EventHandler(this.menuBtnCircle_Click);
            // 
            // menuBtnSquare
            // 
            this.menuBtnSquare.AutoSize = false;
            this.menuBtnSquare.Image = global::OOP_lr4_1.Properties.Resources.square;
            this.menuBtnSquare.Name = "menuBtnSquare";
            this.menuBtnSquare.Size = new System.Drawing.Size(32, 32);
            this.menuBtnSquare.Click += new System.EventHandler(this.menuBtnSquare_Click);
            // 
            // menuBtnTriangle
            // 
            this.menuBtnTriangle.AutoSize = false;
            this.menuBtnTriangle.Image = global::OOP_lr4_1.Properties.Resources.triangle;
            this.menuBtnTriangle.Name = "menuBtnTriangle";
            this.menuBtnTriangle.Size = new System.Drawing.Size(32, 32);
            this.menuBtnTriangle.Click += new System.EventHandler(this.menuBtnTriangle_Click);
            // 
            // menuBtnColor
            // 
            this.menuBtnColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuColorRed,
            this.menuColorBlue,
            this.menuColorYellow,
            this.menuColorGreen,
            this.menuColorBlack});
            this.menuBtnColor.Name = "menuBtnColor";
            this.menuBtnColor.Size = new System.Drawing.Size(56, 32);
            this.menuBtnColor.Text = "Цвет";
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.Image = global::OOP_lr4_1.Properties.Resources.square_red;
            this.красныйToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.красныйToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.красныйToolStripMenuItem.Text = "Красный";
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Image = global::OOP_lr4_1.Properties.Resources.square_blue;
            this.синийToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.синийToolStripMenuItem.Text = "Синий";
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Image = global::OOP_lr4_1.Properties.Resources.square_green;
            this.зеленыйToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            // 
            // желтыйToolStripMenuItem
            // 
            this.желтыйToolStripMenuItem.Image = global::OOP_lr4_1.Properties.Resources.square_yellow;
            this.желтыйToolStripMenuItem.Name = "желтыйToolStripMenuItem";
            this.желтыйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.желтыйToolStripMenuItem.Text = "Желтый";
            // 
            // черныйToolStripMenuItem
            // 
            this.черныйToolStripMenuItem.Image = global::OOP_lr4_1.Properties.Resources.square_black;
            this.черныйToolStripMenuItem.Name = "черныйToolStripMenuItem";
            this.черныйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.черныйToolStripMenuItem.Text = "Черный";
            // 
            // menuColorRed
            // 
            this.menuColorRed.Image = global::OOP_lr4_1.Properties.Resources.square_red;
            this.menuColorRed.Name = "menuColorRed";
            this.menuColorRed.Size = new System.Drawing.Size(224, 26);
            this.menuColorRed.Text = "Красный";
            this.menuColorRed.Click += new System.EventHandler(this.menuColorRed_Click);
            // 
            // menuColorBlue
            // 
            this.menuColorBlue.Image = global::OOP_lr4_1.Properties.Resources.square_blue;
            this.menuColorBlue.Name = "menuColorBlue";
            this.menuColorBlue.Size = new System.Drawing.Size(224, 26);
            this.menuColorBlue.Text = "Синий";
            this.menuColorBlue.Click += new System.EventHandler(this.menuColorBlue_Click);
            // 
            // menuColorYellow
            // 
            this.menuColorYellow.Image = global::OOP_lr4_1.Properties.Resources.square_yellow;
            this.menuColorYellow.Name = "menuColorYellow";
            this.menuColorYellow.Size = new System.Drawing.Size(224, 26);
            this.menuColorYellow.Text = "Желтый";
            this.menuColorYellow.Click += new System.EventHandler(this.menuColorYellow_Click);
            // 
            // menuColorGreen
            // 
            this.menuColorGreen.Image = global::OOP_lr4_1.Properties.Resources.square_green;
            this.menuColorGreen.Name = "menuColorGreen";
            this.menuColorGreen.Size = new System.Drawing.Size(224, 26);
            this.menuColorGreen.Text = "Зеленый";
            this.menuColorGreen.Click += new System.EventHandler(this.menuColorGreen_Click);
            // 
            // menuColorBlack
            // 
            this.menuColorBlack.Image = global::OOP_lr4_1.Properties.Resources.square_black;
            this.menuColorBlack.Name = "menuColorBlack";
            this.menuColorBlack.Size = new System.Drawing.Size(224, 26);
            this.menuColorBlack.Text = "Черный";
            this.menuColorBlack.Click += new System.EventHandler(this.menuColorBlack_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 509);
            this.Controls.Add(this.chbSelectOnlyOne);
            this.Controls.Add(this.chbCtrl);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Круги на форме";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox chbCtrl;
        private System.Windows.Forms.CheckBox chbSelectOnlyOne;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuBtnCircle;
        private System.Windows.Forms.ToolStripMenuItem menuBtnSquare;
        private System.Windows.Forms.ToolStripMenuItem menuBtnTriangle;
        private System.Windows.Forms.ToolStripMenuItem menuBtnColor;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem желтыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem черныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuColorRed;
        private System.Windows.Forms.ToolStripMenuItem menuColorBlue;
        private System.Windows.Forms.ToolStripMenuItem menuColorYellow;
        private System.Windows.Forms.ToolStripMenuItem menuColorGreen;
        private System.Windows.Forms.ToolStripMenuItem menuColorBlack;
    }
}

