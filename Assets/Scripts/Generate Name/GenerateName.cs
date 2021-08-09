using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateName : MonoBehaviour
{
    public string charName;
    [SerializeField]private ReadJson readJson;

    [SerializeField] private Text nameText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            charName = GenName();
            nameText.text = charName;
        }
    }
    
    public string GenName()
    {
        string[] _name = readJson.GetRaceNames();
        return _name[Random.Range(0, _name.Length)];
    }
}
