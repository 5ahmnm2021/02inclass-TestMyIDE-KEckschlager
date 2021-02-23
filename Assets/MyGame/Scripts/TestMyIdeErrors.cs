using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestMyIdeErrors : MonoBehaviour
{
    string Tag = "TestMyIdeErrors";

    // Update is called once per frame
    void Update()
    {

    }
    int a = 1;
    int b = 2;
    float d = 5;

    TextMeshProUGUI TextPro;

    // Start is called before the first frame update
    void Start()
    {
        int c = a + b;
        Debug.Log("a + b = 3");
        Debug.Log(Tag + "- Done )");
    }
}