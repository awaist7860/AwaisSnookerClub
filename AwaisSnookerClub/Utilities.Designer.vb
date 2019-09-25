<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilities
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpCosts = New System.Windows.Forms.GroupBox()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.txtJuniorRate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSeniorRate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radChangeCost = New System.Windows.Forms.RadioButton()
        Me.radCreateFile = New System.Windows.Forms.RadioButton()
        Me.radBackup2 = New System.Windows.Forms.RadioButton()
        Me.radBackup1 = New System.Windows.Forms.RadioButton()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpCosts.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grpCosts)
        Me.GroupBox1.Controls.Add(Me.radChangeCost)
        Me.GroupBox1.Controls.Add(Me.radCreateFile)
        Me.GroupBox1.Controls.Add(Me.radBackup2)
        Me.GroupBox1.Controls.Add(Me.radBackup1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 327)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'grpCosts
        '
        Me.grpCosts.Controls.Add(Me.lblHelp)
        Me.grpCosts.Controls.Add(Me.txtJuniorRate)
        Me.grpCosts.Controls.Add(Me.Label2)
        Me.grpCosts.Controls.Add(Me.txtSeniorRate)
        Me.grpCosts.Controls.Add(Me.Label1)
        Me.grpCosts.Location = New System.Drawing.Point(6, 228)
        Me.grpCosts.Name = "grpCosts"
        Me.grpCosts.Size = New System.Drawing.Size(589, 86)
        Me.grpCosts.TabIndex = 4
        Me.grpCosts.TabStop = False
        Me.grpCosts.Visible = False
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Location = New System.Drawing.Point(451, 20)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(97, 26)
        Me.lblHelp.TabIndex = 4
        Me.lblHelp.Text = "Enter as pence per" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "minute eg 4, 5.5"
        '
        'txtJuniorRate
        '
        Me.txtJuniorRate.Location = New System.Drawing.Point(329, 20)
        Me.txtJuniorRate.Name = "txtJuniorRate"
        Me.txtJuniorRate.Size = New System.Drawing.Size(100, 20)
        Me.txtJuniorRate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Junior Rate"
        '
        'txtSeniorRate
        '
        Me.txtSeniorRate.Location = New System.Drawing.Point(95, 20)
        Me.txtSeniorRate.Name = "txtSeniorRate"
        Me.txtSeniorRate.Size = New System.Drawing.Size(100, 20)
        Me.txtSeniorRate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Senior Rate"
        '
        'radChangeCost
        '
        Me.radChangeCost.AutoSize = True
        Me.radChangeCost.Location = New System.Drawing.Point(7, 189)
        Me.radChangeCost.Name = "radChangeCost"
        Me.radChangeCost.Size = New System.Drawing.Size(136, 17)
        Me.radChangeCost.TabIndex = 3
        Me.radChangeCost.TabStop = True
        Me.radChangeCost.Text = "Change Cost of a game"
        Me.radChangeCost.UseVisualStyleBackColor = True
        '
        'radCreateFile
        '
        Me.radCreateFile.AutoSize = True
        Me.radCreateFile.Location = New System.Drawing.Point(7, 135)
        Me.radCreateFile.Name = "radCreateFile"
        Me.radCreateFile.Size = New System.Drawing.Size(180, 17)
        Me.radCreateFile.TabIndex = 2
        Me.radCreateFile.TabStop = True
        Me.radCreateFile.Text = "Create a new Current Games File"
        Me.radCreateFile.UseVisualStyleBackColor = True
        '
        'radBackup2
        '
        Me.radBackup2.AutoSize = True
        Me.radBackup2.Location = New System.Drawing.Point(7, 88)
        Me.radBackup2.Name = "radBackup2"
        Me.radBackup2.Size = New System.Drawing.Size(135, 17)
        Me.radBackup2.TabIndex = 1
        Me.radBackup2.TabStop = True
        Me.radBackup2.Text = "Back up Members Files"
        Me.radBackup2.UseVisualStyleBackColor = True
        '
        'radBackup1
        '
        Me.radBackup1.AutoSize = True
        Me.radBackup1.Location = New System.Drawing.Point(7, 39)
        Me.radBackup1.Name = "radBackup1"
        Me.radBackup1.Size = New System.Drawing.Size(242, 17)
        Me.radBackup1.TabIndex = 0
        Me.radBackup1.TabStop = True
        Me.radBackup1.Text = "Back up Current Games and Daily Games files"
        Me.radBackup1.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(538, 357)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmUtilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 468)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUtilities"
        Me.Text = "Awais Snooker Club - Utilities"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpCosts.ResumeLayout(False)
        Me.grpCosts.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpCosts As System.Windows.Forms.GroupBox
    Friend WithEvents radChangeCost As System.Windows.Forms.RadioButton
    Friend WithEvents radCreateFile As System.Windows.Forms.RadioButton
    Friend WithEvents radBackup2 As System.Windows.Forms.RadioButton
    Friend WithEvents radBackup1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents txtJuniorRate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSeniorRate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
