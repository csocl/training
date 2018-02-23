namespace Lesson_001___Hello_World
{
    partial class HelloWorld
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
            this.Hello_World_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hello_World_Button
            // 
            this.Hello_World_Button.Location = new System.Drawing.Point(39, 35);
            this.Hello_World_Button.Name = "Hello_World_Button";
            this.Hello_World_Button.Size = new System.Drawing.Size(138, 23);
            this.Hello_World_Button.TabIndex = 0;
            this.Hello_World_Button.Text = "Show Hello World";
            this.Hello_World_Button.UseVisualStyleBackColor = true;
            this.Hello_World_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(39, 113);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(75, 23);
            this.Close_Button.TabIndex = 1;
            this.Close_Button.Text = "Close";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 191);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.Hello_World_Button);
            this.Name = "Form1";
            this.Text = "Lesson 001 - Hello World";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Hello_World_Button;
        private System.Windows.Forms.Button Close_Button;
    }
}

