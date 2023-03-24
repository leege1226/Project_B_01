using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_005 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ////주석 단축키는 컨트롤 + k + c 풀기는 컨트롤 + k + u


        //for (int i = 0; i < 5; i++)           //0부터 4까지 i출력
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 0; i < 10; i += 2)       //0부터 9까지 짝수출력
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 3; i > 0; i--)         //3부터 0까지 내려가며 i출력
        //{
        //    Debug.Log(i);
        //}

        for (int i = 0; i < 10; i++)            //0부터 9까지 짝수출력
        {
            if(i%2 == 0)                        //%는 나머지 값
            {
                Debug.Log(i);
            }
        }

        Debug.Log("=======================");

        int sum = 0;
        for(int i = 0; i < 10; i++)             //0부터 9까지 합 출력
        {
            sum += i;
        }
        Debug.Log(sum);

        Debug.Log("==========구구단==========");

        for (int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                Debug.Log(i.ToString() + " x " + j.ToString() + " = " + (i * j).ToString());    //i x j = 곱한 값
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
