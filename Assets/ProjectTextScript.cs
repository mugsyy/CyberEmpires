using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.TestTools.CodeCoverage;
using UnityEngine;
using UnityEngine.UI;

public class ProjectTextScript : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Sprite> sprites = new List<Sprite>();
    public TextAsset TextAsset;

   // private StreamReader reader;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TextAssignment();
                  
    }

    //Project Clicks
    public void OnProjectClick(){



    }

    //Skills Choosen

    public void OnSkillClick(){

        

    }




    public void TextAssignment(){
        
        string[] projectNames = TextAsset.text.Split(";");

        


    }

    
}