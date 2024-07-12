using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject page1;
    public GameObject page2;
    void Start()
    {
        page1.SetActive(true);
        page2.SetActive(false);
        this.gameObject.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void inventoryOn(){
        this.gameObject.SetActive(true);
    }

    public void inventoryOff(){
        this.gameObject.SetActive(false);
    }

    public void arrowLeft(){
        if(!page1.activeSelf && page2.activeSelf){
            page1.SetActive(true);
            page2.SetActive(false);
        }
    }

    public void arrowRight(){

        if (page1.activeSelf && !page2.activeSelf){
            page1.SetActive(false);
            page2.SetActive(true);
        }


    }
    
}
