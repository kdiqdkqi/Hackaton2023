using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.Random;
using UnityEngine.UI;

public class BossColorChange : MonoBehaviour
{   
    public float Hp;
    public float ComparedHp;
    public Text textElement;
    public bool textVisible;
    public float visibleTimer;
    public string elementName;
    public Material[] material;
    public int element;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

        ComparedHp = Hp - Random.Range(5, 10);

        textVisible = false;
        visibleTimer = 4f;

        elementName = "text";
    }
 
    void Update()
    {
        Hp -= Time.deltaTime; 

        if (Hp < ComparedHp)
        {
            int randomNumber = Random.Range(0, material.Count());
            rend.sharedMaterial = material[randomNumber];
            element = randomNumber;
            elementName = material[randomNumber].name;
            ComparedHp = Hp - Random.Range(5, 8);
            textVisible = true;
        }

        if (textVisible == true)
        {
            textElement.gameObject.SetActive(true);
            textElement.text = "Element du boss : " + elementName;

            visibleTimer -= Time.deltaTime;

        if (visibleTimer <= 1f)
        {
            textVisible = false;
            textElement.gameObject.SetActive(false);
            visibleTimer = 4f;
        }

        }


        
    }
}
