
namespace NixonWeek7Lab
{
    partial class ControlForm
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
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnSearchRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(314, 375);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(331, 82);
            this.btnAddRecord.TabIndex = 0;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnSearchRecord
            // 
            this.btnSearchRecord.Location = new System.Drawing.Point(954, 375);
            this.btnSearchRecord.Name = "btnSearchRecord";
            this.btnSearchRecord.Size = new System.Drawing.Size(331, 82);
            this.btnSearchRecord.TabIndex = 1;
            this.btnSearchRecord.Text = "Search Records";
            this.btnSearchRecord.UseVisualStyleBackColor = true;
            this.btnSearchRecord.Click += new System.EventHandler(this.btnSearchRecord_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 1095);
            this.Controls.Add(this.btnSearchRecord);
            this.Controls.Add(this.btnAddRecord);
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnSearchRecord;
    }
}