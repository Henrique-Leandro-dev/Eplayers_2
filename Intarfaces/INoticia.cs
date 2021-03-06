using System.Collections.Generic;
using Eplayers_2.Models;

namespace Eplayers_2.Interfaces
{
    public interface INoticias
    {
         void Create(Noticias n);

        List<Noticias> ReadAll();

        void Update(Noticias n);
        
        void Delete(int IdNoticia);
        
    }
}