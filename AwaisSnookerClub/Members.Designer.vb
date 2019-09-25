<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembers
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
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.radDelete = New System.Windows.Forms.RadioButton()
        Me.grpAdd = New System.Windows.Forms.GroupBox()
        Me.lstCategory = New System.Windows.Forms.ListBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtmemberIDAdd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpDelete = New System.Windows.Forms.GroupBox()
        Me.txtMemberIDDelete = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.btnDisplayMembers = New System.Windows.Forms.Button()
        Me.btnPrintMembers = New System.Windows.Forms.Button()
        Me.grpAdd.SuspendLayout()
        Me.grpDelete.SuspendLayout()
        Me.SuspendLayout()
        '
        'radAdd
        '
        Me.radAdd.AutoSize = True
        Me.radAdd.Location = New System.Drawing.Point(415, 41)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(85, 17)
        Me.radAdd.TabIndex = 0
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "Add Member"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'radDelete
        '
        Me.radDelete.AutoSize = True
        Me.radDelete.Location = New System.Drawing.Point(536, 41)
        Me.radDelete.Name = "radDelete"
        Me.radDelete.Size = New System.Drawing.Size(97, 17)
        Me.radDelete.TabIndex = 1
        Me.radDelete.TabStop = True
        Me.radDelete.Text = "Delete Member"
        Me.radDelete.UseVisualStyleBackColor = True
        '
        'grpAdd
        '
        Me.grpAdd.Controls.Add(Me.lstCategory)
        Me.grpAdd.Controls.Add(Me.txtSurname)
        Me.grpAdd.Controls.Add(Me.txtFirstname)
        Me.grpAdd.Controls.Add(Me.txtmemberIDAdd)
        Me.grpAdd.Controls.Add(Me.Label4)
        Me.grpAdd.Controls.Add(Me.Label3)
        Me.grpAdd.Controls.Add(Me.Label2)
        Me.grpAdd.Controls.Add(Me.Label1)
        Me.grpAdd.Location = New System.Drawing.Point(415, 79)
        Me.grpAdd.Name = "grpAdd"
        Me.grpAdd.Size = New System.Drawing.Size(239, 145)
        Me.grpAdd.TabIndex = 2
        Me.grpAdd.TabStop = False
        '
        'lstCategory
        '
        Me.lstCategory.FormattingEnabled = True
        Me.lstCategory.Items.AddRange(New Object() {"Junior", "Senior"})
        Me.lstCategory.Location = New System.Drawing.Point(122, 99)
        Me.lstCategory.Name = "lstCategory"
        Me.lstCategory.Size = New System.Drawing.Size(100, 30)
        Me.lstCategory.TabIndex = 8
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(122, 20)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtSurname.TabIndex = 7
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(122, 46)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstname.TabIndex = 6
        '
        'txtmemberIDAdd
        '
        Me.txtmemberIDAdd.Location = New System.Drawing.Point(122, 72)
        Me.txtmemberIDAdd.Name = "txtmemberIDAdd"
        Me.txtmemberIDAdd.Size = New System.Drawing.Size(100, 20)
        Me.txtmemberIDAdd.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Membership Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Membership No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Firstname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Surname"
        '
        'grpDelete
        '
        Me.grpDelete.Controls.Add(Me.txtMemberIDDelete)
        Me.grpDelete.Controls.Add(Me.Label5)
        Me.grpDelete.Location = New System.Drawing.Point(415, 79)
        Me.grpDelete.Name = "grpDelete"
        Me.grpDelete.Size = New System.Drawing.Size(239, 57)
        Me.grpDelete.TabIndex = 3
        Me.grpDelete.TabStop = False
        '
        'txtMemberIDDelete
        '
        Me.txtMemberIDDelete.Location = New System.Drawing.Point(121, 16)
        Me.txtMemberIDDelete.Name = "txtMemberIDDelete"
        Me.txtMemberIDDelete.Size = New System.Drawing.Size(100, 20)
        Me.txtMemberIDDelete.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Membership No."
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(537, 230)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(99, 22)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "Add Member"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lstMembers
        '
        Me.lstMembers.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.ItemHeight = 14
        Me.lstMembers.Location = New System.Drawing.Point(13, 37)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.Size = New System.Drawing.Size(396, 186)
        Me.lstMembers.Sorted = True
        Me.lstMembers.TabIndex = 5
        '
        'btnDisplayMembers
        '
        Me.btnDisplayMembers.Location = New System.Drawing.Point(13, 229)
        Me.btnDisplayMembers.Name = "btnDisplayMembers"
        Me.btnDisplayMembers.Size = New System.Drawing.Size(75, 60)
        Me.btnDisplayMembers.TabIndex = 6
        Me.btnDisplayMembers.Text = "Display Members"
        Me.btnDisplayMembers.UseVisualStyleBackColor = True
        '
        'btnPrintMembers
        '
        Me.btnPrintMembers.Location = New System.Drawing.Point(95, 229)
        Me.btnPrintMembers.Name = "btnPrintMembers"
        Me.btnPrintMembers.Size = New System.Drawing.Size(75, 60)
        Me.btnPrintMembers.TabIndex = 7
        Me.btnPrintMembers.Text = "Print Membership List"
        Me.btnPrintMembers.UseVisualStyleBackColor = True
        '
        'frmMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 302)
        Me.Controls.Add(Me.btnPrintMembers)
        Me.Controls.Add(Me.btnDisplayMembers)
        Me.Controls.Add(Me.lstMembers)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpDelete)
        Me.Controls.Add(Me.grpAdd)
        Me.Controls.Add(Me.radDelete)
        Me.Controls.Add(Me.radAdd)
        Me.Name = "frmMembers"
        Me.Text = "Awais Snooker Club - Club Membership"
        Me.grpAdd.ResumeLayout(False)
        Me.grpAdd.PerformLayout()
        Me.grpDelete.ResumeLayout(False)
        Me.grpDelete.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radAdd As System.Windows.Forms.RadioButton
    Friend WithEvents radDelete As System.Windows.Forms.RadioButton
    Friend WithEvents grpAdd As System.Windows.Forms.GroupBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtmemberIDAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstCategory As System.Windows.Forms.ListBox
    Friend WithEvents grpDelete As System.Windows.Forms.GroupBox
    Friend WithEvents txtMemberIDDelete As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lstMembers As System.Windows.Forms.ListBox
    Friend WithEvents btnDisplayMembers As System.Windows.Forms.Button
    Friend WithEvents btnPrintMembers As System.Windows.Forms.Button
End Class
