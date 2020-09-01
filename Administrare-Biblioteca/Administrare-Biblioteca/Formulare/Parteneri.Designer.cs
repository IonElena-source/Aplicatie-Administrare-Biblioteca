namespace Administrare_Biblioteca
{
    partial class Parteneri
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
            this.lbparteneri = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbpremium = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbparteneri
            // 
            this.lbparteneri.AllowDrop = true;
            this.lbparteneri.FormattingEnabled = true;
            this.lbparteneri.Location = new System.Drawing.Point(76, 104);
            this.lbparteneri.Name = "lbparteneri";
            this.lbparteneri.Size = new System.Drawing.Size(234, 251);
            this.lbparteneri.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(72, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parteneri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbpremium
            // 
            this.lbpremium.AllowDrop = true;
            this.lbpremium.FormattingEnabled = true;
            this.lbpremium.Location = new System.Drawing.Point(399, 104);
            this.lbpremium.Name = "lbpremium";
            this.lbpremium.Size = new System.Drawing.Size(229, 251);
            this.lbpremium.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(405, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parteneri Premium";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Parteneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbpremium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbparteneri);
            this.Name = "Parteneri";
            this.Text = "Parteneri";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox lbparteneri;
        public System.Windows.Forms.ListBox lbpremium;
    }
}