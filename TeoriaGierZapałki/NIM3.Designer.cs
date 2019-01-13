namespace TeoriaGierZapałki
{
    partial class NIM3
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
            this.groupBox_settings1 = new System.Windows.Forms.GroupBox();
            this.button_startGame = new System.Windows.Forms.Button();
            this.label_n = new System.Windows.Forms.Label();
            this.numericUpDown_number = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_whichMatch = new System.Windows.Forms.NumericUpDown();
            this.label_turn = new System.Windows.Forms.Label();
            this.label_whichMatch = new System.Windows.Forms.Label();
            this.groupBox_game = new System.Windows.Forms.GroupBox();
            this.button_go = new System.Windows.Forms.Button();
            this.button_back3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_number = new System.Windows.Forms.Label();
            this.groupBox_settings1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_whichMatch)).BeginInit();
            this.groupBox_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_settings1
            // 
            this.groupBox_settings1.Controls.Add(this.button_startGame);
            this.groupBox_settings1.Controls.Add(this.label_n);
            this.groupBox_settings1.Controls.Add(this.numericUpDown_number);
            this.groupBox_settings1.Location = new System.Drawing.Point(604, 22);
            this.groupBox_settings1.Name = "groupBox_settings1";
            this.groupBox_settings1.Size = new System.Drawing.Size(200, 132);
            this.groupBox_settings1.TabIndex = 0;
            this.groupBox_settings1.TabStop = false;
            this.groupBox_settings1.Text = "Settings";
            // 
            // button_startGame
            // 
            this.button_startGame.Location = new System.Drawing.Point(23, 81);
            this.button_startGame.Name = "button_startGame";
            this.button_startGame.Size = new System.Drawing.Size(120, 23);
            this.button_startGame.TabIndex = 4;
            this.button_startGame.Text = "Play";
            this.button_startGame.UseVisualStyleBackColor = true;
            this.button_startGame.Click += new System.EventHandler(this.button_startGame_Click);
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(24, 28);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(97, 13);
            this.label_n.TabIndex = 2;
            this.label_n.Text = "number of matches";
            // 
            // numericUpDown_number
            // 
            this.numericUpDown_number.Location = new System.Drawing.Point(23, 44);
            this.numericUpDown_number.Name = "numericUpDown_number";
            this.numericUpDown_number.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_number.TabIndex = 0;
            // 
            // numericUpDown_whichMatch
            // 
            this.numericUpDown_whichMatch.Location = new System.Drawing.Point(23, 50);
            this.numericUpDown_whichMatch.Name = "numericUpDown_whichMatch";
            this.numericUpDown_whichMatch.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_whichMatch.TabIndex = 2;
            // 
            // label_turn
            // 
            this.label_turn.AutoSize = true;
            this.label_turn.Location = new System.Drawing.Point(627, 291);
            this.label_turn.Name = "label_turn";
            this.label_turn.Size = new System.Drawing.Size(0, 13);
            this.label_turn.TabIndex = 3;
            // 
            // label_whichMatch
            // 
            this.label_whichMatch.AutoSize = true;
            this.label_whichMatch.Location = new System.Drawing.Point(20, 25);
            this.label_whichMatch.Name = "label_whichMatch";
            this.label_whichMatch.Size = new System.Drawing.Size(140, 13);
            this.label_whichMatch.TabIndex = 4;
            this.label_whichMatch.Text = "Remove after which match?";
            // 
            // groupBox_game
            // 
            this.groupBox_game.Controls.Add(this.button_go);
            this.groupBox_game.Controls.Add(this.numericUpDown_whichMatch);
            this.groupBox_game.Controls.Add(this.label_whichMatch);
            this.groupBox_game.Location = new System.Drawing.Point(604, 244);
            this.groupBox_game.Name = "groupBox_game";
            this.groupBox_game.Size = new System.Drawing.Size(200, 135);
            this.groupBox_game.TabIndex = 5;
            this.groupBox_game.TabStop = false;
            this.groupBox_game.Text = "Play";
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(23, 85);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(120, 23);
            this.button_go.TabIndex = 5;
            this.button_go.Text = "Go!";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // button_back3
            // 
            this.button_back3.Location = new System.Drawing.Point(679, 417);
            this.button_back3.Name = "button_back3";
            this.button_back3.Size = new System.Drawing.Size(125, 54);
            this.button_back3.TabIndex = 6;
            this.button_back3.Text = "back to menu ->";
            this.button_back3.UseVisualStyleBackColor = true;
            this.button_back3.Click += new System.EventHandler(this.button_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 507);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(627, 193);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(13, 13);
            this.label_number.TabIndex = 8;
            this.label_number.Text = "0";
            // 
            // NIM3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(828, 531);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_back3);
            this.Controls.Add(this.groupBox_game);
            this.Controls.Add(this.label_turn);
            this.Controls.Add(this.groupBox_settings1);
            this.Name = "NIM3";
            this.Text = "NIM3";
            this.groupBox_settings1.ResumeLayout(false);
            this.groupBox_settings1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_whichMatch)).EndInit();
            this.groupBox_game.ResumeLayout(false);
            this.groupBox_game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_settings1;
        private System.Windows.Forms.Button button_startGame;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.NumericUpDown numericUpDown_number;
        private System.Windows.Forms.NumericUpDown numericUpDown_whichMatch;
        private System.Windows.Forms.Label label_turn;
        private System.Windows.Forms.Label label_whichMatch;
        private System.Windows.Forms.GroupBox groupBox_game;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.Button button_back3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_number;
    }
}
