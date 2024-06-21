namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.LabelDeg_Rad = new System.Windows.Forms.Label();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonBraces = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.buttonPlusOrMines = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.buttonMines = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSqrRoot = new System.Windows.Forms.Button();
            this.buttonDegRad = new System.Windows.Forms.Button();
            this.buttonExp = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonLogOf10 = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonAbsolute = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonXOver_n = new System.Windows.Forms.Button();
            this.button1OverX = new System.Windows.Forms.Button();
            this.buttonSqr = new System.Windows.Forms.Button();
            this.buttonExpOf_n = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.LabelInput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonsPanel.CausesValidation = false;
            this.buttonsPanel.Controls.Add(this.LabelDeg_Rad);
            this.buttonsPanel.Controls.Add(this.buttonHistory);
            this.buttonsPanel.Controls.Add(this.buttonDelete);
            this.buttonsPanel.Controls.Add(this.panel2);
            this.buttonsPanel.Controls.Add(this.panel1);
            this.buttonsPanel.Location = new System.Drawing.Point(0, 126);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(774, 325);
            this.buttonsPanel.TabIndex = 1;
            // 
            // LabelDeg_Rad
            // 
            this.LabelDeg_Rad.AutoSize = true;
            this.LabelDeg_Rad.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeg_Rad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.LabelDeg_Rad.Location = new System.Drawing.Point(104, 17);
            this.LabelDeg_Rad.Name = "LabelDeg_Rad";
            this.LabelDeg_Rad.Size = new System.Drawing.Size(42, 20);
            this.LabelDeg_Rad.TabIndex = 45;
            this.LabelDeg_Rad.Text = "Deg";
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonHistory.BackgroundImage = global::Calculator.Properties.Resources.history;
            this.buttonHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonHistory.FlatAppearance.BorderSize = 0;
            this.buttonHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.ForeColor = System.Drawing.Color.Transparent;
            this.buttonHistory.Location = new System.Drawing.Point(12, 5);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(90, 41);
            this.buttonHistory.TabIndex = 44;
            this.buttonHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonDelete.BackgroundImage = global::Calculator.Properties.Resources.delete;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDelete.Location = new System.Drawing.Point(661, 8);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(84, 35);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonEquals);
            this.panel2.Controls.Add(this.buttonPercent);
            this.panel2.Controls.Add(this.buttonDivision);
            this.panel2.Controls.Add(this.buttonPoint);
            this.panel2.Controls.Add(this.buttonBraces);
            this.panel2.Controls.Add(this.buttonC);
            this.panel2.Controls.Add(this.button_0);
            this.panel2.Controls.Add(this.buttonPlusOrMines);
            this.panel2.Controls.Add(this.buttonPlus);
            this.panel2.Controls.Add(this.button_3);
            this.panel2.Controls.Add(this.button_2);
            this.panel2.Controls.Add(this.button_1);
            this.panel2.Controls.Add(this.buttonMines);
            this.panel2.Controls.Add(this.buttonMultiplication);
            this.panel2.Controls.Add(this.button_6);
            this.panel2.Controls.Add(this.button_9);
            this.panel2.Controls.Add(this.button_5);
            this.panel2.Controls.Add(this.button_4);
            this.panel2.Controls.Add(this.button_8);
            this.panel2.Controls.Add(this.button_7);
            this.panel2.Location = new System.Drawing.Point(321, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 239);
            this.panel2.TabIndex = 1;
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonEquals.BackgroundImage = global::Calculator.Properties.Resources.button_19;
            this.buttonEquals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEquals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEquals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEquals.FlatAppearance.BorderSize = 0;
            this.buttonEquals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquals.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEquals.Location = new System.Drawing.Point(335, 187);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(84, 35);
            this.buttonEquals.TabIndex = 28;
            this.buttonEquals.Tag = "=";
            this.buttonEquals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonPercent.BackgroundImage = global::Calculator.Properties.Resources.button_2;
            this.buttonPercent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPercent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPercent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPercent.FlatAppearance.BorderSize = 0;
            this.buttonPercent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPercent.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPercent.Location = new System.Drawing.Point(233, 3);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(84, 35);
            this.buttonPercent.TabIndex = 4;
            this.buttonPercent.Tag = "%";
            this.buttonPercent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPercent.UseVisualStyleBackColor = false;
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonDivision.BackgroundImage = global::Calculator.Properties.Resources.button_3;
            this.buttonDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDivision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDivision.FlatAppearance.BorderSize = 0;
            this.buttonDivision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivision.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDivision.Location = new System.Drawing.Point(335, 2);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(84, 35);
            this.buttonDivision.TabIndex = 5;
            this.buttonDivision.Tag = "/";
            this.buttonDivision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.OperatorsClick);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonPoint.BackgroundImage = global::Calculator.Properties.Resources.button_18;
            this.buttonPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPoint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPoint.FlatAppearance.BorderSize = 0;
            this.buttonPoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoint.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPoint.Location = new System.Drawing.Point(234, 187);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(84, 35);
            this.buttonPoint.TabIndex = 27;
            this.buttonPoint.Tag = ".";
            this.buttonPoint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.NumberClick);
            // 
            // buttonBraces
            // 
            this.buttonBraces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonBraces.BackgroundImage = global::Calculator.Properties.Resources.button_1;
            this.buttonBraces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBraces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBraces.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBraces.FlatAppearance.BorderSize = 0;
            this.buttonBraces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonBraces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBraces.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBraces.Location = new System.Drawing.Point(126, 3);
            this.buttonBraces.Name = "buttonBraces";
            this.buttonBraces.Size = new System.Drawing.Size(84, 35);
            this.buttonBraces.TabIndex = 3;
            this.buttonBraces.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBraces.UseVisualStyleBackColor = false;
            this.buttonBraces.Click += new System.EventHandler(this.buttonBraces_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonC.BackgroundImage = global::Calculator.Properties.Resources.button;
            this.buttonC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.ForeColor = System.Drawing.Color.Transparent;
            this.buttonC.Location = new System.Drawing.Point(14, 3);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(84, 35);
            this.buttonC.TabIndex = 2;
            this.buttonC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.button_0.BackgroundImage = global::Calculator.Properties.Resources.button_17;
            this.button_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_0.FlatAppearance.BorderSize = 0;
            this.button_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_0.ForeColor = System.Drawing.Color.Transparent;
            this.button_0.Location = new System.Drawing.Point(127, 187);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(84, 35);
            this.button_0.TabIndex = 26;
            this.button_0.Tag = "0";
            this.button_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.NumberClick);
            // 
            // buttonPlusOrMines
            // 
            this.buttonPlusOrMines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonPlusOrMines.BackgroundImage = global::Calculator.Properties.Resources.button_16;
            this.buttonPlusOrMines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlusOrMines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlusOrMines.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPlusOrMines.FlatAppearance.BorderSize = 0;
            this.buttonPlusOrMines.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonPlusOrMines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlusOrMines.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPlusOrMines.Location = new System.Drawing.Point(15, 187);
            this.buttonPlusOrMines.Name = "buttonPlusOrMines";
            this.buttonPlusOrMines.Size = new System.Drawing.Size(84, 35);
            this.buttonPlusOrMines.TabIndex = 25;
            this.buttonPlusOrMines.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPlusOrMines.UseVisualStyleBackColor = false;
            this.buttonPlusOrMines.Click += new System.EventHandler(this.buttonPlusOrMines_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonPlus.BackgroundImage = global::Calculator.Properties.Resources.button_15;
            this.buttonPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPlus.Location = new System.Drawing.Point(335, 139);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(84, 35);
            this.buttonPlus.TabIndex = 24;
            this.buttonPlus.Tag = "+";
            this.buttonPlus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.OperatorsClick);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.button_3.BackgroundImage = global::Calculator.Properties.Resources.button_14;
            this.button_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_3.FlatAppearance.BorderSize = 0;
            this.button_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.ForeColor = System.Drawing.Color.Transparent;
            this.button_3.Location = new System.Drawing.Point(234, 140);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(84, 35);
            this.button_3.TabIndex = 23;
            this.button_3.Tag = "3";
            this.button_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.NumberClick);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.button_2.BackgroundImage = global::Calculator.Properties.Resources.button_13;
            this.button_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_2.FlatAppearance.BorderSize = 0;
            this.button_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.ForeColor = System.Drawing.Color.Transparent;
            this.button_2.Location = new System.Drawing.Point(127, 140);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(84, 35);
            this.button_2.TabIndex = 22;
            this.button_2.Tag = "2";
            this.button_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.NumberClick);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.button_1.BackgroundImage = global::Calculator.Properties.Resources.button_12;
            this.button_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_1.FlatAppearance.BorderSize = 0;
            this.button_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.ForeColor = System.Drawing.Color.Transparent;
            this.button_1.Location = new System.Drawing.Point(15, 140);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(84, 35);
            this.button_1.TabIndex = 21;
            this.button_1.Tag = "1";
            this.button_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.NumberClick);
            // 
            // buttonMines
            // 
            this.buttonMines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonMines.BackgroundImage = global::Calculator.Properties.Resources.button_11;
            this.buttonMines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMines.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMines.FlatAppearance.BorderSize = 0;
            this.buttonMines.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonMines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMines.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMines.Location = new System.Drawing.Point(335, 92);
            this.buttonMines.Name = "buttonMines";
            this.buttonMines.Size = new System.Drawing.Size(84, 35);
            this.buttonMines.TabIndex = 9;
            this.buttonMines.Tag = "-";
            this.buttonMines.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMines.UseVisualStyleBackColor = false;
            this.buttonMines.Click += new System.EventHandler(this.OperatorsClick);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonMultiplication.BackgroundImage = global::Calculator.Properties.Resources.button_7;
            this.buttonMultiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMultiplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMultiplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMultiplication.FlatAppearance.BorderSize = 0;
            this.buttonMultiplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplication.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMultiplication.Location = new System.Drawing.Point(335, 47);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(84, 35);
            this.buttonMultiplication.TabIndex = 13;
            this.buttonMultiplication.Tag = "*";
            this.buttonMultiplication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.OperatorsClick);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.button_6.BackgroundImage = global::Calculator.Properties.Resources.button_10;
            this.button_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_6.FlatAppearance.BorderSize = 0;
            this.button_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.ForeColor = System.Drawing.Color.Transparent;
            this.button_6.Location = new System.Drawing.Point(233, 93);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(84, 35);
            this.button_6.TabIndex = 8;
            this.button_6.Tag = "6";
            this.button_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.NumberClick);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.button_9.BackgroundImage = global::Calculator.Properties.Resources.button_6;
            this.button_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_9.FlatAppearance.BorderSize = 0;
            this.button_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.ForeColor = System.Drawing.Color.Transparent;
            this.button_9.Location = new System.Drawing.Point(233, 48);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(84, 35);
            this.button_9.TabIndex = 12;
            this.button_9.Tag = "9";
            this.button_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.NumberClick);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.button_5.BackgroundImage = global::Calculator.Properties.Resources.button_9;
            this.button_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_5.FlatAppearance.BorderSize = 0;
            this.button_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.ForeColor = System.Drawing.Color.Transparent;
            this.button_5.Location = new System.Drawing.Point(126, 93);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(84, 35);
            this.button_5.TabIndex = 7;
            this.button_5.Tag = "5";
            this.button_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.NumberClick);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.button_4.BackgroundImage = global::Calculator.Properties.Resources.button_8;
            this.button_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_4.FlatAppearance.BorderSize = 0;
            this.button_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.ForeColor = System.Drawing.Color.Transparent;
            this.button_4.Location = new System.Drawing.Point(14, 93);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(84, 35);
            this.button_4.TabIndex = 6;
            this.button_4.Tag = "4";
            this.button_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.NumberClick);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.button_8.BackgroundImage = global::Calculator.Properties.Resources.button_5;
            this.button_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_8.FlatAppearance.BorderSize = 0;
            this.button_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.ForeColor = System.Drawing.Color.Transparent;
            this.button_8.Location = new System.Drawing.Point(126, 48);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(84, 35);
            this.button_8.TabIndex = 11;
            this.button_8.Tag = "8";
            this.button_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.NumberClick);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.button_7.BackgroundImage = global::Calculator.Properties.Resources.button_4;
            this.button_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_7.FlatAppearance.BorderSize = 0;
            this.button_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.ForeColor = System.Drawing.Color.Transparent;
            this.button_7.Location = new System.Drawing.Point(14, 48);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(84, 35);
            this.button_7.TabIndex = 10;
            this.button_7.Tag = "7";
            this.button_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.NumberClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSqrRoot);
            this.panel1.Controls.Add(this.buttonDegRad);
            this.panel1.Controls.Add(this.buttonExp);
            this.panel1.Controls.Add(this.buttonSin);
            this.panel1.Controls.Add(this.buttonCos);
            this.panel1.Controls.Add(this.buttonUndo);
            this.panel1.Controls.Add(this.buttonLogOf10);
            this.panel1.Controls.Add(this.buttonPi);
            this.panel1.Controls.Add(this.buttonLog);
            this.panel1.Controls.Add(this.buttonAbsolute);
            this.panel1.Controls.Add(this.buttonTan);
            this.panel1.Controls.Add(this.buttonXOver_n);
            this.panel1.Controls.Add(this.button1OverX);
            this.panel1.Controls.Add(this.buttonSqr);
            this.panel1.Controls.Add(this.buttonExpOf_n);
            this.panel1.Location = new System.Drawing.Point(5, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 244);
            this.panel1.TabIndex = 0;
            // 
            // buttonSqrRoot
            // 
            this.buttonSqrRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonSqrRoot.BackgroundImage = global::Calculator.Properties.Resources.button_22;
            this.buttonSqrRoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSqrRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSqrRoot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSqrRoot.FlatAppearance.BorderSize = 0;
            this.buttonSqrRoot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonSqrRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSqrRoot.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSqrRoot.Location = new System.Drawing.Point(224, 6);
            this.buttonSqrRoot.Name = "buttonSqrRoot";
            this.buttonSqrRoot.Size = new System.Drawing.Size(84, 35);
            this.buttonSqrRoot.TabIndex = 31;
            this.buttonSqrRoot.Tag = "sqrt(";
            this.buttonSqrRoot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSqrRoot.UseVisualStyleBackColor = false;
            this.buttonSqrRoot.Click += new System.EventHandler(this.FunctionButton);
            // 
            // buttonDegRad
            // 
            this.buttonDegRad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonDegRad.BackgroundImage = global::Calculator.Properties.Resources.button_21;
            this.buttonDegRad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDegRad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDegRad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDegRad.FlatAppearance.BorderSize = 0;
            this.buttonDegRad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonDegRad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDegRad.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDegRad.Location = new System.Drawing.Point(117, 6);
            this.buttonDegRad.Name = "buttonDegRad";
            this.buttonDegRad.Size = new System.Drawing.Size(84, 35);
            this.buttonDegRad.TabIndex = 30;
            this.buttonDegRad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDegRad.UseVisualStyleBackColor = false;
            this.buttonDegRad.Click += new System.EventHandler(this.buttonDegRad_Click);
            // 
            // buttonExp
            // 
            this.buttonExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonExp.BackgroundImage = global::Calculator.Properties.Resources.button_34;
            this.buttonExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExp.FlatAppearance.BorderSize = 0;
            this.buttonExp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExp.ForeColor = System.Drawing.Color.Transparent;
            this.buttonExp.Location = new System.Drawing.Point(225, 190);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(84, 35);
            this.buttonExp.TabIndex = 43;
            this.buttonExp.Tag = "e";
            this.buttonExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonExp.UseVisualStyleBackColor = false;
            this.buttonExp.Click += new System.EventHandler(this.ConstanetsButton);
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonSin.BackgroundImage = global::Calculator.Properties.Resources.button_23;
            this.buttonSin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSin.FlatAppearance.BorderSize = 0;
            this.buttonSin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSin.Location = new System.Drawing.Point(5, 51);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(84, 35);
            this.buttonSin.TabIndex = 35;
            this.buttonSin.Tag = "sin(";
            this.buttonSin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSin.UseVisualStyleBackColor = false;
            this.buttonSin.Click += new System.EventHandler(this.FunctionButton);
            // 
            // buttonCos
            // 
            this.buttonCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonCos.BackgroundImage = global::Calculator.Properties.Resources.button_24;
            this.buttonCos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCos.FlatAppearance.BorderSize = 0;
            this.buttonCos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCos.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCos.Location = new System.Drawing.Point(117, 51);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(84, 35);
            this.buttonCos.TabIndex = 36;
            this.buttonCos.Tag = "cos(";
            this.buttonCos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCos.UseVisualStyleBackColor = false;
            this.buttonCos.Click += new System.EventHandler(this.FunctionButton);
            // 
            // buttonUndo
            // 
            this.buttonUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonUndo.BackgroundImage = global::Calculator.Properties.Resources.button_20;
            this.buttonUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUndo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonUndo.FlatAppearance.BorderSize = 0;
            this.buttonUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUndo.ForeColor = System.Drawing.Color.Transparent;
            this.buttonUndo.Image = global::Calculator.Properties.Resources._switch;
            this.buttonUndo.Location = new System.Drawing.Point(5, 6);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(84, 35);
            this.buttonUndo.TabIndex = 29;
            this.buttonUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUndo.UseVisualStyleBackColor = false;
            // 
            // buttonLogOf10
            // 
            this.buttonLogOf10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonLogOf10.BackgroundImage = global::Calculator.Properties.Resources.button_26;
            this.buttonLogOf10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogOf10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogOf10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLogOf10.FlatAppearance.BorderSize = 0;
            this.buttonLogOf10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonLogOf10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOf10.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogOf10.Location = new System.Drawing.Point(5, 96);
            this.buttonLogOf10.Name = "buttonLogOf10";
            this.buttonLogOf10.Size = new System.Drawing.Size(84, 35);
            this.buttonLogOf10.TabIndex = 32;
            this.buttonLogOf10.Tag = "log10(";
            this.buttonLogOf10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLogOf10.UseVisualStyleBackColor = false;
            this.buttonLogOf10.Click += new System.EventHandler(this.FunctionButton);
            // 
            // buttonPi
            // 
            this.buttonPi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonPi.BackgroundImage = global::Calculator.Properties.Resources.button_33;
            this.buttonPi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPi.FlatAppearance.BorderSize = 0;
            this.buttonPi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPi.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPi.Location = new System.Drawing.Point(118, 190);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(84, 35);
            this.buttonPi.TabIndex = 42;
            this.buttonPi.Tag = "pi";
            this.buttonPi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPi.UseVisualStyleBackColor = false;
            this.buttonPi.Click += new System.EventHandler(this.ConstanetsButton);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonLog.BackgroundImage = global::Calculator.Properties.Resources.button_27;
            this.buttonLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLog.FlatAppearance.BorderSize = 0;
            this.buttonLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLog.Location = new System.Drawing.Point(117, 96);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(84, 35);
            this.buttonLog.TabIndex = 33;
            this.buttonLog.Tag = "log(";
            this.buttonLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.FunctionButton);
            // 
            // buttonAbsolute
            // 
            this.buttonAbsolute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonAbsolute.BackgroundImage = global::Calculator.Properties.Resources.button_32;
            this.buttonAbsolute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAbsolute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbsolute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAbsolute.FlatAppearance.BorderSize = 0;
            this.buttonAbsolute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonAbsolute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbsolute.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAbsolute.Location = new System.Drawing.Point(6, 190);
            this.buttonAbsolute.Name = "buttonAbsolute";
            this.buttonAbsolute.Size = new System.Drawing.Size(84, 35);
            this.buttonAbsolute.TabIndex = 41;
            this.buttonAbsolute.Tag = "abs(";
            this.buttonAbsolute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAbsolute.UseVisualStyleBackColor = false;
            this.buttonAbsolute.Click += new System.EventHandler(this.FunctionButton);
            // 
            // buttonTan
            // 
            this.buttonTan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonTan.BackgroundImage = global::Calculator.Properties.Resources.button_25;
            this.buttonTan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonTan.FlatAppearance.BorderSize = 0;
            this.buttonTan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonTan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTan.ForeColor = System.Drawing.Color.Transparent;
            this.buttonTan.Location = new System.Drawing.Point(224, 51);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(84, 35);
            this.buttonTan.TabIndex = 37;
            this.buttonTan.Tag = "tan(";
            this.buttonTan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonTan.UseVisualStyleBackColor = false;
            this.buttonTan.Click += new System.EventHandler(this.FunctionButton);
            // 
            // buttonXOver_n
            // 
            this.buttonXOver_n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonXOver_n.BackgroundImage = global::Calculator.Properties.Resources.button_31;
            this.buttonXOver_n.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonXOver_n.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonXOver_n.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonXOver_n.FlatAppearance.BorderSize = 0;
            this.buttonXOver_n.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonXOver_n.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXOver_n.ForeColor = System.Drawing.Color.Transparent;
            this.buttonXOver_n.Location = new System.Drawing.Point(225, 143);
            this.buttonXOver_n.Name = "buttonXOver_n";
            this.buttonXOver_n.Size = new System.Drawing.Size(84, 35);
            this.buttonXOver_n.TabIndex = 40;
            this.buttonXOver_n.Tag = "^";
            this.buttonXOver_n.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonXOver_n.UseVisualStyleBackColor = false;
            this.buttonXOver_n.Click += new System.EventHandler(this.FunctionButton);
            // 
            // button1OverX
            // 
            this.button1OverX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.button1OverX.BackgroundImage = global::Calculator.Properties.Resources.button_28;
            this.button1OverX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1OverX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1OverX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1OverX.FlatAppearance.BorderSize = 0;
            this.button1OverX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1OverX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1OverX.ForeColor = System.Drawing.Color.Transparent;
            this.button1OverX.Location = new System.Drawing.Point(224, 96);
            this.button1OverX.Name = "button1OverX";
            this.button1OverX.Size = new System.Drawing.Size(84, 35);
            this.button1OverX.TabIndex = 34;
            this.button1OverX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1OverX.UseVisualStyleBackColor = false;
            this.button1OverX.Click += new System.EventHandler(this.button1OverX_Click);
            // 
            // buttonSqr
            // 
            this.buttonSqr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonSqr.BackgroundImage = global::Calculator.Properties.Resources.button_30;
            this.buttonSqr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSqr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSqr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSqr.FlatAppearance.BorderSize = 0;
            this.buttonSqr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonSqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSqr.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSqr.Location = new System.Drawing.Point(118, 143);
            this.buttonSqr.Name = "buttonSqr";
            this.buttonSqr.Size = new System.Drawing.Size(84, 35);
            this.buttonSqr.TabIndex = 39;
            this.buttonSqr.Tag = "^2";
            this.buttonSqr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSqr.UseVisualStyleBackColor = false;
            this.buttonSqr.Click += new System.EventHandler(this.FunctionButton);
            // 
            // buttonExpOf_n
            // 
            this.buttonExpOf_n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.buttonExpOf_n.BackgroundImage = global::Calculator.Properties.Resources.button_29;
            this.buttonExpOf_n.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExpOf_n.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExpOf_n.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExpOf_n.FlatAppearance.BorderSize = 0;
            this.buttonExpOf_n.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonExpOf_n.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpOf_n.ForeColor = System.Drawing.Color.Transparent;
            this.buttonExpOf_n.Location = new System.Drawing.Point(6, 143);
            this.buttonExpOf_n.Name = "buttonExpOf_n";
            this.buttonExpOf_n.Size = new System.Drawing.Size(84, 35);
            this.buttonExpOf_n.TabIndex = 38;
            this.buttonExpOf_n.Tag = "exp(";
            this.buttonExpOf_n.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonExpOf_n.UseVisualStyleBackColor = false;
            this.buttonExpOf_n.Click += new System.EventHandler(this.FunctionButton);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.BackColor = System.Drawing.Color.Transparent;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.LblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.LblResult.Location = new System.Drawing.Point(13, 43);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(58, 67);
            this.LblResult.TabIndex = 2;
            this.LblResult.Text = "0";
            // 
            // LabelInput
            // 
            this.LabelInput.AutoSize = true;
            this.LabelInput.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(138)))), ((int)(((byte)(147)))));
            this.LabelInput.Location = new System.Drawing.Point(30, 9);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(0, 29);
            this.LabelInput.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculator.Properties.Resources.Rectangle_2;
            this.pictureBox1.Location = new System.Drawing.Point(1, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 10);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(752, 399);
            this.Controls.Add(this.LabelInput);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(774, 455);
            this.MinimumSize = new System.Drawing.Size(774, 455);
            this.Name = "Calculator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Calculator";
            this.buttonsPanel.ResumeLayout(false);
            this.buttonsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonBraces;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button buttonMines;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button buttonPlusOrMines;
        private System.Windows.Forms.Button buttonSqrRoot;
        private System.Windows.Forms.Button buttonDegRad;
        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonLogOf10;
        private System.Windows.Forms.Button buttonPi;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonAbsolute;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Button buttonXOver_n;
        private System.Windows.Forms.Button button1OverX;
        private System.Windows.Forms.Button buttonSqr;
        private System.Windows.Forms.Button buttonExpOf_n;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.Label LabelDeg_Rad;
    }
}

