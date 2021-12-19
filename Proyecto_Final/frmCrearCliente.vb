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
        Dim bln2 As Boolean = vali.validar_nombre_empresa(txtnombree.Text)
        Dim bln3 As Boolean = vali.validar_cod_empresa(txtcod.Text)
        Dim agregar As New ClaseClientes
        cod = val(txtcod.Text)
        nombre = txtnombree.Text
        ubicacion = txtubicacion.Text
        email = txtemail.Text
        numero = txtnumerot.Text
        If bln = False Then
            MessageBox.Show("Ingrese un E-mail Valido")
            txtemail.ResetText()
            txtemail.Focus()
        ElseIf bln2 Then
            MessageBox.Show("este nombre ya existe")
            txtnombree.ResetText()
            txtnombree.Focus()
        ElseIf bln3 Then
            MessageBox.Show("este codigo de usuario es invalido o ya existe")
            txtcod.ResetText()
            txtcod.Focus()
        Else
            Try
                MessageBox.Show(agregar.agregar_nuevo_cliente(cod, nombre, ubicacion, email, numero))
                txtcod.ResetText()
                txtnombree.ResetText()
                txtubicacion.ResetText()
                txtemail.ResetText()
                txtnumerot.ResetText()
                txtcod.Focus()
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
    Private Sub txtnombree_Leave(sender As Object, e As EventArgs) Handles txtnombree.Leave
        If Trim(txtnombree.Text) = "" Then
            MsgBox("vacio")
            txtnombree.Focus()
        End If
    End Sub

    Private Sub txtubicacion_Leave(sender As Object, e As EventArgs) Handles txtubicacion.Leave
        If Trim(txtubicacion.Text) = "" Then
            MsgBox("vacio")
            txtubicacion.Focus()
        End If
    End Sub

    Private Sub txtemail_Leave(sender As Object, e As EventArgs) Handles txtemail.Leave
        If Trim(txtemail.Text) = "" Then
            MsgBox("vacio")
            txtemail.Focus()
        End If
    End Sub

    Private Sub txtnumerot_Leave(sender As Object, e As EventArgs) Handles txtnumerot.Leave
        If Trim(txtnumerot.Text) = "" Then
            MsgBox("vacio")
            txtnumerot.Focus()
        End If
    End Sub

    Private Sub txtcod_Leave(sender As Object, e As EventArgs) Handles txtcod.Leave
        If Trim(txtcod.Text) = "" Then
            MsgBox("vacio")
            txtcod.Focus()
        End If
    End Sub

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