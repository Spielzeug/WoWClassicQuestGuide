using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoWClassicQuestGuide.Context;
using WoWClassicQuestGuide.IModel;
using WoWClassicQuestGuide.IRepository;

namespace WoWClassicQuestGuide.Repository
{
    public class ChapterRepository : IBaseRepository<IChapterModel>
    {

        public IList<IChapterModel> GetAll()
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                return context.Chapters.ToList();
            }
        }

        public async void AddAsync(IChapterModel chapter)
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                await context.Chapters.AddAsync(chapter);
                await context.SaveChangesAsync();
            }
        }

        public async void DeleteAsync(IChapterModel chapter)
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                context.Chapters.Remove(chapter);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IChapterModel> FindByGuiDAsync(string GuiD)
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                return await context.Chapters.FindAsync(GuiD);
            }
        }

        public async void UpdateAsync(IChapterModel chapter)
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                context.Chapters.Update(chapter);
                await context.SaveChangesAsync();
            }
        }
    }
}
