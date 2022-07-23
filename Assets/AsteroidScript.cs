using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < -MaxRange)
        {
            Destroy(gameObject);
            GameObject.Find("Ship").GetComponent<PlayerScript>().AddDamage(damage);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(("collision"));
        if (collision.collider.GetComponent<BulletScript>())
        {
            Health -= 1;
            if(Health==0) Destroy(gameObject);
        }

        PlayerScript player = collision.collider.GetComponent<PlayerScript>();
        if (player)
        {
            Destroy(gameObject);
            player.AddDamage(damage);
        }
    }

    public float damage = 11;
    [Range(0, float.MaxValue)]
    public float MaxRange = 47;
    public float speed = 43;
    public float Health = 5;


}
