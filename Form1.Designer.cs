namespace BONILLA_SchoolSupplyStore
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tabSupplyStore = new TabControl();
            tabStudents = new TabPage();
            txtSID = new TextBox();
            label22 = new Label();
            dataStudents = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            studID = new DataGridViewTextBoxColumn();
            lastname = new DataGridViewTextBoxColumn();
            firstname = new DataGridViewTextBoxColumn();
            middlename = new DataGridViewTextBoxColumn();
            course = new DataGridViewTextBoxColumn();
            college = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnAdd = new Button();
            txtCollege = new TextBox();
            txtCourse = new TextBox();
            txtMname = new TextBox();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtStudentID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabSupplies = new TabPage();
            label23 = new Label();
            txtIID = new TextBox();
            dataItems = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            itemID = new DataGridViewTextBoxColumn();
            itemname = new DataGridViewTextBoxColumn();
            itemprice = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            label15 = new Label();
            btnEnter = new Button();
            label14 = new Label();
            txtItemprice = new TextBox();
            label12 = new Label();
            txtItemname = new TextBox();
            label10 = new Label();
            txtItemID = new TextBox();
            tabPurchasing = new TabPage();
            txtSelectedPurchase = new TextBox();
            btnInvalidate = new Button();
            txtQuantity = new TextBox();
            label18 = new Label();
            txtSelectedItemID = new TextBox();
            txtSelectedStudentID = new TextBox();
            dataItems2 = new DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataStudents2 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            label17 = new Label();
            label16 = new Label();
            label13 = new Label();
            dataPurchase = new DataGridView();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            itemquantity = new DataGridViewTextBoxColumn();
            purchaseDate = new DataGridViewTextBoxColumn();
            label11 = new Label();
            btnRegister = new Button();
            label9 = new Label();
            tabSupplyStore.SuspendLayout();
            tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataStudents).BeginInit();
            tabSupplies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataItems).BeginInit();
            tabPurchasing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataItems2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataStudents2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataPurchase).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(505, 74);
            label1.TabIndex = 0;
            label1.Text = "School Supply Store";
            label1.Click += label1_Click;
            // 
            // tabSupplyStore
            // 
            tabSupplyStore.Controls.Add(tabStudents);
            tabSupplyStore.Controls.Add(tabSupplies);
            tabSupplyStore.Controls.Add(tabPurchasing);
            tabSupplyStore.Location = new Point(12, 86);
            tabSupplyStore.Name = "tabSupplyStore";
            tabSupplyStore.SelectedIndex = 0;
            tabSupplyStore.Size = new Size(1372, 937);
            tabSupplyStore.TabIndex = 1;
            // 
            // tabStudents
            // 
            tabStudents.Controls.Add(txtSID);
            tabStudents.Controls.Add(label22);
            tabStudents.Controls.Add(dataStudents);
            tabStudents.Controls.Add(btnEdit);
            tabStudents.Controls.Add(btnAdd);
            tabStudents.Controls.Add(txtCollege);
            tabStudents.Controls.Add(txtCourse);
            tabStudents.Controls.Add(txtMname);
            tabStudents.Controls.Add(txtFname);
            tabStudents.Controls.Add(txtLname);
            tabStudents.Controls.Add(txtStudentID);
            tabStudents.Controls.Add(label8);
            tabStudents.Controls.Add(label7);
            tabStudents.Controls.Add(label6);
            tabStudents.Controls.Add(label5);
            tabStudents.Controls.Add(label4);
            tabStudents.Controls.Add(label3);
            tabStudents.Controls.Add(label2);
            tabStudents.Location = new Point(4, 24);
            tabStudents.Name = "tabStudents";
            tabStudents.Padding = new Padding(3);
            tabStudents.Size = new Size(1364, 909);
            tabStudents.TabIndex = 0;
            tabStudents.Text = "STUDENTS";
            tabStudents.UseVisualStyleBackColor = true;
            // 
            // txtSID
            // 
            txtSID.Enabled = false;
            txtSID.Location = new Point(6, 113);
            txtSID.Name = "txtSID";
            txtSID.Size = new Size(139, 23);
            txtSID.TabIndex = 17;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(6, 78);
            label22.Name = "label22";
            label22.Size = new Size(57, 32);
            label22.TabIndex = 16;
            label22.Text = "I.D.:";
            // 
            // dataStudents
            // 
            dataStudents.AllowUserToAddRows = false;
            dataStudents.AllowUserToDeleteRows = false;
            dataStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataStudents.Columns.AddRange(new DataGridViewColumn[] { ID, studID, lastname, firstname, middlename, course, college });
            dataStudents.Location = new Point(432, 15);
            dataStudents.Name = "dataStudents";
            dataStudents.ReadOnly = true;
            dataStudents.RowTemplate.Height = 25;
            dataStudents.Size = new Size(926, 888);
            dataStudents.TabIndex = 15;
            dataStudents.SelectionChanged += dataStudents_SelectionChanged;
            // 
            // ID
            // 
            ID.HeaderText = "I.D.";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // studID
            // 
            studID.HeaderText = "Student I.D.";
            studID.Name = "studID";
            studID.ReadOnly = true;
            // 
            // lastname
            // 
            lastname.HeaderText = "Last Name";
            lastname.Name = "lastname";
            lastname.ReadOnly = true;
            lastname.Width = 150;
            // 
            // firstname
            // 
            firstname.HeaderText = "First Name";
            firstname.Name = "firstname";
            firstname.ReadOnly = true;
            firstname.Width = 150;
            // 
            // middlename
            // 
            middlename.HeaderText = "Middle Name";
            middlename.Name = "middlename";
            middlename.ReadOnly = true;
            middlename.Width = 150;
            // 
            // course
            // 
            course.HeaderText = "Course";
            course.Name = "course";
            course.ReadOnly = true;
            course.Width = 125;
            // 
            // college
            // 
            college.HeaderText = "College";
            college.Name = "college";
            college.ReadOnly = true;
            college.Width = 125;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Tw Cen MT Condensed Extra Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(226, 714);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(181, 93);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Tw Cen MT Condensed Extra Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(20, 714);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(181, 93);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCollege
            // 
            txtCollege.Location = new Point(6, 668);
            txtCollege.Name = "txtCollege";
            txtCollege.Size = new Size(296, 23);
            txtCollege.TabIndex = 12;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(6, 571);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(296, 23);
            txtCourse.TabIndex = 11;
            // 
            // txtMname
            // 
            txtMname.Location = new Point(6, 480);
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(296, 23);
            txtMname.TabIndex = 10;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(6, 381);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(296, 23);
            txtFname.TabIndex = 9;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(6, 288);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(296, 23);
            txtLname.TabIndex = 8;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(6, 200);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(296, 23);
            txtStudentID.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 633);
            label8.Name = "label8";
            label8.Size = new Size(94, 32);
            label8.TabIndex = 6;
            label8.Text = "College:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 536);
            label7.Name = "label7";
            label7.Size = new Size(89, 32);
            label7.TabIndex = 5;
            label7.Text = "Course:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 445);
            label6.Name = "label6";
            label6.Size = new Size(241, 32);
            label6.TabIndex = 4;
            label6.Text = "Student Middle Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 346);
            label5.Name = "label5";
            label5.Size = new Size(213, 32);
            label5.TabIndex = 3;
            label5.Text = "Student First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 253);
            label4.Name = "label4";
            label4.Size = new Size(210, 32);
            label4.TabIndex = 2;
            label4.Text = "Student Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 165);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 1;
            label3.Text = "Student I.D.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT Condensed Extra Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 15);
            label2.Name = "label2";
            label2.Size = new Size(285, 48);
            label2.TabIndex = 0;
            label2.Text = "STUDENT DETAILS";
            // 
            // tabSupplies
            // 
            tabSupplies.Controls.Add(label23);
            tabSupplies.Controls.Add(txtIID);
            tabSupplies.Controls.Add(dataItems);
            tabSupplies.Controls.Add(btnSave);
            tabSupplies.Controls.Add(label15);
            tabSupplies.Controls.Add(btnEnter);
            tabSupplies.Controls.Add(label14);
            tabSupplies.Controls.Add(txtItemprice);
            tabSupplies.Controls.Add(label12);
            tabSupplies.Controls.Add(txtItemname);
            tabSupplies.Controls.Add(label10);
            tabSupplies.Controls.Add(txtItemID);
            tabSupplies.Location = new Point(4, 24);
            tabSupplies.Name = "tabSupplies";
            tabSupplies.Padding = new Padding(3);
            tabSupplies.Size = new Size(1364, 909);
            tabSupplies.TabIndex = 1;
            tabSupplies.Text = "SCHOOL SUPPLIES";
            tabSupplies.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(6, 136);
            label23.Name = "label23";
            label23.Size = new Size(57, 32);
            label23.TabIndex = 32;
            label23.Text = "I.D.:";
            // 
            // txtIID
            // 
            txtIID.Enabled = false;
            txtIID.Location = new Point(6, 171);
            txtIID.Name = "txtIID";
            txtIID.Size = new Size(134, 23);
            txtIID.TabIndex = 33;
            // 
            // dataItems
            // 
            dataItems.AllowUserToAddRows = false;
            dataItems.AllowUserToDeleteRows = false;
            dataItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataItems.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, itemID, itemname, itemprice });
            dataItems.Location = new Point(432, 18);
            dataItems.Name = "dataItems";
            dataItems.ReadOnly = true;
            dataItems.RowTemplate.Height = 25;
            dataItems.Size = new Size(926, 885);
            dataItems.TabIndex = 31;
            dataItems.CellContentClick += dataItems_CellContentClick;
            dataItems.SelectionChanged += dataItems_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "I.D.";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // itemID
            // 
            itemID.HeaderText = "Item I.D. ";
            itemID.Name = "itemID";
            itemID.ReadOnly = true;
            itemID.Width = 125;
            // 
            // itemname
            // 
            itemname.HeaderText = "Item Name";
            itemname.Name = "itemname";
            itemname.ReadOnly = true;
            itemname.Width = 400;
            // 
            // itemprice
            // 
            itemprice.HeaderText = "Item Price";
            itemprice.Name = "itemprice";
            itemprice.ReadOnly = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tw Cen MT Condensed Extra Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(224, 542);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(181, 93);
            btnSave.TabIndex = 30;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tw Cen MT Condensed Extra Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(84, 18);
            label15.Name = "label15";
            label15.Size = new Size(290, 48);
            label15.TabIndex = 16;
            label15.Text = "SCHOOL SUPPLIES";
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Tw Cen MT Condensed Extra Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnter.Location = new Point(23, 542);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(181, 93);
            btnEnter.TabIndex = 29;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(6, 238);
            label14.Name = "label14";
            label14.Size = new Size(109, 32);
            label14.TabIndex = 17;
            label14.Text = "Item I.D.:";
            // 
            // txtItemprice
            // 
            txtItemprice.Location = new Point(6, 483);
            txtItemprice.Name = "txtItemprice";
            txtItemprice.Size = new Size(296, 23);
            txtItemprice.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(6, 340);
            label12.Name = "label12";
            label12.Size = new Size(134, 32);
            label12.TabIndex = 19;
            label12.Text = "Item Name:";
            // 
            // txtItemname
            // 
            txtItemname.Location = new Point(6, 375);
            txtItemname.Name = "txtItemname";
            txtItemname.Size = new Size(296, 23);
            txtItemname.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(6, 448);
            label10.Name = "label10";
            label10.Size = new Size(123, 32);
            label10.TabIndex = 21;
            label10.Text = "Item Price:";
            // 
            // txtItemID
            // 
            txtItemID.Location = new Point(6, 273);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(296, 23);
            txtItemID.TabIndex = 23;
            // 
            // tabPurchasing
            // 
            tabPurchasing.Controls.Add(txtSelectedPurchase);
            tabPurchasing.Controls.Add(btnInvalidate);
            tabPurchasing.Controls.Add(txtQuantity);
            tabPurchasing.Controls.Add(label18);
            tabPurchasing.Controls.Add(txtSelectedItemID);
            tabPurchasing.Controls.Add(txtSelectedStudentID);
            tabPurchasing.Controls.Add(dataItems2);
            tabPurchasing.Controls.Add(dataStudents2);
            tabPurchasing.Controls.Add(label17);
            tabPurchasing.Controls.Add(label16);
            tabPurchasing.Controls.Add(label13);
            tabPurchasing.Controls.Add(dataPurchase);
            tabPurchasing.Controls.Add(label11);
            tabPurchasing.Controls.Add(btnRegister);
            tabPurchasing.Controls.Add(label9);
            tabPurchasing.Location = new Point(4, 24);
            tabPurchasing.Name = "tabPurchasing";
            tabPurchasing.Padding = new Padding(3);
            tabPurchasing.Size = new Size(1364, 909);
            tabPurchasing.TabIndex = 2;
            tabPurchasing.Text = "PURCHASING DETAILS";
            tabPurchasing.UseVisualStyleBackColor = true;
            // 
            // txtSelectedPurchase
            // 
            txtSelectedPurchase.Location = new Point(1229, 842);
            txtSelectedPurchase.Name = "txtSelectedPurchase";
            txtSelectedPurchase.Size = new Size(112, 23);
            txtSelectedPurchase.TabIndex = 46;
            // 
            // btnInvalidate
            // 
            btnInvalidate.Font = new Font("Tw Cen MT Condensed Extra Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvalidate.Location = new Point(1181, 67);
            btnInvalidate.Name = "btnInvalidate";
            btnInvalidate.Size = new Size(160, 49);
            btnInvalidate.TabIndex = 45;
            btnInvalidate.Text = "Invalidate";
            btnInvalidate.UseVisualStyleBackColor = true;
            btnInvalidate.Click += btnInvalidate_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(863, 89);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 44;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(710, 84);
            label18.Name = "label18";
            label18.Size = new Size(156, 28);
            label18.TabIndex = 43;
            label18.Text = "Insert Quantity: ";
            // 
            // txtSelectedItemID
            // 
            txtSelectedItemID.Location = new Point(533, 842);
            txtSelectedItemID.Name = "txtSelectedItemID";
            txtSelectedItemID.Size = new Size(112, 23);
            txtSelectedItemID.TabIndex = 42;
            txtSelectedItemID.Visible = false;
            // 
            // txtSelectedStudentID
            // 
            txtSelectedStudentID.Location = new Point(533, 333);
            txtSelectedStudentID.Name = "txtSelectedStudentID";
            txtSelectedStudentID.Size = new Size(112, 23);
            txtSelectedStudentID.TabIndex = 41;
            txtSelectedStudentID.Visible = false;
            // 
            // dataItems2
            // 
            dataItems2.AllowUserToAddRows = false;
            dataItems2.AllowUserToDeleteRows = false;
            dataItems2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataItems2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataItems2.Location = new Point(16, 460);
            dataItems2.Name = "dataItems2";
            dataItems2.ReadOnly = true;
            dataItems2.RowTemplate.Height = 25;
            dataItems2.Size = new Size(662, 433);
            dataItems2.TabIndex = 37;
            dataItems2.SelectionChanged += dataItems2_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "I.D.";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Item I.D.";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Item Name";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 200;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Item Price";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataStudents2
            // 
            dataStudents2.AllowUserToAddRows = false;
            dataStudents2.AllowUserToDeleteRows = false;
            dataStudents2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataStudents2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataStudents2.Location = new Point(16, 47);
            dataStudents2.Name = "dataStudents2";
            dataStudents2.ReadOnly = true;
            dataStudents2.RowTemplate.Height = 25;
            dataStudents2.Size = new Size(662, 354);
            dataStudents2.TabIndex = 36;
            dataStudents2.SelectionChanged += dataStudents2_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "I.D.";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Student I.D. ";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Last Name";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "First Name";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Middle Name";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Course";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "College";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(3, 425);
            label17.Name = "label17";
            label17.Size = new Size(140, 32);
            label17.TabIndex = 35;
            label17.Text = "Select Items:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(0, 393);
            label16.Name = "label16";
            label16.Size = new Size(678, 32);
            label16.TabIndex = 34;
            label16.Text = "-----------------------------------------------------------------------------------";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(6, 12);
            label13.Name = "label13";
            label13.Size = new Size(160, 32);
            label13.TabIndex = 33;
            label13.Text = "Select Student:";
            // 
            // dataPurchase
            // 
            dataPurchase.AllowUserToAddRows = false;
            dataPurchase.AllowUserToDeleteRows = false;
            dataPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPurchase.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, itemquantity, purchaseDate });
            dataPurchase.Location = new Point(710, 122);
            dataPurchase.Name = "dataPurchase";
            dataPurchase.ReadOnly = true;
            dataPurchase.RowTemplate.Height = 25;
            dataPurchase.Size = new Size(648, 771);
            dataPurchase.TabIndex = 32;
            dataPurchase.SelectionChanged += dataPurchase_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "I.D.";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Width = 50;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Student";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Width = 200;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "Item";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            dataGridViewTextBoxColumn15.Width = 150;
            // 
            // itemquantity
            // 
            itemquantity.HeaderText = "Quantity of Purchase";
            itemquantity.Name = "itemquantity";
            itemquantity.ReadOnly = true;
            // 
            // purchaseDate
            // 
            purchaseDate.HeaderText = "Date of Purchase";
            purchaseDate.Name = "purchaseDate";
            purchaseDate.ReadOnly = true;
            purchaseDate.Width = 150;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(674, 3);
            label11.Name = "label11";
            label11.Size = new Size(30, 896);
            label11.TabIndex = 31;
            label11.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Tw Cen MT Condensed Extra Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(989, 67);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(160, 49);
            btnRegister.TabIndex = 30;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT Condensed Extra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(700, 12);
            label9.Name = "label9";
            label9.Size = new Size(238, 32);
            label9.TabIndex = 17;
            label9.Text = "View Purchase Details";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 1033);
            Controls.Add(tabSupplyStore);
            Controls.Add(label1);
            Name = "frmHome";
            Text = "HOME";
            Load += frmHome_Load;
            tabSupplyStore.ResumeLayout(false);
            tabStudents.ResumeLayout(false);
            tabStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataStudents).EndInit();
            tabSupplies.ResumeLayout(false);
            tabSupplies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataItems).EndInit();
            tabPurchasing.ResumeLayout(false);
            tabPurchasing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataItems2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataStudents2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataPurchase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabSupplyStore;
        private TabPage tabStudents;
        private TabPage tabSupplies;
        private TabPage tabPurchasing;
        private DataGridView dataStudents;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtCollege;
        private TextBox txtCourse;
        private TextBox txtMname;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtStudentID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataItems;
        private Button btnSave;
        private Label label15;
        private Button btnEnter;
        private Label label14;
        private TextBox txtItemprice;
        private Label label12;
        private TextBox txtItemname;
        private Label label10;
        private TextBox txtItemID;
        private TextBox txtSelectedItemID;
        private TextBox txtSelectedStudentID;
        private DataGridView dataItems2;
        private DataGridView dataStudents2;
        private Label label17;
        private Label label16;
        private Label label13;
        private DataGridView dataPurchase;
        private Label label11;
        private Button btnRegister;
        private Label label9;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn studID;
        private DataGridViewTextBoxColumn lastname;
        private DataGridViewTextBoxColumn firstname;
        private DataGridViewTextBoxColumn middlename;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn college;
        private TextBox txtSID;
        private Label label22;
        private Label label23;
        private TextBox txtIID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn itemID;
        private DataGridViewTextBoxColumn itemname;
        private DataGridViewTextBoxColumn itemprice;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private TextBox txtQuantity;
        private Label label18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn itemquantity;
        private DataGridViewTextBoxColumn purchaseDate;
        private TextBox txtSelectedPurchase;
        private Button btnInvalidate;
    }
}