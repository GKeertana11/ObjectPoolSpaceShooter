using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public GameObject bullet;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement;
        movement = Input.GetAxis("Horizontal") * playerSpeed;
        transform.Translate(0,-movement*Time.deltaTime, 0);
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


    }

