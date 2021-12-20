namespace Rock_Paper_ScissorsGame
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbComputer = new System.Windows.Forms.PictureBox();
            this.lblTextResult = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.pbRock = new System.Windows.Forms.PictureBox();
            this.pbScissors = new System.Windows.Forms.PictureBox();
            this.pbPaper = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.Location = new System.Drawing.Point(12, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(144, 15);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Enter your username:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(178, 8);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(153, 20);
            this.tbUserName.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.Location = new System.Drawing.Point(9, 104);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(37, 15);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComputer.Location = new System.Drawing.Point(240, 102);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(69, 15);
            this.lblComputer.TabIndex = 3;
            this.lblComputer.Text = "Computer";
            this.lblComputer.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(114, 45);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 34);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.Gray;
            this.pbUser.Location = new System.Drawing.Point(12, 130);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(101, 82);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 5;
            this.pbUser.TabStop = false;
            this.pbUser.Visible = false;
            // 
            // pbComputer
            // 
            this.pbComputer.BackColor = System.Drawing.Color.Gray;
            this.pbComputer.Location = new System.Drawing.Point(208, 130);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(101, 82);
            this.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComputer.TabIndex = 6;
            this.pbComputer.TabStop = false;
            this.pbComputer.Visible = false;
            // 
            // lblTextResult
            // 
            this.lblTextResult.AutoSize = true;
            this.lblTextResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextResult.Location = new System.Drawing.Point(111, 232);
            this.lblTextResult.Name = "lblTextResult";
            this.lblTextResult.Size = new System.Drawing.Size(56, 16);
            this.lblTextResult.TabIndex = 7;
            this.lblTextResult.Text = "Result:";
            this.lblTextResult.Visible = false;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChoose.Location = new System.Drawing.Point(102, 278);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(118, 15);
            this.lblChoose.TabIndex = 8;
            this.lblChoose.Text = "Choose your picture:";
            this.lblChoose.Visible = false;
            // 
            // pbRock
            // 
            this.pbRock.Image = global::Rock_Paper_ScissorsGame.Properties.Resources.rock;
            this.pbRock.Location = new System.Drawing.Point(12, 308);
            this.pbRock.Name = "pbRock";
            this.pbRock.Size = new System.Drawing.Size(82, 64);
            this.pbRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRock.TabIndex = 9;
            this.pbRock.TabStop = false;
            this.pbRock.Visible = false;
            this.pbRock.Click += new System.EventHandler(this.pbRock_Click);
            // 
            // pbScissors
            // 
            this.pbScissors.Image = global::Rock_Paper_ScissorsGame.Properties.Resources.scissors;
            this.pbScissors.Location = new System.Drawing.Point(227, 308);
            this.pbScissors.Name = "pbScissors";
            this.pbScissors.Size = new System.Drawing.Size(82, 64);
            this.pbScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScissors.TabIndex = 10;
            this.pbScissors.TabStop = false;
            this.pbScissors.Visible = false;
            this.pbScissors.Click += new System.EventHandler(this.pbScissors_Click);
            // 
            // pbPaper
            // 
            this.pbPaper.Image = global::Rock_Paper_ScissorsGame.Properties.Resources.paper;
            this.pbPaper.Location = new System.Drawing.Point(124, 308);
            this.pbPaper.Name = "pbPaper";
            this.pbPaper.Size = new System.Drawing.Size(82, 64);
            this.pbPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPaper.TabIndex = 11;
            this.pbPaper.TabStop = false;
            this.pbPaper.Visible = false;
            this.pbPaper.Click += new System.EventHandler(this.pbPaper_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(68, 397);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 41);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(185, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 41);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(173, 232);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 14;
            this.lblResult.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pbPaper);
            this.Controls.Add(this.pbScissors);
            this.Controls.Add(this.pbRock);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.lblTextResult);
            this.Controls.Add(this.pbComputer);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lblUserName);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock-Paper-Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbComputer;
        private System.Windows.Forms.Label lblTextResult;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.PictureBox pbRock;
        private System.Windows.Forms.PictureBox pbScissors;
        private System.Windows.Forms.PictureBox pbPaper;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblResult;
    }
}

