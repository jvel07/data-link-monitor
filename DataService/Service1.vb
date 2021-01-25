' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in both code and config file together.
Public Class Service1
    Implements IService1

    Public Function GetData(ByVal value As Integer) As String Implements IService1.GetData
        Return String.Format("You entered: {0}", value)
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IService1.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

    'ESTADOS
    Public Function insertarEstadoEnlace(ByVal id_estado_enlace As Integer, ByVal porcent_pings_perd As Double, ByVal tiempo_monitoreo As Integer, ByVal fk_id_farm As Integer, ByVal ip_farm As String, ByVal nombre_farm As String) As Integer Implements IService1.insertarEstadoEnlace
        Dim Estado_EnlaceTableAdapter As New DataAccessTier.intermitenciaDataSetTableAdapters.Estado_EnlaceTableAdapter()
        Return Estado_EnlaceTableAdapter.Insert(id_estado_enlace, porcent_pings_perd, tiempo_monitoreo, fk_id_farm, ip_farm, nombre_farm)

    End Function

    Public Function obtenerEstados() As DataEntityTier.intermitenciaDataSet.Estado_EnlaceDataTable Implements IService1.obtenerEstados
        Dim Estado_EnlaceTableAdapter As New DataAccessTier.intermitenciaDataSetTableAdapters.Estado_EnlaceTableAdapter()
        Return Estado_EnlaceTableAdapter.GetEstados

    End Function

    Public Function modificarEstadoEnlace(ByVal id_estado_enlace As Integer, ByVal porcent_pings_perd As Double, ByVal tiempo_monitoreo As Integer, ByVal fk_id_farm As Integer, ByVal ip_farm As String, ByVal nombre_farm As String) As Integer Implements IService1.modificarEstadoEnlace
        Dim Estado_EnlaceTableAdapter As New DataAccessTier.intermitenciaDataSetTableAdapters.Estado_EnlaceTableAdapter()
        Return Estado_EnlaceTableAdapter.UpdateEstado(porcent_pings_perd, tiempo_monitoreo, fk_id_farm, ip_farm, nombre_farm, id_estado_enlace)

    End Function

    Public Function eliminarEstadoEnlace() As Integer Implements IService1.eliminarEstadoEnlace
        Dim Estado_EnlaceTableAdapter As New DataAccessTier.intermitenciaDataSetTableAdapters.Estado_EnlaceTableAdapter()
        Return Estado_EnlaceTableAdapter.DeleteEstados
    End Function
    'FARMACIAS
    Public Function insertarFarmacia(ByVal id_farmacia As Integer, ByVal nombre_farmacia As String, ByVal ip_farmacia As String, ByVal rec_alerta As String) As Integer Implements IService1.insertarFarmacia
        Dim Info_FarmaciaTableAdapter As New DataAccessTier.intermitenciaDataSetTableAdapters.Info_FarmaciaTableAdapter()
        Return Info_FarmaciaTableAdapter.InsertFarmacia(id_farmacia, nombre_farmacia, ip_farmacia, rec_alerta)
    End Function

    Public Function modificarFarmacia(ByVal idFarmacia As Integer, ByVal nombreFarmacia As String, ByVal ipFarmacia As String, ByVal rec_alerta As String) As Integer Implements IService1.modificarFarmacia
        Dim Info_FarmaciaTableAdapter As New DataAccessTier.intermitenciaDataSetTableAdapters.Info_FarmaciaTableAdapter()
        Return Info_FarmaciaTableAdapter.UpdateFarmacia(nombreFarmacia, ipFarmacia, rec_alerta, idFarmacia)

    End Function
    Public Function obtenerFarmacias() As DataEntityTier.intermitenciaDataSet.Info_FarmaciaDataTable Implements IService1.obtenerFarmacias
        Dim Info_FarmaciaTableAdapter As New DataAccessTier.intermitenciaDataSetTableAdapters.Info_FarmaciaTableAdapter()
        Return Info_FarmaciaTableAdapter.GetFarmacias
    End Function






   
End Class
