namespace POSWindowsFormsAppWithFramework.UserControls
{
    partial class OrderUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_textView_Hello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_textView_Hello
            // 
            this.lbl_textView_Hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textView_Hello.Location = new System.Drawing.Point(182, 177);
            this.lbl_textView_Hello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_textView_Hello.Name = "lbl_textView_Hello";
            this.lbl_textView_Hello.Size = new System.Drawing.Size(328, 110);
            this.lbl_textView_Hello.TabIndex = 12;
            this.lbl_textView_Hello.Text = "Order";
            this.lbl_textView_Hello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_textView_Hello);
            this.Name = "OrderUC";
            this.Size = new System.Drawing.Size(693, 465);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_textView_Hello;
    }
}
