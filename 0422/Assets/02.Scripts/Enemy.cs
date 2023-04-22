using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float health = 50.0f;

    public float Health
    {
        get { return health; }
    }

    void TakeDamage(int value)
    {
        health -= value;
        if (health <= 0)
        {
            die();
        }
    }

    public float GetHealth()
    {
        return health;
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(10);
            Debug.Log("health :" + health);
            coll.gameObject.SetActive(false);
        }
    }

    void die()
    {
        Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("health :" + health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
