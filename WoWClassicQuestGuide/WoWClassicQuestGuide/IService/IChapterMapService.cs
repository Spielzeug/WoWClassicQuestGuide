using System;
using System.Collections.Generic;
using System.Text;
using WoWClassicQuestGuide.IModel;

namespace WoWClassicQuestGuide.IService
{
    public interface IChapterMapService
    {
        IChapterMapModel getChapterForGuiD(string GuiD);
        IList<IChapterMapModel> getAllChapterMaps();

        void addChapterMap(IChapterMapModel chapterMap);
        void updateChapterMap(IChapterMapModel chapterMap);
        void deleteChapterMap(IChapterMapModel chapterMap);
    }
}
