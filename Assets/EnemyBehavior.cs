using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Color enemyColor = GetComponent<SpriteRenderer>().material.color;
        //Color bulletColor = Bullet.GetComponent<SpriteRenderer>().sharedMaterial.color;

        //if (enemyColor.Equals(bulletColor))
        //{
        //    Destroy(gameObject);
        //}

        if (collision.gameObject.name == "Prootagoonist")
        {
            Destroy(collision.gameObject);
        }
    }
}
