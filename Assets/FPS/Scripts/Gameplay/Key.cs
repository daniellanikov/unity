using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.FPS.Gameplay
{
    public class Key : MonoBehaviour
    {
        public bool hasKey = false;
        public UnityAction<bool> onUnlockKey;
        PlayerCharacterController m_PlayerCharacterController;
        PlayerInputHandler m_InputHandler;

        void Start()
        {
            m_PlayerCharacterController = GetComponent<PlayerCharacterController>();
            DebugUtility.HandleErrorIfNullGetComponent<PlayerCharacterController, Key>(m_PlayerCharacterController,
                this, gameObject);

            m_InputHandler = GetComponent<PlayerInputHandler>();
            DebugUtility.HandleErrorIfNullGetComponent<PlayerInputHandler, Key>(m_InputHandler, this, gameObject);

        }

        public bool TryUnlock()
        {
            onUnlockKey.Invoke(true);
            hasKey = true;
            return true;
        }
    }
}