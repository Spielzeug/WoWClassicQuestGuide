using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WoWClassicQuestGuide.IModel
{
    public interface IChapterModel : IBaseModel
    {
        [Key]
        string GuiD { get; set; }
        int ChapterNumber { get; set; }

        IList<IStepModel> steps { get; set; }
    }
}
