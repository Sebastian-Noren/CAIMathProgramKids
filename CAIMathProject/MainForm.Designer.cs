namespace CAIMathProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.additionTextBox = new System.Windows.Forms.TextBox();
            this.subtractionTextBox = new System.Windows.Forms.TextBox();
            this.MultiTextBox = new System.Windows.Forms.TextBox();
            this.MultiRatioTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddSubRatio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.testBtn = new System.Windows.Forms.Button();
            this.practiceBtn = new System.Windows.Forms.Button();
            this.labelMaxPercent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.labelResponse = new System.Windows.Forms.Label();
            this.labelTestComplete = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Settings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // additionTextBox
            // 
            this.additionTextBox.Location = new System.Drawing.Point(142, 107);
            this.additionTextBox.Name = "additionTextBox";
            this.additionTextBox.Size = new System.Drawing.Size(100, 29);
            this.additionTextBox.TabIndex = 0;
            this.additionTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.additionTextBox_KeyUp);
            // 
            // subtractionTextBox
            // 
            this.subtractionTextBox.Location = new System.Drawing.Point(142, 145);
            this.subtractionTextBox.Name = "subtractionTextBox";
            this.subtractionTextBox.Size = new System.Drawing.Size(100, 29);
            this.subtractionTextBox.TabIndex = 1;
            this.subtractionTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.subtractionTextBox_KeyUp);
            // 
            // MultiTextBox
            // 
            this.MultiTextBox.Location = new System.Drawing.Point(142, 185);
            this.MultiTextBox.Name = "MultiTextBox";
            this.MultiTextBox.Size = new System.Drawing.Size(100, 29);
            this.MultiTextBox.TabIndex = 2;
            this.MultiTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MultiTextBox_KeyUp);
            // 
            // MultiRatioTextbox
            // 
            this.MultiRatioTextbox.Location = new System.Drawing.Point(443, 188);
            this.MultiRatioTextbox.Name = "MultiRatioTextbox";
            this.MultiRatioTextbox.Size = new System.Drawing.Size(84, 29);
            this.MultiRatioTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Addition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subtraction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Multiplication";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.label7);
            this.Settings.Controls.Add(this.AddSubRatio);
            this.Settings.Controls.Add(this.label6);
            this.Settings.Controls.Add(this.testBtn);
            this.Settings.Controls.Add(this.practiceBtn);
            this.Settings.Controls.Add(this.labelMaxPercent);
            this.Settings.Controls.Add(this.label4);
            this.Settings.Controls.Add(this.nameTextBox);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Controls.Add(this.MultiRatioTextbox);
            this.Settings.Controls.Add(this.label3);
            this.Settings.Controls.Add(this.additionTextBox);
            this.Settings.Controls.Add(this.label2);
            this.Settings.Controls.Add(this.MultiTextBox);
            this.Settings.Controls.Add(this.subtractionTextBox);
            this.Settings.Location = new System.Drawing.Point(14, 115);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(546, 386);
            this.Settings.TabIndex = 7;
            this.Settings.TabStop = false;
            this.Settings.Text = "Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Add/Subtract Ratio";
            // 
            // AddSubRatio
            // 
            this.AddSubRatio.Location = new System.Drawing.Point(443, 145);
            this.AddSubRatio.Name = "AddSubRatio";
            this.AddSubRatio.Size = new System.Drawing.Size(84, 29);
            this.AddSubRatio.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Multiplication Ratio";
            // 
            // testBtn
            // 
            this.testBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.testBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.testBtn.Location = new System.Drawing.Point(340, 328);
            this.testBtn.Margin = new System.Windows.Forms.Padding(4);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(181, 42);
            this.testBtn.TabIndex = 11;
            this.testBtn.Text = "Take Test";
            this.testBtn.UseVisualStyleBackColor = false;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // practiceBtn
            // 
            this.practiceBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.practiceBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.practiceBtn.Location = new System.Drawing.Point(21, 328);
            this.practiceBtn.Margin = new System.Windows.Forms.Padding(4);
            this.practiceBtn.Name = "practiceBtn";
            this.practiceBtn.Size = new System.Drawing.Size(181, 42);
            this.practiceBtn.TabIndex = 10;
            this.practiceBtn.Text = "Practice";
            this.practiceBtn.UseVisualStyleBackColor = false;
            this.practiceBtn.Click += new System.EventHandler(this.practiceBtn_Click);
            // 
            // labelMaxPercent
            // 
            this.labelMaxPercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMaxPercent.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labelMaxPercent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMaxPercent.Location = new System.Drawing.Point(142, 230);
            this.labelMaxPercent.Margin = new System.Windows.Forms.Padding(0);
            this.labelMaxPercent.Name = "labelMaxPercent";
            this.labelMaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMaxPercent.Size = new System.Drawing.Size(100, 28);
            this.labelMaxPercent.TabIndex = 9;
            this.labelMaxPercent.Text = "0%";
            this.labelMaxPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(16, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Your name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(142, 40);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameTextBox.Size = new System.Drawing.Size(385, 29);
            this.nameTextBox.TabIndex = 7;
            // 
            // labelQuestion
            // 
            this.labelQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(19, 34);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(209, 64);
            this.labelQuestion.TabIndex = 8;
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.Location = new System.Drawing.Point(234, 35);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 50);
            this.answerTextBox.TabIndex = 9;
            this.answerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answerTextBox_KeyDown);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(340, 35);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(100, 63);
            this.enterBtn.TabIndex = 10;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // labelResponse
            // 
            this.labelResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelResponse.Location = new System.Drawing.Point(19, 101);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(421, 44);
            this.labelResponse.TabIndex = 11;
            this.labelResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTestComplete
            // 
            this.labelTestComplete.AutoSize = true;
            this.labelTestComplete.Location = new System.Drawing.Point(14, 42);
            this.labelTestComplete.Name = "labelTestComplete";
            this.labelTestComplete.Size = new System.Drawing.Size(0, 25);
            this.labelTestComplete.TabIndex = 12;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(14, 67);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 25);
            this.labelInfo.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.labelInfo);
            this.groupBox1.Controls.Add(this.labelTestComplete);
            this.groupBox1.Location = new System.Drawing.Point(14, 682);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 403);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Questions";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.White;
            this.listBox2.Font = new System.Drawing.Font("Courier New", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(19, 95);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(439, 277);
            this.listBox2.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("Courier New", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(22, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(386, 508);
            this.listBox1.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelQuestion);
            this.groupBox2.Controls.Add(this.answerTextBox);
            this.groupBox2.Controls.Add(this.enterBtn);
            this.groupBox2.Controls.Add(this.labelResponse);
            this.groupBox2.Location = new System.Drawing.Point(14, 515);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 161);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Answer the Question.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CAIMathProject.Properties.Resources.icon;
            this.pictureBox2.Location = new System.Drawing.Point(14, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CAIMathProject.Properties.Resources.mathkids;
            this.pictureBox1.Location = new System.Drawing.Point(619, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(813, 97);
            this.label5.TabIndex = 21;
            this.label5.Text = "Math Assisted Program - KIDS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(518, 515);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 570);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Results";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 1155);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox additionTextBox;
        private System.Windows.Forms.TextBox MultiRatioTextbox;
        private System.Windows.Forms.TextBox MultiTextBox;
        private System.Windows.Forms.TextBox subtractionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label labelMaxPercent;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button practiceBtn;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label labelResponse;
        private System.Windows.Forms.Label labelTestComplete;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddSubRatio;
        private System.Windows.Forms.Label label6;
    }
}

