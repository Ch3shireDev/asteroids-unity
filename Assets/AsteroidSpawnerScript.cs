using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class AsteroidSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > cooldown)
        {
            var y = Random.Range(-MaxY, MaxY);
            var pos = new Vector3(SpawnX, y);
            Instantiate(asteroid, pos, Quaternion.identity);
            timer = 0;
        }

    }

    public GameObject asteroid;
    private float timer = 0;
    public float cooldown = 0.7f;
    public float MaxY = 19;
    public float SpawnX = 43;
}
