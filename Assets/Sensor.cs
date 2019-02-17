using System.Collections;
using System;
using UnityEngine;

public class Sensor : MonoBehaviour {

    public float checkRadius;
    public LayerMask checkLayers;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, checkRadius, checkLayers);
            Array.Sort(colliders, new Dist_Comparer(transform));

            foreach(Collider item in colliders)
            {
                Debug.Log(item.name);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }

}
