namespace IT481_Unit2_Crooks
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtMessageText = new System.Windows.Forms.RichTextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radCustomers = new System.Windows.Forms.RadioButton();
            this.radOrders = new System.Windows.Forms.RadioButton();
            this.radEmployees = new System.Windows.Forms.RadioButton();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new IT481_Unit2_Crooks.DataSet1();
            this.customersTableAdapter = new IT481_Unit2_Crooks.DataSet1TableAdapters.CustomersTableAdapter();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new IT481_Unit2_Crooks.DataSet1TableAdapters.OrdersTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new IT481_Unit2_Crooks.DataSet1TableAdapters.EmployeesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(62, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 35);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Insert Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(176, 178);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 16);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(91, 198);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(108, 16);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "Company Name:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(205, 175);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 4;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(205, 200);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(100, 22);
            this.txtCompany.TabIndex = 5;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(564, 156);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(137, 35);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Count Records";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtMessageText
            // 
            this.txtMessageText.Location = new System.Drawing.Point(115, 54);
            this.txtMessageText.Name = "txtMessageText";
            this.txtMessageText.Size = new System.Drawing.Size(586, 96);
            this.txtMessageText.TabIndex = 7;
            this.txtMessageText.Text = "Click a button below to get started...";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(343, 523);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(137, 36);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View Database";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radCustomers
            // 
            this.radCustomers.AutoSize = true;
            this.radCustomers.Location = new System.Drawing.Point(565, 265);
            this.radCustomers.Name = "radCustomers";
            this.radCustomers.Size = new System.Drawing.Size(131, 20);
            this.radCustomers.TabIndex = 10;
            this.radCustomers.TabStop = true;
            this.radCustomers.Text = "Customers Table";
            this.radCustomers.UseVisualStyleBackColor = true;
            // 
            // radOrders
            // 
            this.radOrders.AutoSize = true;
            this.radOrders.Location = new System.Drawing.Point(565, 291);
            this.radOrders.Name = "radOrders";
            this.radOrders.Size = new System.Drawing.Size(108, 20);
            this.radOrders.TabIndex = 11;
            this.radOrders.TabStop = true;
            this.radOrders.Text = "Orders Table";
            this.radOrders.UseVisualStyleBackColor = true;
            // 
            // radEmployees
            // 
            this.radEmployees.AutoSize = true;
            this.radEmployees.Location = new System.Drawing.Point(565, 317);
            this.radEmployees.Name = "radEmployees";
            this.radEmployees.Size = new System.Drawing.Size(136, 20);
            this.radEmployees.TabIndex = 12;
            this.radEmployees.TabStop = true;
            this.radEmployees.Text = "Employees Table";
            this.radEmployees.UseVisualStyleBackColor = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // customersBindingSource2
            // 
            this.customersBindingSource2.DataMember = "Customers";
            this.customersBindingSource2.DataSource = this.dataSet1;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.dataSet1;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.dataSet1;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(215, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(385, 36);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "Welcome to the Database!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radEmployees);
            this.Controls.Add(this.radOrders);
            this.Controls.Add(this.radCustomers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtMessageText);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Form1";
            this.Text = "Northwind Frontend";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DataSet1TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.RichTextBox txtMessageText;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radCustomers;
        private System.Windows.Forms.RadioButton radOrders;
        private System.Windows.Forms.RadioButton radEmployees;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private System.Windows.Forms.BindingSource customersBindingSource2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private DataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUser;
    }
}

