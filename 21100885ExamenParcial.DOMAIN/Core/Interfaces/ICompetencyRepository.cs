using _21100885ExamenParcial.DOMAIN.Core.Entities;

namespace _21100885ExamenParcial.DOMAIN.Core.Interfaces
{
    public interface ICompetencyRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Competency>> GetCompetencies();
        Task Insert(Competency competency);
        Task<bool> Update(Competency competency);
    }
}