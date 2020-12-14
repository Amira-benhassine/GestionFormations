using OA_DataAccess;
using OA_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Service
{
    public class CategorieRepository : ICategorieRepository
    {
        private IRepository<Categorie> _repository;
        public CategorieRepository(IRepository<Categorie> repository)
        {
            _repository = repository;
        }

        void ICategorieRepository.Add(Categorie categorie)
        {
            _repository.Add(categorie);
        }

        void ICategorieRepository.Delete(Categorie categorie)
        {
            _repository.Delete(categorie);
        }

        IEnumerable<Categorie> ICategorieRepository.GetAll()
        {
            return _repository.GetAll();
        }

        Categorie ICategorieRepository.GetById(int id)
        {
            return _repository.GetById(id);
        }

        void ICategorieRepository.Update(Categorie categorie)
        {
            _repository.Update(categorie);
        }
    }
}
