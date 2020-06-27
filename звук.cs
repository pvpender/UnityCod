using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class звук : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider sl;
    void Start()
    {
        sl.value = 0.5f; 
    }
    public GameObject me, st_me,tex;
    public Text zn;

    // Update is called once per frame
  public void zvuk(float val)
    {
        float stval = AudioListener.volume;
        int a;
        string b;
        stval = val;
        AudioListener.volume = stval;
        a=System.Convert.ToInt32(val*100);
        //  zn = System.Convert.ToString(val) ;
        b = System.Convert.ToString(a);
        tex.GetComponent<Text>().text = b;
        Debug.Log(a);
    }
    public void za()
    {
        me.SetActive(false);
        st_me.SetActive(true);
    }
    
}
