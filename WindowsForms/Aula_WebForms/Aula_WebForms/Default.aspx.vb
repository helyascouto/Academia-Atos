Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Clixk_Click(sender As Object, e As EventArgs) Handles Click.Click
        lbnNome.Text = txbNome.Text


    End Sub
End Class