using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowSimulation : MonoBehaviour
{  public Transform target;
    public GameObject ballprefab;
    public float ballspeed = 5.0f;
    public float shootangle=0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {     

            // Instantiate(ballprefab);
            GameObject instance = Instantiate(ballprefab);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
           // Camera camera = GetComponentInChildren<Camera>();
            
            rb.velocity =  calcBallisticVelocityVector(rb.transform,target.transform,shootangle) * ballspeed;
            //calcBallisticVelocityVector(instance.transform, target.transform, shootangle);
        }

    }
    Vector3 calcBallisticVelocityVector(Transform source, Transform target, float angle)
    {
        Vector3 direction = target.position - source.position;            // get target direction
        float h = direction.y;                                            // get height difference
        direction.y = 0;                                                // remove height
        float distance = direction.magnitude;                            // get horizontal distance
        float a = angle * Mathf.Deg2Rad;                                // Convert angle to radians
        direction.y = distance * Mathf.Tan(a);                            // Set direction to elevation angle
        distance += h / Mathf.Tan(a);                                        // Correction for small height differences

        // calculate velocity
        float velocity = Mathf.Sqrt(distance * Physics.gravity.magnitude / Mathf.Sin(2 * a));
        return velocity * direction.normalized;

    }
}
