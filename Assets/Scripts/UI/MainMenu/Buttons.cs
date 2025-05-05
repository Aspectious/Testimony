using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        this.button = this.GetComponent<Button>();
        switch (this.name)
        {
            case "NewProjButton":
                button.onClick.AddListener(newProjButtonBehav);
                break;
            case "OpenProjButton":
                button.onClick.AddListener(OpenProjButton);
                break;
        }
    }

    void newProjButtonBehav()
    {
        SceneManager.LoadScene("Creator");
    }

    void OpenProjButton()
    {
        
    }
}
