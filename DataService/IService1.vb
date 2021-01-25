' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
<ServiceContract()>
Public Interface IService1

    <OperationContract()>
    Function GetData(ByVal value As Integer) As String

    <OperationContract()>
    Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType

    ' TODO: Add your service operations here


    'FUNCIONES ESTADO ENLACE

    <OperationContract()>
    Function insertarEstadoEnlace(ByVal id_estado_enlace As Integer, ByVal porcent_pings_perd As Double, ByVal tiempo_monitoreo As Integer, ByVal fk_id_farm As Integer, ByVal ip_farm As String, ByVal nombre_farm As String) As Integer

    <OperationContract()>
    Function obtenerEstados() As DataEntityTier.intermitenciaDataSet.Estado_EnlaceDataTable

    <OperationContract()>
    Function modificarEstadoEnlace(ByVal id_estado_enlace As Integer, ByVal porcent_pings_perd As Double, ByVal tiempo_monitoreo As Integer, ByVal fk_id_farm As Integer, ByVal ip_farm As String, ByVal nombre_farm As String) As Integer

    <OperationContract()>
    Function eliminarEstadoEnlace() As Integer

    'FUNCIONES INFO FARMACIA

    <OperationContract()>
    Function insertarFarmacia(ByVal id_farmacia As Integer, ByVal nombre_farmacia As String, ByVal ip_farmacia As String, ByVal rec_alerta As String) As Integer

    <OperationContract()>
    Function obtenerFarmacias() As DataEntityTier.intermitenciaDataSet.Info_FarmaciaDataTable

    <OperationContract()> _
    Function modificarFarmacia(ByVal codigoFarmacia As Integer, ByVal nombreFarmacia As String, ByVal ipFarmacia As String, ByVal rec_alerta As String) As Integer




End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property BoolValue() As Boolean

    <DataMember()>
    Public Property StringValue() As String

End Class
