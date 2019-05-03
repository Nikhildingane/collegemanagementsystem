<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Finance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.side = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbusername = New System.Windows.Forms.Label()
        Me.lbdepartment = New System.Windows.Forms.Label()
        Me.btn_report_salary = New System.Windows.Forms.Button()
        Me.btn_report_fees = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.sp_esp = New System.Windows.Forms.Panel()
        Me.sp_vsf = New System.Windows.Forms.Panel()
        Me.sp_fc = New System.Windows.Forms.Panel()
        Me.fin_btn_esp = New System.Windows.Forms.Button()
        Me.fin_btn_vsf = New System.Windows.Forms.Button()
        Me.fin_btn_fc = New System.Windows.Forms.Button()
        Me.FinanceFeeCollection = New System.Windows.Forms.Panel()
        Me.fc_tb_fee_to_pay = New System.Windows.Forms.TextBox()
        Me.fc_tb_student_mn = New System.Windows.Forms.TextBox()
        Me.fc_tb_course_fee = New System.Windows.Forms.TextBox()
        Me.fc_tb_remaining_fee = New System.Windows.Forms.TextBox()
        Me.fc_tb_paid_fee = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.fc_btn_search = New System.Windows.Forms.Button()
        Me.fc_btn_clear = New System.Windows.Forms.Button()
        Me.fc_btn_collect = New System.Windows.Forms.Button()
        Me.fc_tb_student_course_year = New System.Windows.Forms.TextBox()
        Me.fc_tb_student_course = New System.Windows.Forms.TextBox()
        Me.fc_tb_fee_date = New System.Windows.Forms.TextBox()
        Me.fc_tb_student_dept = New System.Windows.Forms.TextBox()
        Me.fc_tb_student_ln = New System.Windows.Forms.TextBox()
        Me.fc_tb_student_id = New System.Windows.Forms.TextBox()
        Me.fc_tb_student_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.FinanceViewStudentFees = New System.Windows.Forms.Panel()
        Me.pf_btn_search = New System.Windows.Forms.Button()
        Me.pf_btn_reset = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pf_cb_course_year = New System.Windows.Forms.ComboBox()
        Me.pf_cb_course = New System.Windows.Forms.ComboBox()
        Me.pf_cb_dept = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pf_cb_year = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pf_dg = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FinanceEmployeeFacultySalaryPayment = New System.Windows.Forms.Panel()
        Me.es_tb_leaves = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.es_tb_salary_month = New System.Windows.Forms.TextBox()
        Me.es_tb_emp_phone = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.es_btn_search = New System.Windows.Forms.Button()
        Me.es_tb_emp_mn = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.es_tb_emp_ln = New System.Windows.Forms.TextBox()
        Me.es_btn_pay = New System.Windows.Forms.Button()
        Me.es_btn_reset = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.es_tb_salary = New System.Windows.Forms.TextBox()
        Me.es_tb_salary_date = New System.Windows.Forms.TextBox()
        Me.es_tb_emp_name = New System.Windows.Forms.TextBox()
        Me.es_tb_emp_id = New System.Windows.Forms.TextBox()
        Me.side.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FinanceFeeCollection.SuspendLayout()
        Me.FinanceViewStudentFees.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pf_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FinanceEmployeeFacultySalaryPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'side
        '
        Me.side.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.side.Controls.Add(Me.PictureBox1)
        Me.side.Controls.Add(Me.Label4)
        Me.side.Controls.Add(Me.Label14)
        Me.side.Controls.Add(Me.lbusername)
        Me.side.Controls.Add(Me.lbdepartment)
        Me.side.Controls.Add(Me.btn_report_salary)
        Me.side.Controls.Add(Me.btn_report_fees)
        Me.side.Controls.Add(Me.LinkLabel1)
        Me.side.Controls.Add(Me.sp_esp)
        Me.side.Controls.Add(Me.sp_vsf)
        Me.side.Controls.Add(Me.sp_fc)
        Me.side.Controls.Add(Me.fin_btn_esp)
        Me.side.Controls.Add(Me.fin_btn_vsf)
        Me.side.Controls.Add(Me.fin_btn_fc)
        Me.side.Dock = System.Windows.Forms.DockStyle.Left
        Me.side.Location = New System.Drawing.Point(0, 0)
        Me.side.Name = "side"
        Me.side.Size = New System.Drawing.Size(338, 562)
        Me.side.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.CMS.My.Resources.Resources.et_line_e040_0__10242
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Global.CMS.My.Resources.Resources.et_line_e040_0__10242
        Me.PictureBox1.Image = Global.CMS.My.Resources.Resources.et_line_e040_0__10242
        Me.PictureBox1.Location = New System.Drawing.Point(104, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 115)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(26, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Username :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(15, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 20)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Department :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbusername
        '
        Me.lbusername.AutoSize = True
        Me.lbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbusername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbusername.Location = New System.Drawing.Point(135, 161)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(66, 20)
        Me.lbusername.TabIndex = 31
        Me.lbusername.Text = "Label31"
        Me.lbusername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbdepartment
        '
        Me.lbdepartment.AutoSize = True
        Me.lbdepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdepartment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbdepartment.Location = New System.Drawing.Point(135, 127)
        Me.lbdepartment.Name = "lbdepartment"
        Me.lbdepartment.Size = New System.Drawing.Size(66, 20)
        Me.lbdepartment.TabIndex = 29
        Me.lbdepartment.Text = "Label30"
        Me.lbdepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_report_salary
        '
        Me.btn_report_salary.FlatAppearance.BorderSize = 0
        Me.btn_report_salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_report_salary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_report_salary.ForeColor = System.Drawing.Color.White
        Me.btn_report_salary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_report_salary.Location = New System.Drawing.Point(4, 446)
        Me.btn_report_salary.Name = "btn_report_salary"
        Me.btn_report_salary.Size = New System.Drawing.Size(331, 60)
        Me.btn_report_salary.TabIndex = 27
        Me.btn_report_salary.Text = "Salary Report"
        Me.btn_report_salary.UseVisualStyleBackColor = True
        '
        'btn_report_fees
        '
        Me.btn_report_fees.FlatAppearance.BorderSize = 0
        Me.btn_report_fees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_report_fees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_report_fees.ForeColor = System.Drawing.Color.White
        Me.btn_report_fees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_report_fees.Location = New System.Drawing.Point(4, 386)
        Me.btn_report_fees.Name = "btn_report_fees"
        Me.btn_report_fees.Size = New System.Drawing.Size(331, 60)
        Me.btn_report_fees.TabIndex = 26
        Me.btn_report_fees.Text = "Fee Report"
        Me.btn_report_fees.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(251, 525)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 20)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Logout"
        '
        'sp_esp
        '
        Me.sp_esp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.sp_esp.Location = New System.Drawing.Point(333, 325)
        Me.sp_esp.Name = "sp_esp"
        Me.sp_esp.Size = New System.Drawing.Size(5, 60)
        Me.sp_esp.TabIndex = 20
        Me.sp_esp.Visible = False
        '
        'sp_vsf
        '
        Me.sp_vsf.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.sp_vsf.Location = New System.Drawing.Point(333, 263)
        Me.sp_vsf.Name = "sp_vsf"
        Me.sp_vsf.Size = New System.Drawing.Size(5, 60)
        Me.sp_vsf.TabIndex = 20
        Me.sp_vsf.Visible = False
        '
        'sp_fc
        '
        Me.sp_fc.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.sp_fc.Location = New System.Drawing.Point(333, 201)
        Me.sp_fc.Name = "sp_fc"
        Me.sp_fc.Size = New System.Drawing.Size(5, 60)
        Me.sp_fc.TabIndex = 20
        '
        'fin_btn_esp
        '
        Me.fin_btn_esp.FlatAppearance.BorderSize = 0
        Me.fin_btn_esp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fin_btn_esp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fin_btn_esp.ForeColor = System.Drawing.Color.White
        Me.fin_btn_esp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.fin_btn_esp.Location = New System.Drawing.Point(1, 324)
        Me.fin_btn_esp.Name = "fin_btn_esp"
        Me.fin_btn_esp.Size = New System.Drawing.Size(336, 62)
        Me.fin_btn_esp.TabIndex = 0
        Me.fin_btn_esp.Text = "Employee Salary Payment"
        Me.fin_btn_esp.UseVisualStyleBackColor = True
        '
        'fin_btn_vsf
        '
        Me.fin_btn_vsf.FlatAppearance.BorderSize = 0
        Me.fin_btn_vsf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fin_btn_vsf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fin_btn_vsf.ForeColor = System.Drawing.Color.White
        Me.fin_btn_vsf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.fin_btn_vsf.Location = New System.Drawing.Point(1, 262)
        Me.fin_btn_vsf.Name = "fin_btn_vsf"
        Me.fin_btn_vsf.Size = New System.Drawing.Size(336, 62)
        Me.fin_btn_vsf.TabIndex = 0
        Me.fin_btn_vsf.Text = "View Pending Student Fees"
        Me.fin_btn_vsf.UseVisualStyleBackColor = True
        '
        'fin_btn_fc
        '
        Me.fin_btn_fc.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.fin_btn_fc.Cursor = System.Windows.Forms.Cursors.Default
        Me.fin_btn_fc.FlatAppearance.BorderSize = 0
        Me.fin_btn_fc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fin_btn_fc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fin_btn_fc.ForeColor = System.Drawing.Color.White
        Me.fin_btn_fc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.fin_btn_fc.Location = New System.Drawing.Point(1, 200)
        Me.fin_btn_fc.Name = "fin_btn_fc"
        Me.fin_btn_fc.Size = New System.Drawing.Size(336, 62)
        Me.fin_btn_fc.TabIndex = 0
        Me.fin_btn_fc.Text = "Fee Collection"
        Me.fin_btn_fc.UseVisualStyleBackColor = False
        '
        'FinanceFeeCollection
        '
        Me.FinanceFeeCollection.Controls.Add(Me.fc_tb_fee_to_pay)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_tb_student_mn)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_tb_course_fee)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_tb_remaining_fee)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_tb_paid_fee)
        Me.FinanceFeeCollection.Controls.Add(Me.Label40)
        Me.FinanceFeeCollection.Controls.Add(Me.Label37)
        Me.FinanceFeeCollection.Controls.Add(Me.Label38)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_btn_search)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_btn_clear)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_btn_collect)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_tb_student_course_year)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_tb_student_course)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_tb_fee_date)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_tb_student_dept)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_tb_student_ln)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_tb_student_id)
        Me.FinanceFeeCollection.Controls.Add(Me.fc_tb_student_name)
        Me.FinanceFeeCollection.Controls.Add(Me.Label7)
        Me.FinanceFeeCollection.Controls.Add(Me.Label6)
        Me.FinanceFeeCollection.Controls.Add(Me.Label5)
        Me.FinanceFeeCollection.Controls.Add(Me.Label2)
        Me.FinanceFeeCollection.Controls.Add(Me.Label3)
        Me.FinanceFeeCollection.Controls.Add(Me.Label1)
        Me.FinanceFeeCollection.Controls.Add(Me.Label11)
        Me.FinanceFeeCollection.Controls.Add(Me.Label10)
        Me.FinanceFeeCollection.Controls.Add(Me.Label32)
        Me.FinanceFeeCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FinanceFeeCollection.Location = New System.Drawing.Point(338, 0)
        Me.FinanceFeeCollection.Name = "FinanceFeeCollection"
        Me.FinanceFeeCollection.Size = New System.Drawing.Size(843, 562)
        Me.FinanceFeeCollection.TabIndex = 2
        '
        'fc_tb_fee_to_pay
        '
        Me.fc_tb_fee_to_pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_tb_fee_to_pay.Location = New System.Drawing.Point(583, 399)
        Me.fc_tb_fee_to_pay.Name = "fc_tb_fee_to_pay"
        Me.fc_tb_fee_to_pay.Size = New System.Drawing.Size(239, 23)
        Me.fc_tb_fee_to_pay.TabIndex = 44
        Me.fc_tb_fee_to_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fc_tb_student_mn
        '
        Me.fc_tb_student_mn.Enabled = False
        Me.fc_tb_student_mn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_tb_student_mn.Location = New System.Drawing.Point(148, 180)
        Me.fc_tb_student_mn.Name = "fc_tb_student_mn"
        Me.fc_tb_student_mn.Size = New System.Drawing.Size(239, 23)
        Me.fc_tb_student_mn.TabIndex = 45
        Me.fc_tb_student_mn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fc_tb_course_fee
        '
        Me.fc_tb_course_fee.Enabled = False
        Me.fc_tb_course_fee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_tb_course_fee.Location = New System.Drawing.Point(583, 180)
        Me.fc_tb_course_fee.Name = "fc_tb_course_fee"
        Me.fc_tb_course_fee.Size = New System.Drawing.Size(239, 23)
        Me.fc_tb_course_fee.TabIndex = 43
        Me.fc_tb_course_fee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fc_tb_remaining_fee
        '
        Me.fc_tb_remaining_fee.Enabled = False
        Me.fc_tb_remaining_fee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_tb_remaining_fee.Location = New System.Drawing.Point(583, 326)
        Me.fc_tb_remaining_fee.Name = "fc_tb_remaining_fee"
        Me.fc_tb_remaining_fee.Size = New System.Drawing.Size(239, 23)
        Me.fc_tb_remaining_fee.TabIndex = 43
        Me.fc_tb_remaining_fee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fc_tb_paid_fee
        '
        Me.fc_tb_paid_fee.Enabled = False
        Me.fc_tb_paid_fee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_tb_paid_fee.Location = New System.Drawing.Point(583, 253)
        Me.fc_tb_paid_fee.Name = "fc_tb_paid_fee"
        Me.fc_tb_paid_fee.Size = New System.Drawing.Size(239, 23)
        Me.fc_tb_paid_fee.TabIndex = 43
        Me.fc_tb_paid_fee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(435, 182)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(106, 18)
        Me.Label40.TabIndex = 41
        Me.Label40.Text = "Course Fee :"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(20, 255)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(99, 18)
        Me.Label37.TabIndex = 40
        Me.Label37.Text = "Last Name :"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(20, 182)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(116, 18)
        Me.Label38.TabIndex = 42
        Me.Label38.Text = "Middle Name :"
        '
        'fc_btn_search
        '
        Me.fc_btn_search.BackgroundImage = Global.CMS.My.Resources.Resources.Entypo_d83d_0__10241
        Me.fc_btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fc_btn_search.Location = New System.Drawing.Point(387, 32)
        Me.fc_btn_search.Name = "fc_btn_search"
        Me.fc_btn_search.Size = New System.Drawing.Size(27, 26)
        Me.fc_btn_search.TabIndex = 30
        Me.fc_btn_search.UseVisualStyleBackColor = True
        '
        'fc_btn_clear
        '
        Me.fc_btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.fc_btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_btn_clear.ForeColor = System.Drawing.Color.White
        Me.fc_btn_clear.Location = New System.Drawing.Point(473, 478)
        Me.fc_btn_clear.Name = "fc_btn_clear"
        Me.fc_btn_clear.Size = New System.Drawing.Size(120, 53)
        Me.fc_btn_clear.TabIndex = 28
        Me.fc_btn_clear.Text = "Clear"
        Me.fc_btn_clear.UseVisualStyleBackColor = False
        '
        'fc_btn_collect
        '
        Me.fc_btn_collect.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.fc_btn_collect.Enabled = False
        Me.fc_btn_collect.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_btn_collect.ForeColor = System.Drawing.Color.White
        Me.fc_btn_collect.Location = New System.Drawing.Point(250, 478)
        Me.fc_btn_collect.Name = "fc_btn_collect"
        Me.fc_btn_collect.Size = New System.Drawing.Size(120, 53)
        Me.fc_btn_collect.TabIndex = 29
        Me.fc_btn_collect.Text = "Collect"
        Me.fc_btn_collect.UseVisualStyleBackColor = False
        '
        'fc_tb_student_course_year
        '
        Me.fc_tb_student_course_year.Enabled = False
        Me.fc_tb_student_course_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_tb_student_course_year.Location = New System.Drawing.Point(583, 107)
        Me.fc_tb_student_course_year.Name = "fc_tb_student_course_year"
        Me.fc_tb_student_course_year.Size = New System.Drawing.Size(239, 23)
        Me.fc_tb_student_course_year.TabIndex = 23
        Me.fc_tb_student_course_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fc_tb_student_course
        '
        Me.fc_tb_student_course.Enabled = False
        Me.fc_tb_student_course.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_tb_student_course.Location = New System.Drawing.Point(148, 399)
        Me.fc_tb_student_course.Name = "fc_tb_student_course"
        Me.fc_tb_student_course.Size = New System.Drawing.Size(239, 23)
        Me.fc_tb_student_course.TabIndex = 23
        Me.fc_tb_student_course.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fc_tb_fee_date
        '
        Me.fc_tb_fee_date.Enabled = False
        Me.fc_tb_fee_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_tb_fee_date.Location = New System.Drawing.Point(583, 34)
        Me.fc_tb_fee_date.Name = "fc_tb_fee_date"
        Me.fc_tb_fee_date.Size = New System.Drawing.Size(239, 23)
        Me.fc_tb_fee_date.TabIndex = 26
        Me.fc_tb_fee_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fc_tb_student_dept
        '
        Me.fc_tb_student_dept.Enabled = False
        Me.fc_tb_student_dept.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_tb_student_dept.Location = New System.Drawing.Point(148, 326)
        Me.fc_tb_student_dept.Name = "fc_tb_student_dept"
        Me.fc_tb_student_dept.Size = New System.Drawing.Size(239, 23)
        Me.fc_tb_student_dept.TabIndex = 26
        Me.fc_tb_student_dept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fc_tb_student_ln
        '
        Me.fc_tb_student_ln.Enabled = False
        Me.fc_tb_student_ln.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_tb_student_ln.Location = New System.Drawing.Point(148, 253)
        Me.fc_tb_student_ln.Name = "fc_tb_student_ln"
        Me.fc_tb_student_ln.Size = New System.Drawing.Size(239, 23)
        Me.fc_tb_student_ln.TabIndex = 26
        Me.fc_tb_student_ln.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fc_tb_student_id
        '
        Me.fc_tb_student_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_tb_student_id.Location = New System.Drawing.Point(148, 34)
        Me.fc_tb_student_id.Name = "fc_tb_student_id"
        Me.fc_tb_student_id.Size = New System.Drawing.Size(239, 23)
        Me.fc_tb_student_id.TabIndex = 26
        Me.fc_tb_student_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fc_tb_student_name
        '
        Me.fc_tb_student_name.Enabled = False
        Me.fc_tb_student_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fc_tb_student_name.Location = New System.Drawing.Point(148, 107)
        Me.fc_tb_student_name.Name = "fc_tb_student_name"
        Me.fc_tb_student_name.Size = New System.Drawing.Size(239, 23)
        Me.fc_tb_student_name.TabIndex = 26
        Me.fc_tb_student_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(435, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Fee to Pay:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(435, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Remaining Fee :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(435, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Paid Fee :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(435, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(435, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Course Year :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Student Name :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 401)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 18)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Course :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Department :"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(20, 36)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(96, 18)
        Me.Label32.TabIndex = 21
        Me.Label32.Text = "Student ID :"
        '
        'FinanceViewStudentFees
        '
        Me.FinanceViewStudentFees.Controls.Add(Me.pf_btn_search)
        Me.FinanceViewStudentFees.Controls.Add(Me.pf_btn_reset)
        Me.FinanceViewStudentFees.Controls.Add(Me.GroupBox2)
        Me.FinanceViewStudentFees.Controls.Add(Me.pf_dg)
        Me.FinanceViewStudentFees.Controls.Add(Me.Label12)
        Me.FinanceViewStudentFees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FinanceViewStudentFees.Location = New System.Drawing.Point(338, 0)
        Me.FinanceViewStudentFees.Name = "FinanceViewStudentFees"
        Me.FinanceViewStudentFees.Size = New System.Drawing.Size(843, 562)
        Me.FinanceViewStudentFees.TabIndex = 21
        Me.FinanceViewStudentFees.Visible = False
        '
        'pf_btn_search
        '
        Me.pf_btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pf_btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pf_btn_search.ForeColor = System.Drawing.Color.White
        Me.pf_btn_search.Location = New System.Drawing.Point(457, 177)
        Me.pf_btn_search.Name = "pf_btn_search"
        Me.pf_btn_search.Size = New System.Drawing.Size(120, 53)
        Me.pf_btn_search.TabIndex = 35
        Me.pf_btn_search.Text = "Search"
        Me.pf_btn_search.UseVisualStyleBackColor = False
        '
        'pf_btn_reset
        '
        Me.pf_btn_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pf_btn_reset.Enabled = False
        Me.pf_btn_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pf_btn_reset.ForeColor = System.Drawing.Color.White
        Me.pf_btn_reset.Location = New System.Drawing.Point(647, 177)
        Me.pf_btn_reset.Name = "pf_btn_reset"
        Me.pf_btn_reset.Size = New System.Drawing.Size(120, 53)
        Me.pf_btn_reset.TabIndex = 35
        Me.pf_btn_reset.Text = "Reset"
        Me.pf_btn_reset.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pf_cb_course_year)
        Me.GroupBox2.Controls.Add(Me.pf_cb_course)
        Me.GroupBox2.Controls.Add(Me.pf_cb_dept)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.pf_cb_year)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 218)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Standard :"
        '
        'pf_cb_course_year
        '
        Me.pf_cb_course_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pf_cb_course_year.FormattingEnabled = True
        Me.pf_cb_course_year.Location = New System.Drawing.Point(130, 163)
        Me.pf_cb_course_year.Name = "pf_cb_course_year"
        Me.pf_cb_course_year.Size = New System.Drawing.Size(269, 21)
        Me.pf_cb_course_year.TabIndex = 26
        '
        'pf_cb_course
        '
        Me.pf_cb_course.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pf_cb_course.FormattingEnabled = True
        Me.pf_cb_course.Location = New System.Drawing.Point(130, 120)
        Me.pf_cb_course.Name = "pf_cb_course"
        Me.pf_cb_course.Size = New System.Drawing.Size(269, 21)
        Me.pf_cb_course.TabIndex = 26
        '
        'pf_cb_dept
        '
        Me.pf_cb_dept.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pf_cb_dept.FormattingEnabled = True
        Me.pf_cb_dept.Location = New System.Drawing.Point(130, 77)
        Me.pf_cb_dept.Name = "pf_cb_dept"
        Me.pf_cb_dept.Size = New System.Drawing.Size(269, 21)
        Me.pf_cb_dept.TabIndex = 27
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 164)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 18)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Course Year :"
        '
        'pf_cb_year
        '
        Me.pf_cb_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pf_cb_year.FormattingEnabled = True
        Me.pf_cb_year.Location = New System.Drawing.Point(130, 34)
        Me.pf_cb_year.Name = "pf_cb_year"
        Me.pf_cb_year.Size = New System.Drawing.Size(269, 21)
        Me.pf_cb_year.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 18)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Course :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 18)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Department :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 18)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Year :"
        '
        'pf_dg
        '
        Me.pf_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pf_dg.Location = New System.Drawing.Point(24, 262)
        Me.pf_dg.Name = "pf_dg"
        Me.pf_dg.Size = New System.Drawing.Size(795, 283)
        Me.pf_dg.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(406, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 0
        '
        'FinanceEmployeeFacultySalaryPayment
        '
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.es_tb_leaves)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.Label26)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.es_tb_salary_month)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.es_tb_emp_phone)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.Label25)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.es_btn_search)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.es_tb_emp_mn)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.Label8)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.Label9)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.es_tb_emp_ln)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.es_btn_pay)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.es_btn_reset)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.Label21)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.Label20)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.Label19)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.Label23)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.Label24)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.es_tb_salary)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.es_tb_salary_date)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.es_tb_emp_name)
        Me.FinanceEmployeeFacultySalaryPayment.Controls.Add(Me.es_tb_emp_id)
        Me.FinanceEmployeeFacultySalaryPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FinanceEmployeeFacultySalaryPayment.Location = New System.Drawing.Point(338, 0)
        Me.FinanceEmployeeFacultySalaryPayment.Name = "FinanceEmployeeFacultySalaryPayment"
        Me.FinanceEmployeeFacultySalaryPayment.Size = New System.Drawing.Size(843, 562)
        Me.FinanceEmployeeFacultySalaryPayment.TabIndex = 22
        Me.FinanceEmployeeFacultySalaryPayment.Visible = False
        '
        'es_tb_leaves
        '
        Me.es_tb_leaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es_tb_leaves.Location = New System.Drawing.Point(551, 290)
        Me.es_tb_leaves.Name = "es_tb_leaves"
        Me.es_tb_leaves.Size = New System.Drawing.Size(239, 24)
        Me.es_tb_leaves.TabIndex = 54
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(429, 293)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(71, 18)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "Leaves :"
        '
        'es_tb_salary_month
        '
        Me.es_tb_salary_month.Enabled = False
        Me.es_tb_salary_month.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es_tb_salary_month.Location = New System.Drawing.Point(551, 206)
        Me.es_tb_salary_month.Name = "es_tb_salary_month"
        Me.es_tb_salary_month.Size = New System.Drawing.Size(239, 24)
        Me.es_tb_salary_month.TabIndex = 52
        '
        'es_tb_emp_phone
        '
        Me.es_tb_emp_phone.Enabled = False
        Me.es_tb_emp_phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es_tb_emp_phone.Location = New System.Drawing.Point(551, 122)
        Me.es_tb_emp_phone.Name = "es_tb_emp_phone"
        Me.es_tb_emp_phone.Size = New System.Drawing.Size(239, 24)
        Me.es_tb_emp_phone.TabIndex = 52
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(429, 125)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 18)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "Phone :"
        '
        'es_btn_search
        '
        Me.es_btn_search.BackgroundImage = Global.CMS.My.Resources.Resources.Entypo_d83d_0__10241
        Me.es_btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.es_btn_search.Location = New System.Drawing.Point(380, 121)
        Me.es_btn_search.Name = "es_btn_search"
        Me.es_btn_search.Size = New System.Drawing.Size(27, 26)
        Me.es_btn_search.TabIndex = 50
        Me.es_btn_search.UseVisualStyleBackColor = True
        '
        'es_tb_emp_mn
        '
        Me.es_tb_emp_mn.Enabled = False
        Me.es_tb_emp_mn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es_tb_emp_mn.Location = New System.Drawing.Point(141, 290)
        Me.es_tb_emp_mn.Name = "es_tb_emp_mn"
        Me.es_tb_emp_mn.Size = New System.Drawing.Size(239, 24)
        Me.es_tb_emp_mn.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 377)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 18)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Last Name :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 18)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Middle Name :"
        '
        'es_tb_emp_ln
        '
        Me.es_tb_emp_ln.Enabled = False
        Me.es_tb_emp_ln.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es_tb_emp_ln.Location = New System.Drawing.Point(141, 374)
        Me.es_tb_emp_ln.Name = "es_tb_emp_ln"
        Me.es_tb_emp_ln.Size = New System.Drawing.Size(239, 24)
        Me.es_tb_emp_ln.TabIndex = 46
        '
        'es_btn_pay
        '
        Me.es_btn_pay.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.es_btn_pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es_btn_pay.ForeColor = System.Drawing.Color.White
        Me.es_btn_pay.Location = New System.Drawing.Point(253, 478)
        Me.es_btn_pay.Name = "es_btn_pay"
        Me.es_btn_pay.Size = New System.Drawing.Size(104, 47)
        Me.es_btn_pay.TabIndex = 25
        Me.es_btn_pay.Text = "Pay"
        Me.es_btn_pay.UseVisualStyleBackColor = False
        '
        'es_btn_reset
        '
        Me.es_btn_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.es_btn_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es_btn_reset.ForeColor = System.Drawing.Color.White
        Me.es_btn_reset.Location = New System.Drawing.Point(485, 478)
        Me.es_btn_reset.Name = "es_btn_reset"
        Me.es_btn_reset.Size = New System.Drawing.Size(104, 47)
        Me.es_btn_reset.TabIndex = 26
        Me.es_btn_reset.Text = "Reset"
        Me.es_btn_reset.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(429, 377)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 18)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Salary :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(429, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 18)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Salary Date :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(429, 209)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 18)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Salary Month :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(24, 209)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 18)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "Name :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(24, 125)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(34, 18)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "ID :"
        '
        'es_tb_salary
        '
        Me.es_tb_salary.Enabled = False
        Me.es_tb_salary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es_tb_salary.Location = New System.Drawing.Point(551, 374)
        Me.es_tb_salary.Name = "es_tb_salary"
        Me.es_tb_salary.Size = New System.Drawing.Size(239, 24)
        Me.es_tb_salary.TabIndex = 21
        '
        'es_tb_salary_date
        '
        Me.es_tb_salary_date.Enabled = False
        Me.es_tb_salary_date.Location = New System.Drawing.Point(551, 38)
        Me.es_tb_salary_date.Name = "es_tb_salary_date"
        Me.es_tb_salary_date.Size = New System.Drawing.Size(239, 20)
        Me.es_tb_salary_date.TabIndex = 21
        Me.es_tb_salary_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'es_tb_emp_name
        '
        Me.es_tb_emp_name.Enabled = False
        Me.es_tb_emp_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es_tb_emp_name.Location = New System.Drawing.Point(141, 206)
        Me.es_tb_emp_name.Name = "es_tb_emp_name"
        Me.es_tb_emp_name.Size = New System.Drawing.Size(239, 24)
        Me.es_tb_emp_name.TabIndex = 21
        '
        'es_tb_emp_id
        '
        Me.es_tb_emp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es_tb_emp_id.Location = New System.Drawing.Point(140, 122)
        Me.es_tb_emp_id.Name = "es_tb_emp_id"
        Me.es_tb_emp_id.Size = New System.Drawing.Size(239, 24)
        Me.es_tb_emp_id.TabIndex = 22
        '
        'Form_Finance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 562)
        Me.Controls.Add(Me.FinanceEmployeeFacultySalaryPayment)
        Me.Controls.Add(Me.FinanceFeeCollection)
        Me.Controls.Add(Me.FinanceViewStudentFees)
        Me.Controls.Add(Me.side)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Finance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Finance"
        Me.side.ResumeLayout(False)
        Me.side.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FinanceFeeCollection.ResumeLayout(False)
        Me.FinanceFeeCollection.PerformLayout()
        Me.FinanceViewStudentFees.ResumeLayout(False)
        Me.FinanceViewStudentFees.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pf_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FinanceEmployeeFacultySalaryPayment.ResumeLayout(False)
        Me.FinanceEmployeeFacultySalaryPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents side As Panel
    Friend WithEvents sp_esp As Panel
    Friend WithEvents sp_vsf As Panel
    Friend WithEvents sp_fc As Panel
    Friend WithEvents fin_btn_esp As Button
    Friend WithEvents fin_btn_vsf As Button
    Friend WithEvents fin_btn_fc As Button
    Friend WithEvents FinanceFeeCollection As Panel
    Friend WithEvents fc_btn_clear As Button
    Friend WithEvents fc_btn_collect As Button
    Friend WithEvents fc_tb_student_course As TextBox
    Friend WithEvents fc_tb_student_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents FinanceViewStudentFees As Panel
    Friend WithEvents FinanceEmployeeFacultySalaryPayment As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents pf_dg As DataGridView
    Friend WithEvents es_btn_pay As Button
    Friend WithEvents es_btn_reset As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents es_tb_emp_name As TextBox
    Friend WithEvents es_tb_emp_id As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents es_tb_salary As TextBox
    Friend WithEvents es_tb_salary_date As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents fc_tb_student_course_year As TextBox
    Friend WithEvents fc_tb_student_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pf_cb_course As ComboBox
    Friend WithEvents pf_cb_dept As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents pf_cb_course_year As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents pf_btn_reset As Button
    Friend WithEvents fc_tb_fee_date As TextBox
    Friend WithEvents fc_tb_student_dept As TextBox
    Friend WithEvents fc_tb_student_ln As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents fc_btn_search As Button
    Friend WithEvents fc_tb_fee_to_pay As TextBox
    Friend WithEvents fc_tb_student_mn As TextBox
    Friend WithEvents fc_tb_paid_fee As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents fc_tb_course_fee As TextBox
    Friend WithEvents fc_tb_remaining_fee As TextBox
    Friend WithEvents pf_cb_year As ComboBox
    Friend WithEvents es_tb_emp_mn As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents es_tb_emp_ln As TextBox
    Friend WithEvents es_btn_search As Button
    Friend WithEvents es_tb_emp_phone As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents es_tb_leaves As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents es_tb_salary_month As TextBox
    Friend WithEvents pf_btn_search As Button
    Friend WithEvents btn_report_salary As Button
    Friend WithEvents btn_report_fees As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbusername As Label
    Friend WithEvents lbdepartment As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
