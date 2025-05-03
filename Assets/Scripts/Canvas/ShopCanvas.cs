using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopCanvas : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject ShopCamera;
    public GameObject MainCamera;
	public Text MoneyText;

	public GameObject BuyButton2, BuyButton3, BuyButton4, BuyButton5, BuyButton6;
	public GameObject BuyCanvas;
	public GameObject NoMoneyCanvas;
	public Text BuyCanvasText;

	public GameObject MoneyController;
	public int car2, car3, car4, car5, car6;

	public GameObject Car1, Car2, Car3, Car4, Car5, Car6;

	public GameObject AchievesController;
	void Start()
	{
		AchievesController = GameObject.FindWithTag("AchievesController");
		MoneyController = GameObject.FindWithTag("MoneyController");

		car2 = PlayerPrefs.GetInt("Car2", car2);
		car3 = PlayerPrefs.GetInt("Car3", car3);
		car4 = PlayerPrefs.GetInt("Car4", car4);
		car5 = PlayerPrefs.GetInt("Car5", car5);
		car6 = PlayerPrefs.GetInt("Car6", car6);
		BuyButton2.SetActive((car2 == 1) ? true : false);
		BuyButton3.SetActive((car3 == 1) ? true : false);
		BuyButton4.SetActive((car4 == 1) ? true : false);
		BuyButton5.SetActive((car5 == 1) ? true : false);
		BuyButton6.SetActive((car6 == 1) ? true : false);

	}
	public void ExitButton()
    {
        MainCanvas.SetActive(true);
        ShopCamera.SetActive(false);
        MainCamera.SetActive(true);
        gameObject.SetActive(false);
		BuyCanvas.SetActive(false);
		NoMoneyCanvas.SetActive(false);
	}
	public void ExitBuyCanvas()
	{
		BuyCanvas.SetActive(false);
		NoMoneyCanvas.SetActive(false);
	}
	public void ExitNoMoneyCanvas()
	{
		NoMoneyCanvas.SetActive(false);
	}

	public void BuyCar2()
	{
		BuyCanvas.SetActive(true);
		BuyCanvasText.text = "Buy for \n 2000?";
	}

	public void BuyCar3()
	{
		BuyCanvas.SetActive(true);
		BuyCanvasText.text = "Buy for \n 5000?";
	}

	public void BuyCar4()
	{
		BuyCanvas.SetActive(true);
		BuyCanvasText.text = "Buy for \n 8000?";
	}

	public void BuyCar5()
	{
		BuyCanvas.SetActive(true);
		BuyCanvasText.text = "Buy for \n 10000?";
	}

	public void BuyCar6()
	{
		BuyCanvas.SetActive(true);
		BuyCanvasText.text = "Buy for \n 12000?";
	}

	public void BuyCarYes()
    {
		if(BuyCanvasText.text == "Buy for \n 2000?")
        {
			if (MoneyController.GetComponent<AddMoney>().Money >= 2000)
			{
				MoneyController.GetComponent<AddMoney>().Money -= 2000;
				car2 = 0;
				PlayerPrefs.SetInt("Car2", car2);
				PlayerPrefs.SetInt("Car2Bought", 1);
				BuyButton2.SetActive(false);
				BuyCanvas.SetActive(false);
				//включать звук
			}
			else
			{
				NoMoneyCanvas.SetActive(true);
			}
		}
		if (BuyCanvasText.text == "Buy for \n 5000?")
		{
			if (MoneyController.GetComponent<AddMoney>().Money >= 5000)
			{
				MoneyController.GetComponent<AddMoney>().Money -= 5000;
				car3 = 0;
				PlayerPrefs.SetInt("Car3", car3);
				PlayerPrefs.SetInt("Car3Bought", 1);
				BuyButton3.SetActive(false);
				BuyCanvas.SetActive(false);
			}
			else
			{
				NoMoneyCanvas.SetActive(true);
			}
		}
		if (BuyCanvasText.text == "Buy for \n 8000?")
		{
			if (MoneyController.GetComponent<AddMoney>().Money >= 8000)
			{
				MoneyController.GetComponent<AddMoney>().Money -= 8000;
				car4 = 0;
				PlayerPrefs.SetInt("Car4", car4);
				PlayerPrefs.SetInt("Car4Bought", 1);
				BuyButton4.SetActive(false);
				BuyCanvas.SetActive(false);
			}
			else
			{
				NoMoneyCanvas.SetActive(true);
			}
		}
		if (BuyCanvasText.text == "Buy for \n 10000?")
		{
			if (MoneyController.GetComponent<AddMoney>().Money >= 10000)
			{
				MoneyController.GetComponent<AddMoney>().Money -= 10000;
				car5 = 0;
				PlayerPrefs.SetInt("Car5", car5);
				PlayerPrefs.SetInt("Car5Bought", 1);
				BuyButton5.SetActive(false);
				BuyCanvas.SetActive(false);
			}
			else
			{
				NoMoneyCanvas.SetActive(true);
			}
		}
		if (BuyCanvasText.text == "Buy for \n 12000?")
		{
			if (MoneyController.GetComponent<AddMoney>().Money >= 12000)
			{
				MoneyController.GetComponent<AddMoney>().Money -= 12000;
				car6 = 0;
				PlayerPrefs.SetInt("Car6", car6);
				PlayerPrefs.SetInt("Car6Bought", 1);
				BuyButton6.SetActive(false);
				BuyCanvas.SetActive(false);
			}
			else
			{
				NoMoneyCanvas.SetActive(true);
			}
		}
	}

	public void SelectCar1()
	{
		PlayerPrefs.SetInt("SelectedCar", 1);
		Car1.SetActive(true);
		Car2.SetActive(false);
		Car3.SetActive(false);
		Car4.SetActive(false);
		Car5.SetActive(false);
		Car6.SetActive(false);
	}

	public void SelectCar2()
	{
		PlayerPrefs.SetInt("SelectedCar", 2);
		Car1.SetActive(false);
		Car2.SetActive(true);
		Car3.SetActive(false);
		Car4.SetActive(false);
		Car5.SetActive(false);
		Car6.SetActive(false);
	}

	public void SelectCar3()
	{
		PlayerPrefs.SetInt("SelectedCar", 3);
		Car1.SetActive(false);
		Car2.SetActive(false);
		Car3.SetActive(true);
		Car4.SetActive(false);
		Car5.SetActive(false);
		Car6.SetActive(false);
	}

	public void SelectCar4()
	{
		PlayerPrefs.SetInt("SelectedCar", 4);
		Car1.SetActive(false);
		Car2.SetActive(false);
		Car3.SetActive(false);
		Car4.SetActive(true);
		Car5.SetActive(false);
		Car6.SetActive(false);
	}

	public void SelectCar5()
	{
		PlayerPrefs.SetInt("SelectedCar", 5);
		Car1.SetActive(false);
		Car2.SetActive(false);
		Car3.SetActive(false);
		Car4.SetActive(false);
		Car5.SetActive(true);
		Car6.SetActive(false);
	}

	public void SelectCar6()
	{
		PlayerPrefs.SetInt("SelectedCar", 6);
		Car1.SetActive(false);
		Car2.SetActive(false);
		Car3.SetActive(false);
		Car4.SetActive(false);
		Car5.SetActive(false);
		Car6.SetActive(true);
	}

}
