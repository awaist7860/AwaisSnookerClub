Public Class frmUtilities

    Private Sub frmUtilities_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowChnageCost()
        grpCosts.Visible = Not grpCosts.Visible
    End Sub

    Private Sub radChangeCost_CheckedChanged(sender As Object, e As EventArgs) Handles radChangeCost.CheckedChanged
        ShowChnageCost()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If radBackup1.Checked = True Then
            Call BackupGamesFile()
        ElseIf radBackup2.Checked = True Then
            Call BackUpMembersFile()
        ElseIf radCreateFile.Checked = True Then
            Call CreateCurrentGamesFile()
        ElseIf radChangeCost.Checked = True Then
            Call ChangeCostOfGame()
        End If
    End Sub

    Public Sub BackupGamesFile()
        Dim Source1, Source2, Destination1, Destination2 As String
        Source1 = "CurrentGames.dat"        'File must be in the bin folder
        Destination1 = "C:\CurrentGames.dat"
        FileCopy(Source1, Destination1)
        Source2 = "FinishedGames.dat"       'File must be in the bin folder
        Destination2 = "C:\FinishedGames.dat"
        FileCopy(Source2, Destination2)
    End Sub

    Public Sub BackupMembersFile()
        Dim Source, Destination As String
        Source = "Members.dat"              'File must be in the bin folder
        Destination = "C:\Members.dat"
        FileCopy(Source, Destination)
    End Sub

    Public Sub CreateCurrentGamesFile()
        'Creates current games file with one record for each value
        Dim OneGame As GameType
        Dim TableNumber As Short
        FileOpen(1, "CurrentGames.dat", OpenMode.Random, , , Len(OneGame))
        For TableNumber = 1 To MaxTables            'Loops 20 times, once for each table
            OneGame.MemberID = " "                  'set member ID to Blank
            OneGame.TableID = TableNumber           'assign a number from 1 to 20
            OneGame.Occupied = "N"                  'set to not occupied
            FilePut(1, OneGame, TableNumber)        'write record to file
        Next TableNumber
        FileClose(1)
    End Sub

    Public Sub ChangeCostOfGame()
        'stores new senior and junior rates in costs file
        Dim JuniorCost, SeniorCost As String
        SeniorCost = txtSeniorRate.Text                 'get the 2 new rates from user
        JuniorCost = txtJuniorRate.Text
        If (Not IsNumeric(SeniorCost)) Or (Not IsNumeric(JuniorCost)) Then
            MsgBox("One or both of the rates are not numbers. Please re-enter")
        Else
            FileOpen(1, "Cost.txt", OpenMode.Output)
            Print(1, SeniorCost, JuniorCost)            'write new rates to the file
            FileClose(1)
        End If
    End Sub

End Class