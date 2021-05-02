using Unity.FPS.Game;
using Unity.FPS.Gameplay;
using UnityEngine;
using UnityEngine.UI;

namespace Unity.FPS.UI
{
    public class KeyCounter : MonoBehaviour
    {
        [Tooltip("Image component representing key")]
        public Image i_key;

        [Tooltip("Canvas group that contains the whole UI for the key")]
        public CanvasGroup MainCanvasGroup;

        Key m_key;

        void Awake()
        {
            m_key = FindObjectOfType<Key>();
            DebugUtility.HandleErrorIfNullFindObject<Key, KeyCounter>(m_key, this);
        }

        void Update()
        {
            MainCanvasGroup.gameObject.SetActive(m_key.hasKey);
        }
    }
}