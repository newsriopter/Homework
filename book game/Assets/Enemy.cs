using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.gameObject.name=="Player"){
            Debug.Log("Player detected");
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.name=="Player"){
            Debug.Log("Player lost");
        }
    }
}
