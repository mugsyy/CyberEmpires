using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class SettingsPanel : MonoBehaviour
{
    public GameObject ComputerArea;
    public GameObject ProjectsArea;
    public GameObject StartProjectArea;
    public GameObject ShopArea;

    public GameObject SkillsArea;

    void Start()
    {
        ComputerArea.SetActive(false);
        ProjectsArea.SetActive(false);
        StartProjectArea.SetActive(false);
        ShopArea.SetActive(false);
        SkillsArea.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setpanelon()
    {
        ComputerArea.SetActive(true);
        ShopArea.SetActive(false);
        ProjectsArea.SetActive(false);
        SkillsArea.SetActive(false);
    }

    public void ProjectsPanel()
    {
        ProjectsArea.SetActive(true);
        ShopArea.SetActive(false);
        SkillsArea.SetActive(false);
    }

    public void StartProjectPanel()
    {
        StartProjectArea.SetActive(true);
        ShopArea.SetActive(false);
        SkillsArea.SetActive(false);
    }

    public void SkillsPanel()
    {
        SkillsArea.SetActive(true);
        ShopArea.SetActive(false);
        ComputerArea.SetActive(false);
        ProjectsArea.SetActive(false);
        StartProjectArea.SetActive(false);
    }

    public void StartShopAreaPanel(){
        ShopArea.SetActive(true);
        ComputerArea.SetActive(false);
        ProjectsArea.SetActive(false);
        StartProjectArea.SetActive(false);
        SkillsArea.SetActive(false);
    }

    public void ClosePanel()
    {
        if (ComputerArea.activeSelf && ProjectsArea.activeSelf || ComputerArea && StartProjectArea.activeSelf)
        {
            ProjectsArea.SetActive(false);
            StartProjectArea.SetActive(false);
            ShopArea.SetActive(false);
        }
        else if (ComputerArea.activeSelf)
        {
            ComputerArea.SetActive(false);
        }
        else{
            ShopArea.SetActive(false);
            SkillsArea.SetActive(false);
        }
        
 
    }
}
