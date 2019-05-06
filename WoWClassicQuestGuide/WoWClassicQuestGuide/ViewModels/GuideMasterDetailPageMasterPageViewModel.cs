using Prism.Mvvm;
using WoWClassicQuestGuide.IService;

namespace WoWClassicQuestGuide.ViewModels
{
    public class GuideMasterDetailPageMasterPageViewModel : BindableBase
    {
        private readonly IChapterService _chapterService;
        private string _textToSay = "Hello from Xamarin.Forms and Prism";

        public GuideMasterDetailPageMasterPageViewModel(IChapterService chapterService)
        {
            _chapterService = chapterService;
        }

        public string TextToSay
        {
            get { return _textToSay; }
            set { SetProperty(ref _textToSay, value); }
        }
    }
}
