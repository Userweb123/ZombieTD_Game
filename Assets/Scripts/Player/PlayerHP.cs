using UnityEngine;

public class PlayerHP : HPSystem
{
    protected override void OnDeath()
    {
        Debug.Log("Player Died");
    }
}