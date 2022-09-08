using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shotPrefab;
    float distanceToDetect;
    void Start()
    {
        distanceToDetect = 8;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.DrawRay(transform.position, transform.up * distanceToDetect, Color.red);

       // Ray ray = new Ray(transform.position, transform.up);

       // RaycastHit hit;


        //if (Physics.Raycast(ray, out hit, distanceToDetect))
      //  {
        //if (hit.collider != null && hit.collider.tag == "square")
     //       {
      //          Instantiate(shotPrefab, transform.position, transform.rotation);
      //      }
     //   }

        if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit, distanceToDetect))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distanceToDetect, Color.black);
            Debug.Log("Detected something");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distanceToDetect, Color.blue);
        }
        
    }
}
