using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.Random;
using UnityEngine.UI;
using Unity.VisualScripting;

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
    public int Health;
    [SerializeField] private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

        ComparedHp = Hp - Random.Range(1, 3);

        textVisible = false;
        visibleTimer = 4f;

        elementName = "text";
    }


    void Update()
    {
        Hp -= Time.deltaTime; 

        if (Hp <= 0 ) 
        {
            Hp = 100;
            ComparedHp = Hp - Random.Range(2, 4);
        }

        if (Hp < ComparedHp)
        {
            int randomNumber = Random.Range(0, material.Count());
            rend.sharedMaterial = material[randomNumber];
            element = randomNumber;
            elementName = material[randomNumber].name;
            ComparedHp = Hp - Random.Range(2, 4);
            textVisible = true;
            gameObject.name = material[randomNumber].name;
        }

        if (textVisible == true)
        {

            visibleTimer -= Time.deltaTime;

            if (visibleTimer <= 1f)
            {
                textVisible = false;
                textElement.gameObject.SetActive(false);
                visibleTimer = 4f;
        }
        }
    }
        public void OnTriggerEnter(Collider other)
        {

            if (other.CompareTag(gameObject.name))
            {
                slider.value -= 0.05f;
                Debug.Log("Triggered by Enemy");
            }
            if (slider.value <= 0f)
        {
            Destroy(gameObject);
        }
        }
}
