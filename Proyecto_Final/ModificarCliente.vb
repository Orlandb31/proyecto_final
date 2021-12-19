Imports Modulo_Conexion
Imports ModuloClientes
Imports System.Data.SqlClient

Public Class ModificarCliente

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cliente As New clientes
        Dim conectar As New CAConexion
        Dim dtclientes As New DataTable
        dtclientes = cliente.Consultar_cliente(txtNombreBuscar.Text)

        If dtclientes.Rows.Count <> 0 Then

            With cbox_clientes
                .DataSource = dtclientes
                .DisplayMember = "impresion"
                .ValueMember = "nombre"
            End With
        Else
            MsgBox("No tiene clientes asociados")
            cbox_clientes.DataSource = Nothing
            cbox_clientes.Items.Clear()
            btn_elegir.Enabled = False
        End If
    End Sub

    Private Sub btn_elegir_Click(sender As Object, e As EventArgs) Handles btn_elegir.Click

    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click

    End Sub
End Class