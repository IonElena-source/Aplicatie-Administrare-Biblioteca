namespace Administrare_Biblioteca
{
    partial class ReportFormular
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbzilereport = new System.Windows.Forms.TextBox();
            this.tbCartereport = new System.Windows.Forms.TextBox();
            this.tbcititorreport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(415, 216);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(100, 20);
            this.tbAdresa.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(240, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 38);
            this.label4.TabIndex = 15;
            this.label4.Text = "Adresa";
            // 
            // tbzilereport
            // 
            this.tbzilereport.Location = new System.Drawing.Point(415, 273);
            this.tbzilereport.Name = "tbzilereport";
            this.tbzilereport.Size = new System.Drawing.Size(100, 20);
            this.tbzilereport.TabIndex = 14;
            // 
            // tbCartereport
            // 
            this.tbCartereport.Location = new System.Drawing.Point(415, 165);
            this.tbCartereport.Name = "tbCartereport";
            this.tbCartereport.Size = new System.Drawing.Size(100, 20);
            this.tbCartereport.TabIndex = 13;
            // 
            // tbcititorreport
            // 
            this.tbcititorreport.Location = new System.Drawing.Point(415, 116);
            this.tbcititorreport.Name = "tbcititorreport";
            this.tbcititorreport.Size = new System.Drawing.Size(100, 20);
            this.tbcititorreport.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(240, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "Numar de zile cu care a inatrziat";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(240, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "Carte imprumtata";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(240, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nume Cititor";
            // 
            // ReportFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbzilereport);
            this.Controls.Add(this.tbCartereport);
            this.Controls.Add(this.tbcititorreport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReportFormular";
            this.Text = "ReportFormular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbzilereport;
        private System.Windows.Forms.TextBox tbCartereport;
        private System.Windows.Forms.TextBox tbcititorreport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}