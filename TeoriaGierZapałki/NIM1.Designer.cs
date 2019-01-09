namespace TeoriaGierZapałki
{
    partial class NIM1
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
            this.label_k = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.numericUpDown_maximum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_numberOfMatches = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_choice = new System.Windows.Forms.NumericUpDown();
            this.label_turn = new System.Windows.Forms.Label();
            this.label_howMany = new System.Windows.Forms.Label();
            this.groupBox_game = new System.Windows.Forms.GroupBox();
            this.button_go = new System.Windows.Forms.Button();
            this.button_back1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_max = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.groupBox_settings1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numberOfMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_choice)).BeginInit();
            this.groupBox_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_settings1
            // 
            this.groupBox_settings1.Controls.Add(this.button_startGame);
            this.groupBox_settings1.Controls.Add(this.label_k);
            this.groupBox_settings1.Controls.Add(this.label_n);
            this.groupBox_settings1.Controls.Add(this.numericUpDown_maximum);
            this.groupBox_settings1.Controls.Add(this.numericUpDown_numberOfMatches);
            this.groupBox_settings1.Location = new System.Drawing.Point(604, 22);
            this.groupBox_settings1.Name = "groupBox_settings1";
            this.groupBox_settings1.Size = new System.Drawing.Size(200, 181);
            this.groupBox_settings1.TabIndex = 0;
            this.groupBox_settings1.TabStop = false;
            this.groupBox_settings1.Text = "Settings";
            // 
            // button_startGame
            // 
            this.button_startGame.Location = new System.Drawing.Point(23, 134);
            this.button_startGame.Name = "button_startGame";
            this.button_startGame.Size = new System.Drawing.Size(120, 23);
            this.button_startGame.TabIndex = 4;
            this.button_startGame.Text = "Play";
            this.button_startGame.UseVisualStyleBackColor = true;
            this.button_startGame.Click += new System.EventHandler(this.button_startGame_Click);
            // 
            // label_k
            // 
            this.label_k.AutoSize = true;
            this.label_k.Location = new System.Drawing.Point(24, 77);
            this.label_k.Name = "label_k";
            this.label_k.Size = new System.Drawing.Size(107, 13);
            this.label_k.TabIndex = 3;
            this.label_k.Text = "maximum for one turn";
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
            // numericUpDown_maximum
            // 
            this.numericUpDown_maximum.Location = new System.Drawing.Point(23, 93);
            this.numericUpDown_maximum.Name = "numericUpDown_maximum";
            this.numericUpDown_maximum.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_maximum.TabIndex = 1;
            // 
            // numericUpDown_numberOfMatches
            // 
            this.numericUpDown_numberOfMatches.Location = new System.Drawing.Point(23, 44);
            this.numericUpDown_numberOfMatches.Name = "numericUpDown_numberOfMatches";
            this.numericUpDown_numberOfMatches.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_numberOfMatches.TabIndex = 0;
            // 
            // numericUpDown_choice
            // 
            this.numericUpDown_choice.Location = new System.Drawing.Point(23, 50);
            this.numericUpDown_choice.Name = "numericUpDown_choice";
            this.numericUpDown_choice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_choice.TabIndex = 2;
            // 
            // label_turn
            // 
            this.label_turn.AutoSize = true;
            this.label_turn.Location = new System.Drawing.Point(627, 291);
            this.label_turn.Name = "label_turn";
            this.label_turn.Size = new System.Drawing.Size(0, 13);
            this.label_turn.TabIndex = 3;
            // 
            // label_howMany
            // 
            this.label_howMany.AutoSize = true;
            this.label_howMany.Location = new System.Drawing.Point(20, 25);
            this.label_howMany.Name = "label_howMany";
            this.label_howMany.Size = new System.Drawing.Size(165, 13);
            this.label_howMany.TabIndex = 4;
            this.label_howMany.Text = "How many matches do you take?";
            // 
            // groupBox_game
            // 
            this.groupBox_game.Controls.Add(this.button_go);
            this.groupBox_game.Controls.Add(this.numericUpDown_choice);
            this.groupBox_game.Controls.Add(this.label_howMany);
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
            // button_back1
            // 
            this.button_back1.Location = new System.Drawing.Point(683, 428);
            this.button_back1.Name = "button_back1";
            this.button_back1.Size = new System.Drawing.Size(121, 46);
            this.button_back1.TabIndex = 6;
            this.button_back1.Text = "back to menu ->";
            this.button_back1.UseVisualStyleBackColor = true;
            this.button_back1.Click += new System.EventHandler(this.button_back1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 452);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(734, 216);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(13, 13);
            this.label_max.TabIndex = 8;
            this.label_max.Text = "0";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(658, 216);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(13, 13);
            this.label_number.TabIndex = 9;
            this.label_number.Text = "0";
            // 
            // NIM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(828, 531);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_back1);
            this.Controls.Add(this.groupBox_game);
            this.Controls.Add(this.label_turn);
            this.Controls.Add(this.groupBox_settings1);
            this.Name = "NIM1";
            this.Text = "NIM1";
            this.groupBox_settings1.ResumeLayout(false);
            this.groupBox_settings1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numberOfMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_choice)).EndInit();
            this.groupBox_game.ResumeLayout(false);
            this.groupBox_game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_settings1;
        private System.Windows.Forms.Button button_startGame;
        private System.Windows.Forms.Label label_k;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.NumericUpDown numericUpDown_maximum;
        private System.Windows.Forms.NumericUpDown numericUpDown_numberOfMatches;
        private System.Windows.Forms.NumericUpDown numericUpDown_choice;
        private System.Windows.Forms.Label label_turn;
        private System.Windows.Forms.Label label_howMany;
        private System.Windows.Forms.GroupBox groupBox_game;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.Button button_back1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_number;
    }
}
