namespace LicenseKeyGenerator
{
    partial class LicenseKeyGeneratorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMachineCode;
        private System.Windows.Forms.TextBox txtMachineCode;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblMaskedKey;
        private System.Windows.Forms.TextBox txtMaskedKey;
        private System.Windows.Forms.Button btnCopyMasked;
        private System.Windows.Forms.Label lblOriginalKey;
        private System.Windows.Forms.TextBox txtOriginalKey;
        private System.Windows.Forms.Button btnCopyOriginal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMachineCode = new System.Windows.Forms.Label();
            this.txtMachineCode = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblMaskedKey = new System.Windows.Forms.Label();
            this.txtMaskedKey = new System.Windows.Forms.TextBox();
            this.btnCopyMasked = new System.Windows.Forms.Button();
            this.lblOriginalKey = new System.Windows.Forms.Label();
            this.txtOriginalKey = new System.Windows.Forms.TextBox();
            this.btnCopyOriginal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMachineCode
            // 
            this.lblMachineCode.AutoSize = true;
            this.lblMachineCode.Location = new System.Drawing.Point(12, 15);
            this.lblMachineCode.Name = "lblMachineCode";
            this.lblMachineCode.Size = new System.Drawing.Size(87, 15);
            this.lblMachineCode.TabIndex = 0;
            this.lblMachineCode.Text = "Machine Code:";
            // 
            // txtMachineCode
            // 
            this.txtMachineCode.Location = new System.Drawing.Point(105, 12);
            this.txtMachineCode.Name = "txtMachineCode";
            this.txtMachineCode.Size = new System.Drawing.Size(250, 23);
            this.txtMachineCode.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 45);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(343, 27);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate License Key";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblMaskedKey
            // 
            this.lblMaskedKey.AutoSize = true;
            this.lblMaskedKey.Location = new System.Drawing.Point(12, 85);
            this.lblMaskedKey.Name = "lblMaskedKey";
            this.lblMaskedKey.Size = new System.Drawing.Size(120, 15);
            this.lblMaskedKey.TabIndex = 3;
            this.lblMaskedKey.Text = "Masked License Key:";
            // 
            // txtMaskedKey
            // 
            this.txtMaskedKey.Location = new System.Drawing.Point(12, 103);
            this.txtMaskedKey.Name = "txtMaskedKey";
            this.txtMaskedKey.ReadOnly = true;
            this.txtMaskedKey.Size = new System.Drawing.Size(343, 23);
            this.txtMaskedKey.TabIndex = 4;
            // 
            // btnCopyMasked
            // 
            this.btnCopyMasked.Location = new System.Drawing.Point(12, 132);
            this.btnCopyMasked.Name = "btnCopyMasked";
            this.btnCopyMasked.Size = new System.Drawing.Size(120, 23);
            this.btnCopyMasked.TabIndex = 5;
            this.btnCopyMasked.Text = "Copy Masked Key";
            this.btnCopyMasked.UseVisualStyleBackColor = true;
            this.btnCopyMasked.Click += new System.EventHandler(this.btnCopyMasked_Click);
            // 
            // lblOriginalKey
            // 
            this.lblOriginalKey.AutoSize = true;
            this.lblOriginalKey.Location = new System.Drawing.Point(12, 170);
            this.lblOriginalKey.Name = "lblOriginalKey";
            this.lblOriginalKey.Size = new System.Drawing.Size(120, 15);
            this.lblOriginalKey.TabIndex = 6;
            this.lblOriginalKey.Text = "Original License Key:";
            // 
            // txtOriginalKey
            // 
            this.txtOriginalKey.Location = new System.Drawing.Point(12, 188);
            this.txtOriginalKey.Name = "txtOriginalKey";
            this.txtOriginalKey.ReadOnly = true;
            this.txtOriginalKey.Size = new System.Drawing.Size(343, 23);
            this.txtOriginalKey.TabIndex = 7;
            // 
            // btnCopyOriginal
            // 
            this.btnCopyOriginal.Location = new System.Drawing.Point(12, 217);
            this.btnCopyOriginal.Name = "btnCopyOriginal";
            this.btnCopyOriginal.Size = new System.Drawing.Size(120, 23);
            this.btnCopyOriginal.TabIndex = 8;
            this.btnCopyOriginal.Text = "Copy Original Key";
            this.btnCopyOriginal.UseVisualStyleBackColor = true;
            this.btnCopyOriginal.Click += new System.EventHandler(this.btnCopyOriginal_Click);
            // 
            // LicenseKeyGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 260);
            this.Controls.Add(this.btnCopyOriginal);
            this.Controls.Add(this.txtOriginalKey);
            this.Controls.Add(this.lblOriginalKey);
            this.Controls.Add(this.btnCopyMasked);
            this.Controls.Add(this.txtMaskedKey);
            this.Controls.Add(this.lblMaskedKey);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtMachineCode);
            this.Controls.Add(this.lblMachineCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseKeyGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Key Generator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}