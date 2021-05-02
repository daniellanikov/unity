using Unity.FPS.Game;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class ObjectiveOpenTreasure : Objective
    {
        protected override void Start()
        {
            base.Start();

            EventManager.AddListener<PickupEvent>(OnTreasurePickup);
        }

        void OnTreasurePickup(PickupEvent evt)
        {
            if (evt.Pickup.GetComponent<TreasurePickup>() != null)
            {
                CompleteObjective(string.Empty, "1", "Objective complete : " + "lofasz");
            }
        }

        void OnDestroy()
        {
            EventManager.RemoveListener<PickupEvent>(OnTreasurePickup);
        }
    }
}