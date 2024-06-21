namespace Calculator
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.Historypanel = new System.Windows.Forms.Panel();
            this.buttonBraces = new System.Windows.Forms.Button();
            this.NoHistoryPic = new System.Windows.Forms.PictureBox();
            this.Exepretionlbl = new System.Windows.Forms.Label();
            this.Historypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoHistoryPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Historypanel
            // 
            this.Historypanel.AutoScroll = true;
            this.Historypanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.Historypanel.Controls.Add(this.Exepretionlbl);
            this.Historypanel.Controls.Add(this.NoHistoryPic);
            this.Historypanel.Location = new System.Drawing.Point(49, 31);
            this.Historypanel.Name = "Historypanel";
            this.Historypanel.Size = new System.Drawing.Size(266, 291);
            this.Historypanel.TabIndex = 1;
            // 
            // buttonBraces
            // 
            this.buttonBraces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.buttonBraces.BackgroundImage = global::Calculator.Properties.Resources.clear_button1;
            this.buttonBraces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBraces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBraces.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBraces.FlatAppearance.BorderSize = 0;
            this.buttonBraces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonBraces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBraces.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBraces.Location = new System.Drawing.Point(104, 358);
            this.buttonBraces.Name = "buttonBraces";
            this.buttonBraces.Size = new System.Drawing.Size(153, 35);
            this.buttonBraces.TabIndex = 4;
            this.buttonBraces.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBraces.UseVisualStyleBackColor = false;
            this.buttonBraces.Click += new System.EventHandler(this.buttonBraces_Click);
            // 
            // NoHistoryPic
            // 
            this.NoHistoryPic.Image = global::Calculator.Properties.Resources.Group_4;
            this.NoHistoryPic.Location = new System.Drawing.Point(35, 40);
            this.NoHistoryPic.Name = "NoHistoryPic";
            this.NoHistoryPic.Size = new System.Drawing.Size(195, 193);
            this.NoHistoryPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NoHistoryPic.TabIndex = 0;
            this.NoHistoryPic.TabStop = false;
            this.NoHistoryPic.Click += new System.EventHandler(this.NoHistoryPic_Click);
            // 
            // Exepretionlbl
            // 
            this.Exepretionlbl.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Exepretionlbl.AutoSize = true;
            this.Exepretionlbl.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Exepretionlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exepretionlbl.Location = new System.Drawing.Point(35, 15);
            this.Exepretionlbl.Name = "Exepretionlbl";
            this.Exepretionlbl.Size = new System.Drawing.Size(0, 29);
            this.Exepretionlbl.TabIndex = 1;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(360, 405);
            this.Controls.Add(this.buttonBraces);
            this.Controls.Add(this.Historypanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "History";
            this.Text = "History";
            this.Historypanel.ResumeLayout(false);
            this.Historypanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoHistoryPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox NoHistoryPic;
        private System.Windows.Forms.Panel Historypanel;
        private System.Windows.Forms.Button buttonBraces;
        private System.Windows.Forms.Label Exepretionlbl;
    }
}