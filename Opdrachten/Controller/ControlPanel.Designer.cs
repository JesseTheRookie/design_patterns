namespace Controller
{
    partial class ControlPanel
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
            this.btnVolgendStation = new System.Windows.Forms.Button();
            this.btnNewDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolgendStation
            // 
            this.btnVolgendStation.Location = new System.Drawing.Point(54, 70);
            this.btnVolgendStation.Name = "btnVolgendStation";
            this.btnVolgendStation.Size = new System.Drawing.Size(170, 74);
            this.btnVolgendStation.TabIndex = 0;
            this.btnVolgendStation.Text = "Volgend Station";
            this.btnVolgendStation.UseVisualStyleBackColor = true;
            this.btnVolgendStation.Click += new System.EventHandler(this.btnVolgendStation_Click);
            // 
            // btnNewDisplay
            // 
            this.btnNewDisplay.Location = new System.Drawing.Point(90, 164);
            this.btnNewDisplay.Name = "btnNewDisplay";
            this.btnNewDisplay.Size = new System.Drawing.Size(104, 45);
            this.btnNewDisplay.TabIndex = 1;
            this.btnNewDisplay.Text = "Nieuw display";
            this.btnNewDisplay.UseVisualStyleBackColor = true;
            this.btnNewDisplay.Click += new System.EventHandler(this.btnNewDisplay_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 450);
            this.Controls.Add(this.btnNewDisplay);
            this.Controls.Add(this.btnVolgendStation);
            this.Name = "ControlPanel";
            this.Text = "Controller";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolgendStation;
        private System.Windows.Forms.Button btnNewDisplay;
    }
}