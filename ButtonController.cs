using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
  public  string part;
    // Start is called before the first frame update
    void Start()
    {
       
        gameObject.GetComponent<Button>().onClick.AddListener(()=>GameManager.gm.drop(part));
        
    }

    
}
