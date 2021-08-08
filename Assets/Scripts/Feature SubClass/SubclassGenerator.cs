using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubclassGenerator : MonoBehaviour
{
    [SerializeField] private ReadJson _char;
    [SerializeField] private Text _subclassText;
    [SerializeField] private Text _classText;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            _classText.text = _char.charClass;
            GenSubClass();
        }
    }

    public void GenSubClass()
    {
        string _class = _char.charClass;
        
        string[] _subclasses = _char.GetSubclasses(_class);

        if (_subclasses[0] != "ERROR: INVALID CLASS")
        {
            int _randInt = Random.Range(0, _subclasses.Length);
            _subclassText.text = _subclasses[_randInt];
        } else {
            _subclassText.text = "INVALID CLASS";
        }
    }
}
