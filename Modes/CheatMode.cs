using System.Collections.Generic;
using LuckyRunner.Utils;
using LuckyTower;
using LuckyTower.CharacterSystem;
using LuckyTower.Evelius;
using LuckyTower.RoomGeneration;

namespace LuckyRunner.Modes
{
    internal class CheatMode : IModeRun
    {
        private readonly List<string> _currentLabels = new List<string>();

        public void InitializeRun(GameManager gameManager)
        {
        }

        public List<string> GetGuiLabels(GameManager gameManager)
        {
            _currentLabels.Clear();

            var eveliusMood = $"Evelius mood: {EveliusController.GetMood(gameManager.EveliusMood)}";
            _currentLabels.Add(eveliusMood);

            var currentRoomFlags = SegmentParser.GetRoomFlags(gameManager.CurrentRoom);
            var currentRoomLabel = $"Current room flags: {currentRoomFlags}";
            _currentLabels.Add(currentRoomLabel);
            
            var currentRoom = gameManager.CurrentRoom;
            
            var rooms = SegmentParser.ParseCurrentSegment(currentRoom);
            _currentLabels.AddRange(rooms);
            return _currentLabels;
        }
    }
}