using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.ComponentModel;

public class Men_sc : MonoBehaviour
{
    private int scen, menu;//будешь обращаться к ним из другого скрипта - поменяй private на public
    public Button st, men, ext;
    public GameObject ob,me;//либо грузишь сцену с меню, либо объеденяешь объекты связанный с меню под один gameobject (смотри как сделано меню) и задаешь им состояние setactive(false);
    // Start is called before the first frame update
    void Start()
    {
        //me.SetActive(false);
        scen = 1;//Номер сцены с выбором персонажа
        menu = 2;//Номер сцены с меню 
    }
    
    public void start()
    {
        SceneManager.LoadScene(scen);
    }
    public void lo_men()
    {
       // SceneManager.LoadScene(menu);//либо грузишь сцену, либо смотри вариант 2
         ob.SetActive(false); //одно из двух
         me.SetActive(true);
          
    }
    public void exit()
    {
        Application.Quit();
    }
}
