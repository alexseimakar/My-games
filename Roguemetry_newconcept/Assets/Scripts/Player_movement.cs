using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;
    Rigidbody2D rb;
    public Vector2 moveDir;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        InputManagement();
    }
    void FixedUpdate()
    {
        Move();
        Rotate();
    }

    void InputManagement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(moveX, moveY).normalized;
    }
    
    void Move()
    {
        rb.linearVelocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }

    void Rotate()
    {
        if (moveDir != Vector2.zero) // Проверяем, движется ли персонаж
        {
            // Вычисляем нужный поворот
            Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, moveDir);

            // Плавно поворачиваем в сторону перемещения
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}


