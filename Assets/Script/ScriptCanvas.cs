using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptCanvas : MonoBehaviour
{
    [Header("Текстовые переменные")]
    public Text PopulationText;
    public Text YearText;
    public Text PYearText;

    [Header("Объекты Unity")]
    public GameObject TopMenu;
    public GameObject MainButton;
    public GameObject DownMenu1;
    public GameObject DownMenu2;
    public GameObject DownMenu3;
    public GameObject DownMenu4;
    public GameObject DownMenu5;
    public GameObject SliderF;
    public GameObject SliderM;
    public GameObject SliderE;
    public GameObject SliderR;
    public GameObject SliderA;
    [Header("Числовые переменные")]

    public long Population;
    public int Year;
    public int upKIP;
    public int downKIP;


    public void Start()
    {
        upKIP = 120;
        downKIP = 60;
        Year = 2237;
        Population = 500;
        StartCoroutine(IncPop());
        StartCoroutine(Time());
        

    }

    public void Update()
    {
        PopulationText.text = Population + "";
        YearText.text = "Year " + Year;
        PYearText.text = "Population growth   " + (upKIP - downKIP) * 60 + " people/year";


    }



    IEnumerator IncPop()
    {
        while (true)
        {
          float x = (upKIP - downKIP) / 60;
          float y;
            if (x > 1)
                Population += (long)x;
            if (x > 0)
            {
                y = x;
            }            
            else
                x = x++;
           yield return new WaitForSeconds(1f);

        }
    }//Цикл прироста населения

    IEnumerator Time()
    {
        while (true)
        {
            Year++;
            yield return new WaitForSeconds(60f);

        }
    }//Цикл времени

    public void OnClick()//Главное нажатие
    {
        Population++;
    }

    public void OpenTopMenu()//Активация верхнего меню
    {
        TopMenu.SetActive(!TopMenu.activeSelf);
        MainButton.SetActive(!MainButton.activeSelf);

    }

    public void OpenDownMenu1()//Активация нижнего меню 1
    {
        DownMenu1.SetActive(!DownMenu1.activeSelf);
    }
    public void OpenDownMenu2()//Активация нижнего меню 2
    {
        DownMenu2.SetActive(!DownMenu2.activeSelf);               
    }    
    public void OpenDownMenu3()//Активация нижнего меню 3
    {
        DownMenu3.SetActive(!DownMenu3.activeSelf);        
    }
    public void OpenDownMenu4()//Активация нижнего меню 4
    {
        DownMenu4.SetActive(!DownMenu4.activeSelf);
    }
    public void OpenDownMenu5()//Активация нижнего меню 5
    {
        DownMenu5.SetActive(!DownMenu5.activeSelf);
    }



}
