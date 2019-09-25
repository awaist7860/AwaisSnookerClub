Public Class frmGame

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radStart_CheckedChanged(sender As Object, e As EventArgs) Handles radStart.CheckedChanged
        showGRPStart()
    End Sub

    Private Sub radFinish_CheckedChanged(sender As Object, e As EventArgs) Handles radFinish.CheckedChanged
        showGRPFinish()
    End Sub

    Public Sub showGRPStart()
        grpStart.Visible = True         'Hide Controls for starting a game
        grpFinish.Visible = False       'and show the finishing ones
        btnOk.Text = "Start Game"
    End Sub

    Public Sub showGRPFinish()
        grpStart.Visible = False         'Hide Controls for starting a game
        grpFinish.Visible = True       'and show the finishing ones
        btnOk.Text = "Finish Game"
    End Sub
End Class