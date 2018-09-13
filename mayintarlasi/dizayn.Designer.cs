namespace mayintarlasi
{
    partial class dizayn
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
            this.btEditor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEditor
            // 
            this.btEditor.Location = new System.Drawing.Point(12, 92);
            this.btEditor.Name = "btEditor";
            this.btEditor.Size = new System.Drawing.Size(573, 78);
            this.btEditor.TabIndex = 0;
            this.btEditor.Text = "HARİTA DÜZENLEME MODU";
            this.btEditor.UseVisualStyleBackColor = true;
            this.btEditor.Click += new System.EventHandler(this.btEditor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "bilgi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dizayn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btEditor);
            this.Name = "dizayn";
            this.Text = "dizayn";
            this.Load += new System.EventHandler(this.dizayn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEditor;
        private System.Windows.Forms.Button button1;
    }
}