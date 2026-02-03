using UnityEngine;

public class FloatingText : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float lifetime = 1.5f;
    [SerializeField] float deviationRange = 0.5f;
    Camera playerCamera;
    TMPro.TextMeshPro textComponent;
    float deviationx;
    float deviationz;
    private void Start()
    {
        Destroy(gameObject, lifetime);
        playerCamera = FindAnyObjectByType<Camera>();
        deviationx = Random.Range(-deviationRange, deviationRange);
        transform.rotation = playerCamera.transform.rotation;
        textComponent = GetComponent<TMPro.TextMeshPro>();
    }

    private void Update()
    {
        transform.Translate(deviationx * Time.deltaTime, moveSpeed * Time.deltaTime, deviationz * Time.deltaTime);
         
        Color color = textComponent.color;
        color.a = Mathf.Lerp(color.a, 0, Time.deltaTime / lifetime);
        textComponent.color = color;
    }
}