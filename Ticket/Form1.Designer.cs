namespace Ticket
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
            this.UserInputStore = new System.Windows.Forms.TextBox();
            this.labelStore = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelProvince = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.UserInputProvince = new System.Windows.Forms.TextBox();
            this.UserInputCity = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.dgvStores = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCallHist = new System.Windows.Forms.Button();
            this.btnNewTk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInputStore
            // 
            this.UserInputStore.Location = new System.Drawing.Point(75, 12);
            this.UserInputStore.Name = "UserInputStore";
            this.UserInputStore.Size = new System.Drawing.Size(78, 20);
            this.UserInputStore.TabIndex = 0;
            this.UserInputStore.TextChanged += new System.EventHandler(this.UserInputStore_TextChanged);
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Location = new System.Drawing.Point(22, 15);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(32, 13);
            this.labelStore.TabIndex = 2;
            this.labelStore.Text = "Store";
            this.labelStore.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(22, 94);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "City";
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(22, 68);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(49, 13);
            this.labelProvince.TabIndex = 4;
            this.labelProvince.Text = "Province";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(22, 41);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 5;
            this.labelCountry.Text = "Country";
            // 
            // UserInputProvince
            // 
            this.UserInputProvince.Location = new System.Drawing.Point(75, 65);
            this.UserInputProvince.Name = "UserInputProvince";
            this.UserInputProvince.Size = new System.Drawing.Size(78, 20);
            this.UserInputProvince.TabIndex = 0;
            this.UserInputProvince.TextChanged += new System.EventHandler(this.UserInputProvince_TextChanged);
            // 
            // UserInputCity
            // 
            this.UserInputCity.Location = new System.Drawing.Point(75, 91);
            this.UserInputCity.Name = "UserInputCity";
            this.UserInputCity.Size = new System.Drawing.Size(78, 20);
            this.UserInputCity.TabIndex = 0;
            this.UserInputCity.TextChanged += new System.EventHandler(this.UserInputCity_TextChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(25, 134);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(78, 27);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Canada",
            "USA"});
            this.comboBoxCountry.Location = new System.Drawing.Point(75, 38);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(78, 21);
            this.comboBoxCountry.TabIndex = 7;
            // 
            // dgvStores
            // 
            this.dgvStores.AllowUserToDeleteRows = false;
            this.dgvStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StoreID,
            this.Country,
            this.Province,
            this.City});
            this.dgvStores.Location = new System.Drawing.Point(288, 11);
            this.dgvStores.Name = "dgvStores";
            this.dgvStores.ReadOnly = true;
            this.dgvStores.Size = new System.Drawing.Size(447, 440);
            this.dgvStores.TabIndex = 8;
            this.dgvStores.DoubleClick += new System.EventHandler(this.dgvStores_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // StoreID
            // 
            this.StoreID.DataPropertyName = "StoreID";
            this.StoreID.HeaderText = "Store #";
            this.StoreID.Name = "StoreID";
            this.StoreID.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // Province
            // 
            this.Province.DataPropertyName = "Province";
            this.Province.HeaderText = "Province";
            this.Province.Name = "Province";
            this.Province.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(109, 134);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(193, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCallHist
            // 
            this.btnCallHist.Location = new System.Drawing.Point(25, 179);
            this.btnCallHist.Name = "btnCallHist";
            this.btnCallHist.Size = new System.Drawing.Size(78, 27);
            this.btnCallHist.TabIndex = 9;
            this.btnCallHist.Text = "Call History";
            this.btnCallHist.UseVisualStyleBackColor = true;
            this.btnCallHist.Click += new System.EventHandler(this.btnCallHist_Click);
            // 
            // btnNewTk
            // 
            this.btnNewTk.Location = new System.Drawing.Point(109, 179);
            this.btnNewTk.Name = "btnNewTk";
            this.btnNewTk.Size = new System.Drawing.Size(78, 27);
            this.btnNewTk.TabIndex = 9;
            this.btnNewTk.Text = "New Ticket";
            this.btnNewTk.UseVisualStyleBackColor = true;
            this.btnNewTk.Click += new System.EventHandler(this.btnNewTk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 463);
            this.Controls.Add(this.btnNewTk);
            this.Controls.Add(this.btnCallHist);
            this.Controls.Add(this.dgvStores);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelProvince);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelStore);
            this.Controls.Add(this.UserInputCity);
            this.Controls.Add(this.UserInputProvince);
            this.Controls.Add(this.UserInputStore);
            this.Name = "Form1";
            this.Text = "Ticket System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputStore;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox UserInputProvince;
        private System.Windows.Forms.TextBox UserInputCity;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        /// <summary>
        /// Data Grid View of the Stores Information saved into the database
        /// </summary>
        private System.Windows.Forms.DataGridView dgvStores;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Province;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.Button btnCallHist;
        private System.Windows.Forms.Button btnNewTk;
    }
}

