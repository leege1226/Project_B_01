using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;
        answer = 1 + 2;
        Debug.Log(answer);

        int n1 = 8;
        int n2 = 9;
        int answer2;
        answer2 = n1 + n2;
        Debug .Log(answer2);

        int answer3 = 10;
        answer3 += 5;
        Debug.Log(answer3);

        answer3++;
        Debug.Log(answer3);

        string str1 = "Happy ";
        string str2 = "birthday";
        string message;

        message = str1 + str2;
        Debug .Log(message);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
