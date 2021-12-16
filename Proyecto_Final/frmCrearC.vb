Imports Modulo_Administracion
Imports System.Text.RegularExpressions
Public Class frmCrearC
    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Dim nombre As String
        Dim val As New validaciones
        Dim ubicacion As String
        Dim email As String
        Dim numero As String
        Dim bln As Boolean = IsValidEmail(txtemail.Text)
        Dim bln2 As Boolean = val.validar(txtnombree.Text)
        Dim insertar As New CLogica
        nombre = txtnombree.Text
        ubicacion = txtubicacion.Text
        email = txtemail.Text
        numero = txtnumerot.Text
        If bln Then
            MessageBox.Show("Ingrese un E-mail Valido")
            txtemail.ResetText()
        ElseIf bln2 Then
            MessageBox.Show("este nombre ya existe")
        Else
            Try
                'MessageBox.Show(insertar.Ingresarproducto(nombre, precio, cantidad, descripcion))
            Catch ex As Exception
                MessageBox.Show("Hubo un error=" + ex.ToString)
            End Try

        End If
    End Sub
    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function
End Class