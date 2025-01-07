using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform PlayerTarget;  // Ссылка на трансформ игрока
    public Transform CrosshairTarget;  // Ссылка на трансформ Прицела
    public float smoothSpeed = 0.7f;  // Скорость сглаживания
/*    public Vector3 offset;  // Смещение камеры относительно игрока
*/
    void LateUpdate()
    {
        /*// Желаемая позиция камеры с учётом смещения
        Vector3 desiredPosition = PlayerTarget.position + offset;*/

        // Интерполяция позиции камеры для плавного следования
        Vector3 smoothedPosition = Vector3.Lerp(PlayerTarget.position, CrosshairTarget.position, smoothSpeed);

        // Обновление позиции камеры
        transform.position = smoothedPosition;
    }
}