using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject temp = ObjectPoolScript.instance.GetObjectsFromPool("Health");
        if (temp != null)
        {
            Debug.Log("active");
            if (Random.Range(0, 100) < 1f)
            {

                temp.transform.position = this.transform.position + new Vector3(Random.Range(-3f, 3f), 0f, 0f);
                temp.SetActive(true);
            }

        }
    }
}
