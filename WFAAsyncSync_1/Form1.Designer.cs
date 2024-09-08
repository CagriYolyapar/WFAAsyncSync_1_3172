namespace WFAAsyncSync_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCalistir = new Button();
            BtnSayi = new Button();
            SuspendLayout();
            // 
            // BtnCalistir
            // 
            BtnCalistir.Location = new Point(83, 59);
            BtnCalistir.Name = "BtnCalistir";
            BtnCalistir.Size = new Size(94, 29);
            BtnCalistir.TabIndex = 0;
            BtnCalistir.Text = "Calıstır";
            BtnCalistir.UseVisualStyleBackColor = true;
            BtnCalistir.Click += BtnCalistir_Click;
            // 
            // BtnSayi
            // 
            BtnSayi.Location = new Point(455, 74);
            BtnSayi.Name = "BtnSayi";
            BtnSayi.Size = new Size(94, 29);
            BtnSayi.TabIndex = 1;
            BtnSayi.Text = "Sayi";
            BtnSayi.UseVisualStyleBackColor = true;
            BtnSayi.Click += BtnSayi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSayi);
            Controls.Add(BtnCalistir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCalistir;
        private Button BtnSayi;
    }
}
