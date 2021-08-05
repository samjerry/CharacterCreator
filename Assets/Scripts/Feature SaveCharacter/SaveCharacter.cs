using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCharacter : MonoBehaviour
{
    public void ScreenShot()
    {
        ScreenCapture.CaptureScreenshot("../CharacterCreator/CharacterSheets/DnD_CharacterSheet.png");
        Debug.Log("Screenshot taken");
    }
}
