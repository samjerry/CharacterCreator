using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenStats : MonoBehaviour
{
    [SerializeField] GameObject _target;
    [SerializeField] Text _statText;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            string[] _stats = GenStatPrio();

            _statText.text = "";
           
            for (int i = 0; i < _stats.Length; i++)
            {
                _statText.text += _stats[i] + "\n";
            }
        }
    }

    public string[] GenStatPrio() => ShuffleArray(_target.GetComponent<ReadJson>().newChar.charStats);
    
    private string[] ShuffleArray(string[] _stats)
    {
        string _temp;
        for (int i = 0; i < _stats.Length; i++)
        {
            int _rnd = Random.Range(0, _stats.Length);
            _temp = _stats[_rnd];
            _stats[_rnd] = _stats[i];
            _stats[i] = _temp;
        }

        return _stats;
    }
}
