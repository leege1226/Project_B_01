using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_005 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ////�ּ� ����Ű�� ��Ʈ�� + k + c Ǯ��� ��Ʈ�� + k + u


        //for (int i = 0; i < 5; i++)           //0���� 4���� i���
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 0; i < 10; i += 2)       //0���� 9���� ¦�����
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 3; i > 0; i--)         //3���� 0���� �������� i���
        //{
        //    Debug.Log(i);
        //}

        for (int i = 0; i < 10; i++)            //0���� 9���� ¦�����
        {
            if(i%2 == 0)                        //%�� ������ ��
            {
                Debug.Log(i);
            }
        }

        Debug.Log("=======================");

        int sum = 0;
        for(int i = 0; i < 10; i++)             //0���� 9���� �� ���
        {
            sum += i;
        }
        Debug.Log(sum);

        Debug.Log("==========������==========");

        for (int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                Debug.Log(i.ToString() + " x " + j.ToString() + " = " + (i * j).ToString());    //i x j = ���� ��
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}