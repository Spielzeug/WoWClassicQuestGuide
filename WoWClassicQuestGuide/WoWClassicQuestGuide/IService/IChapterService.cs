using System.Collections.Generic;
using WoWClassicQuestGuide.IModel;

namespace WoWClassicQuestGuide.IService
{
    public interface IChapterService
    {
        IChapterModel getChapterForGuiD(string GuiD);
        IList<IChapterModel> getAllChapters();

        void addChapter(IChapterModel chapter);
        void updateChapter(IChapterModel chapter);
        void deleteChapter(IChapterModel chapter);
    }
}
