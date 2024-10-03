using System.Collections.Generic;
using LuckyRunner.Modes;
using LuckyTower;
using LuckyTower.CharacterSystem;
using UnityEngine;

namespace LuckyRunner
{
    public class ModMenu : MonoBehaviour
    {
        private readonly Dictionary<Mode, IModeRun> _modeRuns = new Dictionary<Mode, IModeRun>();
        
        private Mode _currentMode = Mode.SegmentInfo;
        private IModeRun CurrentRun => _modeRuns[_currentMode];

        private void Start()
        {
            _modeRuns.Add(Mode.SegmentInfo, new CheatMode());
            _modeRuns.Add(Mode.OnlyBalcony, new BlindShortMode());
            _modeRuns.Add(Mode.Off, new BlankMode());
        }

        private void OnGUI()
        {
            var currentX = 100;
            var currentY = 100;

            const int width = 400;
            const int offsetY = 40;

            GUI.Label(new Rect(currentX, currentY, width, offsetY), $"Current mode: {_currentMode.ToString()}");
            currentY += offsetY;

            // Rider say this is expensive but LTU developers use this in DebugCanvas.Update and so will I
            if (Player.CurrentPlayer == null)
                return;

            var runLabels = CurrentRun.GetGuiLabels(GameManager.Instance);
            foreach (var label in runLabels)
            {
                GUI.Label(new Rect(currentX, currentY, width, offsetY), label);
                currentY += offsetY;
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F5))
            {
                _currentMode = (Mode)(((int)_currentMode + 1) % (int)Mode.Total);
            }
        }
    }
}