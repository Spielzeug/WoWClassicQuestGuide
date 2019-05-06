using System.Collections.Generic;
using WoWClassicQuestGuide.IModel;

namespace WoWClassicQuestGuide.Model
{
    public class ChapterModel : IChapterModel
    {
        public string GuiD { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int ChapterNumber { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IList<IStepModel> steps { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
