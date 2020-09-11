namespace Performance_Counters_Enumerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listViewCategories = new System.Windows.Forms.ListView();
            this.groupCategories = new System.Windows.Forms.GroupBox();
            this.txtMachine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowCounters = new System.Windows.Forms.Button();
            this.groupBoxCounters = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewCounters = new System.Windows.Forms.ListView();
            this.btnExport = new System.Windows.Forms.Button();
            this.checkBoxCategoryDescription = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCategoryDescription = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCounterDescription = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumberOfCategoriesFound = new System.Windows.Forms.Label();
            this.groupCategories.SuspendLayout();
            this.groupBoxCounters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(370, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.Update_Click);
            // 
            // listViewCategories
            // 
            this.listViewCategories.Location = new System.Drawing.Point(11, 49);
            this.listViewCategories.Name = "listViewCategories";
            this.listViewCategories.Size = new System.Drawing.Size(434, 290);
            this.listViewCategories.TabIndex = 1;
            this.listViewCategories.UseCompatibleStateImageBehavior = false;
            this.listViewCategories.View = System.Windows.Forms.View.Details;
            this.listViewCategories.SelectedIndexChanged += new System.EventHandler(this.OnSelectedCategory);
            // 
            // groupCategories
            // 
            this.groupCategories.Controls.Add(this.txtNumberOfCategoriesFound);
            this.groupCategories.Controls.Add(this.label3);
            this.groupCategories.Controls.Add(this.txtMachine);
            this.groupCategories.Controls.Add(this.label1);
            this.groupCategories.Controls.Add(this.btnShowCounters);
            this.groupCategories.Controls.Add(this.btnUpdate);
            this.groupCategories.Controls.Add(this.listViewCategories);
            this.groupCategories.Location = new System.Drawing.Point(12, 12);
            this.groupCategories.Name = "groupCategories";
            this.groupCategories.Size = new System.Drawing.Size(457, 387);
            this.groupCategories.TabIndex = 2;
            this.groupCategories.TabStop = false;
            this.groupCategories.Text = "Categories";
            // 
            // txtMachine
            // 
            this.txtMachine.AutoSize = true;
            this.txtMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachine.Location = new System.Drawing.Point(246, 26);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(19, 13);
            this.txtMachine.TabIndex = 3;
            this.txtMachine.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Peformance Counters Categories available on:";
            // 
            // btnShowCounters
            // 
            this.btnShowCounters.Location = new System.Drawing.Point(370, 351);
            this.btnShowCounters.Name = "btnShowCounters";
            this.btnShowCounters.Size = new System.Drawing.Size(75, 23);
            this.btnShowCounters.TabIndex = 6;
            this.btnShowCounters.Text = "Counters >>";
            this.btnShowCounters.UseVisualStyleBackColor = true;
            this.btnShowCounters.Click += new System.EventHandler(this.btnShowCounters_Click);
            // 
            // groupBoxCounters
            // 
            this.groupBoxCounters.Controls.Add(this.label2);
            this.groupBoxCounters.Controls.Add(this.listViewCounters);
            this.groupBoxCounters.Location = new System.Drawing.Point(473, 12);
            this.groupBoxCounters.Name = "groupBoxCounters";
            this.groupBoxCounters.Size = new System.Drawing.Size(457, 387);
            this.groupBoxCounters.TabIndex = 4;
            this.groupBoxCounters.TabStop = false;
            this.groupBoxCounters.Text = "Counters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Peformance Counters available for the selected Category";
            // 
            // listViewCounters
            // 
            this.listViewCounters.Location = new System.Drawing.Point(16, 49);
            this.listViewCounters.Name = "listViewCounters";
            this.listViewCounters.Size = new System.Drawing.Size(434, 290);
            this.listViewCounters.TabIndex = 0;
            this.listViewCounters.UseCompatibleStateImageBehavior = false;
            this.listViewCounters.View = System.Windows.Forms.View.Details;
            this.listViewCounters.SelectedIndexChanged += new System.EventHandler(this.OnCounterSelected);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(368, 25);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // checkBoxCategoryDescription
            // 
            this.checkBoxCategoryDescription.AutoSize = true;
            this.checkBoxCategoryDescription.Location = new System.Drawing.Point(28, 28);
            this.checkBoxCategoryDescription.Name = "checkBoxCategoryDescription";
            this.checkBoxCategoryDescription.Size = new System.Drawing.Size(185, 17);
            this.checkBoxCategoryDescription.TabIndex = 1;
            this.checkBoxCategoryDescription.Text = "Save Categories Description Field";
            this.checkBoxCategoryDescription.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCategoryDescription);
            this.groupBox1.Location = new System.Drawing.Point(12, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Description";
            // 
            // textBoxCategoryDescription
            // 
            this.textBoxCategoryDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCategoryDescription.Location = new System.Drawing.Point(9, 25);
            this.textBoxCategoryDescription.Multiline = true;
            this.textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            this.textBoxCategoryDescription.ReadOnly = true;
            this.textBoxCategoryDescription.Size = new System.Drawing.Size(434, 86);
            this.textBoxCategoryDescription.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCounterDescription);
            this.groupBox2.Location = new System.Drawing.Point(473, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 194);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Counter Description";
            // 
            // textBoxCounterDescription
            // 
            this.textBoxCounterDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCounterDescription.Location = new System.Drawing.Point(16, 25);
            this.textBoxCounterDescription.Multiline = true;
            this.textBoxCounterDescription.Name = "textBoxCounterDescription";
            this.textBoxCounterDescription.ReadOnly = true;
            this.textBoxCounterDescription.Size = new System.Drawing.Size(434, 86);
            this.textBoxCounterDescription.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.checkBoxCategoryDescription);
            this.groupBox3.Location = new System.Drawing.Point(12, 532);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 68);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XML";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of Categories found:";
            // 
            // txtNumberOfCategoriesFound
            // 
            this.txtNumberOfCategoriesFound.AutoSize = true;
            this.txtNumberOfCategoriesFound.Location = new System.Drawing.Point(160, 351);
            this.txtNumberOfCategoriesFound.Name = "txtNumberOfCategoriesFound";
            this.txtNumberOfCategoriesFound.Size = new System.Drawing.Size(16, 13);
            this.txtNumberOfCategoriesFound.TabIndex = 8;
            this.txtNumberOfCategoriesFound.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 611);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCounters);
            this.Controls.Add(this.groupCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Performance Counters Enumerator";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.groupCategories.ResumeLayout(false);
            this.groupCategories.PerformLayout();
            this.groupBoxCounters.ResumeLayout(false);
            this.groupBoxCounters.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView listViewCategories;
        private System.Windows.Forms.GroupBox groupCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMachine;
        private System.Windows.Forms.Button btnShowCounters;
        private System.Windows.Forms.GroupBox groupBoxCounters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewCounters;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox checkBoxCategoryDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCategoryDescription;
        private System.Windows.Forms.TextBox textBoxCounterDescription;
        private System.Windows.Forms.Label txtNumberOfCategoriesFound;
        private System.Windows.Forms.Label label3;
    }
}

