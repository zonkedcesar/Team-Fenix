Public Class Acerca
    Private Sub Acerca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TagVersion.Text = String.Format("Versión {0}", My.Application.Info.Version.ToString)
        RichTextBox1.Enabled = False
    End Sub
End Class