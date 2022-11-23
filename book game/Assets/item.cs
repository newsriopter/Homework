using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public int RotSpeed=100;
    Transform Item;
    // Start is called before the first frame update
    void Start()
    {
        Item=this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Item.Rotate(RotSpeed*Time.deltaTime,RotSpeed*Time.deltaTime,RotSpeed*Time.deltaTime);
    }
}
