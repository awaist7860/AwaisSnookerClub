Public Class frmMembers

    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub showAdd()
        grpDelete.Visible = False
        grpAdd.Visible = True
        btnOK.Text = "Add Member"
    End Sub

    Public Sub ShowDelete()
        grpDelete.Visible = True
        grpAdd.Visible = False
        btnOK.Text = "Delete Members"
    End Sub

    Private Function CheckDuplicateMemberID(ByVal MemberID As String) As Boolean
        'Returns True if memberID has already been used as a membership number, otherwise returns false
        Dim Found As Boolean
        Dim OneMember As MemberType         'One record
        Found = False
        FileOpen(1, "Members.dat", OpenMode.Random, , , Len(OneMember))
        Do While (Not EOF(1)) And (Found = False)       'Keep looping until a aduplicate ID has been found or the end of the file is reached
            FileGet(1, OneMember)       '3rd Parameter, record number 
            If (MemberID = OneMember.MemberID) And (OneMember.Deleted = "N") Then
                Found = True
            End If
        Loop
        FileClose(1)
        Return Found            'Return true or false from function
    End Function

    Private Function FindDeletedMember() As Integer
        'Finds the first record in Members file that is logically deleted
        'A logically deleted record has the Deleted field set to Y
        'Returns the record number of the first deleted record, or returns 0 if 	'there are none
        Dim Found As Boolean
        Dim RecordNumber As Short
        Dim OneMember As MemberType
        Found = False
        FileOpen(1, "Members.dat", OpenMode.Random, , , Len(OneMember))
        Do While (Not EOF(1)) And (Found = False)
            RecordNumber = RecordNumber + 1   '****to get to the next record
            FileGet(1, OneMember)    'read record from file
            If OneMember.Deleted = "Y" Then   'is record logically deleted?
                Found = True
            End If
        Loop
        FileClose(1)
        If Found Then            'there IS a deleted record so
            Return RecordNumber   'return its number
        Else
            Return 0     'return 0 if no deleted record in file
        End If
    End Function

    Private Sub AddMember(ByRef OneMember As MemberType)
        'Stores record in memebrs file. Calls FindDeletedMember function to get first logicly deleted record in the file and uses this space for the new record. if no such record it appends new record
        Dim NumberOfRecords, DeletedRecordNumber As Short
        Dim sender As System.Object             'Sender and e must be sent as parameters to btnDisplayMembers_click
        Dim e As System.EventArgs
        DeletedRecordNumber = FindDeletedMember()
        FileOpen(1, "Members.dat", OpenMode.Random, , , Len(OneMember))
        If DeletedRecordNumber <> 0 Then                        'There is a deleted record to use so store record in this space.
            FilePut(1, OneMember, NumberOfRecords + 1)
        Else                                                    'No deleted records so calulate no. of records in file and append new
            NumberOfRecords = LOF(1) / Len(OneMember)
            FilePut(1, OneMember, NumberOfRecords + 1)
        End If
        FileClose(1)
        'Call btnDisplayMembers_Click(sender, e)                 'Son new member is in list box
    End Sub

    Private Function DeleteMember(ByVal MemberID As String) As Boolean
        'Logicly deletes record with membership no. MemberID from Mmebrs file by setting its Deleted dield to Y. Returns True if deletion is succesful, otherwise returns false
        Dim OneMember As MemberType
        Dim RecordNumber As Short
        Dim Found As Boolean
        Dim Sender As System.Object
        Dim e As System.EventArgs
        RecordNumber = 0
        FileOpen(1, "Members.dat", OpenMode.Random, , , Len(OneMember))
        Do While (Not EOF(1)) And (Not Found)
            RecordNumber = RecordNumber + 1
            FileGet(1, OneMember)                           'Read one record from file
            If OneMember.MemberID = MemberID Then           'is the the required record?
                If OneMember.Deleted = "Y" Then             'has the member been deleted
                    MsgBox("This member does not exist")
                Else
                    OneMember.Deleted = "Y"
                    Found = True
                End If
            End If
        Loop
        FilePut(1, OneMember, RecordNumber)                 'Write record to file
        FileClose(1)
        'Call btnDisplayMembers_Click(Sender, e)             'Remove member from list box
        If Not Found Then                                   'no record in file to delete
            Return False
        Else                                                'a record has been deleted
            Return True
        End If
    End Function

    Private Sub radAdd_CheckedChanged(sender As Object, e As EventArgs) Handles radAdd.CheckedChanged
        showAdd()
    End Sub

    Private Sub radDelete_CheckedChanged(sender As Object, e As EventArgs) Handles radDelete.CheckedChanged
        ShowDelete()
    End Sub


    Private Sub btnDisplayMembers_Click(sender As Object, e As EventArgs) Handles btnDisplayMembers.Click

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Processes either adding or deleting a member
        Dim memberID As String
        Dim MemberDeleted As Boolean        'Return value from DeleteMember
        Dim Duplicate As Boolean            'True is membership number already in use
        Dim Response As Short               'Reply when asked to confirim impending deletion
        Dim OneMember As MemberType
        If btnOK.Text = "Add Member" Then               'Add member
            If txtmemberIDAdd.Text.Length = 6 Then     '6 caharcter ID entered check
                memberID = txtmemberIDAdd.Text
                Duplicate = CheckDuplicateMemberID(memberID)        'Is membership

                If Not Duplicate Then           'Membership number is not true
                    'members details have been entered on form so use them
                    If (txtSurname.Text <> "") And (txtFirstname.Text <> "") And (lstCategory.Text <> "") Then
                        OneMember.MemberID = txtmemberIDAdd.Text    'Collect details into one record

                        OneMember.Surname = txtSurname.Text
                        OneMember.Firstname = txtFirstname.Text
                        If lstCategory.Text = "Senior" Then
                            OneMember.Category = "S"
                        Else
                            OneMember.Category = "J"
                        End If
                        OneMember.Deleted = "N"
                        Call AddMember(OneMember)                   'Add new member to file
                        txtmemberIDAdd.Text = ""                    'Clear member details on form
                        txtSurname.Text = ""
                        txtFirstname.Text = ""
                    Else
                        MsgBox("You have not filled in all the details of the member")
                    End If
                Else                                                ''user has entered a duplicate membership number
                    MsgBox("Membership No. " & memberID * " has been used. ENter a different one")
                    txtmemberIDAdd.Focus()
                End If
            Else                                'Not enough characters typed in for membership no.
                MsgBox("You must enter a amebership number with 6 characters")
                txtmemberIDAdd.Focus()
            End If
        Else            'Else part of (if btn.text = "add member") i.e delete a member
            memberID = txtMemberIDDelete.Text
            If memberID = "" Then           'User has not enterd a membership number
                MsgBox("You havent entered a membership number")
            Else
                Response = MsgBox("Confirm you want to delete this number?", vbYesNo)
                If Response = 6 Then            'User Does wish to delete
                    MemberDeleted = DeleteMember(memberID)          'True if deletion a success
                    txtMemberIDDelete.Text = ""
                    If Not MemberDeleted Then               'Deletion not succesful
                        MsgBox("Member not deleted. Membership number " & memberID & "does not exist")
                    End If
                End If
            End If          'end of (if memberid ="")
        End If              'end of (if btnOk.Text = "Add Member")
    End Sub
End Class