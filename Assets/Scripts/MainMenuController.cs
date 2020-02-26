using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Text textTile;
    
   

    public void PlayButtonPressed()
    {
        print("PLAY BUTTON PRESSED");

        textTile.text = "PLAY BUTTON PRESSED!";

        // load new scene

    }
}
