using System.Threading;
using UnityEngine;

namespace LuckyRunner
{
    public static class Loader
    {
        public static void MainLoad()
        {
            new Thread(() =>
            {
                Thread.Sleep(5000); // 5 second sleep as initialization occurs *really* early

                var someObject = new GameObject();
                someObject.AddComponent<ModMenu>(); // MonoBehaviour
                Object.DontDestroyOnLoad(someObject);

            }).Start();
        }
    }
}