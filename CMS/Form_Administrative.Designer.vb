<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Administrative
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.side = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbusername = New System.Windows.Forms.Label()
        Me.lbdepartment = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.smallpanelusers = New System.Windows.Forms.Panel()
        Me.smallpaneldept = New System.Windows.Forms.Panel()
        Me.btn_users = New System.Windows.Forms.Button()
        Me.btn_dept = New System.Windows.Forms.Button()
        Me.dept = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_lib = New System.Windows.Forms.Button()
        Me.btn_fin = New System.Windows.Forms.Button()
        Me.btn_ad = New System.Windows.Forms.Button()
        Me.btn_hr = New System.Windows.Forms.Button()
        Me.create_del_user = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_department = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_comfirm_password = New System.Windows.Forms.TextBox()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb_delete = New System.Windows.Forms.RadioButton()
        Me.rb_new = New System.Windows.Forms.RadioButton()
        Me.side.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dept.SuspendLayout()
        Me.create_del_user.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'side
        '
        Me.side.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.side.Controls.Add(Me.PictureBox1)
        Me.side.Controls.Add(Me.Label26)
        Me.side.Controls.Add(Me.Label25)
        Me.side.Controls.Add(Me.lbusername)
        Me.side.Controls.Add(Me.lbdepartment)
        Me.side.Controls.Add(Me.LinkLabel1)
        Me.side.Controls.Add(Me.smallpanelusers)
        Me.side.Controls.Add(Me.smallpaneldept)
        Me.side.Controls.Add(Me.btn_users)
        Me.side.Controls.Add(Me.btn_dept)
        Me.side.Dock = System.Windows.Forms.DockStyle.Left
        Me.side.Location = New System.Drawing.Point(0, 0)
        Me.side.Name = "side"
        Me.side.Size = New System.Drawing.Size(331, 562)
        Me.side.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.CMS.My.Resources.Resources.et_line_e040_0__10242
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Global.CMS.My.Resources.Resources.et_line_e040_0__10242
        Me.PictureBox1.Image = Global.CMS.My.Resources.Resources.et_line_e040_0__10242
        Me.PictureBox1.Location = New System.Drawing.Point(100, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 115)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label26.Location = New System.Drawing.Point(23, 162)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(91, 20)
        Me.Label26.TabIndex = 27
        Me.Label26.Text = "Username :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label25.Location = New System.Drawing.Point(12, 128)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(102, 20)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "Department :"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbusername
        '
        Me.lbusername.AutoSize = True
        Me.lbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbusername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbusername.Location = New System.Drawing.Point(132, 162)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(66, 20)
        Me.lbusername.TabIndex = 28
        Me.lbusername.Text = "Label31"
        Me.lbusername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbdepartment
        '
        Me.lbdepartment.AutoSize = True
        Me.lbdepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdepartment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbdepartment.Location = New System.Drawing.Point(132, 128)
        Me.lbdepartment.Name = "lbdepartment"
        Me.lbdepartment.Size = New System.Drawing.Size(105, 20)
        Me.lbdepartment.TabIndex = 26
        Me.lbdepartment.Text = "Adminstartive"
        Me.lbdepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(258, 525)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 20)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Logout"
        '
        'smallpanelusers
        '
        Me.smallpanelusers.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.smallpanelusers.Location = New System.Drawing.Point(326, 259)
        Me.smallpanelusers.Name = "smallpanelusers"
        Me.smallpanelusers.Size = New System.Drawing.Size(5, 60)
        Me.smallpanelusers.TabIndex = 20
        Me.smallpanelusers.Visible = False
        '
        'smallpaneldept
        '
        Me.smallpaneldept.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.smallpaneldept.Location = New System.Drawing.Point(326, 199)
        Me.smallpaneldept.Name = "smallpaneldept"
        Me.smallpaneldept.Size = New System.Drawing.Size(5, 60)
        Me.smallpaneldept.TabIndex = 20
        '
        'btn_users
        '
        Me.btn_users.FlatAppearance.BorderSize = 0
        Me.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_users.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_users.ForeColor = System.Drawing.Color.White
        Me.btn_users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_users.Location = New System.Drawing.Point(0, 259)
        Me.btn_users.Name = "btn_users"
        Me.btn_users.Size = New System.Drawing.Size(331, 60)
        Me.btn_users.TabIndex = 0
        Me.btn_users.Text = "Create / Delete User"
        Me.btn_users.UseVisualStyleBackColor = True
        '
        'btn_dept
        '
        Me.btn_dept.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_dept.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_dept.FlatAppearance.BorderSize = 0
        Me.btn_dept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dept.ForeColor = System.Drawing.Color.White
        Me.btn_dept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dept.Location = New System.Drawing.Point(0, 199)
        Me.btn_dept.Name = "btn_dept"
        Me.btn_dept.Size = New System.Drawing.Size(331, 60)
        Me.btn_dept.TabIndex = 0
        Me.btn_dept.Text = "Departments"
        Me.btn_dept.UseVisualStyleBackColor = False
        '
        'dept
        '
        Me.dept.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dept.Controls.Add(Me.Label5)
        Me.dept.Controls.Add(Me.Label6)
        Me.dept.Controls.Add(Me.Label7)
        Me.dept.Controls.Add(Me.Label8)
        Me.dept.Controls.Add(Me.btn_lib)
        Me.dept.Controls.Add(Me.btn_fin)
        Me.dept.Controls.Add(Me.btn_ad)
        Me.dept.Controls.Add(Me.btn_hr)
        Me.dept.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dept.Location = New System.Drawing.Point(331, 0)
        Me.dept.Name = "dept"
        Me.dept.Size = New System.Drawing.Size(683, 562)
        Me.dept.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(451, 485)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 26)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Library"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(432, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 26)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Admission"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(138, 485)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 26)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Finance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(88, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 26)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Human Resource"
        '
        'btn_lib
        '
        Me.btn_lib.BackgroundImage = Global.CMS.My.Resources.Resources._24_10_2018_library_18566382
        Me.btn_lib.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_lib.Location = New System.Drawing.Point(389, 301)
        Me.btn_lib.Name = "btn_lib"
        Me.btn_lib.Size = New System.Drawing.Size(208, 181)
        Me.btn_lib.TabIndex = 2
        Me.btn_lib.UseVisualStyleBackColor = True
        '
        'btn_fin
        '
        Me.btn_fin.BackgroundImage = Global.CMS.My.Resources.Resources.finance400
        Me.btn_fin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_fin.Location = New System.Drawing.Point(82, 301)
        Me.btn_fin.Name = "btn_fin"
        Me.btn_fin.Size = New System.Drawing.Size(208, 181)
        Me.btn_fin.TabIndex = 3
        Me.btn_fin.UseVisualStyleBackColor = True
        '
        'btn_ad
        '
        Me.btn_ad.BackgroundImage = Global.CMS.My.Resources.Resources.admission
        Me.btn_ad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ad.Location = New System.Drawing.Point(389, 47)
        Me.btn_ad.Name = "btn_ad"
        Me.btn_ad.Size = New System.Drawing.Size(208, 181)
        Me.btn_ad.TabIndex = 4
        Me.btn_ad.UseVisualStyleBackColor = True
        '
        'btn_hr
        '
        Me.btn_hr.BackgroundImage = Global.CMS.My.Resources.Resources.hr
        Me.btn_hr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_hr.Location = New System.Drawing.Point(82, 47)
        Me.btn_hr.Name = "btn_hr"
        Me.btn_hr.Size = New System.Drawing.Size(208, 181)
        Me.btn_hr.TabIndex = 5
        Me.btn_hr.UseVisualStyleBackColor = True
        '
        'create_del_user
        '
        Me.create_del_user.BackColor = System.Drawing.Color.WhiteSmoke
        Me.create_del_user.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.create_del_user.Controls.Add(Me.GroupBox1)
        Me.create_del_user.Controls.Add(Me.btn_delete)
        Me.create_del_user.Controls.Add(Me.btn_create)
        Me.create_del_user.Controls.Add(Me.GroupBox4)
        Me.create_del_user.Dock = System.Windows.Forms.DockStyle.Fill
        Me.create_del_user.Location = New System.Drawing.Point(331, 0)
        Me.create_del_user.Name = "create_del_user"
        Me.create_del_user.Size = New System.Drawing.Size(683, 562)
        Me.create_del_user.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_department)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tb_comfirm_password)
        Me.GroupBox1.Controls.Add(Me.tb_password)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tb_username)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(56, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 304)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'cb_department
        '
        Me.cb_department.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_department.FormattingEnabled = True
        Me.cb_department.Location = New System.Drawing.Point(243, 243)
        Me.cb_department.Name = "cb_department"
        Me.cb_department.Size = New System.Drawing.Size(279, 24)
        Me.cb_department.TabIndex = 23
        Me.cb_department.Text = "Select"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Gender :"
        '
        'tb_comfirm_password
        '
        Me.tb_comfirm_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_comfirm_password.Location = New System.Drawing.Point(243, 175)
        Me.tb_comfirm_password.Name = "tb_comfirm_password"
        Me.tb_comfirm_password.Size = New System.Drawing.Size(278, 23)
        Me.tb_comfirm_password.TabIndex = 16
        Me.tb_comfirm_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_password
        '
        Me.tb_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_password.Location = New System.Drawing.Point(243, 106)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.Size = New System.Drawing.Size(278, 23)
        Me.tb_password.TabIndex = 17
        Me.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Comfirm Password :"
        '
        'tb_username
        '
        Me.tb_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_username.Location = New System.Drawing.Point(243, 37)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(278, 23)
        Me.tb_username.TabIndex = 18
        Me.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Password :"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(45, 39)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(111, 18)
        Me.Label32.TabIndex = 21
        Me.Label32.Text = "USERNAME :"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_delete.Enabled = False
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(373, 469)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(120, 53)
        Me.btn_delete.TabIndex = 13
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_create.Enabled = False
        Me.btn_create.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create.ForeColor = System.Drawing.Color.White
        Me.btn_create.Location = New System.Drawing.Point(186, 469)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(120, 53)
        Me.btn_create.TabIndex = 13
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.rb_delete)
        Me.GroupBox4.Controls.Add(Me.rb_new)
        Me.GroupBox4.Location = New System.Drawing.Point(132, 37)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(414, 84)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        '
        'rb_delete
        '
        Me.rb_delete.AutoSize = True
        Me.rb_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_delete.Location = New System.Drawing.Point(254, 32)
        Me.rb_delete.Name = "rb_delete"
        Me.rb_delete.Size = New System.Drawing.Size(98, 20)
        Me.rb_delete.TabIndex = 0
        Me.rb_delete.Text = "Delete User"
        Me.rb_delete.UseVisualStyleBackColor = True
        '
        'rb_new
        '
        Me.rb_new.AutoSize = True
        Me.rb_new.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_new.Location = New System.Drawing.Point(62, 32)
        Me.rb_new.Name = "rb_new"
        Me.rb_new.Size = New System.Drawing.Size(85, 20)
        Me.rb_new.TabIndex = 0
        Me.rb_new.Text = "New User"
        Me.rb_new.UseVisualStyleBackColor = True
        '
        'Form_Administrative
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 562)
        Me.Controls.Add(Me.dept)
        Me.Controls.Add(Me.create_del_user)
        Me.Controls.Add(Me.side)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Administrative"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.side.ResumeLayout(False)
        Me.side.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dept.ResumeLayout(False)
        Me.dept.PerformLayout()
        Me.create_del_user.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents side As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents smallpanelusers As Panel
    Friend WithEvents smallpaneldept As Panel
    Friend WithEvents btn_users As Button
    Friend WithEvents btn_dept As Button
    Friend WithEvents dept As Panel
    Friend WithEvents create_del_user As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_lib As Button
    Friend WithEvents btn_fin As Button
    Friend WithEvents btn_ad As Button
    Friend WithEvents btn_hr As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rb_delete As RadioButton
    Friend WithEvents rb_new As RadioButton
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_create As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cb_department As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_comfirm_password As TextBox
    Friend WithEvents tb_password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lbusername As Label
    Friend WithEvents lbdepartment As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
