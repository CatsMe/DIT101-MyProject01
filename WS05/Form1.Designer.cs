namespace WS05
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GuessNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.txtInrerval = new System.Windows.Forms.TextBox();
            this.txtGuessNumber = new System.Windows.Forms.TextBox();
            this.btnCreateRnd = new System.Windows.Forms.Button();
            this.picDice = new System.Windows.Forms.PictureBox();
            this.tmrRoll = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).BeginInit();
            this.SuspendLayout();
            // 
            // GuessNumber
            // 
            this.GuessNumber.AutoSize = true;
            this.GuessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessNumber.Location = new System.Drawing.Point(98, 80);
            this.GuessNumber.Name = "GuessNumber";
            this.GuessNumber.Size = new System.Drawing.Size(183, 29);
            this.GuessNumber.TabIndex = 0;
            this.GuessNumber.Text = "Guess Number";
            this.GuessNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inrerval";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(409, 193);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(126, 45);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            this.btnRoll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRoll_MouseDown);
            this.btnRoll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRoll_MouseUp);
            // 
            // txtInrerval
            // 
            this.txtInrerval.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInrerval.Location = new System.Drawing.Point(299, 122);
            this.txtInrerval.Name = "txtInrerval";
            this.txtInrerval.Size = new System.Drawing.Size(236, 36);
            this.txtInrerval.TabIndex = 3;
            // 
            // txtGuessNumber
            // 
            this.txtGuessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuessNumber.Location = new System.Drawing.Point(299, 77);
            this.txtGuessNumber.Name = "txtGuessNumber";
            this.txtGuessNumber.Size = new System.Drawing.Size(236, 36);
            this.txtGuessNumber.TabIndex = 4;
            // 
            // btnCreateRnd
            // 
            this.btnCreateRnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRnd.Location = new System.Drawing.Point(156, 193);
            this.btnCreateRnd.Name = "btnCreateRnd";
            this.btnCreateRnd.Size = new System.Drawing.Size(214, 45);
            this.btnCreateRnd.TabIndex = 5;
            this.btnCreateRnd.Text = "Create Random";
            this.btnCreateRnd.UseVisualStyleBackColor = true;
            this.btnCreateRnd.Click += new System.EventHandler(this.btnCreateRnd_Click);
            // 
            // picDice
            // 
            this.picDice.Image = ((System.Drawing.Image)(resources.GetObject("picDice.Image")));
            this.picDice.Location = new System.Drawing.Point(601, 77);
            this.picDice.Name = "picDice";
            this.picDice.Size = new System.Drawing.Size(128, 128);
            this.picDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDice.TabIndex = 6;
            this.picDice.TabStop = false;
            this.picDice.Click += new System.EventHandler(this.picDice_Click);
            // 
            // tmrRoll
            // 
            this.tmrRoll.Tick += new System.EventHandler(this.tmrRoll_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 444);
            this.Controls.Add(this.picDice);
            this.Controls.Add(this.btnCreateRnd);
            this.Controls.Add(this.txtGuessNumber);
            this.Controls.Add(this.txtInrerval);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GuessNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GuessNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.TextBox txtInrerval;
        private System.Windows.Forms.TextBox txtGuessNumber;
        private System.Windows.Forms.Button btnCreateRnd;
        private System.Windows.Forms.PictureBox picDice;
        private System.Windows.Forms.Timer tmrRoll;
    }
}

