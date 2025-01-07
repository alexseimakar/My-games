using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform PlayerTarget;  // ������ �� ��������� ������
    public Transform CrosshairTarget;  // ������ �� ��������� �������
    public float smoothSpeed = 0.7f;  // �������� �����������
/*    public Vector3 offset;  // �������� ������ ������������ ������
*/
    void LateUpdate()
    {
        /*// �������� ������� ������ � ������ ��������
        Vector3 desiredPosition = PlayerTarget.position + offset;*/

        // ������������ ������� ������ ��� �������� ����������
        Vector3 smoothedPosition = Vector3.Lerp(PlayerTarget.position, CrosshairTarget.position, smoothSpeed);

        // ���������� ������� ������
        transform.position = smoothedPosition;
    }
}