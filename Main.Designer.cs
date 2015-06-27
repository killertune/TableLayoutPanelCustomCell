namespace TableLayoutPanelTest
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.customCell5 = new TableLayoutPanelTest.CustomCell();
            this.customCell4 = new TableLayoutPanelTest.CustomCell();
            this.customCell3 = new TableLayoutPanelTest.CustomCell();
            this.customCell2 = new TableLayoutPanelTest.CustomCell();
            this.customCell1 = new TableLayoutPanelTest.CustomCell();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "画面名";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.customCell5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.customCell4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.customCell3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.customCell2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.customCell1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(668, 1167);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // customCell5
            // 
            this.customCell5.BackColor = System.Drawing.Color.White;
            this.customCell5.Location = new System.Drawing.Point(3, 935);
            this.customCell5.Name = "customCell5";
            this.customCell5.Size = new System.Drawing.Size(662, 227);
            this.customCell5.TabIndex = 4;
            // 
            // customCell4
            // 
            this.customCell4.BackColor = System.Drawing.Color.White;
            this.customCell4.Location = new System.Drawing.Point(3, 702);
            this.customCell4.Name = "customCell4";
            this.customCell4.Size = new System.Drawing.Size(662, 227);
            this.customCell4.TabIndex = 3;
            // 
            // customCell3
            // 
            this.customCell3.BackColor = System.Drawing.Color.White;
            this.customCell3.Location = new System.Drawing.Point(3, 469);
            this.customCell3.Name = "customCell3";
            this.customCell3.Size = new System.Drawing.Size(662, 227);
            this.customCell3.TabIndex = 2;
            // 
            // customCell2
            // 
            this.customCell2.BackColor = System.Drawing.Color.White;
            this.customCell2.Location = new System.Drawing.Point(3, 236);
            this.customCell2.Name = "customCell2";
            this.customCell2.Size = new System.Drawing.Size(662, 227);
            this.customCell2.TabIndex = 1;
            // 
            // customCell1
            // 
            this.customCell1.BackColor = System.Drawing.Color.White;
            this.customCell1.Location = new System.Drawing.Point(3, 3);
            this.customCell1.Name = "customCell1";
            this.customCell1.Size = new System.Drawing.Size(662, 227);
            this.customCell1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(725, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomCell customCell3;
        private CustomCell customCell2;
        private CustomCell customCell1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private CustomCell customCell5;
        private CustomCell customCell4;

    }
}