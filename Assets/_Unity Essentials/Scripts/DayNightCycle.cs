using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Кількість секунд, за які минає повна доба")]
    public float dayDurationInSeconds = 60f;

    void Update()
    {
        // Розраховуємо швидкість обертання (360 градусів за час доби)
        float rotationSpeed = 360f / dayDurationInSeconds;

        // Обертаємо навколо осі X
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}