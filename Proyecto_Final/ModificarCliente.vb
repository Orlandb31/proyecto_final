Imports Modulo_Conexion
Imports ModuloClientes
Imports System.Data.SqlClient

Public Class ModificarCliente
    Private cliente As New clientes
    Private conectar As New CAConexion
    Private dtclientes As New DataTable
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try
            dtclientes = cliente.Consultar_cliente(txtNombreBuscar.Text)
            MsgBox(dtclientes)

            If dtclientes.Rows.Count <> 0 Then

                With cbox_clientes
                    .DataSource = dtclientes
                    .ValueMember = "nombre"
                    .DisplayMember = "impresion"
                End With
            Else
                MsgBox("No tiene clientes asociados")
                cbox_clientes.DataSource = Nothing
                cbox_clientes.Items.Clear()
                btn_elegir.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conectar.conexion.State <> ConnectionState.Closed Then conectar.conexion.Close()
        End Try
    End Sub
End Class