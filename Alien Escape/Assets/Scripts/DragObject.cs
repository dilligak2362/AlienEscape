using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isDragging = false;
    private Vector3 offset;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        isDragging = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        Time.timeScale = 1; 
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void FixedUpdate()
    {
        if (isDragging)
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)) + offset;
            rb.MovePosition(newPosition);
        }
    }
}

