using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*bulletspeed*Time.deltaTime); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Astroid")
        {
            collision.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
           // Destroy(collision.gameObject);
        }

    }
}
