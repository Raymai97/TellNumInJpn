namespace TellNumInJpn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDaiji = new System.Windows.Forms.ComboBox();
            this.chkSpaceHiraRomaji = new System.Windows.Forms.CheckBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblRomaji = new System.Windows.Forms.Label();
            this.lblHiragana = new System.Windows.Forms.Label();
            this.txtRomaji = new System.Windows.Forms.TextBox();
            this.lblKanji = new System.Windows.Forms.Label();
            this.txtHiragana = new System.Windows.Forms.TextBox();
            this.txtKanji = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbDaiji);
            this.panel1.Controls.Add(this.chkSpaceHiraRomaji);
            this.panel1.Controls.Add(this.lblGreeting);
            this.panel1.Controls.Add(this.lblRomaji);
            this.panel1.Controls.Add(this.lblHiragana);
            this.panel1.Controls.Add(this.txtRomaji);
            this.panel1.Controls.Add(this.lblKanji);
            this.panel1.Controls.Add(this.txtHiragana);
            this.panel1.Controls.Add(this.txtKanji);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 311);
            this.panel1.TabIndex = 0;
            // 
            // cmbDaiji
            // 
            this.cmbDaiji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDaiji.FormattingEnabled = true;
            this.cmbDaiji.Items.AddRange(new object[] {
            "Don\'t use 大字",
            "Use current 大字",
            "Use obsolete 大字"});
            this.cmbDaiji.Location = new System.Drawing.Point(380, 41);
            this.cmbDaiji.Name = "cmbDaiji";
            this.cmbDaiji.Size = new System.Drawing.Size(179, 27);
            this.cmbDaiji.TabIndex = 1;
            this.cmbDaiji.SelectedIndexChanged += new System.EventHandler(this.cmbDaiji_SelectedIndexChanged);
            // 
            // chkSpaceHiraRomaji
            // 
            this.chkSpaceHiraRomaji.AutoSize = true;
            this.chkSpaceHiraRomaji.Checked = true;
            this.chkSpaceHiraRomaji.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpaceHiraRomaji.Location = new System.Drawing.Point(36, 225);
            this.chkSpaceHiraRomaji.Name = "chkSpaceHiraRomaji";
            this.chkSpaceHiraRomaji.Size = new System.Drawing.Size(331, 23);
            this.chkSpaceHiraRomaji.TabIndex = 5;
            this.chkSpaceHiraRomaji.Text = "Separate hiragana and romaji with space";
            this.chkSpaceHiraRomaji.UseVisualStyleBackColor = true;
            this.chkSpaceHiraRomaji.CheckedChanged += new System.EventHandler(this.chkSpaceHiraRomaji_CheckedChanged);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(136, 264);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(323, 19);
            this.lblGreeting.TabIndex = 5;
            this.lblGreeting.Text = "あけましておめでとうございます！ - Raymai (2015)";
            this.lblGreeting.Click += new System.EventHandler(this.lblGreeting_Click);
            // 
            // lblRomaji
            // 
            this.lblRomaji.AutoSize = true;
            this.lblRomaji.Location = new System.Drawing.Point(32, 167);
            this.lblRomaji.Margin = new System.Windows.Forms.Padding(3);
            this.lblRomaji.Name = "lblRomaji";
            this.lblRomaji.Size = new System.Drawing.Size(129, 19);
            this.lblRomaji.TabIndex = 2;
            this.lblRomaji.Text = "Romaji ローマ字：";
            // 
            // lblHiragana
            // 
            this.lblHiragana.AutoSize = true;
            this.lblHiragana.Location = new System.Drawing.Point(32, 108);
            this.lblHiragana.Margin = new System.Windows.Forms.Padding(3);
            this.lblHiragana.Name = "lblHiragana";
            this.lblHiragana.Size = new System.Drawing.Size(142, 19);
            this.lblHiragana.TabIndex = 2;
            this.lblHiragana.Text = "Hiragana ひらがな：";
            // 
            // txtRomaji
            // 
            this.txtRomaji.Location = new System.Drawing.Point(36, 192);
            this.txtRomaji.Name = "txtRomaji";
            this.txtRomaji.ReadOnly = true;
            this.txtRomaji.Size = new System.Drawing.Size(523, 27);
            this.txtRomaji.TabIndex = 4;
            // 
            // lblKanji
            // 
            this.lblKanji.AutoSize = true;
            this.lblKanji.Location = new System.Drawing.Point(32, 49);
            this.lblKanji.Margin = new System.Windows.Forms.Padding(3);
            this.lblKanji.Name = "lblKanji";
            this.lblKanji.Size = new System.Drawing.Size(96, 19);
            this.lblKanji.TabIndex = 2;
            this.lblKanji.Text = "Kanji 漢字：";
            // 
            // txtHiragana
            // 
            this.txtHiragana.Location = new System.Drawing.Point(36, 133);
            this.txtHiragana.Name = "txtHiragana";
            this.txtHiragana.ReadOnly = true;
            this.txtHiragana.Size = new System.Drawing.Size(523, 27);
            this.txtHiragana.TabIndex = 3;
            // 
            // txtKanji
            // 
            this.txtKanji.Location = new System.Drawing.Point(36, 74);
            this.txtKanji.Name = "txtKanji";
            this.txtKanji.ReadOnly = true;
            this.txtKanji.Size = new System.Drawing.Size(523, 27);
            this.txtKanji.TabIndex = 2;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(3, 3);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(588, 27);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(594, 311);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tell number in Japanese v1.2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblRomaji;
        private System.Windows.Forms.Label lblHiragana;
        private System.Windows.Forms.TextBox txtRomaji;
        private System.Windows.Forms.Label lblKanji;
        private System.Windows.Forms.TextBox txtHiragana;
        private System.Windows.Forms.TextBox txtKanji;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.CheckBox chkSpaceHiraRomaji;
        private System.Windows.Forms.ComboBox cmbDaiji;
    }
}

