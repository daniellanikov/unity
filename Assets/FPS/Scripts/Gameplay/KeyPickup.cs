namespace Unity.FPS.Gameplay
{
    public class KeyPickup : Pickup
    {
        protected override void OnPicked(PlayerCharacterController byPlayer)
        {
            var key = byPlayer.GetComponent<Key>();
            key.hasKey = true;
            PlayPickupFeedback();
            Destroy(gameObject);
        }
    }
}