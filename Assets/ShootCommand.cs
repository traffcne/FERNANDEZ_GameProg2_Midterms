using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShootCommand : MonoBehaviour
{
    public ProjectileBehavior ProjectilePrefab;
    public FollowMouse Mouse;
    
    public Transform LaunchOffset;
    public Rigidbody2D bulletInstance;
   
    public float Force = 25f;

    void Start()
    {
        bulletInstance.velocity = new Vector2(Mouse.Direction.x, Mouse.Direction.y).normalized * Force;
    }

    void Update()
    {
        FireBullet();
    }

    void FireBullet()
    {
        if (Input.GetMouseButtonDown(0)){ 
        Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }
    }
}
