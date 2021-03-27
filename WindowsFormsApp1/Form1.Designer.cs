
namespace WindowsFormsApp1
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
            this.ImageView = new System.Windows.Forms.PictureBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.btn_mirror = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageView
            // 
            this.ImageView.Location = new System.Drawing.Point(12, 12);
            this.ImageView.Name = "ImageView";
            this.ImageView.Size = new System.Drawing.Size(769, 609);
            this.ImageView.TabIndex = 0;
            this.ImageView.TabStop = false;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(787, 34);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(91, 50);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // btn_mirror
            // 
            this.btn_mirror.Location = new System.Drawing.Point(787, 90);
            this.btn_mirror.Name = "btn_mirror";
            this.btn_mirror.Size = new System.Drawing.Size(91, 50);
            this.btn_mirror.TabIndex = 2;
            this.btn_mirror.Text = "MirrorView";
            this.btn_mirror.UseVisualStyleBackColor = true;
            this.btn_mirror.Click += new System.EventHandler(this.btn_mirror_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(787, 146);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 50);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 643);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_mirror);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.ImageView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageView;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button btn_mirror;
        private System.Windows.Forms.Button btn_save;
    }
}

