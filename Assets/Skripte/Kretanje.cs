using UnityEngine;

public class Kretanje : MonoBehaviour
{
    bool isMoving = false;
    Vector3 targetPosition;

    void Update()
    {
        if (Input.touchCount == 0)
            return;

        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Began)
            return;

        isMoving = true;
        targetPosition = Camera.main.ScreenToWorldPoint(touch.position);
        targetPosition.z = transform.position.z;

        if (targetPosition.x < transform.position.x)
            return;

        if (isMoving)
        {
            float step = 5f * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, step);

            if (transform.position.y == targetPosition.y)
                isMoving = false;
        }
    }
}