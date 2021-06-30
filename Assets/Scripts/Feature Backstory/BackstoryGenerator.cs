using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackstoryGenerator : MonoBehaviour
{

    private void Start()
    {

    }

    public string GenerateBackstory(Character _char) {
        string _backstory = "adjective, race, class from location, who, details";
        string _adjective = "adjective";
        string _race = "race";
        string _class = "class";
        string _location = "location";
        string _details = "details";


        Debug.Log(_char.storyAdjective.Length);

        _adjective = RandomStringFromArray(_char.storyAdjective);
        _location = RandomStringFromArray(_char.storyLocation);
        _details = RandomStringFromArray(_char.storyDetails);
        _race = RandomStringFromArray(_char.charRaces);
        _class = RandomStringFromArray(_char.charClasses);

        _backstory = _adjective + " " + _race + " " + _class + " from " + _location + " who " + _details;
        return _backstory;
    }

    private string RandomStringFromArray(string[] strArray)
    {
        int _index = 0;
        
        _index = Random.Range(0, strArray.Length);

        Debug.Log(_index + " out of " + strArray.Length);
        
        return strArray[_index];
    }
}
