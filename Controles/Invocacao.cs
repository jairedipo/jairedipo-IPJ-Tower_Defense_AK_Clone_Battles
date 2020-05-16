using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Invocacao : MonoBehaviour
{
    int cristais = 100;

    public GameObject Goop;
    public GameObject Shurtle;
    public GameObject Dog;
    public GameObject Grunt;
    public GameObject Lich;
    public GameObject Footman;
    public GameObject Golem;

    string tecla1 = "";
    string tecla2 = "";

    Quaternion rot = new Quaternion(0, 90.0f, 0, 0);

    void Start()
    {

    }

    void Update()
    {
        if (Input.anyKeyDown && tecla1 == "")
        {
            tecla1 = verificaEntrada(Input.inputString);
            if (tecla1 == "")
                 print("Comando inválido");
        }
        else if (Input.anyKeyDown && tecla1 != "")
        {
            tecla2 = verificaEntrada(Input.inputString, tecla1);

            if (tecla2 == "")
            {
                tecla1 = "";
                print("Comando inválido");
            }
            else
            {
                Instantiate(getChar(tecla1), getPosition(tecla2), rot);
                tecla1 = tecla2 = "";
            }
        }
    }

    Vector3 getPosition(string tecla)
    {

        if (tecla == "w")
        {
            return new Vector3((float)Random.Range(-15.8f, -12.8f), 0.0f, (float)Random.Range(-13.6f, -16.6f));
        }

        if (tecla == "e")
        {
            return new Vector3((float)Random.Range(-12f, -9f), 0.0f, (float)Random.Range(-13.6f, -16.6f));
        }

        if (tecla == "d")
        {
            return new Vector3((float)Random.Range(-12f, -9f), 0.0f, (float)Random.Range(-18.1f, -21.1f));
        }

        if (tecla == "x")
        {
            return new Vector3((float)Random.Range(-12f, -9f), 0.0f, (float)Random.Range(-23.6f, -26.6f));
        }

        if (tecla == "z")
        {
            return new Vector3((float)Random.Range(-15.8f, -12.8f), 0.0f, (float)Random.Range(-23.6f, -26.6f));
        }
        return new Vector3();
    }


    GameObject getChar(string tecla)
    {
        if (tecla == "1")
        {
            return Goop;
        }

        if (tecla == "2")
        {
            return Shurtle;
        }

        if (tecla == "3")
        {
            return Dog;
        }

        if (tecla == "4")
        {
            return Grunt;
        }

        if (tecla == "5")
        {
            return Lich;
        }

        if (tecla == "6")
        {
            return Footman;
        }

        if (tecla == "7")
        {
            return Golem;
        }

        return null;
    }

    string verificaEntrada(string input)
    {
        if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7")
        {
            return input;
        }
        return "";
    }

    string verificaEntrada(string input, string tecla1)
    {
        if (input == "w" || input == "e" || input == "d" || input == "x" || input == "z")
        {
            return input;
        }
        return "";
    }
 }
