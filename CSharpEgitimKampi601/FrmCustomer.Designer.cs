namespace CSharpEgitimKampi601
{
	partial class FrmCustomer
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
			this.btnById = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.txtCustomerCity = new System.Windows.Forms.TextBox();
			this.lblCustomerCity = new System.Windows.Forms.Label();
			this.txtCustomerSurname = new System.Windows.Forms.TextBox();
			this.lblCustomerSurname = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.lblCustomerID = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnById
			// 
			this.btnById.BackColor = System.Drawing.Color.LightCoral;
			this.btnById.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnById.Location = new System.Drawing.Point(161, 482);
			this.btnById.Name = "btnById";
			this.btnById.Size = new System.Drawing.Size(217, 41);
			this.btnById.TabIndex = 35;
			this.btnById.Text = "ID\'YE GÖRE GETİR";
			this.btnById.UseVisualStyleBackColor = false;
			this.btnById.Click += new System.EventHandler(this.btnById_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(550, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(794, 525);
			this.dataGridView1.TabIndex = 34;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(161, 435);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(217, 41);
			this.btnDelete.TabIndex = 33;
			this.btnDelete.Text = "SİL";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.LightCoral;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(161, 388);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(217, 41);
			this.btnUpdate.TabIndex = 32;
			this.btnUpdate.Text = "GÜNCELLE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.LightCoral;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAdd.Location = new System.Drawing.Point(161, 341);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(217, 41);
			this.btnAdd.TabIndex = 31;
			this.btnAdd.Text = "EKLE";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.Color.LightCoral;
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(161, 294);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(217, 41);
			this.btnList.TabIndex = 30;
			this.btnList.Text = "LİSTELE";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtCustomerCity
			// 
			this.txtCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerCity.Location = new System.Drawing.Point(208, 221);
			this.txtCustomerCity.Name = "txtCustomerCity";
			this.txtCustomerCity.Size = new System.Drawing.Size(274, 27);
			this.txtCustomerCity.TabIndex = 25;
			// 
			// lblCustomerCity
			// 
			this.lblCustomerCity.AutoSize = true;
			this.lblCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCustomerCity.Location = new System.Drawing.Point(47, 221);
			this.lblCustomerCity.Name = "lblCustomerCity";
			this.lblCustomerCity.Size = new System.Drawing.Size(128, 20);
			this.lblCustomerCity.TabIndex = 24;
			this.lblCustomerCity.Text = "Müşteri Şehri:";
			// 
			// txtCustomerSurname
			// 
			this.txtCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerSurname.Location = new System.Drawing.Point(208, 160);
			this.txtCustomerSurname.Name = "txtCustomerSurname";
			this.txtCustomerSurname.Size = new System.Drawing.Size(274, 27);
			this.txtCustomerSurname.TabIndex = 23;
			// 
			// lblCustomerSurname
			// 
			this.lblCustomerSurname.AutoSize = true;
			this.lblCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCustomerSurname.Location = new System.Drawing.Point(47, 160);
			this.lblCustomerSurname.Name = "lblCustomerSurname";
			this.lblCustomerSurname.Size = new System.Drawing.Size(140, 20);
			this.lblCustomerSurname.TabIndex = 22;
			this.lblCustomerSurname.Text = "Müşteri Soyadı:";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerName.Location = new System.Drawing.Point(208, 105);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(274, 27);
			this.txtCustomerName.TabIndex = 21;
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.AutoSize = true;
			this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCustomerName.Location = new System.Drawing.Point(47, 105);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(111, 20);
			this.lblCustomerName.TabIndex = 20;
			this.lblCustomerName.Text = "Müşteri Adı:";
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerID.Location = new System.Drawing.Point(208, 46);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.Size = new System.Drawing.Size(274, 27);
			this.txtCustomerID.TabIndex = 19;
			// 
			// lblCustomerID
			// 
			this.lblCustomerID.AutoSize = true;
			this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCustomerID.Location = new System.Drawing.Point(47, 46);
			this.lblCustomerID.Name = "lblCustomerID";
			this.lblCustomerID.Size = new System.Drawing.Size(103, 20);
			this.lblCustomerID.TabIndex = 18;
			this.lblCustomerID.Text = "Müşteri ID:";
			// 
			// FrmCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1381, 600);
			this.Controls.Add(this.btnById);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtCustomerCity);
			this.Controls.Add(this.lblCustomerCity);
			this.Controls.Add(this.txtCustomerSurname);
			this.Controls.Add(this.lblCustomerSurname);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.lblCustomerName);
			this.Controls.Add(this.txtCustomerID);
			this.Controls.Add(this.lblCustomerID);
			this.Name = "FrmCustomer";
			this.Text = "FrmCustomer";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnById;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtCustomerCity;
		private System.Windows.Forms.Label lblCustomerCity;
		private System.Windows.Forms.TextBox txtCustomerSurname;
		private System.Windows.Forms.Label lblCustomerSurname;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Label lblCustomerName;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.Label lblCustomerID;
	}
}