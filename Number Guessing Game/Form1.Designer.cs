namespace Number_Guessing_Game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtEnterNumber = new System.Windows.Forms.TextBox();
            this.lbmQuetion = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(328, 283);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(160, 65);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Проверка";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.CheckNumber);
            // 
            // txtEnterNumber
            // 
            this.txtEnterNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnterNumber.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterNumber.Location = new System.Drawing.Point(210, 173);
            this.txtEnterNumber.Name = "txtEnterNumber";
            this.txtEnterNumber.Size = new System.Drawing.Size(377, 41);
            this.txtEnterNumber.TabIndex = 1;
            this.txtEnterNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbmQuetion
            // 
            this.lbmQuetion.AutoSize = true;
            this.lbmQuetion.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmQuetion.Location = new System.Drawing.Point(228, 132);
            this.lbmQuetion.Name = "lbmQuetion";
            this.lbmQuetion.Size = new System.Drawing.Size(350, 28);
            this.lbmQuetion.TabIndex = 2;
            this.lbmQuetion.Text = "Я загадал число от 0 до 100";
            this.lbmQuetion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(229, 231);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(219, 21);
            this.lblGuess.TabIndex = 3;
            this.lblGuess.Text = "Количество попыток: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.lbmQuetion);
            this.Controls.Add(this.txtEnterNumber);
            this.Controls.Add(this.btnCheck);
            this.Name = "Form1";
            this.Text = "Number Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtEnterNumber;
        private System.Windows.Forms.Label lbmQuetion;
        private System.Windows.Forms.Label lblGuess;
    }
}

