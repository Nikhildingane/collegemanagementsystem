<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Form_LibraryMembar
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pb_rb_emp = New System.Windows.Forms.RadioButton()
        Me.pb_rb_student = New System.Windows.Forms.RadioButton()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Controls.Add(Me.pb_rb_emp)
        Me.GroupBox3.Controls.Add(Me.pb_rb_student)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 76)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(173, 151)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'pb_rb_emp
        '
        Me.pb_rb_emp.AutoSize = True
        Me.pb_rb_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_rb_emp.Location = New System.Drawing.Point(42, 94)
        Me.pb_rb_emp.Name = "pb_rb_emp"
        Me.pb_rb_emp.Size = New System.Drawing.Size(88, 21)
        Me.pb_rb_emp.TabIndex = 1
        Me.pb_rb_emp.Text = "Employee"
        Me.pb_rb_emp.UseVisualStyleBackColor = True
        '
        'pb_rb_student
        '
        Me.pb_rb_student.AutoSize = True
        Me.pb_rb_student.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_rb_student.Location = New System.Drawing.Point(42, 35)
        Me.pb_rb_student.Name = "pb_rb_student"
        Me.pb_rb_student.Size = New System.Drawing.Size(75, 21)
        Me.pb_rb_student.TabIndex = 1
        Me.pb_rb_student.Text = "Student"
        Me.pb_rb_student.UseVisualStyleBackColor = True
        '
        'Report_Form_LibraryMembar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Report_Form_LibraryMembar"
        Me.Text = "Report_Form_LibraryMembar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents pb_rb_emp As RadioButton
    Friend WithEvents pb_rb_student As RadioButton
End Class
