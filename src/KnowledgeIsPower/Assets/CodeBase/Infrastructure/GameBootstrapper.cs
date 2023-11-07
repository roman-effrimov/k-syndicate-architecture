using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
        private Game m_Game;

        private void Awake()
        {
            m_Game = new Game();
        
            DontDestroyOnLoad(this);
        }
    }
}