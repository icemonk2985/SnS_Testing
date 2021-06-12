using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.GetComponent<Bullet>())
        {
            this.GetComponent<Health>().i_Health -= collision.transform.GetComponent<Bullet>().i_Damage;
            if (this.GetComponent<Health>().i_Health <= 0)
            {
                Destroy(this.gameObject);
            }
            Destroy(collision.gameObject);
        }
    }
}
