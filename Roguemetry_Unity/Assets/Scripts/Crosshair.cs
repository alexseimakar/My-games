using UnityEngine;

public class Crosshair : MonoBehaviour
{

    void Awake()
    {
        Cursor.visible = false;
    }

    
    void LateUpdate()
    {
        Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint( Input.mousePosition );
        transform.position = mouseCursorPos;
    }
}
