using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makesq : MonoBehaviour
{
    float timer;
    public GameObject Square;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            GameObject s = Instantiate(Square);
            s.transform.position = new Vector2(Random.Range(-6, 6), 10);
            timer = 0.5f;
        }

        timer -= Time.deltaTime;
    }
}
