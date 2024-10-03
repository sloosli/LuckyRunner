using System.Collections.Generic;
using System.Linq;
using LuckyRunner.Utils;
using LuckyTower;
using LuckyTower.CharacterSystem;

namespace LuckyRunner.Modes
{
    internal class BlindShortMode : IModeRun
    {
        private readonly List<string> _currentLabels = new List<string>();

        public void InitializeRun(GameManager gameManager)
        {
        }

        public List<string> GetGuiLabels(GameManager gameManager)
        {
            _currentLabels.Clear();

            var currentSegment = SegmentParser.ParseCurrentSegment(gameManager.CurrentRoom);
            var balconyFloor = currentSegment.FirstOrDefault(floor => floor.Contains("BalconyEntrance"));

            if (balconyFloor == null)
            {
                _currentLabels.Add("Shortcut not in this segment");
            }
            else
            {
                var balconyFloorIndex = currentSegment.IndexOf(balconyFloor);
                _currentLabels.Add($"Shortcut after {balconyFloorIndex} floors");
            }

            return _currentLabels;
        }
    }
}