namespace PuniPos_2
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QuantityLabel.Location = new System.Drawing.Point(0, 0);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(35, 17);
            this.QuantityLabel.TabIndex = 0;
            this.QuantityLabel.Text = "Qun";
            this.QuantityLabel.Click += new System.EventHandler(this.QuantityLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLabel.Location = new System.Drawing.Point(38, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(112, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "OrderItem Name";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PriceLabel.Location = new System.Drawing.Point(237, 0);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(72, 17);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "TotalPrice";
            this.PriceLabel.Click += new System.EventHandler(this.PriceLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 25);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // ListItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.panel1);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(309, 23);
            this.Load += new System.EventHandler(this.ListItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Panel panel1;
    }
}
