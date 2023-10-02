namespace KostkyWin
{
    partial class MainWindow
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
            btnHodKostkou = new Button();
            lblHodnota = new Label();
            lbMaximum = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnHodKostkou
            // 
            btnHodKostkou.Location = new Point(387, 75);
            btnHodKostkou.Name = "btnHodKostkou";
            btnHodKostkou.Size = new Size(168, 84);
            btnHodKostkou.TabIndex = 0;
            btnHodKostkou.Text = "Hod Kostkou";
            btnHodKostkou.UseVisualStyleBackColor = true;
            btnHodKostkou.Click += btnHodKostkou_Click;
            // 
            // lblHodnota
            // 
            lblHodnota.AutoSize = true;
            lblHodnota.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHodnota.ForeColor = Color.Blue;
            lblHodnota.Location = new Point(93, 80);
            lblHodnota.Name = "lblHodnota";
            lblHodnota.Size = new Size(42, 50);
            lblHodnota.TabIndex = 1;
            lblHodnota.Text = "1";
            // 
            // lbMaximum
            // 
            lbMaximum.FormattingEnabled = true;
            lbMaximum.ItemHeight = 15;
            lbMaximum.Items.AddRange(new object[] { "6", "8", "10", "12", "16", "22" });
            lbMaximum.Location = new Point(117, 249);
            lbMaximum.Name = "lbMaximum";
            lbMaximum.Size = new Size(163, 139);
            lbMaximum.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 219);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 3;
            label1.Text = "Nastav max. hodnotu kostky";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lbMaximum);
            Controls.Add(lblHodnota);
            Controls.Add(btnHodKostkou);
            Name = "MainWindow";
            Text = "Form1";
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHodKostkou;
        private Label lblHodnota;
        private ListBox lbMaximum;
        private Label label1;
    }
}