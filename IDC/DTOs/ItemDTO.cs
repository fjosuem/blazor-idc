using IDC.Pages;

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
        public int IdQuienesSomos { get; set; }
        public override int Id
        {
            get => IdQuienesSomos;
            set => IdQuienesSomos = value;
        }
        public string? UrlImagenQuienesSomos { get; set; }
    }

    public class DoctrinaDTO : ItemDTO
    {
        public int IdDoctrina { get; set; }
        public override int Id
        {
            get => IdDoctrina;
            set => IdDoctrina = value;
        }
        public string? UrlImagenDoctrina { get; set; }
    }
    public class DevocionalDTO : ItemDTO
    {
        public int IdDevocional { get; set; }
        public override int Id
        {
            get => IdDevocional;
            set => IdDevocional = value;
        }
        public string? UrlImagenDevocional { get; set; }
    }

    public class CortoDTO : ItemDTO
    {
        public int IdCorto { get; set; }
        public override int Id
        {
            get => IdCorto;
            set => IdCorto = value;
        }
        public string? UrlImagenCorto { get; set; }
    }

    public class LeninDTO : ItemDTO
    {
        public int IdLenin { get; set; }
        public override int Id
        {
            get => IdLenin;
            set => IdLenin = value;
        }
        public string? UrlImagenLenin { get; set; }
    }

    public class GriegoDTO : ItemDTO
    {
        public int IdGriego { get; set; }
        public override int Id
        {
            get => IdGriego;
            set => IdGriego = value;
        }
        public string? UrlImagenGriego { get; set; }
    }

    public class AlabanzaDTO : ItemDTO
    {
        public int IdAlabanza { get; set; }
        public override int Id
        {
            get => IdAlabanza;
            set => IdAlabanza = value;
        }
        public string? UrlImagenAlabanza { get; set; }
    }
    
    public class DirectorioDTO : ItemDTO
    {
        public int IdDirectorio { get; set; }
        public override int Id
        {
            get => IdDirectorio;
            set => IdDirectorio = value;
        }
        public string? UrlImagenDirectorio { get; set; }
    }

}
