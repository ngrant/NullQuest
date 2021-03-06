using System;
using System.Linq;
using BadSnowstorm;
using NullQuest.Data;
using NullQuest.Town;
using NullQuest.Game;

namespace NullQuest.MainMenu
{
    public class LoadGameController : Controller
    {
        private readonly ISaveGameRepository _saveGameRepository;
        private readonly IAsciiArtRepository _asciiArtRepository;
        private readonly GameWorld _gameWorld;

        public LoadGameController(ISaveGameRepository saveGameRepository, IAsciiArtRepository asciiArtRepository, GameWorld gameWorld)
        {
            _saveGameRepository = saveGameRepository;
            _asciiArtRepository = asciiArtRepository;
            _gameWorld = gameWorld;
        }

        public override ViewModel Index()
        {
            var menu = new Menu();
            menu.Prompt = "Select save game slot: ";

            var saveGameSlots = _saveGameRepository.GetSaveGameSlots()
                .Where(x => !x.IsEmpty)
                .Select((x, i) => new { SaveGameData = x, Index = i + 1 }).ToList();

            foreach (var item in saveGameSlots.OrderBy(x => x.SaveGameData.Id))
            {
                menu.AddMenuItem(
                    new MenuItem
                    {
                        ActionResult = Actions.PopAndGoTo<TownController>,
                        Text = item.SaveGameData.Title,
                        Id = item.Index.ToString()[0],
                        OnInputAccepted = () =>
                        {
                            item.SaveGameData.LoadToGameWorld(_gameWorld);
                        }
                    });
            }

            menu.AddMenuItem(
                new MenuItem
                {
                    ActionResult = Actions.GoBack,
                    Text = "Cancel",
                    Id = (saveGameSlots.Count + 1).ToString()[0]
                });

            var viewModel = ViewModel.CreateWithMenu<MainMenuViewModel>(menu);
            
            viewModel.Message = "Three slots to choose from. Which one will it be?";
            viewModel.TitleArt = _asciiArtRepository.GetTitleArt();

            return viewModel;
        }
    }
}