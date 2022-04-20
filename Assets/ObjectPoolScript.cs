using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolScript : MonoBehaviour
{
   // private static ObjectPoolScript instance;
    public static ObjectPoolScript instance;
    public List<GameObject> pool = new List<GameObject>();
    public List<PoolObject> poolItems = new List<PoolObject>();
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        return;
    }
    // Start is called before the first frame update
    void Start()
    {
        AddToPool();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddToPool()
    {
        foreach (PoolObject item in poolItems)
        {
            
            for(int i=0;i<item.amount;i++)
            {

               GameObject temp= Instantiate(item.prefab);
                temp.SetActive(false);
                pool.Add(temp);

            }
        }
    }

    public GameObject GetObjectsFromPool(string tagname)
    {
       for(int i=0;i<pool.Count;i++)
        {
          if(pool[i].gameObject.tag==tagname && !pool[i].gameObject.activeInHierarchy)
            {
                return pool[i].gameObject;
            }
        }
        return null;
        foreach(PoolObject item in poolItems)
        {
            if(item.prefab.tag==tagname)
            {
                GameObject temp = Instantiate(item.prefab);
                temp.SetActive(false);
                pool.Add(temp);
                return temp;
            }
        }
    }

}
[System.Serializable]
public class PoolObject {
    public GameObject prefab;
    public int amount;

    
    
}

