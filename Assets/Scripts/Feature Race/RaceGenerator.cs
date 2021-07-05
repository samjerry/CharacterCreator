using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceGenerator : MonoBehaviour
{
    // Variables used to get the variable charRace from ReadJson
    [SerializeField] private ReadJson _readJson;
    [SerializeField] private string setCharRace;

    // The Index Number that is going to be randomized 
    [SerializeField] private int IndexNum; 

    //Function to randomize the race
    public int RandomizeRace()
    {
        // Randomized the Index Number
        IndexNum = Random.Range(0, 38);

        //Goes by every Race 
        for (int i = 0; i < 38; i++)
        {
            if(i == IndexNum)
            {
                
            }
            else
            {
                i += 1;
            }
        }
        return IndexNum;
    }

    public void Start()
    {
        RandomizeRace();
    }
    private void Update()
    {
        print(IndexNum);
    }


}
