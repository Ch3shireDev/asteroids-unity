using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float Speed = 10;

    public float MaxRange = 59;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * Speed * Time.deltaTime;

        if (transform.position.x > MaxRange)
        {
            Destroy(gameObject);
        }
    }


}
