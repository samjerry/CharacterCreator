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
        int n = _stats.Length;
        int rng = Random.Range(0, _stats.Length);

        while (n > 1)
        {
            n--;
            int k = (n + 1);
            var value = _stats[k];
            _stats[k] = _stats[n];
            _stats[n] = value;
        }

        return _stats;
    }
}
