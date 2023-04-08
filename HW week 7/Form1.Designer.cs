namespace HW_week_7
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
            this.label_WORDLE = new System.Windows.Forms.Label();
            this.label_setHowMuch = new System.Windows.Forms.Label();
            this.textBox_inputUser = new System.Windows.Forms.TextBox();
            this.button_Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_WORDLE
            // 
            this.label_WORDLE.AutoSize = true;
            this.label_WORDLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WORDLE.Location = new System.Drawing.Point(40, 48);
            this.label_WORDLE.Name = "label_WORDLE";
            this.label_WORDLE.Size = new System.Drawing.Size(299, 69);
            this.label_WORDLE.TabIndex = 0;
            this.label_WORDLE.Text = "WORDLE";
            // 
            // label_setHowMuch
            // 
            this.label_setHowMuch.AutoSize = true;
            this.label_setHowMuch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_setHowMuch.Location = new System.Drawing.Point(68, 134);
            this.label_setHowMuch.Name = "label_setHowMuch";
            this.label_setHowMuch.Size = new System.Drawing.Size(241, 20);
            this.label_setHowMuch.TabIndex = 1;
            this.label_setHowMuch.Text = "Set How Much You Can Guess";
            // 
            // textBox_inputUser
            // 
            this.textBox_inputUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputUser.Location = new System.Drawing.Point(134, 178);
            this.textBox_inputUser.Name = "textBox_inputUser";
            this.textBox_inputUser.Size = new System.Drawing.Size(115, 24);
            this.textBox_inputUser.TabIndex = 2;
            this.textBox_inputUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_inputUser_KeyPress);
            // 
            // button_Play
            // 
            this.button_Play.Location = new System.Drawing.Point(134, 228);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(115, 49);
            this.button_Play.TabIndex = 3;
            this.button_Play.Text = "PLAY";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 381);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.textBox_inputUser);
            this.Controls.Add(this.label_setHowMuch);
            this.Controls.Add(this.label_WORDLE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_WORDLE;
        private System.Windows.Forms.Label label_setHowMuch;
        private System.Windows.Forms.TextBox textBox_inputUser;
        private System.Windows.Forms.Button button_Play;
    }
}

