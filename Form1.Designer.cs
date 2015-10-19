namespace DriverRoutingSimulation
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
            this.button_TestMap_MainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_TestMap_MainForm
            // 
            this.button_TestMap_MainForm.Location = new System.Drawing.Point(43, 93);
            this.button_TestMap_MainForm.Name = "button_TestMap_MainForm";
            this.button_TestMap_MainForm.Size = new System.Drawing.Size(138, 23);
            this.button_TestMap_MainForm.TabIndex = 0;
            this.button_TestMap_MainForm.Text = "Run Simulation";
            this.button_TestMap_MainForm.UseVisualStyleBackColor = true;
            this.button_TestMap_MainForm.Click += new System.EventHandler(this.button_TestMap_MainForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 225);
            this.Controls.Add(this.button_TestMap_MainForm);
            this.Name = "Form1";
            this.Text = "Delivery Sim";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_TestMap_MainForm;
    }
}

