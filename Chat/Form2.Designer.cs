namespace Chat
{
    partial class Form_ChatBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChatBot));
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_In = new System.Windows.Forms.TextBox();
            this.textBox_out = new System.Windows.Forms.TextBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.button_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_send.Location = new System.Drawing.Point(385, 431);
            this.button_send.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(154, 80);
            this.button_send.TabIndex = 0;
            this.button_send.Text = "Отправить";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_In
            // 
            this.textBox_In.Location = new System.Drawing.Point(14, 432);
            this.textBox_In.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_In.Multiline = true;
            this.textBox_In.Name = "textBox_In";
            this.textBox_In.Size = new System.Drawing.Size(363, 115);
            this.textBox_In.TabIndex = 1;
            // 
            // textBox_out
            // 
            this.textBox_out.Location = new System.Drawing.Point(14, 52);
            this.textBox_out.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_out.Multiline = true;
            this.textBox_out.Name = "textBox_out";
            this.textBox_out.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_out.Size = new System.Drawing.Size(525, 372);
            this.textBox_out.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "menuStrip1";
            this.Menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(549, 24);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "menuStrip1";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(385, 517);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(154, 30);
            this.button_clear.TabIndex = 4;
            this.button_clear.Text = "Очистить поле ввода";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Form_ChatBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(549, 559);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_out);
            this.Controls.Add(this.textBox_In);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_ChatBot";
            this.Text = "ЧатБот";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_In;
        private System.Windows.Forms.TextBox textBox_out;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.Button button_clear;
    }
}