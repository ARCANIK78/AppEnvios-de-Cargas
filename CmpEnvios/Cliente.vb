Public Class Cliente
    Public Sub ConsultarCliente(CI As String, ds As dbEnvios.VClientesDataTable)
        Try
            Dim adap As New dbEnviosTableAdapters.VClientesTableAdapter
            adap.ConsultarXCI(ds, CI)
        Catch ex As Exception

        End Try

    End Sub
End Class
