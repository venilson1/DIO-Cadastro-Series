using System.Collections.Generic;
using crud_serie.Interfaces;

namespace crud_serie.classes
{
  public class SerieRepositorio : IRepositorio<Serie>
  {
    private List<Serie> listaSerie = new List<Serie>();
    public void Atualizar(int id, Serie objeto)
    {
      listaSerie[id] = objeto;
    }

    public void Excluir(int id)
    {
      listaSerie[id].getExcluido();
    }

    public void Inserir(Serie objeto)
    {
      listaSerie.Add(objeto);
    }

    public List<Serie> Lista()
    {
      return listaSerie;
    }

    public int ProximoId()
    {
      throw new System.NotImplementedException();
    }

    public Serie RetornaPorId(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}