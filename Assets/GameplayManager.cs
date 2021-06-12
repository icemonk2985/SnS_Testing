using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public GameObject go_Enemy;
    public Transform t_Loc;

    // Start is called before the first frame update
    void Start()
    {
        GameObject temp_Projectile = Instantiate(go_Enemy, t_Loc);
        temp_Projectile.transform.SetParent(null);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject temp_Projectile = Instantiate(go_Enemy, t_Loc);
            temp_Projectile.transform.SetParent(null);
        }
    }
}
