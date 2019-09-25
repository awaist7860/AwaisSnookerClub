Public Class frmMain

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblTable11.Click

    End Sub

    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        'Displays the game form
        Dim GameForm As New frmGame()
        GameForm.ShowDialog()
    End Sub

    Private Sub btnMembership_Click(sender As Object, e As EventArgs) Handles btnMembership.Click
        'Displays the membership form
        Dim Membership As New frmMembers()
        Membership.ShowDialog()
    End Sub

    Private Sub btnUtiltites_Click(sender As Object, e As EventArgs) Handles btnUtiltites.Click
        'Displays the utilities form
        Dim Utilities As New frmUtilities()
        Utilities.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes everything
        Me.Close()
    End Sub
End Class
