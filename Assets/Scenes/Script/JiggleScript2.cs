using UnityEngine;

public class JiggleScript2 : MonoBehaviour
{
    [Range(0, 1)]
    public float power = 0.1f;

    [Header("Position Jiggle effect")]
    public bool jigPos = true; // Use 'bool' instead of 'Boolean'
    public Vector3 positionJigAmount;

    [Range(0, 120)]
    public float positionFrequency = 10;
    private float positionTime;
    private Vector3 basePosition;

    private void Start()
    {
        basePosition = transform.localPosition;
    }

    private void Update()
    {
        float dt = Time.deltaTime;
        positionTime += dt * positionFrequency;

        if (jigPos)
        {
            transform.localPosition = basePosition + positionJigAmount * Mathf.Sin(positionTime) * power;
        }
    }
}
