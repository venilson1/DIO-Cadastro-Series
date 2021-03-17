namespace crud_serie.classes
{
    public class Serie : EntidadeBase
    {
        private Genero Genero {get; set;}
        public string Titulo { get; set; }  
        public string Descricao { get; set; }   
        public int Ano { get; set; }
    }
}