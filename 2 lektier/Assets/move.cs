using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public string name ="Master";
    private int level=1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(name);
        character();
        level+=1;
        character();
    }
    /// <summary>
    /// Method for printing the character name and level.
    /// </summary>
    void character(){
        Debug.Log($"My name is {name} and my level is {level}.");
        level+=1;
        Debug.Log($"My name is {name} and my new level is {level}. I have leveled up!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime);
        }
    }
}
