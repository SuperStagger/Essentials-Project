using UnityEngine;

[ExecuteAlways]
public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in seconds")]
    [SerializeField]
    private float dayDurationInSeconds = 60f;

    // Rotation speed in degrees per second (360 degrees per day)
    private float rotationSpeed => 360f / dayDurationInSeconds;

    void Update()
    {
        // Rotate the light around the x-axis to simulate sun movement
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}