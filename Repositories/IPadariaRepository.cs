using Desafio_epadoca.Models;
using System.Collections.Generic;

namespace Desafio_epadoca.Repositories
{
    public interface IPadariaRepository
    {
        void Add(Padaria padaria);
        void Update(Padaria padaria);
        void Delete(int id);
        Padaria? GetById(int id); // Adicione o modificador nullable aqui
        List<Padaria> GetAll();
    }
}
