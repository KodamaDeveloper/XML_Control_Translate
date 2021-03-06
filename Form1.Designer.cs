﻿namespace Kodama_Xml_Control
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_name_file = new System.Windows.Forms.Label();
            this.textBox_drag = new System.Windows.Forms.TextBox();
            this.button_translate = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_next = new System.Windows.Forms.TextBox();
            this.button_save_file = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_tag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ignore_txt = new System.Windows.Forms.TextBox();
            this.textBox_language_ori = new System.Windows.Forms.TextBox();
            this.textBox_language_des = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_count_error = new System.Windows.Forms.Label();
            this.label_count_translated = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_count_not_tag = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_count_totalline = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name_file
            // 
            this.lbl_name_file.AutoSize = true;
            this.lbl_name_file.Location = new System.Drawing.Point(11, 9);
            this.lbl_name_file.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name_file.Name = "lbl_name_file";
            this.lbl_name_file.Size = new System.Drawing.Size(77, 13);
            this.lbl_name_file.TabIndex = 0;
            this.lbl_name_file.Text = "Drag file in box";
            // 
            // textBox_drag
            // 
            this.textBox_drag.AllowDrop = true;
            this.textBox_drag.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_drag.Location = new System.Drawing.Point(12, 35);
            this.textBox_drag.Multiline = true;
            this.textBox_drag.Name = "textBox_drag";
            this.textBox_drag.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_drag.Size = new System.Drawing.Size(428, 255);
            this.textBox_drag.TabIndex = 1;
            this.textBox_drag.TabStop = false;
            this.textBox_drag.Text = "DragDrop File Here";
            this.textBox_drag.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_drag__DragDrop);
            this.textBox_drag.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_drag_DragEnter);
            // 
            // button_translate
            // 
            this.button_translate.Location = new System.Drawing.Point(797, 294);
            this.button_translate.Name = "button_translate";
            this.button_translate.Size = new System.Drawing.Size(75, 23);
            this.button_translate.TabIndex = 2;
            this.button_translate.Text = "Translate";
            this.button_translate.UseVisualStyleBackColor = true;
            this.button_translate.Click += new System.EventHandler(this.button_translate_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_next
            // 
            this.textBox_next.Location = new System.Drawing.Point(446, 35);
            this.textBox_next.Multiline = true;
            this.textBox_next.Name = "textBox_next";
            this.textBox_next.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_next.Size = new System.Drawing.Size(428, 255);
            this.textBox_next.TabIndex = 4;
            // 
            // button_save_file
            // 
            this.button_save_file.Location = new System.Drawing.Point(797, 322);
            this.button_save_file.Name = "button_save_file";
            this.button_save_file.Size = new System.Drawing.Size(75, 23);
            this.button_save_file.TabIndex = 5;
            this.button_save_file.Text = "Save File";
            this.button_save_file.UseVisualStyleBackColor = true;
            this.button_save_file.Click += new System.EventHandler(this.button_save_file_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name Tag to Translate:";
            // 
            // textBox_tag
            // 
            this.textBox_tag.Location = new System.Drawing.Point(138, 296);
            this.textBox_tag.Name = "textBox_tag";
            this.textBox_tag.Size = new System.Drawing.Size(170, 20);
            this.textBox_tag.TabIndex = 7;
            this.textBox_tag.Text = "<value>";
            this.textBox_tag.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Code to ignore:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_ignore_txt
            // 
            this.textBox_ignore_txt.Location = new System.Drawing.Point(138, 325);
            this.textBox_ignore_txt.Name = "textBox_ignore_txt";
            this.textBox_ignore_txt.Size = new System.Drawing.Size(41, 20);
            this.textBox_ignore_txt.TabIndex = 10;
            this.textBox_ignore_txt.Text = "&jks;";
            // 
            // textBox_language_ori
            // 
            this.textBox_language_ori.Location = new System.Drawing.Point(708, 295);
            this.textBox_language_ori.Name = "textBox_language_ori";
            this.textBox_language_ori.Size = new System.Drawing.Size(50, 20);
            this.textBox_language_ori.TabIndex = 11;
            this.textBox_language_ori.Text = "en";
            // 
            // textBox_language_des
            // 
            this.textBox_language_des.Location = new System.Drawing.Point(708, 321);
            this.textBox_language_des.Name = "textBox_language_des";
            this.textBox_language_des.Size = new System.Drawing.Size(50, 20);
            this.textBox_language_des.TabIndex = 12;
            this.textBox_language_des.Text = "es";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Language Origin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Language Destination:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Error:";
            // 
            // label_count_error
            // 
            this.label_count_error.AutoSize = true;
            this.label_count_error.Location = new System.Drawing.Point(388, 304);
            this.label_count_error.Name = "label_count_error";
            this.label_count_error.Size = new System.Drawing.Size(13, 13);
            this.label_count_error.TabIndex = 16;
            this.label_count_error.Text = "0";
            // 
            // label_count_translated
            // 
            this.label_count_translated.AutoSize = true;
            this.label_count_translated.Location = new System.Drawing.Point(388, 325);
            this.label_count_translated.Name = "label_count_translated";
            this.label_count_translated.Size = new System.Drawing.Size(13, 13);
            this.label_count_translated.TabIndex = 18;
            this.label_count_translated.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Translated:";
            // 
            // label_count_not_tag
            // 
            this.label_count_not_tag.AutoSize = true;
            this.label_count_not_tag.Location = new System.Drawing.Point(518, 304);
            this.label_count_not_tag.Name = "label_count_not_tag";
            this.label_count_not_tag.Size = new System.Drawing.Size(13, 13);
            this.label_count_not_tag.TabIndex = 20;
            this.label_count_not_tag.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Not Tag:";
            // 
            // label_count_totalline
            // 
            this.label_count_totalline.AutoSize = true;
            this.label_count_totalline.Location = new System.Drawing.Point(518, 324);
            this.label_count_totalline.Name = "label_count_totalline";
            this.label_count_totalline.Size = new System.Drawing.Size(13, 13);
            this.label_count_totalline.TabIndex = 22;
            this.label_count_totalline.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total Line:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(852, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_count_totalline);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_count_not_tag);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_count_translated);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_count_error);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_language_des);
            this.Controls.Add(this.textBox_language_ori);
            this.Controls.Add(this.textBox_ignore_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_tag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save_file);
            this.Controls.Add(this.textBox_next);
            this.Controls.Add(this.button_translate);
            this.Controls.Add(this.textBox_drag);
            this.Controls.Add(this.lbl_name_file);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "XML_Control_Translate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name_file;
        private System.Windows.Forms.TextBox textBox_drag;
        private System.Windows.Forms.Button button_translate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_next;
        private System.Windows.Forms.Button button_save_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_tag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ignore_txt;
        private System.Windows.Forms.TextBox textBox_language_ori;
        private System.Windows.Forms.TextBox textBox_language_des;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_count_error;
        private System.Windows.Forms.Label label_count_translated;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_count_not_tag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_count_totalline;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

