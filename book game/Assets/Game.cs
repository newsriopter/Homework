using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Button WinButton;
    public int MaxItems=4;
    public Text HealthText;
    public Text ItemsText;
    public Text ProgressText;
    private int _itemsCollected=0;
    private int _playerHP=10;
    void Start()
    {
        ItemsText.text+=_itemsCollected;
        HealthText.text+=_playerHP;
        Items=Items;
        HP=HP;
    }
    public int Items{
        get{return _itemsCollected;}
        set{_itemsCollected=value; ItemsText.text="Items collected: "+Items; if(_itemsCollected>=MaxItems){ProgressText.text="You've found all the items!"; WinButton.gameObject.SetActive(true);Time.timeScale=0f;} else {ProgressText.text="Item found, only "+(MaxItems - _itemsCollected)+" more to go!";} Debug.LogFormat("Items: {0}", _itemsCollected);}}
    public int HP{
        get{return _playerHP;}
        set{_playerHP=value; HealthText.text="Health: "+HP; Debug.LogFormat("HP: {0}", _playerHP);}
    }
    public void RestartScene(){
        SceneManager.LoadScene(0);
        Time.timeScale=1f;
    }
    void Update()
    {}
}