Public Class RegEnvioIU
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim objCliente As New CmpEnvios.Cliente
            objCliente.ConsultarCliente(txTCI.Text, Me.DbEnvios1.VClientes)
            If Me.DbEnvios1.VClientes.Rows.Count = 0 Then
                MsgBox("Se ha digitado de manera incorrecta el CI del Cliente" & vbNewLine & "Vuelva a intentarlo!!")
                txTCI.Focus()
                txTCI.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub RegEnvioIU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objCarga As New CmpEnvios.Carga
        objCarga.ListarTiposCargas(Me.DbEnvios1.TTiposCarga)
        objCarga.listarDestinos(Me.DbEnvios1.TDestinos)
    End Sub

    Private Sub CbDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDestino.SelectedIndexChanged
        Dim objCarga As New CmpEnvios.Carga
        objCarga.ConsultarCosto(cbTipoCarga.SelectedValue, cbDestino.SelectedValue, Me.DbEnvios1.TTarifas)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim objCliente As New CmpEnvios.Cliente
            objCliente.ConsultarCliente(txTCIDestinatario.Text, Me.DbEnvios2.VClientes)
            If Me.DbEnvios2.VClientes.Rows.Count = 0 Then
                MsgBox("Se ha digitado de manera incorrecta el CI del Destinatario" & vbNewLine & "Vuelva a intentarlo!!")
                txTCIDestinatario.Focus()
                txTCIDestinatario.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim objEnvio As New CmpEnvios.Envio
            objEnvio.GuardarEnvio(txtFecha.Value, txTCI.Text, txtCosto.Text, cbDestino.SelectedValue, txtDetalle.Text, txTCIDestinatario.Text)
            MsgBox("Se ha registrado el nuevo envio de la carga!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class