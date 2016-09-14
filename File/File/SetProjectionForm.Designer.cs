namespace File
{
    partial class SetProjectionForm
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
            this.optEmpty = new System.Windows.Forms.RadioButton();
            this.optWellKnown = new System.Windows.Forms.RadioButton();
            this.cboWellKnown = new System.Windows.Forms.ComboBox();
            this.optDefinition = new System.Windows.Forms.RadioButton();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optEmpty
            // 
            this.optEmpty.AutoSize = true;
            this.optEmpty.Location = new System.Drawing.Point(28, 27);
            this.optEmpty.Name = "optEmpty";
            this.optEmpty.Size = new System.Drawing.Size(287, 16);
            this.optEmpty.TabIndex = 0;
            this.optEmpty.TabStop = true;
            this.optEmpty.Text = "Empty (will be grabbed from the first layer)";
            this.optEmpty.UseVisualStyleBackColor = true;
            // 
            // optWellKnown
            // 
            this.optWellKnown.AutoSize = true;
            this.optWellKnown.Location = new System.Drawing.Point(28, 59);
            this.optWellKnown.Name = "optWellKnown";
            this.optWellKnown.Size = new System.Drawing.Size(149, 16);
            this.optWellKnown.TabIndex = 1;
            this.optWellKnown.TabStop = true;
            this.optWellKnown.Text = "Well known projection";
            this.optWellKnown.UseVisualStyleBackColor = true;
            // 
            // cboWellKnown
            // 
            this.cboWellKnown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWellKnown.FormattingEnabled = true;
            this.cboWellKnown.Location = new System.Drawing.Point(184, 59);
            this.cboWellKnown.Name = "cboWellKnown";
            this.cboWellKnown.Size = new System.Drawing.Size(206, 20);
            this.cboWellKnown.TabIndex = 2;
            // 
            // optDefinition
            // 
            this.optDefinition.AutoSize = true;
            this.optDefinition.Location = new System.Drawing.Point(28, 85);
            this.optDefinition.Name = "optDefinition";
            this.optDefinition.Size = new System.Drawing.Size(437, 16);
            this.optDefinition.TabIndex = 3;
            this.optDefinition.TabStop = true;
            this.optDefinition.Text = "Enter projection definition in any form (e.g. PROJ4, WKT, EPSG code):";
            this.optDefinition.UseVisualStyleBackColor = true;
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(28, 116);
            this.txtDefinition.Multiline = true;
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(593, 101);
            this.txtDefinition.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(465, 235);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(546, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SetProjectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 270);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.optDefinition);
            this.Controls.Add(this.cboWellKnown);
            this.Controls.Add(this.optWellKnown);
            this.Controls.Add(this.optEmpty);
            this.Name = "SetProjectionForm";
            this.Text = "SetProjectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optEmpty;
        private System.Windows.Forms.RadioButton optWellKnown;
        private System.Windows.Forms.ComboBox cboWellKnown;
        private System.Windows.Forms.RadioButton optDefinition;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}