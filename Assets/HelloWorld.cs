using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bolenleriBul(10,90);
    }
    string elemanlar;
    string bolum2;
    string bolum3;
    string bolum4;
    string bolum5;

    void bolenleriBul(int ilksayi, int ikincisayi)
    {
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            elemanlar += i + "-";

            if(i%2 == 0)
            {
                bolum2 += i + "-";
            }
            if(i%3 == 0)
            {
                bolum3 += i + "-";
            }
            if (i%4 == 0)
            {
                bolum4 += i + "-";
            }
            if((i%5) == 0)
            {
                bolum5 += i + "-";
            }


        }
        
        
        
        
        Debug.Log("Bu iki say� aras�ndaki say�lar: " + elemanlar);
        Debug.Log("Aradaki say�lardan ikiye b�l�nenler: " + bolum2);
        Debug.Log("Aradaki say�lardan ��e b�l�nenler: " + bolum3);
        Debug.Log("Aradaki say�lardan d�rde b�l�nenler: " + bolum4);
        Debug.Log("Aradaki say�lardan be�e b�l�nenler: " + bolum5);
        

    }

}
