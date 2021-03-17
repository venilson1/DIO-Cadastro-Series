namespace crud_serie.classes
{
    public class Serie : EntidadeBase
    {
        private Genero Genero {get; set;}
        public string Titulo { get; set; }  
        public string Descricao { get; set; }   
        public int Ano { get; set; }

        public  Serie(int id, Genero genero, string titulo, string descricao, int ano) {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }
    }
}