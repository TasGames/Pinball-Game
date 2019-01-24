using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    [SerializeField] protected float moveSpeed = 10.0f;

    protected Vector2 targetPosition;
    protected Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        targetPosition = transform.position;
    }

    void Update()
    {
        if (Input.touchCount == 1)
        {
            var touch = Input.touches[0];

            if (touch.position.x > Screen.width * 0.8 && touch.position.y > Screen.height / 4)
            {
                Vector2 touchPos = touch.position;
                Vector3 rawPosition = Camera.main.ScreenToWorldPoint(touchPos);
                targetPosition.y = rawPosition.y;
                Vector2 moveToPosition = Vector2.MoveTowards(transform.position, targetPosition, Time.fixedDeltaTime * moveSpeed);
                rb.MovePosition(moveToPosition);
            }

        }
    }

    void OnMouseDrag()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector3 rawPosition = Camera.main.ScreenToWorldPoint(mousePos);
        targetPosition.y = rawPosition.y;
        Vector2 moveToPosition = Vector2.MoveTowards(transform.position, targetPosition, Time.fixedDeltaTime * moveSpeed);
        rb.MovePosition(moveToPosition);
    }
}
