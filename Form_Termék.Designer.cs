namespace WindowsFormsAppLogin
{
    partial class Form_Termék
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_létrehozás = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_ujar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ujraktarKeszlet = new System.Windows.Forms.NumericUpDown();
            this.textBox_ujtermeknev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ujar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ujraktarKeszlet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék létrehozása";
            // 
            // button_létrehozás
            // 
            this.button_létrehozás.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_létrehozás.Location = new System.Drawing.Point(287, 400);
            this.button_létrehozás.Name = "button_létrehozás";
            this.button_létrehozás.Size = new System.Drawing.Size(197, 38);
            this.button_létrehozás.TabIndex = 1;
            this.button_létrehozás.Text = "Létrehozás";
            this.button_létrehozás.UseVisualStyleBackColor = true;
            this.button_létrehozás.Click += new System.EventHandler(this.button_létrehozás_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(254, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Raktár készlet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(254, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Egységár";
            // 
            // numericUpDown_ujar
            // 
            this.numericUpDown_ujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_ujar.Location = new System.Drawing.Point(390, 156);
            this.numericUpDown_ujar.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_ujar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ujar.Name = "numericUpDown_ujar";
            this.numericUpDown_ujar.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_ujar.TabIndex = 9;
            this.numericUpDown_ujar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_ujar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_ujraktarKeszlet
            // 
            this.numericUpDown_ujraktarKeszlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_ujraktarKeszlet.Location = new System.Drawing.Point(390, 196);
            this.numericUpDown_ujraktarKeszlet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_ujraktarKeszlet.Name = "numericUpDown_ujraktarKeszlet";
            this.numericUpDown_ujraktarKeszlet.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_ujraktarKeszlet.TabIndex = 10;
            this.numericUpDown_ujraktarKeszlet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_ujtermeknev
            // 
            this.textBox_ujtermeknev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_ujtermeknev.Location = new System.Drawing.Point(390, 116);
            this.textBox_ujtermeknev.Name = "textBox_ujtermeknev";
            this.textBox_ujtermeknev.Size = new System.Drawing.Size(152, 26);
            this.textBox_ujtermeknev.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(254, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Terméknév";
            // 
            // Form_Termék
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_ujar);
            this.Controls.Add(this.numericUpDown_ujraktarKeszlet);
            this.Controls.Add(this.textBox_ujtermeknev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_létrehozás);
            this.Controls.Add(this.label1);
            this.Name = "Form_Termék";
            this.Text = "Form_Termék";
            this.Load += new System.EventHandler(this.Form_Termék_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ujar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ujraktarKeszlet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_létrehozás;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_ujar;
        private System.Windows.Forms.NumericUpDown numericUpDown_ujraktarKeszlet;
        private System.Windows.Forms.TextBox textBox_ujtermeknev;
        private System.Windows.Forms.Label label2;
    }
}