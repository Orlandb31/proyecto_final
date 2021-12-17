﻿Imports Modulo_Administracion

Public Class frmcrearproducto

    Private Sub Precio_Click(sender As Object, e As EventArgs) Handles lblprecio.Click

    End Sub

    Private Sub frmcrearproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre As String
        Dim precio As Double
        Dim cantidad As Integer
        Dim descripcion As String
        Dim insert As New CLogica
        nombre = txtnombre.Text
        descripcion = txtdescripcion.Text
        precio = Val(txtprecio.Text)
        cantidad = Val(Numeric1.Text)
        If (cantidad <= 5) Then
            MessageBox.Show("No se puede ingresar un producto menor a 5 unidades")
        ElseIf (cantidad > 5) Then
            Try
                MessageBox.Show(insert.Ingresarproducto(nombre, precio, cantidad, descripcion))
            Catch ex As Exception
                MessageBox.Show("Hubo un error=" + ex.ToString)
            End Try

        End If
    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        NumerosyDecimal(txtprecio, e)
    End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class