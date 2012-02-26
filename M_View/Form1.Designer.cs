namespace M_View
{
    partial class Form1
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
            this.nextBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filmImgSrc = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plotTb = new System.Windows.Forms.TextBox();
            this.plotLbl = new System.Windows.Forms.TextBox();
            this.castTb = new System.Windows.Forms.TextBox();
            this.castLbl = new System.Windows.Forms.TextBox();
            this.writersTb = new System.Windows.Forms.TextBox();
            this.writersLbl = new System.Windows.Forms.TextBox();
            this.directorTb = new System.Windows.Forms.TextBox();
            this.directorLbl = new System.Windows.Forms.TextBox();
            this.genreTb = new System.Windows.Forms.TextBox();
            this.genreLbl = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.urlClickLbl = new System.Windows.Forms.Label();
            this.MpaaTb = new System.Windows.Forms.TextBox();
            this.textBoxMpaaLbl = new System.Windows.Forms.TextBox();
            this.textBoxRatingLbl = new System.Windows.Forms.TextBox();
            this.textBoxRunningLbl = new System.Windows.Forms.TextBox();
            this.textBoxYearlbl = new System.Windows.Forms.TextBox();
            this.ratingTb = new System.Windows.Forms.TextBox();
            this.runningTimeTb = new System.Windows.Forms.TextBox();
            this.yearTb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmImgSrc)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.nextBtn.Location = new System.Drawing.Point(87, 500);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(61, 23);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.reloadBtn.Location = new System.Drawing.Point(154, 500);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(79, 23);
            this.reloadBtn.TabIndex = 2;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.previousBtn.Location = new System.Drawing.Point(12, 500);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(69, 23);
            this.previousBtn.TabIndex = 3;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.filmImgSrc);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 325);
            this.panel1.TabIndex = 4;
            // 
            // filmImgSrc
            // 
            this.filmImgSrc.BackColor = System.Drawing.SystemColors.Control;
            this.filmImgSrc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.filmImgSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filmImgSrc.Location = new System.Drawing.Point(3, 3);
            this.filmImgSrc.Name = "filmImgSrc";
            this.filmImgSrc.Size = new System.Drawing.Size(215, 319);
            this.filmImgSrc.TabIndex = 0;
            this.filmImgSrc.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.controlToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuFile.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(38, 20);
            this.menuFile.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.controlToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(872, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(81, 17);
            this.status.Text = "Status: Ready";
            // 
            // titleTb
            // 
            this.titleTb.BackColor = System.Drawing.SystemColors.Control;
            this.titleTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTb.Font = new System.Drawing.Font("Miramonte", 32F, System.Drawing.FontStyle.Bold);
            this.titleTb.Location = new System.Drawing.Point(6, 6);
            this.titleTb.Multiline = true;
            this.titleTb.Name = "titleTb";
            this.titleTb.Size = new System.Drawing.Size(614, 60);
            this.titleTb.TabIndex = 7;
            this.titleTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.plotTb);
            this.panel2.Controls.Add(this.plotLbl);
            this.panel2.Controls.Add(this.castTb);
            this.panel2.Controls.Add(this.castLbl);
            this.panel2.Controls.Add(this.writersTb);
            this.panel2.Controls.Add(this.writersLbl);
            this.panel2.Controls.Add(this.directorTb);
            this.panel2.Controls.Add(this.directorLbl);
            this.panel2.Controls.Add(this.genreTb);
            this.panel2.Controls.Add(this.genreLbl);
            this.panel2.Controls.Add(this.titleTb);
            this.panel2.Location = new System.Drawing.Point(239, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 462);
            this.panel2.TabIndex = 8;
            // 
            // plotTb
            // 
            this.plotTb.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.plotTb.Location = new System.Drawing.Point(144, 310);
            this.plotTb.Multiline = true;
            this.plotTb.Name = "plotTb";
            this.plotTb.Size = new System.Drawing.Size(476, 146);
            this.plotTb.TabIndex = 19;
            // 
            // plotLbl
            // 
            this.plotLbl.Font = new System.Drawing.Font("Miramonte", 18F, System.Drawing.FontStyle.Bold);
            this.plotLbl.Location = new System.Drawing.Point(6, 310);
            this.plotLbl.Multiline = true;
            this.plotLbl.Name = "plotLbl";
            this.plotLbl.Size = new System.Drawing.Size(132, 48);
            this.plotLbl.TabIndex = 18;
            this.plotLbl.Text = "Plot";
            // 
            // castTb
            // 
            this.castTb.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.castTb.Location = new System.Drawing.Point(144, 198);
            this.castTb.Multiline = true;
            this.castTb.Name = "castTb";
            this.castTb.Size = new System.Drawing.Size(476, 106);
            this.castTb.TabIndex = 17;
            // 
            // castLbl
            // 
            this.castLbl.Font = new System.Drawing.Font("Miramonte", 18F, System.Drawing.FontStyle.Bold);
            this.castLbl.Location = new System.Drawing.Point(6, 198);
            this.castLbl.Multiline = true;
            this.castLbl.Name = "castLbl";
            this.castLbl.Size = new System.Drawing.Size(132, 51);
            this.castLbl.TabIndex = 16;
            this.castLbl.Text = "Cast";
            // 
            // writersTb
            // 
            this.writersTb.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.writersTb.Location = new System.Drawing.Point(144, 138);
            this.writersTb.Multiline = true;
            this.writersTb.Name = "writersTb";
            this.writersTb.Size = new System.Drawing.Size(476, 54);
            this.writersTb.TabIndex = 15;
            // 
            // writersLbl
            // 
            this.writersLbl.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.writersLbl.Location = new System.Drawing.Point(6, 138);
            this.writersLbl.Name = "writersLbl";
            this.writersLbl.Size = new System.Drawing.Size(132, 27);
            this.writersLbl.TabIndex = 14;
            this.writersLbl.Text = "Writer\'s";
            // 
            // directorTb
            // 
            this.directorTb.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.directorTb.Location = new System.Drawing.Point(144, 105);
            this.directorTb.Multiline = true;
            this.directorTb.Name = "directorTb";
            this.directorTb.Size = new System.Drawing.Size(476, 27);
            this.directorTb.TabIndex = 13;
            // 
            // directorLbl
            // 
            this.directorLbl.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.directorLbl.Location = new System.Drawing.Point(6, 105);
            this.directorLbl.Name = "directorLbl";
            this.directorLbl.Size = new System.Drawing.Size(132, 27);
            this.directorLbl.TabIndex = 12;
            this.directorLbl.Text = "Director\'s";
            // 
            // genreTb
            // 
            this.genreTb.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.genreTb.Location = new System.Drawing.Point(144, 72);
            this.genreTb.Multiline = true;
            this.genreTb.Name = "genreTb";
            this.genreTb.Size = new System.Drawing.Size(476, 27);
            this.genreTb.TabIndex = 11;
            // 
            // genreLbl
            // 
            this.genreLbl.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.genreLbl.Location = new System.Drawing.Point(6, 72);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(132, 27);
            this.genreLbl.TabIndex = 10;
            this.genreLbl.Text = "Genre\'s";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.urlClickLbl);
            this.panel3.Controls.Add(this.MpaaTb);
            this.panel3.Controls.Add(this.textBoxMpaaLbl);
            this.panel3.Controls.Add(this.textBoxRatingLbl);
            this.panel3.Controls.Add(this.textBoxRunningLbl);
            this.panel3.Controls.Add(this.textBoxYearlbl);
            this.panel3.Controls.Add(this.ratingTb);
            this.panel3.Controls.Add(this.runningTimeTb);
            this.panel3.Controls.Add(this.yearTb);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.ForeColor = System.Drawing.Color.Khaki;
            this.panel3.Location = new System.Drawing.Point(12, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 134);
            this.panel3.TabIndex = 9;
            // 
            // urlClickLbl
            // 
            this.urlClickLbl.AutoSize = true;
            this.urlClickLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlClickLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urlClickLbl.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.urlClickLbl.ForeColor = System.Drawing.Color.Gold;
            this.urlClickLbl.Location = new System.Drawing.Point(65, 107);
            this.urlClickLbl.Name = "urlClickLbl";
            this.urlClickLbl.Size = new System.Drawing.Size(88, 21);
            this.urlClickLbl.TabIndex = 12;
            this.urlClickLbl.Text = "IMDB Link";
            this.urlClickLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.urlClickLbl_Click);
            // 
            // MpaaTb
            // 
            this.MpaaTb.BackColor = System.Drawing.SystemColors.Control;
            this.MpaaTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MpaaTb.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.MpaaTb.Location = new System.Drawing.Point(124, 82);
            this.MpaaTb.Name = "MpaaTb";
            this.MpaaTb.ReadOnly = true;
            this.MpaaTb.Size = new System.Drawing.Size(91, 20);
            this.MpaaTb.TabIndex = 10;
            // 
            // textBoxMpaaLbl
            // 
            this.textBoxMpaaLbl.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMpaaLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMpaaLbl.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxMpaaLbl.Location = new System.Drawing.Point(5, 82);
            this.textBoxMpaaLbl.Name = "textBoxMpaaLbl";
            this.textBoxMpaaLbl.ReadOnly = true;
            this.textBoxMpaaLbl.Size = new System.Drawing.Size(115, 20);
            this.textBoxMpaaLbl.TabIndex = 9;
            this.textBoxMpaaLbl.Text = " MPAA Rating";
            // 
            // textBoxRatingLbl
            // 
            this.textBoxRatingLbl.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRatingLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRatingLbl.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxRatingLbl.Location = new System.Drawing.Point(5, 56);
            this.textBoxRatingLbl.Name = "textBoxRatingLbl";
            this.textBoxRatingLbl.ReadOnly = true;
            this.textBoxRatingLbl.Size = new System.Drawing.Size(115, 20);
            this.textBoxRatingLbl.TabIndex = 8;
            this.textBoxRatingLbl.Text = " IMDB Rating";
            // 
            // textBoxRunningLbl
            // 
            this.textBoxRunningLbl.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRunningLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRunningLbl.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxRunningLbl.Location = new System.Drawing.Point(5, 31);
            this.textBoxRunningLbl.Name = "textBoxRunningLbl";
            this.textBoxRunningLbl.ReadOnly = true;
            this.textBoxRunningLbl.Size = new System.Drawing.Size(115, 20);
            this.textBoxRunningLbl.TabIndex = 7;
            this.textBoxRunningLbl.Text = " Running Time";
            // 
            // textBoxYearlbl
            // 
            this.textBoxYearlbl.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxYearlbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYearlbl.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxYearlbl.Location = new System.Drawing.Point(5, 5);
            this.textBoxYearlbl.Name = "textBoxYearlbl";
            this.textBoxYearlbl.ReadOnly = true;
            this.textBoxYearlbl.Size = new System.Drawing.Size(115, 20);
            this.textBoxYearlbl.TabIndex = 6;
            this.textBoxYearlbl.Text = " Year";
            // 
            // ratingTb
            // 
            this.ratingTb.BackColor = System.Drawing.SystemColors.Control;
            this.ratingTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratingTb.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.ratingTb.Location = new System.Drawing.Point(124, 57);
            this.ratingTb.Name = "ratingTb";
            this.ratingTb.ReadOnly = true;
            this.ratingTb.Size = new System.Drawing.Size(91, 20);
            this.ratingTb.TabIndex = 5;
            // 
            // runningTimeTb
            // 
            this.runningTimeTb.BackColor = System.Drawing.SystemColors.Control;
            this.runningTimeTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.runningTimeTb.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.runningTimeTb.Location = new System.Drawing.Point(124, 31);
            this.runningTimeTb.Name = "runningTimeTb";
            this.runningTimeTb.ReadOnly = true;
            this.runningTimeTb.Size = new System.Drawing.Size(91, 20);
            this.runningTimeTb.TabIndex = 4;
            // 
            // yearTb
            // 
            this.yearTb.BackColor = System.Drawing.SystemColors.Control;
            this.yearTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearTb.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.yearTb.Location = new System.Drawing.Point(126, 5);
            this.yearTb.Name = "yearTb";
            this.yearTb.ReadOnly = true;
            this.yearTb.Size = new System.Drawing.Size(89, 20);
            this.yearTb.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 548);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "M_View";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmImgSrc)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox filmImgSrc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox titleTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ratingTb;
        private System.Windows.Forms.TextBox runningTimeTb;
        private System.Windows.Forms.TextBox yearTb;
        private System.Windows.Forms.TextBox textBoxRatingLbl;
        private System.Windows.Forms.TextBox textBoxRunningLbl;
        private System.Windows.Forms.TextBox textBoxYearlbl;
        private System.Windows.Forms.TextBox MpaaTb;
        private System.Windows.Forms.TextBox textBoxMpaaLbl;
        private System.Windows.Forms.Label urlClickLbl;
        private System.Windows.Forms.TextBox genreLbl;
        private System.Windows.Forms.TextBox genreTb;
        private System.Windows.Forms.TextBox directorLbl;
        private System.Windows.Forms.TextBox directorTb;
        private System.Windows.Forms.TextBox plotTb;
        private System.Windows.Forms.TextBox plotLbl;
        private System.Windows.Forms.TextBox castTb;
        private System.Windows.Forms.TextBox castLbl;
        private System.Windows.Forms.TextBox writersTb;
        private System.Windows.Forms.TextBox writersLbl;
    }
}

