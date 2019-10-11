using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class ReadText
{
    public ReadText(string ID)
    {
        string path = "Assets/Texts/test.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        reader.ReadToEnd();
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }
}
