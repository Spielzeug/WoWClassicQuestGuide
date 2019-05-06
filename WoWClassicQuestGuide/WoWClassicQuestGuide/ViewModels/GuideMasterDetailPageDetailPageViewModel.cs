using Prism.Mvvm;
using WoWClassicQuestGuide.IService;

namespace WoWClassicQuestGuide.ViewModels
{
    public class GuideMasterDetailPageDetailPageViewModel : BindableBase
    {
        private readonly IChapterMapService _chapterMapService;
        private string _textToSay = "Hello from Xamarin.Forms and Prism";

        public GuideMasterDetailPageDetailPageViewModel(IChapterMapService chapterMapService)
        {
            _chapterMapService = chapterMapService;
        }

        public string TextToSay
        {
            get { return _textToSay; }
            set { SetProperty(ref _textToSay, value); }
        }
    }
}
