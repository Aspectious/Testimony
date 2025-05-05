using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBar : MonoBehaviour
{
    
    /// <summary>
    /// Layout of UI Items for Menu Bar
    /// </summary>
    private Button FileButton;

    private GameObject fileMenu;
    private Button fileMenuNewProjButton;
    private Button fileMenuOpenProjButton;
    private Button fileMenuSaveProjButton;
    
    private Button fileMenuQuitButton;


    private Button PanelButton;
    
    private Button panelMenuNewPanelButton;
    private Button panelMenuOpenPanelButton;
    private Button panelMenuSavePanelButton;
    // Start is called before the first frame update
    void Start()
    {
        this.FileButton = this.transform.Find("FileButton").GetComponent<Button>();
        this.fileMenu = this.transform.Find("FileMenu").gameObject;
        this.fileMenuNewProjButton = this.fileMenu.transform.Find("NewProjButton").GetComponent<Button>();
        this.fileMenuOpenProjButton = this.fileMenu.transform.Find("OpenProjButton").GetComponent<Button>();
        this.fileMenuSaveProjButton = this.fileMenu.transform.Find("SaveProjButton").GetComponent<Button>();
        this.fileMenuQuitButton = this.fileMenu.transform.Find("QuitButton").GetComponent<Button>();
        
        
        this.fileMenu.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
