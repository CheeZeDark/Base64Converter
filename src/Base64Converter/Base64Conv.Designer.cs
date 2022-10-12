
namespace Base64Converter
{
    partial class Base64Conv
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.base64_textbox1 = new System.Windows.Forms.TextBox();
            this.base64_textbox2 = new System.Windows.Forms.TextBox();
            this.encodebase64 = new System.Windows.Forms.Button();
            this.decodebase64 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 170);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(194)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(233, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base64 Converter";
            // 
            // base64_textbox1
            // 
            this.base64_textbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.base64_textbox1.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.base64_textbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(180)))), ((int)(((byte)(66)))));
            this.base64_textbox1.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.base64_textbox1.Location = new System.Drawing.Point(12, 209);
            this.base64_textbox1.Multiline = true;
            this.base64_textbox1.Name = "base64_textbox1";
            this.base64_textbox1.Size = new System.Drawing.Size(228, 131);
            this.base64_textbox1.TabIndex = 1;
            // 
            // base64_textbox2
            // 
            this.base64_textbox2.BackColor = System.Drawing.Color.Black;
            this.base64_textbox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.base64_textbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(37)))));
            this.base64_textbox2.Location = new System.Drawing.Point(461, 209);
            this.base64_textbox2.MaxLength = 99999999;
            this.base64_textbox2.Multiline = true;
            this.base64_textbox2.Name = "base64_textbox2";
            this.base64_textbox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.base64_textbox2.Size = new System.Drawing.Size(207, 131);
            this.base64_textbox2.TabIndex = 2;
            // 
            // encodebase64
            // 
            this.encodebase64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.encodebase64.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodebase64.ForeColor = System.Drawing.Color.SteelBlue;
            this.encodebase64.Location = new System.Drawing.Point(281, 209);
            this.encodebase64.Name = "encodebase64";
            this.encodebase64.Size = new System.Drawing.Size(142, 40);
            this.encodebase64.TabIndex = 3;
            this.encodebase64.Text = "Encode";
            this.encodebase64.UseVisualStyleBackColor = false;
            this.encodebase64.Click += new System.EventHandler(this.encodebase64_Click);
            // 
            // decodebase64
            // 
            this.decodebase64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.decodebase64.Font = new System.Drawing.Font("DejaVu Sans Mono", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decodebase64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(194)))), ((int)(((byte)(89)))));
            this.decodebase64.Location = new System.Drawing.Point(281, 265);
            this.decodebase64.Name = "decodebase64";
            this.decodebase64.Size = new System.Drawing.Size(142, 41);
            this.decodebase64.TabIndex = 4;
            this.decodebase64.Text = "Decode";
            this.decodebase64.UseVisualStyleBackColor = false;
            this.decodebase64.Click += new System.EventHandler(this.decodebase64_Click);
            // 
            // Base64Conv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(680, 369);
            this.Controls.Add(this.decodebase64);
            this.Controls.Add(this.encodebase64);
            this.Controls.Add(this.base64_textbox2);
            this.Controls.Add(this.base64_textbox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Base64Conv";
            this.Text = "Base64 Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox base64_textbox1;
        private System.Windows.Forms.TextBox base64_textbox2;
        private System.Windows.Forms.Button encodebase64;
        private System.Windows.Forms.Button decodebase64;
    }
}

