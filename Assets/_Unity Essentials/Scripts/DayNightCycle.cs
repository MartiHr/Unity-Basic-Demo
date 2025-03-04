using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Length Settings")]
    [Tooltip("Duration of a full day-night cycle in real-time seconds")]
    public float dayDuration = 120f; // Default to 2 minutes per full cycle

    private float rotationSpeed;

    void Start()
    {
        // Calculate rotation speed (360 degrees over the day duration)
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rotate the light around the X-axis to simulate the sun moving
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
