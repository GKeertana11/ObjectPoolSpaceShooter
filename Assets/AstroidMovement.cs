using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime);  
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
           // Destroy(this.gameObject);
            ObjectPoolScript.instance.DecreaseHealth();
            Debug.Log("player");
            this.gameObject.SetActive(false);
        }
    }
}
