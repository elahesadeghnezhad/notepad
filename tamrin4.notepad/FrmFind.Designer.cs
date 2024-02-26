namespace tamrin4.notepad
{
    partial class FrmFind
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
            this.lblfind = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnfindnext = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoup = new System.Windows.Forms.RadioButton();
            this.rdodown = new System.Windows.Forms.RadioButton();
            this.hlmatchcase = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfind
            // 
            this.lblfind.AutoSize = true;
            this.lblfind.Location = new System.Drawing.Point(8, 15);
            this.lblfind.Name = "lblfind";
            this.lblfind.Size = new System.Drawing.Size(69, 16);
            this.lblfind.TabIndex = 0;
            this.lblfind.Text = "Find what:";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(79, 12);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(210, 23);
            this.txtfind.TabIndex = 1;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(295, 12);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(66, 27);
            this.btnfind.TabIndex = 2;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnfindnext
            // 
            this.btnfindnext.Location = new System.Drawing.Point(295, 44);
            this.btnfindnext.Name = "btnfindnext";
            this.btnfindnext.Size = new System.Drawing.Size(66, 27);
            this.btnfindnext.TabIndex = 3;
            this.btnfindnext.Text = "FindNext";
            this.btnfindnext.UseVisualStyleBackColor = true;
            this.btnfindnext.Click += new System.EventHandler(this.btnfindnext_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(295, 77);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(66, 27);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoup);
            this.groupBox1.Controls.Add(this.rdodown);
            this.groupBox1.Location = new System.Drawing.Point(167, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // rdoup
            // 
            this.rdoup.AutoSize = true;
            this.rdoup.Location = new System.Drawing.Point(5, 22);
            this.rdoup.Name = "rdoup";
            this.rdoup.Size = new System.Drawing.Size(41, 20);
            this.rdoup.TabIndex = 6;
            this.rdoup.TabStop = true;
            this.rdoup.Text = "Up";
            this.rdoup.UseVisualStyleBackColor = true;
            // 
            // rdodown
            // 
            this.rdodown.AutoSize = true;
            this.rdodown.Checked = true;
            this.rdodown.Location = new System.Drawing.Point(49, 22);
            this.rdodown.Name = "rdodown";
            this.rdodown.Size = new System.Drawing.Size(58, 20);
            this.rdodown.TabIndex = 7;
            this.rdodown.TabStop = true;
            this.rdodown.Text = "Down";
            this.rdodown.UseVisualStyleBackColor = true;
            // 
            // hlmatchcase
            // 
            this.hlmatchcase.AutoSize = true;
            this.hlmatchcase.Location = new System.Drawing.Point(11, 73);
            this.hlmatchcase.Name = "hlmatchcase";
            this.hlmatchcase.Size = new System.Drawing.Size(91, 20);
            this.hlmatchcase.TabIndex = 0;
            this.hlmatchcase.Text = "Match case";
            this.hlmatchcase.UseVisualStyleBackColor = true;
            // 
            // FrmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 126);
            this.Controls.Add(this.hlmatchcase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnfindnext);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.lblfind);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFind";
            this.Text = "Find";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfind;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnfindnext;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoup;
        private System.Windows.Forms.RadioButton rdodown;
        private System.Windows.Forms.CheckBox hlmatchcase;
    }
}