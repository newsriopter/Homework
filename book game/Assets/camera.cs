using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Vector3 camoffset=new Vector3(0f,1.2f,-2.6f);
    private Transform _target;
    // Start is called before the first frame update
    void Start()
    {
        _target=GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position=_target.TransformPoint(camoffset);
        this.transform.LookAt(_target);
    }
}
