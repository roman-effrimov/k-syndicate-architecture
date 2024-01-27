using CodeBase.Services.Input;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class Game
    {
        public static IInputService InputService;
        
        public Game()
        {
            RegisterInputService();
        }

        private static void RegisterInputService()
        {
            if (Application.isEditor || Application.platform == RuntimePlatform.WindowsPlayer ||
                Application.platform == RuntimePlatform.OSXPlayer)
            {
                InputService = new StandaloneInputService();
            }
            else
                InputService = new MobileInputService();
        }
    }
}