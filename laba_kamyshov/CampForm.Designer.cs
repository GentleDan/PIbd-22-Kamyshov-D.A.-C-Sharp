﻿namespace laba_kamyshov
{
    partial class CampForm
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
            this.pictureCampBox = new System.Windows.Forms.PictureBox();
            this.placeGroupBox = new System.Windows.Forms.GroupBox();
            this.takeExcavator = new System.Windows.Forms.Button();
            this.MaskedBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.place = new System.Windows.Forms.Label();
            this.listBoxCamp = new System.Windows.Forms.ListBox();
            this.textBoxNewCamp = new System.Windows.Forms.TextBox();
            this.labelCamps = new System.Windows.Forms.Label();
            this.Button_Add_Camp = new System.Windows.Forms.Button();
            this.Button_Del_Camp = new System.Windows.Forms.Button();
            this.buttonCreateTransport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCampBox)).BeginInit();
            this.placeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureCampBox
            // 
            this.pictureCampBox.BackColor = System.Drawing.Color.White;
            this.pictureCampBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureCampBox.Location = new System.Drawing.Point(0, 0);
            this.pictureCampBox.Name = "pictureCampBox";
            this.pictureCampBox.Size = new System.Drawing.Size(890, 525);
            this.pictureCampBox.TabIndex = 0;
            this.pictureCampBox.TabStop = false;
            // 
            // placeGroupBox
            // 
            this.placeGroupBox.Controls.Add(this.takeExcavator);
            this.placeGroupBox.Controls.Add(this.MaskedBoxPlace);
            this.placeGroupBox.Controls.Add(this.place);
            this.placeGroupBox.Location = new System.Drawing.Point(896, 381);
            this.placeGroupBox.Name = "placeGroupBox";
            this.placeGroupBox.Size = new System.Drawing.Size(135, 100);
            this.placeGroupBox.TabIndex = 3;
            this.placeGroupBox.TabStop = false;
            this.placeGroupBox.Text = "Забрать транспорт";
            // 
            // takeExcavator
            // 
            this.takeExcavator.Location = new System.Drawing.Point(25, 71);
            this.takeExcavator.Name = "takeExcavator";
            this.takeExcavator.Size = new System.Drawing.Size(75, 23);
            this.takeExcavator.TabIndex = 2;
            this.takeExcavator.Text = "Забрать";
            this.takeExcavator.UseVisualStyleBackColor = true;
            this.takeExcavator.Click += new System.EventHandler(this.TakeExcavator_Click);
            // 
            // MaskedBoxPlace
            // 
            this.MaskedBoxPlace.Location = new System.Drawing.Point(75, 39);
            this.MaskedBoxPlace.Mask = "00";
            this.MaskedBoxPlace.Name = "MaskedBoxPlace";
            this.MaskedBoxPlace.Size = new System.Drawing.Size(25, 20);
            this.MaskedBoxPlace.TabIndex = 1;
            this.MaskedBoxPlace.ValidatingType = typeof(int);
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Location = new System.Drawing.Point(27, 42);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(42, 13);
            this.place.TabIndex = 0;
            this.place.Text = "Место:";
            // 
            // listBoxCamp
            // 
            this.listBoxCamp.FormattingEnabled = true;
            this.listBoxCamp.Location = new System.Drawing.Point(896, 91);
            this.listBoxCamp.Name = "listBoxCamp";
            this.listBoxCamp.Size = new System.Drawing.Size(132, 95);
            this.listBoxCamp.TabIndex = 4;
            this.listBoxCamp.SelectedIndexChanged += new System.EventHandler(this.ListBoxCamp_SelectedIndexChanged);
            // 
            // textBoxNewCamp
            // 
            this.textBoxNewCamp.Location = new System.Drawing.Point(896, 36);
            this.textBoxNewCamp.Name = "textBoxNewCamp";
            this.textBoxNewCamp.Size = new System.Drawing.Size(132, 20);
            this.textBoxNewCamp.TabIndex = 5;
            // 
            // labelCamps
            // 
            this.labelCamps.AutoSize = true;
            this.labelCamps.Location = new System.Drawing.Point(938, 9);
            this.labelCamps.Name = "labelCamps";
            this.labelCamps.Size = new System.Drawing.Size(49, 13);
            this.labelCamps.TabIndex = 6;
            this.labelCamps.Text = "Стоянки";
            // 
            // Button_Add_Camp
            // 
            this.Button_Add_Camp.Location = new System.Drawing.Point(896, 62);
            this.Button_Add_Camp.Name = "Button_Add_Camp";
            this.Button_Add_Camp.Size = new System.Drawing.Size(132, 23);
            this.Button_Add_Camp.TabIndex = 7;
            this.Button_Add_Camp.Text = "Добавить стоянку";
            this.Button_Add_Camp.UseVisualStyleBackColor = true;
            this.Button_Add_Camp.Click += new System.EventHandler(this.Button_Add_Camp_Click);
            // 
            // Button_Del_Camp
            // 
            this.Button_Del_Camp.Location = new System.Drawing.Point(896, 192);
            this.Button_Del_Camp.Name = "Button_Del_Camp";
            this.Button_Del_Camp.Size = new System.Drawing.Size(135, 23);
            this.Button_Del_Camp.TabIndex = 8;
            this.Button_Del_Camp.Text = "Удалить стоянку";
            this.Button_Del_Camp.UseVisualStyleBackColor = true;
            this.Button_Del_Camp.Click += new System.EventHandler(this.Button_Del_Camp_Click);
            // 
            // buttonCreateTransport
            // 
            this.buttonCreateTransport.Location = new System.Drawing.Point(896, 243);
            this.buttonCreateTransport.Name = "buttonCreateTransport";
            this.buttonCreateTransport.Size = new System.Drawing.Size(132, 101);
            this.buttonCreateTransport.TabIndex = 9;
            this.buttonCreateTransport.Text = "Добавить транспорт";
            this.buttonCreateTransport.UseVisualStyleBackColor = true;
            this.buttonCreateTransport.Click += new System.EventHandler(this.buttonCreateTransport_Click);
            // 
            // CampForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 525);
            this.Controls.Add(this.buttonCreateTransport);
            this.Controls.Add(this.Button_Del_Camp);
            this.Controls.Add(this.Button_Add_Camp);
            this.Controls.Add(this.labelCamps);
            this.Controls.Add(this.textBoxNewCamp);
            this.Controls.Add(this.listBoxCamp);
            this.Controls.Add(this.placeGroupBox);
            this.Controls.Add(this.pictureCampBox);
            this.Name = "CampForm";
            this.Text = "Стоянка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCampBox)).EndInit();
            this.placeGroupBox.ResumeLayout(false);
            this.placeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCampBox;
        private System.Windows.Forms.GroupBox placeGroupBox;
        private System.Windows.Forms.Button takeExcavator;
        private System.Windows.Forms.MaskedTextBox MaskedBoxPlace;
        private System.Windows.Forms.Label place;
        private System.Windows.Forms.ListBox listBoxCamp;
        private System.Windows.Forms.TextBox textBoxNewCamp;
        private System.Windows.Forms.Label labelCamps;
        private System.Windows.Forms.Button Button_Add_Camp;
        private System.Windows.Forms.Button Button_Del_Camp;
        private System.Windows.Forms.Button buttonCreateTransport;
    }
}