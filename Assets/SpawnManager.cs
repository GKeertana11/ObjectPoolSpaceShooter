using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Astroid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Random.Range(0, 100) < 1f)
        {
           // float x = Random.Range(-3.0f, 3.0f);
           Debug.Log("Astroid spawned");
            GameObject temp = ObjectPoolScript.instance.GetObjectsFromPool("Astroid");
            temp.SetActive(true);
            
        }*/
        GameObject temp = ObjectPoolScript.instance.GetObjectsFromPool("Astroid");
        if(temp!=null)
        {
            Debug.Log("active");
            if (Random.Range(0, 100) < 1f)
            {

                temp.transform.position = this.transform.position + new Vector3(0f, Random.Range(-3f, 3f), 0f);
                temp.SetActive(true);
            }

        }
    }
}
