  
using System.Collections.Generic;
using Eplayers_2.Models;

namespace Eplayers_2.Interfaces
{
    public interface IEquipe
    {
        void Create(Equipe e);

        List<Equipe> ReadAll();

        void Update(Equipe e);
        
        void Delete(int IdEquipe); 
    }
}