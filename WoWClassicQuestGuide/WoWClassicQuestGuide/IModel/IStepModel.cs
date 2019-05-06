using System.ComponentModel.DataAnnotations;

namespace WoWClassicQuestGuide.IModel
{
    public interface IStepModel : IBaseModel
    {
        [Key]
        string GuiD { get; set; }
        int StepNumber { get; set; }

        IChapterModel chapter { get; set; }
    }
}
