namespace IDC.DTOs
{
    public class ItemDTO
    {
        public virtual int Id { get; set; }
        public int IdCongregacion { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public string? UrlImagen { get; set; }
        public int TotalPaginas { get; set; }

        public string GenerateSlug() => $"{Id}-{Titulo}".Replace(" ", "-").ToLower();
    }

    public class QuienesSomosDTO : ItemDTO
    {
        public int IdQuienesSomos { get; set; }  // Campo específico de QuienesSomos

        // Sobreescribir la propiedad Id para mapearla a IdQuienesSomos
        public override int Id
        {
            get => IdQuienesSomos;
            set => IdQuienesSomos = value;
        }
        public string? UrlImagenQuienesSomos { get; set; }
    }

    public class AlabanzaDTO : ItemDTO
    {
        public int IdAlabanza { get; set; }  // Campo específico de QuienesSomos

        // Sobreescribir la propiedad Id para mapearla a IdQuienesSomos
        public override int Id
        {
            get => IdAlabanza;
            set => IdAlabanza = value;
        }
        public string? UrlImagenAabanza { get; set; }
    }

}
