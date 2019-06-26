namespace COMP123_S2019_LESSION8B
{
    partial class Lab8
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
            this.TitleLabel08 = new System.Windows.Forms.Label();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel08
            // 
            this.TitleLabel08.AutoSize = true;
            this.TitleLabel08.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel08.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel08.Name = "TitleLabel08";
            this.TitleLabel08.Size = new System.Drawing.Size(107, 37);
            this.TitleLabel08.TabIndex = 0;
            this.TitleLabel08.Text = "Lab08";
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.textBox1);
            this.infoGroupBox.Controls.Add(this.nameLabel);
            this.infoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGroupBox.Location = new System.Drawing.Point(13, 49);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(599, 244);
            this.infoGroupBox.TabIndex = 1;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Info";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(6, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(177, 31);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Enter Name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(189, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 38);
            this.textBox1.TabIndex = 1;
            // 
            // Lab8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.TitleLabel08);
            this.Name = "Lab8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lab8Form";
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel08;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nameLabel;
    }
}

