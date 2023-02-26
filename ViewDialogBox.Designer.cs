namespace khrogaapp
{
    partial class ViewDialogBox
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
            this.akll = new System.Windows.Forms.ListBox();
            this.cafe = new System.Windows.Forms.ListBox();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // akll
            // 
            this.akll.FormattingEnabled = true;
            this.akll.ItemHeight = 15;
            this.akll.Location = new System.Drawing.Point(12, 12);
            this.akll.Name = "akll";
            this.akll.Size = new System.Drawing.Size(192, 289);
            this.akll.TabIndex = 0;
            // 
            // cafe
            // 
            this.cafe.FormattingEnabled = true;
            this.cafe.ItemHeight = 15;
            this.cafe.Location = new System.Drawing.Point(225, 12);
            this.cafe.Name = "cafe";
            this.cafe.Size = new System.Drawing.Size(187, 289);
            this.cafe.TabIndex = 1;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(337, 322);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(216, 322);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 3;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(92, 322);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 4;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ViewDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 357);
            this.Controls.Add(this.add);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.cafe);
            this.Controls.Add(this.akll);
            this.Name = "ViewDialogBox";
            this.Text = "ViewDialogBox";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox akll;
        private ListBox cafe;
        private Button cancel;
        private Button ok;
        private Button add;
    }
}