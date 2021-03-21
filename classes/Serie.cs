namespace crud_serie.classes
{
    public class Serie : EntidadeBase
    {
        private Genero Genero {get; set;}
        private string Titulo { get; set; }  
        private string Descricao { get; set; }   
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public  Serie(int id, Genero genero, string titulo, string descricao, int ano) {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {   
            string retorno = "";
            retorno = $"Gerero: {this.Genero}\n";
            retorno = $"Titulo: {this.Titulo}\n";
            retorno = $"Descrição {this.Descricao}\n";
            retorno = $"Ano de início: {this.Ano}\n";
            retorno = $"Excluido: {this.Excluido}\n";
            return retorno;
        }

        public string getTitulo()
        { 
            return this.Titulo; 
        }

        public int getId()
        { 
            return this.Id; 
        }

        public void getExcluido()
        { 
            this.Excluido = true; 
        }

    }
}