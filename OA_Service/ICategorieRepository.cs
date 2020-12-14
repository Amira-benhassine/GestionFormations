using OA_DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Service
{
    public interface ICategorieRepository
    {
        IEnumerable<Categorie> GetAll();
        Categorie GetById(int id);
        void Add(Categorie categorie);
        void Update(Categorie categorie);
        void Delete(Categorie categorie);
    }
}
