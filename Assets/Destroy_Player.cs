using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Player : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(col.gameObject);
        }
    }
}
