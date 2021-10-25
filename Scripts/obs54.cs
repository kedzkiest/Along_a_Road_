using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs54 : MonoBehaviour
{
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         t += 0.1f;

        Vector3 vec;

        vec = gameObject.transform.localScale;

        vec.z = Mathf.Abs(8 * Mathf.Sin(t));

        gameObject.transform.localScale = vec;
    }
}
