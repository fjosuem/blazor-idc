namespace IDC.DTOs
{
    public class DetalleItemDTO
    {
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Nombre { get; set; }
        public string? UrlImagen { get; set; }
        public string? UrlVideoYoutube { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaEdicion { get; set; }
    }
    
    public class DetalleDoctrinaDTO: DetalleItemDTO
    {
        public int IdDetalleDoctrina { get; set; }
        public int IdDoctrina { get; set; }
    }
}
