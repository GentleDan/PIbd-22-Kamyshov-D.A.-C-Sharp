﻿namespace laba_kamyshov
{
    partial class ExcavatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcavatorForm));
            this.pictureBoxEx = new System.Windows.Forms.PictureBox();
            this.button_Up = new System.Windows.Forms.Button();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Down = new System.Windows.Forms.Button();
            this.button_Right = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEx)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEx
            // 
            this.pictureBoxEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxEx.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEx.Name = "pictureBoxEx";
            this.pictureBoxEx.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxEx.TabIndex = 0;
            this.pictureBoxEx.TabStop = false;
            // 
            // button_Up
            // 
            this.button_Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Up.BackgroundImage")));
            this.button_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Up.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_Up.Location = new System.Drawing.Point(711, 310);
            this.button_Up.Name = "button_Up";
            this.button_Up.Size = new System.Drawing.Size(30, 30);
            this.button_Up.TabIndex = 1;
            this.button_Up.UseVisualStyleBackColor = true;
            this.button_Up.Click += new System.EventHandler(this.button_Move_Click);
            // 
            // button_Left
            // 
            this.button_Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Left.BackgroundImage")));
            this.button_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Left.Location = new System.Drawing.Point(673, 346);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(30, 30);
            this.button_Left.TabIndex = 2;
            this.button_Left.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_Left.UseVisualStyleBackColor = true;
            this.button_Left.Click += new System.EventHandler(this.button_Move_Click);
            // 
            // button_Down
            // 
            this.button_Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Down.BackgroundImage")));
            this.button_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Down.Location = new System.Drawing.Point(711, 382);
            this.button_Down.Name = "button_Down";
            this.button_Down.Size = new System.Drawing.Size(30, 30);
            this.button_Down.TabIndex = 3;
            this.button_Down.UseVisualStyleBackColor = true;
            this.button_Down.Click += new System.EventHandler(this.button_Move_Click);
            // 
            // button_Right
            // 
            this.button_Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Right.BackgroundImage")));
            this.button_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Right.Location = new System.Drawing.Point(749, 346);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(30, 30);
            this.button_Right.TabIndex = 4;
            this.button_Right.UseVisualStyleBackColor = true;
            this.button_Right.Click += new System.EventHandler(this.button_Move_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create Track";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateTrackedVehicle_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Create Excavator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CreateExcavator_button_Click);
            // 
            // ExcavatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Right);
            this.Controls.Add(this.button_Down);
            this.Controls.Add(this.button_Left);
            this.Controls.Add(this.button_Up);
            this.Controls.Add(this.pictureBoxEx);
            this.Name = "ExcavatorForm";
            this.Text = "Экскаватор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEx;
        private System.Windows.Forms.Button button_Up;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Button button_Down;
        private System.Windows.Forms.Button button_Right;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}