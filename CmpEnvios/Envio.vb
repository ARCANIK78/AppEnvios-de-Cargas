Public Class Envio
    Public Sub GuardarEnvio(fecha As Date, CI As String, costo As Double, DestinoID As String, detalle As String, CIDest As String)
        Try
            Dim adap As New dbEnviosTableAdapters.TEnviosTableAdapter
            adap.Insert(fecha, costo, detalle, CI, CIDest, DestinoID, "PENDIENTE")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
