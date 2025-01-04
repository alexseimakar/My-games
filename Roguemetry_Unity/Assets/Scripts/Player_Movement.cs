using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float Movement_speed = 20.0f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.linearVelocity = new Vector2(horizontal * Movement_speed, vertical * Movement_speed);
    }
}
