using System.Collections.Generic;
using System.Threading.Tasks;
using WoWClassicQuestGuide.IModel;

namespace WoWClassicQuestGuide.IRepository
{
    public interface IBaseRepository<T> where T: IBaseModel
    {
        IList<T> GetAll();
        void AddAsync(T entity);
        void DeleteAsync(T entity);
        void UpdateAsync(T entity);
        Task<T> FindByGuiDAsync(string GuiD);
    }
}
