namespace WindowsFormsAppLogin
{
    partial class Form_Törles
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
            this.listBox_termektorles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_vasarlas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_ar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_raktarKeszlet = new System.Windows.Forms.NumericUpDown();
            this.textBox_torlestermeknev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_torlestermekid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_raktarKeszlet)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_termektorles
            // 
            this.listBox_termektorles.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_termektorles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_termektorles.FormattingEnabled = true;
            this.listBox_termektorles.ItemHeight = 29;
            this.listBox_termektorles.Location = new System.Drawing.Point(0, 0);
            this.listBox_termektorles.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_termektorles.Name = "listBox_termektorles";
            this.listBox_termektorles.Size = new System.Drawing.Size(200, 554);
            this.listBox_termektorles.TabIndex = 0;
            this.listBox_termektorles.SelectedIndexChanged += new System.EventHandler(this.listBox_termektorles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(443, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Termék törlése";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_vasarlas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_ar);
            this.groupBox1.Controls.Add(this.numericUpDown_raktarKeszlet);
            this.groupBox1.Controls.Add(this.textBox_torlestermeknev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_torlestermekid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(307, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(489, 373);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott termék";
            // 
            // button_vasarlas
            // 
            this.button_vasarlas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_vasarlas.Location = new System.Drawing.Point(21, 281);
            this.button_vasarlas.Margin = new System.Windows.Forms.Padding(4);
            this.button_vasarlas.Name = "button_vasarlas";
            this.button_vasarlas.Size = new System.Drawing.Size(380, 59);
            this.button_vasarlas.TabIndex = 8;
            this.button_vasarlas.Text = "Törlés";
            this.button_vasarlas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_vasarlas.UseVisualStyleBackColor = true;
            this.button_vasarlas.Click += new System.EventHandler(this.button_vasarlas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Raktár készlet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Egységár";
            // 
            // numericUpDown_ar
            // 
            this.numericUpDown_ar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_ar.Location = new System.Drawing.Point(199, 123);
            this.numericUpDown_ar.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_ar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_ar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ar.Name = "numericUpDown_ar";
            this.numericUpDown_ar.Size = new System.Drawing.Size(160, 30);
            this.numericUpDown_ar.TabIndex = 4;
            this.numericUpDown_ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_ar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_raktarKeszlet
            // 
            this.numericUpDown_raktarKeszlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_raktarKeszlet.Location = new System.Drawing.Point(199, 172);
            this.numericUpDown_raktarKeszlet.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_raktarKeszlet.Name = "numericUpDown_raktarKeszlet";
            this.numericUpDown_raktarKeszlet.Size = new System.Drawing.Size(160, 30);
            this.numericUpDown_raktarKeszlet.TabIndex = 4;
            this.numericUpDown_raktarKeszlet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_torlestermeknev
            // 
            this.textBox_torlestermeknev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_torlestermeknev.Location = new System.Drawing.Point(199, 74);
            this.textBox_torlestermeknev.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_torlestermeknev.Name = "textBox_torlestermeknev";
            this.textBox_torlestermeknev.Size = new System.Drawing.Size(201, 30);
            this.textBox_torlestermeknev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Terméknév";
            // 
            // textBox_torlestermekid
            // 
            this.textBox_torlestermekid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_torlestermekid.Location = new System.Drawing.Point(199, 25);
            this.textBox_torlestermekid.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_torlestermekid.Name = "textBox_torlestermekid";
            this.textBox_torlestermekid.ReadOnly = true;
            this.textBox_torlestermekid.Size = new System.Drawing.Size(119, 30);
            this.textBox_torlestermekid.TabIndex = 1;
            this.textBox_torlestermekid.TextChanged += new System.EventHandler(this.textBox_torlestermekid_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(17, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Termék azonosító";
            // 
            // Form_Törles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_termektorles);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Törles";
            this.Text = "Form_Törles";
            this.Load += new System.EventHandler(this.Form_Törles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_raktarKeszlet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_termektorles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_vasarlas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_ar;
        private System.Windows.Forms.NumericUpDown numericUpDown_raktarKeszlet;
        private System.Windows.Forms.TextBox textBox_torlestermeknev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_torlestermekid;
        private System.Windows.Forms.Label label6;
    }
}