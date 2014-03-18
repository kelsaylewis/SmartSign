namespace TestProject_withHotkeys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.HotKeyLabel = new System.Windows.Forms.Label();
            this.LogLocation = new System.Windows.Forms.Label();
            this.LogButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFlash)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(0, 0);
            this.searchBox.MaximumSize = new System.Drawing.Size(300, 300);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(300, 28);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Search";
            this.searchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearText);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckforEnter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.HotKeyLabel);
            this.splitContainer1.Panel1.Controls.Add(this.LogLocation);
            this.splitContainer1.Panel1.Controls.Add(this.LogButton);
            this.splitContainer1.Panel1.Controls.Add(this.searchBox);
            this.splitContainer1.Panel1.Controls.Add(this.mainFlash);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.AutoScrollMargin = new System.Drawing.Size(15, 15);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(784, 448);
            this.splitContainer1.SplitterDistance = 555;
            this.splitContainer1.TabIndex = 3;
            // 
            // HotKeyLabel
            // 
            this.HotKeyLabel.AutoSize = true;
            this.HotKeyLabel.Location = new System.Drawing.Point(412, 410);
            this.HotKeyLabel.Name = "HotKeyLabel";
            this.HotKeyLabel.Size = new System.Drawing.Size(0, 13);
            this.HotKeyLabel.TabIndex = 5;
            // 
            // LogLocation
            // 
            this.LogLocation.AutoSize = true;
            this.LogLocation.Location = new System.Drawing.Point(16, 431);
            this.LogLocation.Name = "LogLocation";
            this.LogLocation.Size = new System.Drawing.Size(0, 13);
            this.LogLocation.TabIndex = 4;
            // 
            // LogButton
            // 
            this.LogButton.Location = new System.Drawing.Point(12, 405);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(75, 23);
            this.LogButton.TabIndex = 3;
            this.LogButton.Text = "Search Log";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.openLogFile);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 1267);
            this.label10.MinimumSize = new System.Drawing.Size(120, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 10;
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 1137);
            this.label9.MinimumSize = new System.Drawing.Size(120, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 9;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 1007);
            this.label8.MinimumSize = new System.Drawing.Size(120, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 8;
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 878);
            this.label7.MinimumSize = new System.Drawing.Size(120, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 7;
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 747);
            this.label6.MinimumSize = new System.Drawing.Size(120, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 6;
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 618);
            this.label5.MinimumSize = new System.Drawing.Size(120, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 5;
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 489);
            this.label4.MinimumSize = new System.Drawing.Size(120, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 4;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 359);
            this.label3.MinimumSize = new System.Drawing.Size(120, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 3;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 228);
            this.label2.MinimumSize = new System.Drawing.Size(120, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 99);
            this.label1.MinimumSize = new System.Drawing.Size(120, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(128, 1300);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // pictureBox10
            // 
            this.pictureBox10.InitialImage = null;
            this.pictureBox10.Location = new System.Drawing.Point(3, 1173);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(120, 90);
            this.pictureBox10.TabIndex = 12;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loadSideVideo);
            this.pictureBox10.MouseEnter += new System.EventHandler(this.changePointertoHand);
            this.pictureBox10.MouseLeave += new System.EventHandler(this.changeHandtoPointer);
            // 
            // pictureBox9
            // 
            this.pictureBox9.InitialImage = null;
            this.pictureBox9.Location = new System.Drawing.Point(3, 1043);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(120, 90);
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loadSideVideo);
            this.pictureBox9.MouseEnter += new System.EventHandler(this.changePointertoHand);
            this.pictureBox9.MouseLeave += new System.EventHandler(this.changeHandtoPointer);
            // 
            // pictureBox8
            // 
            this.pictureBox8.InitialImage = null;
            this.pictureBox8.Location = new System.Drawing.Point(3, 913);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(120, 90);
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loadSideVideo);
            this.pictureBox8.MouseEnter += new System.EventHandler(this.changePointertoHand);
            this.pictureBox8.MouseLeave += new System.EventHandler(this.changeHandtoPointer);
            // 
            // pictureBox7
            // 
            this.pictureBox7.InitialImage = null;
            this.pictureBox7.Location = new System.Drawing.Point(3, 783);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(120, 90);
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loadSideVideo);
            this.pictureBox7.MouseEnter += new System.EventHandler(this.changePointertoHand);
            this.pictureBox7.MouseLeave += new System.EventHandler(this.changeHandtoPointer);
            // 
            // pictureBox6
            // 
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(3, 653);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(120, 90);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loadSideVideo);
            this.pictureBox6.MouseEnter += new System.EventHandler(this.changePointertoHand);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.changeHandtoPointer);
            // 
            // pictureBox5
            // 
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(3, 523);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(120, 90);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loadSideVideo);
            this.pictureBox5.MouseEnter += new System.EventHandler(this.changePointertoHand);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.changeHandtoPointer);
            // 
            // pictureBox4
            // 
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(3, 393);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 90);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loadSideVideo);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.changePointertoHand);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.changeHandtoPointer);
            // 
            // pictureBox3
            // 
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(3, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 90);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loadSideVideo);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.changePointertoHand);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.changeHandtoPointer);
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(3, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 90);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loadSideVideo);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.changePointertoHand);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.changeHandtoPointer);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 90);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loadSideVideo);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.changePointertoHand);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.changeHandtoPointer);
            // 
            // mainFlash
            // 
            this.mainFlash.Enabled = true;
            this.mainFlash.Location = new System.Drawing.Point(3, 62);
            this.mainFlash.Name = "mainFlash";
            this.mainFlash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mainFlash.OcxState")));
            this.mainFlash.Size = new System.Drawing.Size(547, 334);
            this.mainFlash.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 460);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.Name = "Form1";
            this.Text = "SMARTSign-Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFlash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private AxShockwaveFlashObjects.AxShockwaveFlash mainFlash;
        private System.Windows.Forms.SplitContainer splitContainer1;

        private string path;

        private System.Windows.Forms.PictureBox[] sidePicList;
        private System.Windows.Forms.Label[] sideLabelList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Label LogLocation;
        private System.Windows.Forms.Label HotKeyLabel;

    }
}

