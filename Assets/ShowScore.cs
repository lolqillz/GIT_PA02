using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text scoretext;

    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = "Score: " +PlayerPrefs.GetInt("ShowScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
