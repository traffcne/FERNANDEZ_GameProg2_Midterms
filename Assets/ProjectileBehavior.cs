using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Tilemaps;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float Speed = 3f;
    public GameObject Enemy;
    void Update()
    {
        transform.position += transform.up * Time.deltaTime * Speed;
        StartCoroutine(AutoDestroy());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.GetComponent<SpriteRenderer>().material.color == collision.gameObject.GetComponent<SpriteRenderer>().material.color)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        else if (gameObject.GetComponent<SpriteRenderer>().material.color != collision.gameObject.GetComponent<SpriteRenderer>().material.color)
        {
            Destroy(gameObject);
        }

    }

    IEnumerator AutoDestroy()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
