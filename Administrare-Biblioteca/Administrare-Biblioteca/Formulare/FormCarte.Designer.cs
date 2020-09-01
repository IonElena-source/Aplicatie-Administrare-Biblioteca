namespace Administrare_Biblioteca
{
    partial class FormCarte
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
            this.lbTitlu = new System.Windows.Forms.Label();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.lbDomeniu = new System.Windows.Forms.Label();
            this.tbDomeniu = new System.Windows.Forms.TextBox();
            this.lbCota = new System.Windows.Forms.Label();
            this.tbCota = new System.Windows.Forms.TextBox();
            this.lbRaft = new System.Windows.Forms.Label();
            this.tbRaft = new System.Windows.Forms.TextBox();
            this.CarteCancel = new System.Windows.Forms.Button();
            this.CarteOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitlu
            // 
            this.lbTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitlu.Location = new System.Drawing.Point(48, 26);
            this.lbTitlu.Name = "lbTitlu";
            this.lbTitlu.Size = new System.Drawing.Size(53, 23);
            this.lbTitlu.TabIndex = 8;
            this.lbTitlu.Text = "Titlu";
            // 
            // tbTitlu
            // 
            this.tbTitlu.Location = new System.Drawing.Point(156, 23);
            this.tbTitlu.Multiline = true;
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(244, 26);
            this.tbTitlu.TabIndex = 9;
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAutor.Location = new System.Drawing.Point(48, 81);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(48, 20);
            this.lbAutor.TabIndex = 10;
            this.lbAutor.Text = "Autor";
            // 
            // tbAutor
            // 
            this.tbAutor.BackColor = System.Drawing.Color.White;
            this.tbAutor.Location = new System.Drawing.Point(156, 83);
            this.tbAutor.Multiline = true;
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(244, 30);
            this.tbAutor.TabIndex = 13;
            // 
            // lbDomeniu
            // 
            this.lbDomeniu.AutoSize = true;
            this.lbDomeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDomeniu.Location = new System.Drawing.Point(49, 149);
            this.lbDomeniu.Name = "lbDomeniu";
            this.lbDomeniu.Size = new System.Drawing.Size(36, 18);
            this.lbDomeniu.TabIndex = 14;
            this.lbDomeniu.Text = "Gen";
            // 
            // tbDomeniu
            // 
            this.tbDomeniu.Location = new System.Drawing.Point(156, 150);
            this.tbDomeniu.Name = "tbDomeniu";
            this.tbDomeniu.Size = new System.Drawing.Size(128, 20);
            this.tbDomeniu.TabIndex = 15;
            // 
            // lbCota
            // 
            this.lbCota.AutoSize = true;
            this.lbCota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCota.Location = new System.Drawing.Point(48, 204);
            this.lbCota.Name = "lbCota";
            this.lbCota.Size = new System.Drawing.Size(43, 20);
            this.lbCota.TabIndex = 16;
            this.lbCota.Text = "Cota";
            // 
            // tbCota
            // 
            this.tbCota.Location = new System.Drawing.Point(156, 206);
            this.tbCota.Name = "tbCota";
            this.tbCota.Size = new System.Drawing.Size(128, 20);
            this.tbCota.TabIndex = 17;
            // 
            // lbRaft
            // 
            this.lbRaft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRaft.Location = new System.Drawing.Point(48, 270);
            this.lbRaft.Name = "lbRaft";
            this.lbRaft.Size = new System.Drawing.Size(47, 32);
            this.lbRaft.TabIndex = 18;
            this.lbRaft.Text = "Raft";
            // 
            // tbRaft
            // 
            this.tbRaft.Location = new System.Drawing.Point(156, 270);
            this.tbRaft.Name = "tbRaft";
            this.tbRaft.Size = new System.Drawing.Size(128, 20);
            this.tbRaft.TabIndex = 19;
            // 
            // CarteCancel
            // 
            this.CarteCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CarteCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CarteCancel.Location = new System.Drawing.Point(229, 319);
            this.CarteCancel.Name = "CarteCancel";
            this.CarteCancel.Size = new System.Drawing.Size(90, 28);
            this.CarteCancel.TabIndex = 20;
            this.CarteCancel.Text = "Cancel";
            this.CarteCancel.UseVisualStyleBackColor = true;
            // 
            // CarteOk
            // 
            this.CarteOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CarteOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CarteOk.Location = new System.Drawing.Point(340, 319);
            this.CarteOk.Name = "CarteOk";
            this.CarteOk.Size = new System.Drawing.Size(87, 31);
            this.CarteOk.TabIndex = 21;
            this.CarteOk.Text = "OK";
            this.CarteOk.UseVisualStyleBackColor = true;
            // 
            // FormCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(450, 395);
            this.Controls.Add(this.CarteOk);
            this.Controls.Add(this.CarteCancel);
            this.Controls.Add(this.tbRaft);
            this.Controls.Add(this.lbRaft);
            this.Controls.Add(this.tbCota);
            this.Controls.Add(this.lbCota);
            this.Controls.Add(this.tbDomeniu);
            this.Controls.Add(this.lbDomeniu);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.tbTitlu);
            this.Controls.Add(this.lbTitlu);
            this.Name = "FormCarte";
            this.Text = "FormCarte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitlu;
        public System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.Label lbAutor;
        public System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label lbDomeniu;
        public System.Windows.Forms.TextBox tbDomeniu;
        private System.Windows.Forms.Label lbCota;
        public System.Windows.Forms.TextBox tbCota;
        private System.Windows.Forms.Label lbRaft;
        public System.Windows.Forms.TextBox tbRaft;
        public System.Windows.Forms.Button CarteCancel;
        public System.Windows.Forms.Button CarteOk;
    }
}