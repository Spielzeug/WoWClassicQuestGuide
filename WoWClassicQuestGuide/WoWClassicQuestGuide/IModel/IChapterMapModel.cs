using System.ComponentModel.DataAnnotations;

namespace WoWClassicQuestGuide.IModel
{
    public interface IChapterMapModel : IBaseModel
    {
        [Key]
        string GuiD { get; set; }

        IChapterModel chapter { get; set; }
    }
}
