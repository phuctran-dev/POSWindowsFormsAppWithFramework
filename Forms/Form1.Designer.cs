namespace POSWindowsFormsAppWithFramework
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_HomePage = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1809, 100);
            this.panel1.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1809, 100);
            this.panelContainer.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 931);
            this.panel2.TabIndex = 1;
            // 
            // btn_HomePage
            // 
            this.btn_HomePage.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_HomePage.Location = new System.Drawing.Point(0, 103);
            this.btn_HomePage.Name = "btn_HomePage";
            this.btn_HomePage.Size = new System.Drawing.Size(197, 196);
            this.btn_HomePage.TabIndex = 2;
            this.btn_HomePage.Text = "Homepage";
            this.btn_HomePage.UseVisualStyleBackColor = true;
            this.btn_HomePage.Click += new System.EventHandler(this.btn_HomePage_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Order.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Order.Location = new System.Drawing.Point(0, 305);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(196, 196);
            this.btn_Order.TabIndex = 3;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1809, 1031);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.btn_HomePage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_HomePage;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Panel panelContainer;
    }
}

