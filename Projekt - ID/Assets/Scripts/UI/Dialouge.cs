using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class Dialouge : MonoBehaviour
{
    public Text textObj;
    public bool createNew;
    public GameObject canvas;
    GameObject textPrefab;

    public Dialouge(string text)
    {
        textPrefab = new GameObject();
        canvas = GameObject.FindGameObjectWithTag("Canvas");

        textPrefab.AddComponent<Text>();
        textPrefab.name = "TEXT";

        textPrefab.transform.SetParent(canvas.transform);

        textObj = textPrefab.GetComponent<UnityEngine.UI.Text>();
        textObj.text = text;
        textObj.verticalOverflow = UnityEngine.VerticalWrapMode.Overflow;
        textObj.horizontalOverflow = UnityEngine.HorizontalWrapMode.Overflow;
        textObj.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        textObj.rectTransform.position = new Vector2(614, 269);
    }
}
