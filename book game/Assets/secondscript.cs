using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondscript : MonoBehaviour
{
    private Transform camtransform;
    // Start is called before the first frame update
    void Start()
    {
        camtransform=this.GetComponent<Transform>();
        Debug.Log("Camera's position is "+camtransform.position);
        Debug.Log("Camera's rotation is "+camtransform.localPosition);
        Character hero=new Character();
        hero.PrintStatsInfo();
//        Debug.LogFormat("Hero's name is {0} and his attack is {1}", hero.name, hero.attack);
        Character hero2=new Character("Agatha");
        hero2.PrintStatsInfo();
//        Debug.LogFormat("Hero's name is {0} and his attack is {1}", hero2.name, hero2.attack);
        weapon sword=new weapon("Sword", 10);
        sword.PrintWeaponInfo();
        Character hero3=hero;
        hero3.name="Hero3";
        hero3.PrintStatsInfo();
        hero.PrintStatsInfo();

    }
}
