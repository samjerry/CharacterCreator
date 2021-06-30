using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackstoryGenerator : MonoBehaviour
{
    [SerializeField] private Text _storyTextField;
    private void Start()
    {
        _storyTextField.text = GenerateBackstory();
    }

    public string GenerateBackstory() {
        string _backstory = "adjective, race, class from location, who, details";
        string _adjective = "adjective";
        string _race = "race";
        string _class = "class";
        string _location = "location";
        string _details = "details";

        Character _newChar = GameObject.Find("JsonReader").GetComponent<ReadJson>().newChar;

        _adjective = RandomStringFromArray(_newChar.storyAdjective);
        _location = RandomStringFromArray(_newChar.storyLocation);
        _details = RandomStringFromArray(_newChar.storyDetails);
        _race = RandomStringFromArray(_newChar.charRaces);
        _class = RandomStringFromArray(_newChar.charClasses);

        _backstory = _adjective + " " + _race + " " + _class + " from " + _location + " who " + _details;
        return _backstory;
    }

    private string RandomStringFromArray(string[] strArray) => strArray[Random.Range(0, strArray.Length)]; 
}
