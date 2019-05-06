using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoWClassicQuestGuide.Context;
using WoWClassicQuestGuide.IModel;
using WoWClassicQuestGuide.IRepository;

namespace WoWClassicQuestGuide.Repository
{
    public class StepRepository : IBaseRepository<IStepModel>
    {
        public IList<IStepModel> GetAll()
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                return context.Steps.ToList();
            }
        }

        public async void AddAsync(IStepModel step)
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                await context.Steps.AddAsync(step);
                await context.SaveChangesAsync();
            }
        }

        public async void DeleteAsync(IStepModel step)
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                context.Steps.Remove(step);
                await context.SaveChangesAsync();

            }
        }

        public async Task<IStepModel> FindByGuiDAsync(string GuiD)
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                return await context.Steps.FindAsync(GuiD);
            }
        }

        public async void UpdateAsync(IStepModel step)
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                context.Steps.Update(step);
                await context.SaveChangesAsync();
            }
        }
    }
}
