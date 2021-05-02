namespace Unity.FPS.Gameplay
{
    public class TreasurePickup : Pickup
    {
        protected override void OnPicked(PlayerCharacterController byPlayer)
        {
            var treasure = byPlayer.GetComponent<Treasure>();
            var key = byPlayer.GetComponent<Key>();
            if(key.hasKey)
            {
                treasure.hasTreasure = true;
                PlayPickupFeedback();
                Destroy(gameObject);
            }
        }
    }
}