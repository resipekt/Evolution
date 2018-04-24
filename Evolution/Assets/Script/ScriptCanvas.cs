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
        upKIP = 50;
        downKIP = 10;
        Year = 2237;
        Population = 60;
        StartCoroutine(IncPop());
        StartCoroutine(Time());
        

    }

    public void Update()
    {
        PopulationText.text = Population + "";
        YearText.text = "Year " + Year;
        PYearText.text = "Population growth   " + (upKIP - downKIP) * 60 + " people/year";


    }


	//Цикл прироста населения
    IEnumerator IncPop()
    {
        while (true)
        {
         float x = (upKIP - downKIP) / 60;
         if (x > 1)
               Population += (long)x;
         else
				Population++;
          
            
           yield return new WaitForSeconds(1f);

       }
	}


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
		DownMenu2.SetActive(false);
		DownMenu3.SetActive(false);
		DownMenu4.SetActive(false);
		DownMenu5.SetActive(false);
		TopMenu.SetActive(false);
	}
	public void OpenDownMenu2()//Активация нижнего меню 2
	{
		DownMenu2.SetActive(!DownMenu2.activeSelf);
		DownMenu1.SetActive(false);
		DownMenu3.SetActive(false);
		DownMenu4.SetActive(false);
		DownMenu5.SetActive(false);
		TopMenu.SetActive(false);
	}    
	public void OpenDownMenu3()//Активация нижнего меню 3
	{
		DownMenu3.SetActive(!DownMenu3.activeSelf);
		DownMenu1.SetActive(false);
		DownMenu2.SetActive(false);
		DownMenu4.SetActive(false);
		DownMenu5.SetActive(false);
		TopMenu.SetActive(false);
	}
	public void OpenDownMenu4()//Активация нижнего меню 4
	{
		DownMenu4.SetActive(!DownMenu4.activeSelf);
		DownMenu1.SetActive(false);
		DownMenu2.SetActive(false);
		DownMenu3.SetActive(false);
		DownMenu5.SetActive(false);
		TopMenu.SetActive(false);
	}
	public void OpenDownMenu5()//Активация нижнего меню 5
	{
		DownMenu5.SetActive(!DownMenu5.activeSelf);
		DownMenu1.SetActive(false);
		DownMenu2.SetActive(false);
		DownMenu3.SetActive(false);
		DownMenu4.SetActive(false);
		TopMenu.SetActive(false);
	}



}
