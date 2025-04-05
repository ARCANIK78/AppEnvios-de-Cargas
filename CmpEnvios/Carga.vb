Public Class Carga
    Public Sub ListarTiposCargas(ds As dbEnvios.TTiposCargaDataTable)
        Try
            Dim adap As New dbEnviosTableAdapters.TTiposCargaTableAdapter
            adap.Fill(ds)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub listarDestinos(ds As dbEnvios.TDestinosDataTable)
        Try
            Dim adap As New dbEnviosTableAdapters.TDestinosTableAdapter
            adap.Fill(ds)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ConsultarCosto(TipoCargaID As String, DestinoID As String, ds As dbEnvios.TTarifasDataTable)
        Try
            Dim adap As New dbEnviosTableAdapters.TTarifasTableAdapter
            adap.ConsultarTarifa(ds, TipoCargaID, DestinoID)

        Catch ex As Exception

        End Try

    End Sub
End Class
