namespace TeoriaGierZapałki
{
    partial class MainWindow
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
            this.label_menu = new System.Windows.Forms.Label();
            this.button_NIM1 = new System.Windows.Forms.Button();
            this.button_NIM2 = new System.Windows.Forms.Button();
            this.button_NIM3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_menu.Location = new System.Drawing.Point(198, 61);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(132, 47);
            this.label_menu.TabIndex = 0;
            this.label_menu.Text = "MENU";
            // 
            // button_NIM1
            // 
            this.button_NIM1.BackColor = System.Drawing.Color.BurlyWood;
            this.button_NIM1.Font = new System.Drawing.Font("PT Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_NIM1.Location = new System.Drawing.Point(135, 159);
            this.button_NIM1.Name = "button_NIM1";
            this.button_NIM1.Size = new System.Drawing.Size(260, 84);
            this.button_NIM1.TabIndex = 1;
            this.button_NIM1.Text = "NIM1";
            this.button_NIM1.UseVisualStyleBackColor = false;
            this.button_NIM1.Click += new System.EventHandler(this.button_NIM1_Click);
            // 
            // button_NIM2
            // 
            this.button_NIM2.BackColor = System.Drawing.Color.BurlyWood;
            this.button_NIM2.Font = new System.Drawing.Font("PT Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_NIM2.Location = new System.Drawing.Point(135, 259);
            this.button_NIM2.Name = "button_NIM2";
            this.button_NIM2.Size = new System.Drawing.Size(260, 84);
            this.button_NIM2.TabIndex = 2;
            this.button_NIM2.Text = "NIM2";
            this.button_NIM2.UseVisualStyleBackColor = false;
            this.button_NIM2.Click += new System.EventHandler(this.button_NIM2_Click);
            // 
            // button_NIM3
            // 
            this.button_NIM3.BackColor = System.Drawing.Color.BurlyWood;
            this.button_NIM3.Font = new System.Drawing.Font("PT Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_NIM3.Location = new System.Drawing.Point(135, 361);
            this.button_NIM3.Name = "button_NIM3";
            this.button_NIM3.Size = new System.Drawing.Size(260, 84);
            this.button_NIM3.TabIndex = 3;
            this.button_NIM3.Text = "NIM3";
            this.button_NIM3.UseVisualStyleBackColor = false;
            this.button_NIM3.Click += new System.EventHandler(this.button_NIM3_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 512);
            this.Controls.Add(this.button_NIM3);
            this.Controls.Add(this.button_NIM2);
            this.Controls.Add(this.button_NIM1);
            this.Controls.Add(this.label_menu);
            this.Name = "MainWindow";
            this.Text = "Matches Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Button button_NIM1;
        private System.Windows.Forms.Button button_NIM2;
        private System.Windows.Forms.Button button_NIM3;
    }
}

