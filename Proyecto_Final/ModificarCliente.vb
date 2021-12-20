Imports Modulo_Conexion
Imports ModuloClientes
Imports Modulo_Administracion
Imports System.Data.SqlClient

Public Class ModificarCliente
    Private id As Integer




    Private Sub btn_Modificar_Click1(sender As Object, e As EventArgs)

    End Sub



    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        btn_elegir.Enabled = True
        Dim cliente As New clientes
        Dim conectar As New CAConexion
        Dim dtclientes As New DataTable
        dtclientes = cliente.Consultar_clientes(txtNombreBuscar.Text)
        If dtclientes.Rows.Count <> 0 Then

            With cbox_clientes
                .DataSource = dtclientes
                .DisplayMember = "nombre"
                .ValueMember = "id_clientes"
            End With
        Else
            MsgBox("No tiene clientes asociados")
            cbox_clientes.DataSource = Nothing
            cbox_clientes.Items.Clear()
            btn_elegir.Enabled = False
        End If
    End Sub

    Private Sub btn_elegir_Click(sender As Object, e As EventArgs) Handles btn_elegir.Click
        Dim cliente As New clientes
        Dim conectar As New CAConexion
        Dim dtCliente As New DataTable
        Dim fila As DataRow

        Dim id As Integer

        dtCliente = cliente.Con_cliente(cbox_clientes.SelectedValue, txtNombreBuscar.Text)

        If dtCliente.Rows.Count <> 0 Then
            fila = dtCliente.Rows.Item(0)
            id = fila.ItemArray(0)
            txtNombre.Text = fila.ItemArray(1)
            txtApellido.Text = fila.ItemArray(2)
            txtemail.Text = fila.ItemArray(3)
            txtnumerot.Text = fila.ItemArray(4)
        End If
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        Dim nombre
        Dim ubicacion
        Dim correo
        Dim numTel
        Dim cliente As New CLogica



        nombre = txtNombre.Text
        ubicacion = txtApellido.Text
        correo = txtemail.Text
        numTel = txtnumerot.Text


        If String.IsNullOrEmpty(nombre) Or String.IsNullOrEmpty(ubicacion) Or String.IsNullOrEmpty(correo) Or String.IsNullOrEmpty(numTel) Then
            MsgBox("Complete todos los campos del Formulario")
        Else
            Try
                MessageBox.Show(cliente.actualizar_cliente(cbox_clientes.SelectedValue, nombre, ubicacion, correo, numTel))
                cbox_clientes.Refresh()
                txtNombreBuscar.Text = txtNombre.Text
                txtNombre.ResetText()
                txtApellido.ResetText()
                txtemail.ResetText()
                txtnumerot.ResetText()

            Catch ex As Exception
                MessageBox.Show("Error al actualizar cliente " + ex.Message)
            End Try
        End If

    End Sub
End Class