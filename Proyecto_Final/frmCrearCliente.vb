Imports Modulo_Administracion
Imports System.Text.RegularExpressions
Public Class frmCrearCliente
    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Dim cod As Integer
        Dim nombre As String
        Dim vali As New validaciones
        Dim ubicacion As String
        Dim email As String
        Dim numero As String
        Dim bln As Boolean = IsValidEmail(txtemail.Text)
        Dim bln2 As Boolean = vali.validar_nombre_empresa(txtnombre.Text)
        Dim bln3 As Boolean = vali.validar_cod_empresa(CInt(txtcod.Text))
        Dim agregar As New ClaseClientes
        cod = Val(txtcod.Text)
        nombre = txtnombre.Text
        ubicacion = txtubicacion.Text
        email = txtemail.Text
        numero = txtnumerot.Text
        If Trim(txtcod.Text) = "" Then
            MsgBox("codigo de empresa vacio")
            txtcod.Focus()
        ElseIf Trim(txtnombre.Text) = "" Then
            MsgBox("nombre vacio")
            txtnombre.Focus()
        ElseIf Trim(txtubicacion.Text) = "" Then
            MsgBox("ubicacion vacio")
            txtubicacion.Focus()
        ElseIf Trim(txtemail.Text) = "" Then
            MsgBox("email vacio")
            txtemail.Focus()
        ElseIf Trim(txtnumerot.Text) = "" Then
            MsgBox("numero de telefono vacio")
            txtnumerot.Focus()
        ElseIf bln = False Then
            MessageBox.Show("Ingrese un E-mail Valido")
            txtemail.ResetText()
            txtemail.Focus()
        ElseIf bln2 Then
            MessageBox.Show("este nombre ya existe")
            txtcod.ResetText()
            txtcod.Focus()
        ElseIf bln3 Then
            MessageBox.Show("este codigo de usuario es invalido o ya existe")
            txtnombre.ResetText()
            txtnombre.Focus()
        Else
            Try
                MessageBox.Show(agregar.agregar_nuevo_cliente(cod, nombre, ubicacion, email, numero))
                txtnombre.ResetText()
                txtcod.ResetText()
                txtubicacion.ResetText()
                txtemail.ResetText()
                txtnumerot.ResetText()
                txtnombre.Focus()
            Catch ex As Exception
                MessageBox.Show("Hubo un error=" + ex.ToString)
            End Try
        End If
    End Sub
    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then
            Return False
        End If
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function


    Private Sub txtcod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then
            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
        End If
    End Sub

    Private Sub frmCrearC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcod.Focus()
    End Sub
End Class