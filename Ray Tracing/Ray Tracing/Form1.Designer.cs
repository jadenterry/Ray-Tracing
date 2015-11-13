namespace Ray_Tracing
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
            this.panel = new System.Windows.Forms.Panel();
            this.headingLabel = new System.Windows.Forms.Label();
            this.pitchLabel = new System.Windows.Forms.Label();
            this.headingBar = new System.Windows.Forms.HScrollBar();
            this.pitchBar = new System.Windows.Forms.HScrollBar();
            this.zoomBar = new System.Windows.Forms.HScrollBar();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(86, 70);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 200);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Location = new System.Drawing.Point(522, 29);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(47, 13);
            this.headingLabel.TabIndex = 3;
            this.headingLabel.Text = "Heading";
            // 
            // pitchLabel
            // 
            this.pitchLabel.AutoSize = true;
            this.pitchLabel.Location = new System.Drawing.Point(522, 89);
            this.pitchLabel.Name = "pitchLabel";
            this.pitchLabel.Size = new System.Drawing.Size(31, 13);
            this.pitchLabel.TabIndex = 4;
            this.pitchLabel.Text = "Pitch";
            // 
            // headingBar
            // 
            this.headingBar.Location = new System.Drawing.Point(511, 51);
            this.headingBar.Maximum = 50;
            this.headingBar.Name = "headingBar";
            this.headingBar.Size = new System.Drawing.Size(80, 17);
            this.headingBar.TabIndex = 5;
            this.headingBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.headingBar_Scroll);
            // 
            // pitchBar
            // 
            this.pitchBar.Location = new System.Drawing.Point(511, 121);
            this.pitchBar.Name = "pitchBar";
            this.pitchBar.Size = new System.Drawing.Size(80, 17);
            this.pitchBar.TabIndex = 6;
            this.pitchBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pitchBar_Scroll);
            // 
            // zoomBar
            // 
            this.zoomBar.Location = new System.Drawing.Point(511, 201);
            this.zoomBar.Maximum = 8;
            this.zoomBar.Minimum = -20;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(80, 17);
            this.zoomBar.TabIndex = 7;
            this.zoomBar.Value = -1;
            this.zoomBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.zoomBar_Scroll);
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Location = new System.Drawing.Point(522, 169);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(34, 13);
            this.zoomLabel.TabIndex = 8;
            this.zoomLabel.Text = "Zoom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 473);
            this.Controls.Add(this.zoomLabel);
            this.Controls.Add(this.zoomBar);
            this.Controls.Add(this.pitchBar);
            this.Controls.Add(this.headingBar);
            this.Controls.Add(this.pitchLabel);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Ray Tracer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label pitchLabel;
        private System.Windows.Forms.HScrollBar headingBar;
        private System.Windows.Forms.HScrollBar pitchBar;
        private System.Windows.Forms.HScrollBar zoomBar;
        private System.Windows.Forms.Label zoomLabel;
    }
}

