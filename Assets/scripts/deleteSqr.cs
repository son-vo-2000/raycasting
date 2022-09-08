using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteSqr : MonoBehaviour
{
    private void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
}
