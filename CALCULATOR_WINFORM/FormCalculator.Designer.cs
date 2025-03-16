namespace Assignment4_1_2Calculator
{
    partial class FormCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btnAC = new Button();
            btnC = new Button();
            btnDiv = new Button();
            btnPosNeg = new Button();
            btnMul = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnSub = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnAdd = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnEqual = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnMod = new Button();
            txtHistory = new TextBox();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.InactiveCaptionText;
            txtDisplay.Font = new Font("Microsoft JhengHei", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = SystemColors.HighlightText;
            txtDisplay.Location = new Point(40, 104);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(455, 65);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnAC
            // 
            btnAC.BackColor = Color.Red;
            btnAC.Font = new Font("Microsoft Sans Serif", 18F);
            btnAC.ForeColor = Color.White;
            btnAC.Location = new Point(40, 202);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(95, 83);
            btnAC.TabIndex = 1;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = false;
            btnAC.Click += btnAC_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(255, 128, 0);
            btnC.Font = new Font("Microsoft Sans Serif", 18F);
            btnC.ForeColor = Color.White;
            btnC.Location = new Point(160, 202);
            btnC.Name = "btnC";
            btnC.Size = new Size(95, 83);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(255, 128, 0);
            btnDiv.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiv.ForeColor = SystemColors.ButtonHighlight;
            btnDiv.Location = new Point(400, 202);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(95, 83);
            btnDiv.TabIndex = 4;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnPosNeg
            // 
            btnPosNeg.BackColor = SystemColors.ActiveCaptionText;
            btnPosNeg.Font = new Font("Microsoft Sans Serif", 18F);
            btnPosNeg.ForeColor = SystemColors.ButtonHighlight;
            btnPosNeg.Location = new Point(40, 602);
            btnPosNeg.Name = "btnPosNeg";
            btnPosNeg.Size = new Size(95, 83);
            btnPosNeg.TabIndex = 3;
            btnPosNeg.Text = "+/−";
            btnPosNeg.UseVisualStyleBackColor = false;
            btnPosNeg.Click += btnPosNeg_Click;
            // 
            // btnMul
            // 
            btnMul.BackColor = Color.FromArgb(255, 128, 0);
            btnMul.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMul.ForeColor = SystemColors.ButtonHighlight;
            btnMul.Location = new Point(400, 302);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(95, 83);
            btnMul.TabIndex = 8;
            btnMul.Text = "×";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += btnMul_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Silver;
            btn9.Font = new Font("Microsoft Sans Serif", 18F);
            btn9.ForeColor = SystemColors.ActiveCaptionText;
            btn9.Location = new Point(280, 302);
            btn9.Name = "btn9";
            btn9.Size = new Size(95, 83);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Silver;
            btn8.Font = new Font("Microsoft Sans Serif", 18F);
            btn8.ForeColor = SystemColors.ActiveCaptionText;
            btn8.Location = new Point(160, 302);
            btn8.Name = "btn8";
            btn8.Size = new Size(95, 83);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Silver;
            btn7.Font = new Font("Microsoft Sans Serif", 18F);
            btn7.ForeColor = SystemColors.ActiveCaptionText;
            btn7.Location = new Point(40, 302);
            btn7.Name = "btn7";
            btn7.Size = new Size(95, 83);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.FromArgb(255, 128, 0);
            btnSub.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSub.ForeColor = SystemColors.ButtonHighlight;
            btnSub.Location = new Point(400, 402);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(95, 83);
            btnSub.TabIndex = 12;
            btnSub.Text = "−";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Silver;
            btn6.Font = new Font("Microsoft Sans Serif", 18F);
            btn6.ForeColor = SystemColors.ActiveCaptionText;
            btn6.Location = new Point(280, 402);
            btn6.Name = "btn6";
            btn6.Size = new Size(95, 83);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Silver;
            btn5.Font = new Font("Microsoft Sans Serif", 18F);
            btn5.ForeColor = SystemColors.ActiveCaptionText;
            btn5.Location = new Point(160, 402);
            btn5.Name = "btn5";
            btn5.Size = new Size(95, 83);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Silver;
            btn4.Font = new Font("Microsoft Sans Serif", 18F);
            btn4.ForeColor = SystemColors.ActiveCaptionText;
            btn4.Location = new Point(40, 402);
            btn4.Name = "btn4";
            btn4.Size = new Size(95, 83);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 128, 0);
            btnAdd.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(400, 502);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 83);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Silver;
            btn3.Font = new Font("Microsoft Sans Serif", 18F);
            btn3.ForeColor = SystemColors.ActiveCaptionText;
            btn3.Location = new Point(280, 502);
            btn3.Name = "btn3";
            btn3.Size = new Size(95, 83);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Silver;
            btn2.Font = new Font("Microsoft Sans Serif", 18F);
            btn2.ForeColor = SystemColors.ActiveCaptionText;
            btn2.Location = new Point(160, 502);
            btn2.Name = "btn2";
            btn2.Size = new Size(95, 83);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Silver;
            btn1.Font = new Font("Microsoft Sans Serif", 18F);
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(40, 502);
            btn1.Name = "btn1";
            btn1.Size = new Size(95, 83);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(255, 128, 0);
            btnEqual.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.ForeColor = SystemColors.ButtonHighlight;
            btnEqual.Location = new Point(400, 602);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(95, 83);
            btnEqual.TabIndex = 20;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.ActiveCaptionText;
            btnDot.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDot.ForeColor = SystemColors.ButtonHighlight;
            btnDot.Location = new Point(280, 602);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(95, 83);
            btnDot.TabIndex = 19;
            btnDot.Text = "·";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Silver;
            btn0.Font = new Font("Microsoft Sans Serif", 18F);
            btn0.ForeColor = SystemColors.ActiveCaptionText;
            btn0.Location = new Point(160, 602);
            btn0.Name = "btn0";
            btn0.Size = new Size(95, 83);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.FromArgb(255, 128, 0);
            btnMod.Font = new Font("Microsoft Sans Serif", 18F);
            btnMod.ForeColor = SystemColors.ButtonHighlight;
            btnMod.Location = new Point(280, 202);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(95, 83);
            btnMod.TabIndex = 17;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnMod_Click;
            // 
            // txtHistory
            // 
            txtHistory.BackColor = Color.Black;
            txtHistory.Font = new Font("Microsoft JhengHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHistory.ForeColor = Color.White;
            txtHistory.Location = new Point(40, 39);
            txtHistory.Name = "txtHistory";
            txtHistory.Size = new Size(455, 43);
            txtHistory.TabIndex = 21;
            txtHistory.TextAlign = HorizontalAlignment.Right;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(538, 719);
            Controls.Add(txtHistory);
            Controls.Add(btnEqual);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnMod);
            Controls.Add(btnAdd);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnSub);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMul);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDiv);
            Controls.Add(btnPosNeg);
            Controls.Add(btnC);
            Controls.Add(btnAC);
            Controls.Add(txtDisplay);
            Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormCalculator";
            Text = "Calculator";
            Load += FormCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private TextBox txtDisplay;
        private Button btnAC;
        private Button btnC;
        private Button btnDiv;
        private Button btnPosNeg;
        private Button btnMul;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnSub;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnAdd;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnEqual;
        private Button btnDot;
        private Button btn0;
        private Button btnMod;
        private TextBox txtHistory;

    }
}
