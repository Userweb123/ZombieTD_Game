using UnityEngine;

public class GameSetup : MonoBehaviour
{
    [SerializeField] private GameObject damageTextPrefab;
    void Start()
    {
        HPSystem.SetDamageTextPrefab(damageTextPrefab);
    }
}
