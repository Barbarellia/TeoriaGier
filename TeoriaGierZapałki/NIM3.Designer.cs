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
            this.label_k = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label_turn = new System.Windows.Forms.Label();
            this.label_howMany = new System.Windows.Forms.Label();
            this.groupBox_game = new System.Windows.Forms.GroupBox();
            this.button_go = new System.Windows.Forms.Button();
            this.button_back3 = new System.Windows.Forms.Button();
            this.groupBox_settings1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox_game.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_settings1
            // 
            this.groupBox_settings1.Controls.Add(this.button_startGame);
            this.groupBox_settings1.Controls.Add(this.label_k);
            this.groupBox_settings1.Controls.Add(this.label_n);
            this.groupBox_settings1.Controls.Add(this.numericUpDown2);
            this.groupBox_settings1.Controls.Add(this.numericUpDown1);
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
            // 
            // label_k
            // 
            this.label_k.AutoSize = true;
            this.label_k.Location = new System.Drawing.Point(24, 77);
            this.label_k.Name = "label_k";
            this.label_k.Size = new System.Drawing.Size(42, 13);
            this.label_k.TabIndex = 3;
            this.label_k.Text = "number";
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
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(23, 93);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 44);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 507);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(23, 50);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 2;
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
            this.groupBox_game.Controls.Add(this.numericUpDown3);
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
            // NIM3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(828, 531);
            this.Controls.Add(this.button_back3);
            this.Controls.Add(this.groupBox_game);
            this.Controls.Add(this.label_turn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_settings1);
            this.Name = "NIM3";
            this.Text = "NIM3";
            this.groupBox_settings1.ResumeLayout(false);
            this.groupBox_settings1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox_game.ResumeLayout(false);
            this.groupBox_game.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_settings1;
        private System.Windows.Forms.Button button_startGame;
        private System.Windows.Forms.Label label_k;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label_turn;
        private System.Windows.Forms.Label label_howMany;
        private System.Windows.Forms.GroupBox groupBox_game;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.Button button_back3;
    }
}
