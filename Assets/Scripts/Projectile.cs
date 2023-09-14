using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]public float Speed = 4.5f;

    private void Update()
    {
        transform.position += -transform.right * Time.deltaTime * Speed;
    }

    private void OnCollision2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
