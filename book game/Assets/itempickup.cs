using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itempickup : MonoBehaviour
{
    public Game GameManager;
    void Start()
    {
        GameManager=GameObject.Find("GameManager").GetComponent<Game>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="Player")
        {
            Destroy(this.transform.gameObject);
            Debug.Log("Item picked up");
            GameManager.Items+=1;
        }
    }
}
