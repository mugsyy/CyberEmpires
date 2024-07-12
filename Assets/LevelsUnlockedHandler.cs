using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LevelsUnlockedHandler : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Button[] Buttons;
    int unlockedLevelsNumber;
    private void Start()
    {
        if(!PlayerPrefs.HasKey("LevelsUnlocked")){
            PlayerPrefs.SetInt("LevelsUnlocked", 1);
        }

        unlockedLevelsNumber = PlayerPrefs.GetInt("LevelsUnlocked");

        for (int i = 0; i < Buttons.Length; i++){
            Buttons[i].interactable = false;
        }
    }


    private void Update()
    {
        
        unlockedLevelsNumber = PlayerPrefs.GetInt("LevelsUnlocked");
        

        for (int i = 0; i < unlockedLevelsNumber; i++){
            Buttons[i].interactable = true;
        }
    }
}
