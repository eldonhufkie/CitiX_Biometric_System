namespace CitiX_Biometric_System
{
    partial class frmMainMenu
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
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picFingerPrev = new System.Windows.Forms.PictureBox();
            this.gbKeypad = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btn_ClearEverything = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerPrev)).BeginInit();
            this.gbKeypad.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Location = new System.Drawing.Point(12, 144);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.Size = new System.Drawing.Size(409, 249);
            this.dgvEmployeeList.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(409, 125);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // picFingerPrev
            // 
            this.picFingerPrev.Location = new System.Drawing.Point(570, 12);
            this.picFingerPrev.Name = "picFingerPrev";
            this.picFingerPrev.Size = new System.Drawing.Size(104, 125);
            this.picFingerPrev.TabIndex = 2;
            this.picFingerPrev.TabStop = false;
            // 
            // gbKeypad
            // 
            this.gbKeypad.Controls.Add(this.btnEnter);
            this.gbKeypad.Controls.Add(this.btnNine);
            this.gbKeypad.Controls.Add(this.btnEight);
            this.gbKeypad.Controls.Add(this.btnSeven);
            this.gbKeypad.Controls.Add(this.btnSix);
            this.gbKeypad.Controls.Add(this.btnFive);
            this.gbKeypad.Controls.Add(this.btnFour);
            this.gbKeypad.Controls.Add(this.btnThree);
            this.gbKeypad.Controls.Add(this.btnTwo);
            this.gbKeypad.Controls.Add(this.btnOne);
            this.gbKeypad.Controls.Add(this.btnBackspace);
            this.gbKeypad.Controls.Add(this.btnZero);
            this.gbKeypad.Controls.Add(this.btn_ClearEverything);
            this.gbKeypad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKeypad.Location = new System.Drawing.Point(436, 183);
            this.gbKeypad.Name = "gbKeypad";
            this.gbKeypad.Size = new System.Drawing.Size(238, 210);
            this.gbKeypad.TabIndex = 3;
            this.gbKeypad.TabStop = false;
            this.gbKeypad.Text = "Keypad";
            // 
            // btnEnter
            // 
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEnter.Location = new System.Drawing.Point(177, 112);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(55, 92);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnNine
            // 
            this.btnNine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNine.Location = new System.Drawing.Point(127, 19);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(44, 43);
            this.btnNine.TabIndex = 11;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEight.Location = new System.Drawing.Point(76, 19);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(44, 43);
            this.btnEight.TabIndex = 10;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSeven.Location = new System.Drawing.Point(25, 19);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(44, 43);
            this.btnSeven.TabIndex = 9;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnSix
            // 
            this.btnSix.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSix.Location = new System.Drawing.Point(127, 63);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(44, 43);
            this.btnSix.TabIndex = 8;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFive.Location = new System.Drawing.Point(76, 63);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(44, 43);
            this.btnFive.TabIndex = 7;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFour.Location = new System.Drawing.Point(25, 63);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(44, 43);
            this.btnFour.TabIndex = 6;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnThree
            // 
            this.btnThree.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThree.Location = new System.Drawing.Point(127, 112);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(44, 43);
            this.btnThree.TabIndex = 5;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTwo.Location = new System.Drawing.Point(76, 112);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(44, 43);
            this.btnTwo.TabIndex = 4;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOne.Location = new System.Drawing.Point(25, 112);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(44, 43);
            this.btnOne.TabIndex = 3;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackspace.FlatAppearance.BorderSize = 0;
            this.btnBackspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBackspace.Location = new System.Drawing.Point(127, 161);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(44, 43);
            this.btnBackspace.TabIndex = 2;
            this.btnBackspace.Text = "<=";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnZero
            // 
            this.btnZero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnZero.Location = new System.Drawing.Point(76, 161);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(44, 43);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btn_ClearEverything
            // 
            this.btn_ClearEverything.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ClearEverything.FlatAppearance.BorderSize = 0;
            this.btn_ClearEverything.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_ClearEverything.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ClearEverything.Location = new System.Drawing.Point(25, 161);
            this.btn_ClearEverything.Name = "btn_ClearEverything";
            this.btn_ClearEverything.Size = new System.Drawing.Size(44, 43);
            this.btn_ClearEverything.TabIndex = 0;
            this.btn_ClearEverything.Text = "CE";
            this.btn_ClearEverything.UseVisualStyleBackColor = true;
            this.btn_ClearEverything.Click += new System.EventHandler(this.btn_ClearEverything_Click);
            // 
            // txtPin
            // 
            this.txtPin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(461, 144);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(146, 33);
            this.txtPin.TabIndex = 4;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 405);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.gbKeypad);
            this.Controls.Add(this.picFingerPrev);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.dgvEmployeeList);
            this.Name = "frmMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerPrev)).EndInit();
            this.gbKeypad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picFingerPrev;
        private System.Windows.Forms.GroupBox gbKeypad;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btn_ClearEverything;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtPin;
    }
}

