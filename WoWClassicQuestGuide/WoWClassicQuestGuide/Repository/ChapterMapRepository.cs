using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoWClassicQuestGuide.Context;
using WoWClassicQuestGuide.IModel;
using WoWClassicQuestGuide.IRepository;

namespace WoWClassicQuestGuide.Repository

{
    public class ChapterMapRepository : IBaseRepository<IChapterMapModel>
    {
        public IList<IChapterMapModel> GetAll()
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                return context.ChapterMaps.ToList();
            }
        }

        public async void AddAsync(IChapterMapModel chapterMap)
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                await context.ChapterMaps.AddAsync(chapterMap);
                await context.SaveChangesAsync();
            }
        }

        public async void DeleteAsync(IChapterMapModel chapterMap)
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                context.ChapterMaps.Remove(chapterMap);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IChapterMapModel> FindByGuiDAsync(string GuiD)
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                return await context.ChapterMaps.FindAsync(GuiD);
            }
        }

        public async void UpdateAsync(IChapterMapModel chapterMap)
        {
            using (GuideDatabaseContext context = GuideDatabaseContextHelper<GuideDatabaseContext>.CreateContext())
            {
                context.ChapterMaps.Update(chapterMap);
                await context.SaveChangesAsync();
            }
        }
    }
}
