
namespace MscStdReservation
{
    partial class DeleteRes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDeleteRes = new System.Windows.Forms.Button();
            this.txtDeleteRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 288);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(406, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 52);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Reservation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonDeleteRes);
            this.panel1.Controls.Add(this.txtDeleteRes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(406, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 146);
            this.panel1.TabIndex = 6;
            // 
            // buttonDeleteRes
            // 
            this.buttonDeleteRes.BackColor = System.Drawing.Color.Black;
            this.buttonDeleteRes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteRes.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonDeleteRes.Location = new System.Drawing.Point(116, 77);
            this.buttonDeleteRes.Name = "buttonDeleteRes";
            this.buttonDeleteRes.Size = new System.Drawing.Size(147, 39);
            this.buttonDeleteRes.TabIndex = 3;
            this.buttonDeleteRes.Text = "Delete";
            this.buttonDeleteRes.UseVisualStyleBackColor = false;
            this.buttonDeleteRes.Click += new System.EventHandler(this.buttonDeleteRes_Click);
            // 
            // txtDeleteRes
            // 
            this.txtDeleteRes.Location = new System.Drawing.Point(75, 28);
            this.txtDeleteRes.Name = "txtDeleteRes";
            this.txtDeleteRes.Size = new System.Drawing.Size(264, 27);
            this.txtDeleteRes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futura Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // DeleteRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1109, 590);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "DeleteRes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Reservation";
            this.Load += new System.EventHandler(this.DeleteRes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDeleteRes;
        private System.Windows.Forms.TextBox txtDeleteRes;
        private System.Windows.Forms.Label label3;
    }
}