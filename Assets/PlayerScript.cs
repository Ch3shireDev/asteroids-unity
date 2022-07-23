using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{


    public float Health = 101;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
      var y =  Input.GetAxis("Vertical");
      transform.position += new Vector3(0, y* speed * Time.deltaTime);
      var height = transform.position.y;
      if (Mathf.Abs(height) > MaxHeight)
      {
          height = MaxHeight * Mathf.Sign(height);
          //transform.position.y = height;
          var pos = transform.position;
          pos.y = height;
          transform.position = pos;
      }

      if (Input.GetButton("Fire")&&timer > cooldown)
      {
          Instantiate(bullet, transform.position, transform.rotation);
          timer = 0;
      }

      if (Health < 2)
      {
          Time.timeScale=0;

      }
    }

    public float MaxHeight = 20;
    public float speed = 10;
    public GameObject bullet;
    private float timer = 0;
    public float cooldown = 0.1f;


    public void AddDamage(float damage)
    {
        Health -= damage;
        GameObject.Find("HealthText").GetComponent<Text>().text = $"Zdrowie: {Health}";
    }

}
