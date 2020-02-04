namespace TicTacToe
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.staticTurnLabel = new System.Windows.Forms.Label();
            this.changingTurnLabel = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.PictureBox();
            this.a2 = new System.Windows.Forms.PictureBox();
            this.a3 = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.PictureBox();
            this.b2 = new System.Windows.Forms.PictureBox();
            this.b3 = new System.Windows.Forms.PictureBox();
            this.c1 = new System.Windows.Forms.PictureBox();
            this.c2 = new System.Windows.Forms.PictureBox();
            this.c3 = new System.Windows.Forms.PictureBox();
            this.gameEngine = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.c3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.c2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.c1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.b3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.b2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.b1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.a3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.a2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.a1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(123, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 362);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // staticTurnLabel
            // 
            this.staticTurnLabel.AutoSize = true;
            this.staticTurnLabel.Location = new System.Drawing.Point(259, 13);
            this.staticTurnLabel.Name = "staticTurnLabel";
            this.staticTurnLabel.Size = new System.Drawing.Size(32, 13);
            this.staticTurnLabel.TabIndex = 1;
            this.staticTurnLabel.Text = "Turn:";
            // 
            // changingTurnLabel
            // 
            this.changingTurnLabel.AutoSize = true;
            this.changingTurnLabel.Location = new System.Drawing.Point(298, 12);
            this.changingTurnLabel.Name = "changingTurnLabel";
            this.changingTurnLabel.Size = new System.Drawing.Size(14, 13);
            this.changingTurnLabel.TabIndex = 2;
            this.changingTurnLabel.Text = "X";
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(6, 6);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(126, 110);
            this.a1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a1.TabIndex = 0;
            this.a1.TabStop = false;
            this.a1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(141, 6);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(126, 110);
            this.a2.TabIndex = 1;
            this.a2.TabStop = false;
            this.a2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(277, 6);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(126, 110);
            this.a3.TabIndex = 2;
            this.a3.TabStop = false;
            this.a3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(6, 125);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(126, 110);
            this.b1.TabIndex = 3;
            this.b1.TabStop = false;
            this.b1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(141, 125);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(126, 110);
            this.b2.TabIndex = 4;
            this.b2.TabStop = false;
            this.b2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(277, 125);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(126, 110);
            this.b3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b3.TabIndex = 5;
            this.b3.TabStop = false;
            this.b3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(6, 244);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(126, 110);
            this.c1.TabIndex = 6;
            this.c1.TabStop = false;
            this.c1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(141, 244);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(126, 110);
            this.c2.TabIndex = 7;
            this.c2.TabStop = false;
            this.c2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(277, 244);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(126, 110);
            this.c3.TabIndex = 8;
            this.c3.TabStop = false;
            this.c3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 477);
            this.Controls.Add(this.changingTurnLabel);
            this.Controls.Add(this.staticTurnLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.a1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox c3;
        private System.Windows.Forms.PictureBox c2;
        private System.Windows.Forms.PictureBox c1;
        private System.Windows.Forms.PictureBox b3;
        private System.Windows.Forms.PictureBox b2;
        private System.Windows.Forms.PictureBox b1;
        private System.Windows.Forms.PictureBox a3;
        private System.Windows.Forms.PictureBox a2;
        private System.Windows.Forms.PictureBox a1;
        private System.Windows.Forms.Label staticTurnLabel;
        private System.Windows.Forms.Label changingTurnLabel;
        private System.Windows.Forms.Timer gameEngine;
    }
}

