using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public Vector2 Direction;
    void Update()
    {
        faceMouse();
    }

    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Direction =new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = Direction;
    }
}
