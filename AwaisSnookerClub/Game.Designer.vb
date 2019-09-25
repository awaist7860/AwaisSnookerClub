<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.radStart = New System.Windows.Forms.RadioButton()
        Me.radFinish = New System.Windows.Forms.RadioButton()
        Me.grpStart = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMemberIDStart = New System.Windows.Forms.TextBox()
        Me.txtMmebershipName = New System.Windows.Forms.TextBox()
        Me.txtCategoryStart = New System.Windows.Forms.TextBox()
        Me.cmbTableNumbersStart = New System.Windows.Forms.ComboBox()
        Me.tctStratTimeStart = New System.Windows.Forms.TextBox()
        Me.grpFinish = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.grpStart.SuspendLayout()
        Me.grpFinish.SuspendLayout()
        Me.SuspendLayout()
        '
        'radStart
        '
        Me.radStart.AutoSize = True
        Me.radStart.Location = New System.Drawing.Point(114, 13)
        Me.radStart.Name = "radStart"
        Me.radStart.Size = New System.Drawing.Size(47, 17)
        Me.radStart.TabIndex = 0
        Me.radStart.TabStop = True
        Me.radStart.Text = "Start"
        Me.radStart.UseVisualStyleBackColor = True
        '
        'radFinish
        '
        Me.radFinish.AutoSize = True
        Me.radFinish.Location = New System.Drawing.Point(260, 13)
        Me.radFinish.Name = "radFinish"
        Me.radFinish.Size = New System.Drawing.Size(52, 17)
        Me.radFinish.TabIndex = 1
        Me.radFinish.TabStop = True
        Me.radFinish.Text = "Finish"
        Me.radFinish.UseVisualStyleBackColor = True
        '
        'grpStart
        '
        Me.grpStart.Controls.Add(Me.tctStratTimeStart)
        Me.grpStart.Controls.Add(Me.cmbTableNumbersStart)
        Me.grpStart.Controls.Add(Me.txtCategoryStart)
        Me.grpStart.Controls.Add(Me.txtMmebershipName)
        Me.grpStart.Controls.Add(Me.txtMemberIDStart)
        Me.grpStart.Controls.Add(Me.Label5)
        Me.grpStart.Controls.Add(Me.Label4)
        Me.grpStart.Controls.Add(Me.Label3)
        Me.grpStart.Controls.Add(Me.Label2)
        Me.grpStart.Controls.Add(Me.Label1)
        Me.grpStart.Location = New System.Drawing.Point(13, 45)
        Me.grpStart.Name = "grpStart"
        Me.grpStart.Size = New System.Drawing.Size(378, 167)
        Me.grpStart.TabIndex = 2
        Me.grpStart.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MemberShip No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Member's Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Membership Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Table No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Start Time"
        '
        'txtMemberIDStart
        '
        Me.txtMemberIDStart.Location = New System.Drawing.Point(127, 30)
        Me.txtMemberIDStart.Name = "txtMemberIDStart"
        Me.txtMemberIDStart.Size = New System.Drawing.Size(121, 20)
        Me.txtMemberIDStart.TabIndex = 5
        '
        'txtMmebershipName
        '
        Me.txtMmebershipName.Enabled = False
        Me.txtMmebershipName.Location = New System.Drawing.Point(127, 57)
        Me.txtMmebershipName.Name = "txtMmebershipName"
        Me.txtMmebershipName.Size = New System.Drawing.Size(121, 20)
        Me.txtMmebershipName.TabIndex = 6
        '
        'txtCategoryStart
        '
        Me.txtCategoryStart.Enabled = False
        Me.txtCategoryStart.Location = New System.Drawing.Point(127, 83)
        Me.txtCategoryStart.Name = "txtCategoryStart"
        Me.txtCategoryStart.Size = New System.Drawing.Size(121, 20)
        Me.txtCategoryStart.TabIndex = 7
        '
        'cmbTableNumbersStart
        '
        Me.cmbTableNumbersStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTableNumbersStart.FormattingEnabled = True
        Me.cmbTableNumbersStart.Location = New System.Drawing.Point(127, 109)
        Me.cmbTableNumbersStart.Name = "cmbTableNumbersStart"
        Me.cmbTableNumbersStart.Size = New System.Drawing.Size(121, 21)
        Me.cmbTableNumbersStart.TabIndex = 8
        '
        'tctStratTimeStart
        '
        Me.tctStratTimeStart.Enabled = False
        Me.tctStratTimeStart.Location = New System.Drawing.Point(127, 136)
        Me.tctStratTimeStart.Name = "tctStratTimeStart"
        Me.tctStratTimeStart.Size = New System.Drawing.Size(121, 20)
        Me.tctStratTimeStart.TabIndex = 9
        '
        'grpFinish
        '
        Me.grpFinish.Controls.Add(Me.TextBox7)
        Me.grpFinish.Controls.Add(Me.TextBox6)
        Me.grpFinish.Controls.Add(Me.TextBox5)
        Me.grpFinish.Controls.Add(Me.Label14)
        Me.grpFinish.Controls.Add(Me.Label13)
        Me.grpFinish.Controls.Add(Me.TextBox4)
        Me.grpFinish.Controls.Add(Me.TextBox3)
        Me.grpFinish.Controls.Add(Me.TextBox1)
        Me.grpFinish.Controls.Add(Me.ComboBox1)
        Me.grpFinish.Controls.Add(Me.TextBox2)
        Me.grpFinish.Controls.Add(Me.Label12)
        Me.grpFinish.Controls.Add(Me.Label11)
        Me.grpFinish.Controls.Add(Me.Label10)
        Me.grpFinish.Controls.Add(Me.Label9)
        Me.grpFinish.Controls.Add(Me.Label8)
        Me.grpFinish.Controls.Add(Me.Label7)
        Me.grpFinish.Controls.Add(Me.Label6)
        Me.grpFinish.Location = New System.Drawing.Point(13, 45)
        Me.grpFinish.Name = "grpFinish"
        Me.grpFinish.Size = New System.Drawing.Size(378, 234)
        Me.grpFinish.TabIndex = 3
        Me.grpFinish.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Table No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Member's Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Membership Category"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Start Time"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Finish Time"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Playing Time"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Cost Of Game"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(127, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(127, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(127, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(127, 108)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(121, 20)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(127, 140)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(121, 20)
        Me.TextBox4.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(127, 177)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Hours"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(244, 177)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Minutes"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(179, 169)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(48, 20)
        Me.TextBox5.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(295, 170)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(48, 20)
        Me.TextBox6.TabIndex = 16
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(127, 195)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(121, 20)
        Me.TextBox7.TabIndex = 17
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(308, 285)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Start Game"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 363)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.grpFinish)
        Me.Controls.Add(Me.grpStart)
        Me.Controls.Add(Me.radFinish)
        Me.Controls.Add(Me.radStart)
        Me.Name = "frmGame"
        Me.Text = "Awais Snooker Club - Start and Finish a game"
        Me.grpStart.ResumeLayout(False)
        Me.grpStart.PerformLayout()
        Me.grpFinish.ResumeLayout(False)
        Me.grpFinish.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radStart As System.Windows.Forms.RadioButton
    Friend WithEvents radFinish As System.Windows.Forms.RadioButton
    Friend WithEvents grpStart As System.Windows.Forms.GroupBox
    Friend WithEvents tctStratTimeStart As System.Windows.Forms.TextBox
    Friend WithEvents cmbTableNumbersStart As System.Windows.Forms.ComboBox
    Friend WithEvents txtCategoryStart As System.Windows.Forms.TextBox
    Friend WithEvents txtMmebershipName As System.Windows.Forms.TextBox
    Friend WithEvents txtMemberIDStart As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpFinish As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
