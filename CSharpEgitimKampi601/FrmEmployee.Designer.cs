namespace CSharpEgitimKampi601
{
	partial class FrmEmployee
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
			this.txtSalary = new System.Windows.Forms.TextBox();
			this.lblSalary = new System.Windows.Forms.Label();
			this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
			this.lblEmployeeSurname = new System.Windows.Forms.Label();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.lblEmployeeName = new System.Windows.Forms.Label();
			this.txtEmployeeID = new System.Windows.Forms.TextBox();
			this.lblEmployeeID = new System.Windows.Forms.Label();
			this.lblDepartment = new System.Windows.Forms.Label();
			this.cmbDepartments = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnById
			// 
			this.btnById.BackColor = System.Drawing.Color.Yellow;
			this.btnById.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnById.Location = new System.Drawing.Point(138, 512);
			this.btnById.Name = "btnById";
			this.btnById.Size = new System.Drawing.Size(217, 41);
			this.btnById.TabIndex = 49;
			this.btnById.Text = "ID\'YE GÖRE GETİR";
			this.btnById.UseVisualStyleBackColor = false;
			this.btnById.Click += new System.EventHandler(this.btnById_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(526, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(794, 525);
			this.dataGridView1.TabIndex = 48;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Yellow;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(138, 465);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(217, 41);
			this.btnDelete.TabIndex = 47;
			this.btnDelete.Text = "SİL";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(138, 418);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(217, 41);
			this.btnUpdate.TabIndex = 46;
			this.btnUpdate.Text = "GÜNCELLE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Yellow;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAdd.Location = new System.Drawing.Point(138, 371);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(217, 41);
			this.btnAdd.TabIndex = 45;
			this.btnAdd.Text = "EKLE";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.Color.Yellow;
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(138, 324);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(217, 41);
			this.btnList.TabIndex = 44;
			this.btnList.Text = "LİSTELE";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtSalary
			// 
			this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSalary.Location = new System.Drawing.Point(184, 221);
			this.txtSalary.Name = "txtSalary";
			this.txtSalary.Size = new System.Drawing.Size(274, 27);
			this.txtSalary.TabIndex = 43;
			// 
			// lblSalary
			// 
			this.lblSalary.AutoSize = true;
			this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSalary.Location = new System.Drawing.Point(23, 221);
			this.lblSalary.Name = "lblSalary";
			this.lblSalary.Size = new System.Drawing.Size(145, 20);
			this.lblSalary.TabIndex = 42;
			this.lblSalary.Text = "Personel Maaşı:";
			// 
			// txtEmployeeSurname
			// 
			this.txtEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmployeeSurname.Location = new System.Drawing.Point(184, 160);
			this.txtEmployeeSurname.Name = "txtEmployeeSurname";
			this.txtEmployeeSurname.Size = new System.Drawing.Size(274, 27);
			this.txtEmployeeSurname.TabIndex = 41;
			// 
			// lblEmployeeSurname
			// 
			this.lblEmployeeSurname.AutoSize = true;
			this.lblEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblEmployeeSurname.Location = new System.Drawing.Point(23, 160);
			this.lblEmployeeSurname.Name = "lblEmployeeSurname";
			this.lblEmployeeSurname.Size = new System.Drawing.Size(151, 20);
			this.lblEmployeeSurname.TabIndex = 40;
			this.lblEmployeeSurname.Text = "Personel Soyadı:";
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmployeeName.Location = new System.Drawing.Point(184, 105);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.Size = new System.Drawing.Size(274, 27);
			this.txtEmployeeName.TabIndex = 39;
			// 
			// lblEmployeeName
			// 
			this.lblEmployeeName.AutoSize = true;
			this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblEmployeeName.Location = new System.Drawing.Point(23, 105);
			this.lblEmployeeName.Name = "lblEmployeeName";
			this.lblEmployeeName.Size = new System.Drawing.Size(122, 20);
			this.lblEmployeeName.TabIndex = 38;
			this.lblEmployeeName.Text = "Personel Adı:";
			// 
			// txtEmployeeID
			// 
			this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmployeeID.Location = new System.Drawing.Point(184, 46);
			this.txtEmployeeID.Name = "txtEmployeeID";
			this.txtEmployeeID.Size = new System.Drawing.Size(274, 27);
			this.txtEmployeeID.TabIndex = 37;
			// 
			// lblEmployeeID
			// 
			this.lblEmployeeID.AutoSize = true;
			this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblEmployeeID.Location = new System.Drawing.Point(23, 46);
			this.lblEmployeeID.Name = "lblEmployeeID";
			this.lblEmployeeID.Size = new System.Drawing.Size(114, 20);
			this.lblEmployeeID.TabIndex = 36;
			this.lblEmployeeID.Text = "Personel ID:";
			// 
			// lblDepartment
			// 
			this.lblDepartment.AutoSize = true;
			this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDepartment.Location = new System.Drawing.Point(23, 280);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(107, 20);
			this.lblDepartment.TabIndex = 50;
			this.lblDepartment.Text = "Departman:";
			// 
			// cmbDepartments
			// 
			this.cmbDepartments.FormattingEnabled = true;
			this.cmbDepartments.Location = new System.Drawing.Point(184, 280);
			this.cmbDepartments.Name = "cmbDepartments";
			this.cmbDepartments.Size = new System.Drawing.Size(274, 24);
			this.cmbDepartments.TabIndex = 51;
			// 
			// FrmEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(1342, 597);
			this.Controls.Add(this.cmbDepartments);
			this.Controls.Add(this.lblDepartment);
			this.Controls.Add(this.btnById);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtSalary);
			this.Controls.Add(this.lblSalary);
			this.Controls.Add(this.txtEmployeeSurname);
			this.Controls.Add(this.lblEmployeeSurname);
			this.Controls.Add(this.txtEmployeeName);
			this.Controls.Add(this.lblEmployeeName);
			this.Controls.Add(this.txtEmployeeID);
			this.Controls.Add(this.lblEmployeeID);
			this.Name = "FrmEmployee";
			this.Text = "FrmEmployee";
			this.Load += new System.EventHandler(this.FrmEmployee_Load);
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
		private System.Windows.Forms.TextBox txtSalary;
		private System.Windows.Forms.Label lblSalary;
		private System.Windows.Forms.TextBox txtEmployeeSurname;
		private System.Windows.Forms.Label lblEmployeeSurname;
		private System.Windows.Forms.TextBox txtEmployeeName;
		private System.Windows.Forms.Label lblEmployeeName;
		private System.Windows.Forms.TextBox txtEmployeeID;
		private System.Windows.Forms.Label lblEmployeeID;
		private System.Windows.Forms.Label lblDepartment;
		private System.Windows.Forms.ComboBox cmbDepartments;
	}
}