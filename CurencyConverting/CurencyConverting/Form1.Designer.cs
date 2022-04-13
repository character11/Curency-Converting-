namespace CurencyConverting
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
            this.CboxInput = new System.Windows.Forms.ComboBox();
            this.CboxOutput = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboxInput
            // 
            this.CboxInput.FormattingEnabled = true;
            this.CboxInput.Items.AddRange(new object[] {
            "Euro",
            "MK Denar",
            "US Dolar"});
            this.CboxInput.Location = new System.Drawing.Point(58, 36);
            this.CboxInput.Name = "CboxInput";
            this.CboxInput.Size = new System.Drawing.Size(104, 21);
            this.CboxInput.TabIndex = 0;
            this.CboxInput.Text = "Convert From";
            this.CboxInput.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CboxOutput
            // 
            this.CboxOutput.FormattingEnabled = true;
            this.CboxOutput.Items.AddRange(new object[] {
            "Euro",
            "MK Denar",
            "USD"});
            this.CboxOutput.Location = new System.Drawing.Point(220, 36);
            this.CboxOutput.Name = "CboxOutput";
            this.CboxOutput.Size = new System.Drawing.Size(106, 21);
            this.CboxOutput.TabIndex = 1;
            this.CboxOutput.Text = "Convert To";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConvert);
            this.panel1.Controls.Add(this.txtOutput);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CboxInput);
            this.panel1.Controls.Add(this.CboxOutput);
            this.panel1.Location = new System.Drawing.Point(22, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 92);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(202, 63);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(139, 20);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(44, 63);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(133, 20);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(159, 7);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 160);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "curency convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboxInput;
        private System.Windows.Forms.ComboBox CboxOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnConvert;
    }
}

