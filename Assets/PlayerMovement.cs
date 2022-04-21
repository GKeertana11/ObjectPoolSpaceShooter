using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public GameObject bullet;
   
   public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement;
        movement = Input.GetAxis("Horizontal") * playerSpeed;
       

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x<=4.0f)
        {
            transform.Translate(0, -movement * Time.deltaTime, 0);
           
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x>=-4.0f)
        {
            transform.Translate(0, -movement * Time.deltaTime, 0);
        }
      
        //need to clamp position of player

        if(Input.GetKeyDown(KeyCode.Space))
        {

            GameObject temp = ObjectPoolScript.instance.GetObjectsFromPool("Bullet");

            if (temp != null)
            {
                Debug.Log("active");
                

                    temp.transform.position = this.transform.position+offset;
                    temp.SetActive(true);
                }

            }
            
        }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Health")
        {
            collision.gameObject.SetActive(false);
            ObjectPoolScript.instance.IncreaseHealth();
        }
    }


}

