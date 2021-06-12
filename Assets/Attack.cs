using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject go_Projectile;
    public Transform t_BulletLaunchLoc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            OnAttack();
        }
    }

    void OnAttack()
    {
        GameObject temp_Projectile = Instantiate(go_Projectile, t_BulletLaunchLoc);
        temp_Projectile.transform.SetParent(null);
        temp_Projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(1f, 0f);
    }
}
