using System.Collections.Generic;
using LuckyTower;

namespace LuckyRunner.Modes
{
    public class BlankMode : IModeRun
    {
        public void InitializeRun(GameManager gameManager)
        {
        }

        public List<string> GetGuiLabels(GameManager gameManager)
        {
            return new List<string>();
        }
    }
}