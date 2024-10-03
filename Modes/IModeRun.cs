using System.Collections.Generic;
using LuckyTower;

namespace LuckyRunner.Modes
{
    public interface IModeRun
    {
        void InitializeRun(GameManager gameManager);

        List<string> GetGuiLabels(GameManager gameManager);
    }
}