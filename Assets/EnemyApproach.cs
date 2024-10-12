using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyApproach : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    public float Speed;

    private float distance;
    void Start()
    {
        
    }


    void Update()
    {
        distance = Vector2.Distance(Enemy.transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - Enemy.transform.position;
        direction.Normalize();

        transform.position = Vector2.MoveTowards(Enemy.transform.position, Player.transform.position, Speed * Time.deltaTime);
        
    }
}
