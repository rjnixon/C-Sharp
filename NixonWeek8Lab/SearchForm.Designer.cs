
namespace NixonWeek7Lab
{
    partial class SearchForm
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
            this.txtSearchPhoneNum = new System.Windows.Forms.TextBox();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.cbHomePhone = new System.Windows.Forms.CheckBox();
            this.cbCellPhone = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchPhoneNum
            // 
            this.txtSearchPhoneNum.Location = new System.Drawing.Point(1228, 329);
            this.txtSearchPhoneNum.Name = "txtSearchPhoneNum";
            this.txtSearchPhoneNum.Size = new System.Drawing.Size(382, 31);
            this.txtSearchPhoneNum.TabIndex = 0;
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(343, 324);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(298, 31);
            this.txtSearchLastName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(842, 576);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(183, 60);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1046, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name:";
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(0, 656);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.RowHeadersWidth = 82;
            this.dgvSearchResults.RowTemplate.Height = 33;
            this.dgvSearchResults.Size = new System.Drawing.Size(2157, 522);
            this.dgvSearchResults.TabIndex = 5;
            this.dgvSearchResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResults_CellDoubleClick);
            // 
            // cbHomePhone
            // 
            this.cbHomePhone.AutoSize = true;
            this.cbHomePhone.Checked = true;
            this.cbHomePhone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHomePhone.Location = new System.Drawing.Point(1254, 294);
            this.cbHomePhone.Name = "cbHomePhone";
            this.cbHomePhone.Size = new System.Drawing.Size(168, 29);
            this.cbHomePhone.TabIndex = 6;
            this.cbHomePhone.Text = "Home Phone";
            this.cbHomePhone.UseVisualStyleBackColor = true;
            this.cbHomePhone.CheckedChanged += new System.EventHandler(this.cbHomePhone_CheckedChanged);
            // 
            // cbCellPhone
            // 
            this.cbCellPhone.AutoSize = true;
            this.cbCellPhone.Location = new System.Drawing.Point(1444, 294);
            this.cbCellPhone.Name = "cbCellPhone";
            this.cbCellPhone.Size = new System.Drawing.Size(149, 29);
            this.cbCellPhone.TabIndex = 7;
            this.cbCellPhone.Text = "Cell Phone";
            this.cbCellPhone.UseVisualStyleBackColor = true;
            this.cbCellPhone.CheckedChanged += new System.EventHandler(this.cbCellPhone_CheckedChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2187, 1190);
            this.Controls.Add(this.cbCellPhone);
            this.Controls.Add(this.cbHomePhone);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchLastName);
            this.Controls.Add(this.txtSearchPhoneNum);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchPhoneNum;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.CheckBox cbHomePhone;
        private System.Windows.Forms.CheckBox cbCellPhone;
    }
}