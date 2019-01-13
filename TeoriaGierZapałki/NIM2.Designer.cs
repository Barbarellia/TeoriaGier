namespace TeoriaGierZapałki
{
    partial class NIM2
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
            this.numericUpDown_k = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_n = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_howMany = new System.Windows.Forms.NumericUpDown();
            this.label_turn = new System.Windows.Forms.Label();
            this.label_howMany = new System.Windows.Forms.Label();
            this.groupBox_game = new System.Windows.Forms.GroupBox();
            this.button_go = new System.Windows.Forms.Button();
            this.button_back2 = new System.Windows.Forms.Button();
            this.numericUpDown_whichRow = new System.Windows.Forms.NumericUpDown();
            this.label_whichRow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_rows = new System.Windows.Forms.Label();
            this.label_matches = new System.Windows.Forms.Label();
            this.label_action = new System.Windows.Forms.Label();
            this.groupBox_settings1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_howMany)).BeginInit();
            this.groupBox_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_whichRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_settings1
            // 
            this.groupBox_settings1.Controls.Add(this.button_startGame);
            this.groupBox_settings1.Controls.Add(this.label_k);
            this.groupBox_settings1.Controls.Add(this.label_n);
            this.groupBox_settings1.Controls.Add(this.numericUpDown_k);
            this.groupBox_settings1.Controls.Add(this.numericUpDown_n);
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
            this.label_k.Size = new System.Drawing.Size(137, 13);
            this.label_k.TabIndex = 3;
            this.label_k.Text = "number of matches in a row";
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(24, 28);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(79, 13);
            this.label_n.TabIndex = 2;
            this.label_n.Text = "number of rows";
            // 
            // numericUpDown_k
            // 
            this.numericUpDown_k.Location = new System.Drawing.Point(23, 93);
            this.numericUpDown_k.Name = "numericUpDown_k";
            this.numericUpDown_k.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_k.TabIndex = 1;
            // 
            // numericUpDown_n
            // 
            this.numericUpDown_n.Location = new System.Drawing.Point(23, 44);
            this.numericUpDown_n.Name = "numericUpDown_n";
            this.numericUpDown_n.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_n.TabIndex = 0;
            // 
            // numericUpDown_howMany
            // 
            this.numericUpDown_howMany.Location = new System.Drawing.Point(23, 50);
            this.numericUpDown_howMany.Name = "numericUpDown_howMany";
            this.numericUpDown_howMany.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_howMany.TabIndex = 2;
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
            this.groupBox_game.Controls.Add(this.numericUpDown_whichRow);
            this.groupBox_game.Controls.Add(this.label_whichRow);
            this.groupBox_game.Controls.Add(this.button_go);
            this.groupBox_game.Controls.Add(this.numericUpDown_howMany);
            this.groupBox_game.Controls.Add(this.label_howMany);
            this.groupBox_game.Location = new System.Drawing.Point(604, 238);
            this.groupBox_game.Name = "groupBox_game";
            this.groupBox_game.Size = new System.Drawing.Size(200, 203);
            this.groupBox_game.TabIndex = 5;
            this.groupBox_game.TabStop = false;
            this.groupBox_game.Text = "Play";
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(23, 152);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(120, 23);
            this.button_go.TabIndex = 5;
            this.button_go.Text = "Go!";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // button_back2
            // 
            this.button_back2.Location = new System.Drawing.Point(693, 473);
            this.button_back2.Name = "button_back2";
            this.button_back2.Size = new System.Drawing.Size(111, 46);
            this.button_back2.TabIndex = 6;
            this.button_back2.Text = "back to menu ->";
            this.button_back2.UseVisualStyleBackColor = true;
            this.button_back2.Click += new System.EventHandler(this.button_back2_Click);
            // 
            // numericUpDown_whichRow
            // 
            this.numericUpDown_whichRow.Location = new System.Drawing.Point(23, 107);
            this.numericUpDown_whichRow.Name = "numericUpDown_whichRow";
            this.numericUpDown_whichRow.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_whichRow.TabIndex = 6;
            // 
            // label_whichRow
            // 
            this.label_whichRow.AutoSize = true;
            this.label_whichRow.Location = new System.Drawing.Point(20, 82);
            this.label_whichRow.Name = "label_whichRow";
            this.label_whichRow.Size = new System.Drawing.Size(87, 13);
            this.label_whichRow.TabIndex = 7;
            this.label_whichRow.Text = "From which row?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 507);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label_rows
            // 
            this.label_rows.AutoSize = true;
            this.label_rows.Location = new System.Drawing.Point(614, 206);
            this.label_rows.Name = "label_rows";
            this.label_rows.Size = new System.Drawing.Size(13, 13);
            this.label_rows.TabIndex = 8;
            this.label_rows.Text = "0";
            // 
            // label_matches
            // 
            this.label_matches.AutoSize = true;
            this.label_matches.Location = new System.Drawing.Point(700, 206);
            this.label_matches.Name = "label_matches";
            this.label_matches.Size = new System.Drawing.Size(13, 13);
            this.label_matches.TabIndex = 9;
            this.label_matches.Text = "0";
            // 
            // label_action
            // 
            this.label_action.AutoSize = true;
            this.label_action.Location = new System.Drawing.Point(614, 444);
            this.label_action.Name = "label_action";
            this.label_action.Size = new System.Drawing.Size(87, 13);
            this.label_action.TabIndex = 10;
            this.label_action.Text = "Info about action";
            // 
            // NIM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(828, 531);
            this.Controls.Add(this.label_action);
            this.Controls.Add(this.label_matches);
            this.Controls.Add(this.label_rows);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_back2);
            this.Controls.Add(this.groupBox_game);
            this.Controls.Add(this.label_turn);
            this.Controls.Add(this.groupBox_settings1);
            this.Name = "NIM2";
            this.Text = "NIM2";
            this.groupBox_settings1.ResumeLayout(false);
            this.groupBox_settings1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_howMany)).EndInit();
            this.groupBox_game.ResumeLayout(false);
            this.groupBox_game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_whichRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_settings1;
        private System.Windows.Forms.Button button_startGame;
        private System.Windows.Forms.Label label_k;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.NumericUpDown numericUpDown_k;
        private System.Windows.Forms.NumericUpDown numericUpDown_n;
        private System.Windows.Forms.NumericUpDown numericUpDown_howMany;
        private System.Windows.Forms.Label label_turn;
        private System.Windows.Forms.Label label_howMany;
        private System.Windows.Forms.GroupBox groupBox_game;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.Button button_back2;
        private System.Windows.Forms.NumericUpDown numericUpDown_whichRow;
        private System.Windows.Forms.Label label_whichRow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_rows;
        private System.Windows.Forms.Label label_matches;
        private System.Windows.Forms.Label label_action;
    }
}
