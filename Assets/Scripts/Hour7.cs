using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hour7 : MonoBehaviour
{
    void Start()
    {
        //Exercise1();
        //Exercise2();
        Exercise3();
    }

    // Exercises

    void Exercise1()
    {
        int sum = 0;

        for (int i = 2; i < 500; i += 2)
        {
            sum += i;
        }

        print("Even Number Sum: " + sum);
    }

    void Exercise2()
    {
        print("EXERCISE 2");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 != 0 && i % 5 != 0)
            {
                print(i);
            }
            else
            {
                print("Programming is awesome!");
            }
        }
    }

    void Exercise3()
    {
        int n1 = 0;
        int n2 = 1;
        int n3 = 0;

        print("FIBONACCI SEQUENCE");

        for (int i = 0; i <= 20; i++)
        {
            print(n1);
            n3 = n2;
            n2 += n1;
            n1 = n3;
        }
    }
}
