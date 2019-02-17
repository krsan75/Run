using System.Collections;

using UnityEngine;

public class Ray_cast : MonoBehaviour
{

    public float MaxDistance = 7;

    Quaternion fl = Quaternion.AngleAxis(-45, new Vector3(0, 1, 0));
    Quaternion fr = Quaternion.AngleAxis(45, new Vector3(0, 1, 0));

    void Update()
    {
        Ray ray_forward = new Ray(transform.position, transform.forward);
        Ray ray_right = new Ray(transform.position, transform.right);
        Ray ray_left = new Ray(transform.position, transform.right * -1);
        Ray ray_fl = new Ray(transform.position, fl*transform.forward);
        Ray ray_fr = new Ray(transform.position, fr*transform.forward);

        RaycastHit hit;

        Debug.DrawLine(transform.position, transform.position + transform.forward * MaxDistance, Color.red);
        Debug.DrawLine(transform.position, transform.position + (transform.right * -1) * MaxDistance, Color.red);
        Debug.DrawLine(transform.position, transform.position + transform.right * MaxDistance, Color.red);
        Debug.DrawLine(transform.position, transform.position + fl * transform.forward * MaxDistance, Color.red);
        Debug.DrawLine(transform.position, transform.position + fr * transform.forward * MaxDistance, Color.red);

        if (Physics.Raycast(ray_forward, out hit, MaxDistance))
        {
            Debug.Log("forward" + hit.distance);
        }

        if (Physics.Raycast(ray_left, out hit, MaxDistance))
        {
            Debug.Log("left" + hit.distance);
        }

        if (Physics.Raycast(ray_right, out hit, MaxDistance))
        {
            Debug.Log("right" + hit.distance);
        }
    }
}



