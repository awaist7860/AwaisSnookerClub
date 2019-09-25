Module modDeclaration
    Public lblTables(19), lblStartTimes(19) As Label

    Sub Main()
        Dim MainForm As New frmMain()                   'decalre a frmMain object
        Dim GameForm As New frmGame()                   'Declare a frmGame object
        lblTables(0) = MainForm.lblTable1               'Populate control array of tables
        lblTables(1) = MainForm.lblTable2
        lblTables(2) = MainForm.lblTable3
        lblTables(3) = MainForm.lblTable4
        lblTables(4) = MainForm.lblTable5
        lblTables(5) = MainForm.lblTable6
        lblTables(6) = MainForm.lblTable7
        lblTables(7) = MainForm.lblTable8
        lblTables(8) = MainForm.lblTable9
        lblTables(9) = MainForm.lblTable10
        lblTables(10) = MainForm.lblTable11
        lblTables(11) = MainForm.lblTable12
        lblTables(12) = MainForm.lblTable13
        lblTables(13) = MainForm.lblTable14
        lblTables(14) = MainForm.lblTable15
        lblTables(15) = MainForm.lblTable16
        lblTables(16) = MainForm.lblTable17
        lblTables(17) = MainForm.lblTable18
        lblTables(18) = MainForm.lblTable19
        lblTables(19) = MainForm.lblTable20

        lblStartTimes(0) = MainForm.lblStartTime1       'Populate control aray of start times
        lblStartTimes(1) = MainForm.lblStartTime2
        lblStartTimes(2) = MainForm.lblStartTime3
        lblStartTimes(3) = MainForm.lblStartTime4
        lblStartTimes(4) = MainForm.lblStartTime5
        lblStartTimes(5) = MainForm.lblStartTime6
        lblStartTimes(6) = MainForm.lblStartTime7
        lblStartTimes(7) = MainForm.lblStartTime8
        lblStartTimes(8) = MainForm.lblStartTime9
        lblStartTimes(9) = MainForm.lblStartTime10
        lblStartTimes(10) = MainForm.lblStartTime11
        lblStartTimes(11) = MainForm.lblStartTime12
        lblStartTimes(12) = MainForm.lblStartTime13
        lblStartTimes(13) = MainForm.lblStartTime14
        lblStartTimes(14) = MainForm.lblStartTime15
        lblStartTimes(15) = MainForm.lblStartTime16
        lblStartTimes(16) = MainForm.lblStartTime17
        lblStartTimes(17) = MainForm.lblStartTime18
        lblStartTimes(18) = MainForm.lblStartTime19
        lblStartTimes(19) = MainForm.lblStartTime20

        MainForm.ShowDialog()                           'Display main form

        'MsgBox(NumberOfMinutes("12:30:30", "10:20:55"))        Test the NumberOfMinutes funtion
        'MsgBox(ShortenTime("12:34:46"))                        Tets the shortenTime function`
    End Sub

    Public Const MaxTables = 20     'Awais has 20 tables

    Structure GameType              'Data type for a record to store one current game
        <VBFixedString(6)> Public MemberID As String        '6 bytes
        Dim TableID As Short        '2 bytes
        Dim StartTime As Date       '8 bytes
        Dim Occupied As Char        '2 bytes
    End Structure                   'One record is 18 bytes

    Structure GameFinishedType      'Data type for a finshed game
        Dim TableID As Short        '2 bytes
        Dim StartTime As Date       '8 bytes
        Dim FinsihTime As Date      '8 bytes
        Dim Cost As Decimal         '16 bytes
    End Structure                   ''One record is 34 bytes

    Structure MemberType
        <VBFixedString(6)> Public MemberID As String        '6 bytes
        <VBFixedString(15)> Public Surname As String        '15 bytes
        <VBFixedString(15)> Public Firstname As String      '15 bytes
        Dim Category As Char                                '2 bytes
        Dim Deleted As Char                                 '2 bytes
    End Structure                                           'One record is 40 bytes

End Module
