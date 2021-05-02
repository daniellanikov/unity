using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.FPS.Gameplay
{
    public class Treasure : MonoBehaviour
    {
        public bool hasTreasure = false;
        public UnityAction<bool> onUnlockTreasure;
        PlayerCharacterController m_PlayerCharacterController;
        PlayerInputHandler m_InputHandler;

        void Start()
        {
            m_PlayerCharacterController = GetComponent<PlayerCharacterController>();
            DebugUtility.HandleErrorIfNullGetComponent<PlayerCharacterController, Treasure>(m_PlayerCharacterController,
                this, gameObject);

            m_InputHandler = GetComponent<PlayerInputHandler>();
            DebugUtility.HandleErrorIfNullGetComponent<PlayerInputHandler, Treasure>(m_InputHandler, this, gameObject);

        }

        public bool TryUnlock()
        {
            onUnlockTreasure.Invoke(true);
            hasTreasure = true;
            return true;
        }
    }
}