using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    // Start is called before the first frame update
    int min = 1;
    int max = 1001;
    int shoot = 500;
    void Start()
    {

        Debug.Log("Witam w grze- pomyœl w g³owie liczbê od 1 do 1000");
        Debug.Log("Czy twoja liczba jest równa/wiêksza/mniejsza od 500?");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            NextShoot()
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            NextShoot()
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("KOMPUTER ZGADL LICZBE");
        }
    }
    void NextShoot()
    {
        shoot = (min + max) / 2;
        Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od " + shoot + "?");
    }
}
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    // Start is called before the first frame update
    int min = 1;
    int max = 1000;
    int shoot = 500;
    void Start()
    {

        Debug.Log("Witam w grze- pomyœl w g³owie liczbê od 1 do 1000");
        Debug.Log("Czy twoja liczba jest równa/wiêksza/mniejsza od 500?");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            NextShoot()
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            NextShoot()
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("KOMPUTER ZGADL LICZBE");
        }
    }
    void NextShoot()
    {
        shoot = (min + max) / 2;
        Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od " + shoot + "?");
    }
}
