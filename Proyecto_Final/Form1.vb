Imports Modulo_Conexion
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnconexion_Click(sender As Object, e As EventArgs) Handles btnconexion.Click
        Dim modulo As New CAProbarConexion
        Dim respuestas As Boolean = modulo.verificarconexion
        If respuestas Then
            frmprincipal.Show()
            Me.Hide()
        Else
            MessageBox.Show("error al realizar la conexion", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
