namespace WPF_SUSUERTE_V1.Domain.Enums
{
    public enum StateTransaction
    {
        Iniciada = 1,
        Aprobada,
        Cancelada,
        AprobadaErrorDevuelta,
        CanceladaErrorDevuelta,
        AprobadaSinNotificar,
        ErrorServicioTercero
    }
}
