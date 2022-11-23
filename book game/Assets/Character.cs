using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int attack;
    public Character(){
        name="Hero";
        attack=10;
    }
    //character(string name)
    public Character(string myCharacterName){
        name=myCharacterName;
        //this.name=name;
        //attack=10;
    }
    
    public void PrintStatsInfo(){
            Debug.LogFormat("Hero's name is {0} and his attack is {1}", name, attack);
        }
}

public struct weapon{
    public string name;
    public int damage;
    public weapon(string name, int damage){
        this.name=name;
        this.damage=damage;
    }
    public void PrintWeaponInfo(){
        Debug.LogFormat("Weapon's name is {0} and its damage is {1}", name, damage);
    }
}