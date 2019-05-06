using System.Collections.Generic;
using WoWClassicQuestGuide.IModel;

namespace WoWClassicQuestGuide.IService
{
    public interface IStepService
    {
        IStepModel getStepForGuiD(string GuiD);
        IList<IStepModel> getAllSteps();

        void addStep(IStepModel step);
        void updateStep(IStepModel step);
        void deleteStep(IStepModel step);
    }
}
