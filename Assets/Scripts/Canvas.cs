using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameCanvas;
	 public GameObject player;
    public GameObject MenuCanvas;
    public GameObject LineRenderer;
	public GameObject StopCar;
	public GameObject QuestionCanvas;
	public GameObject MainCanvas;
	public GameObject ShopCanvas;
    public Text BestScore;   
    public GameObject BuyButton2, BuyButton3, BuyButton4, BuyButton5,SelectCar1, SelectCar2, SelectCar3,SelectCar4,SelectCar5;
	public int money;
	public int car2 = 0,car3= 0,car4= 0,car5= 0;  // 0 - false; 1 - true;
	public GameObject Car1,Car2,Car3,Car4,Car5; // skins
	
	
	
    void Start()
    {
	
		money = PlayerPrefs.GetInt( "moneyForShop", money );
		car2 = PlayerPrefs.GetInt( "Car2", car2 );
		car3 = PlayerPrefs.GetInt( "Car3", car3 );
		car4 = PlayerPrefs.GetInt( "Car4", car4 );
		car5 = PlayerPrefs.GetInt( "Car5", car5 );
		
		/*если надо обнулить покупки машин:
		PlayerPrefs.SetInt( "Car2", 0 );
		PlayerPrefs.SetInt( "Car2", 0 );
		PlayerPrefs.SetInt( "Car2", 0 );
		PlayerPrefs.SetInt( "Car2", 0 );*/
		
		
		
		
		if(car2 == 1)
		{
			BuyButton2.SetActive(false);
		    SelectCar2.SetActive(true);
			
		}	

        if(car3 == 1)
		{
			BuyButton3.SetActive(false);
		    SelectCar3.SetActive(true);
			
		}	
		
		if(car4 == 1)
		{
			BuyButton4.SetActive(false);
		    SelectCar4.SetActive(true);
		
		}
		
		if(car5 == 1)
		{
			BuyButton5.SetActive(false);
		    SelectCar5.SetActive(true);
	
		}


		
    }

















    public void StartGame()
    {
		
         BestScore.text = "BestScore:" + 0;
        gameCanvas.SetActive(true);
        MenuCanvas.SetActive(false);
        LineRenderer.SetActive(true);
		StopCar.SetActive(false);
	    
    }
	
	 public void ExitGame()
	 { 
		 Application.Quit();
	 }
	 
	
	 
	 public void QuestionButton()
	 { 
		 QuestionCanvas.SetActive(true);
		MainCanvas.SetActive(false);
	 }
	 
	  public void ExitQuestionButton()
	 { 
		 QuestionCanvas.SetActive(false);
		MainCanvas.SetActive(true);
		ShopCanvas.SetActive(false);
	 }
	 
	   public void OpenShopCanvas()
	 { 
		 QuestionCanvas.SetActive(false);
		MainCanvas.SetActive(false);
		ShopCanvas.SetActive(true);
	 }







     

    public void BuyCar2()
	 { 
		if(money>=1000)
		{
			car2 = 1;
			PlayerPrefs.SetInt( "Car2", car2 );
			BuyButton2.SetActive(false);
		    SelectCar2.SetActive(true);
			money -=1000;
			PlayerPrefs.SetInt( "moneyForShop", money );
		}
		
		
	 }
	 
	   public void BuyCar3()
	 { 
		 if(money>=1000)
		{
			car3 = 1;
				PlayerPrefs.SetInt( "Car3", car3 );
			BuyButton3.SetActive(false);
		    SelectCar3.SetActive(true);
			money -=1000;
			PlayerPrefs.SetInt( "moneyForShop", money );
		}
	 }
	 
	   public void BuyCar4()
	 { 
		 if(money>=1000)
		{
			car4 = 1;
				PlayerPrefs.SetInt( "Car4", car4 );
			BuyButton4.SetActive(false);
		    SelectCar4.SetActive(true);
			money -=1000;
			PlayerPrefs.SetInt( "moneyForShop", money );
		}
	 }
	 
	   public void BuyCar5()
	 { 
		 if(money>=1000)
		{
			car5 = 1;
			PlayerPrefs.SetInt( "Car5", car5 );
			BuyButton5.SetActive(false);
		    SelectCar5.SetActive(true);
			money -=1000;
			PlayerPrefs.SetInt( "moneyForShop", money );
		}
	 }
	 
	   public void selectCar1()
	 { 
	     Car1.SetActive(true);
		 Car2.SetActive(false);
		 Car3.SetActive(false);
		 Car4.SetActive(false);
		 Car5.SetActive(false);	    
	 }
	 
	   public void selectCar2()
	 { 
		 Car1.SetActive(false);
		 Car2.SetActive(true);
		 Car3.SetActive(false);
		 Car4.SetActive(false);
		 Car5.SetActive(false);	 
	 }
	 
	   public void selectCar3()
	 { 
		 Car1.SetActive(false);
		 Car2.SetActive(false);
		 Car3.SetActive(true);
		 Car4.SetActive(false);
		 Car5.SetActive(false);	 
	 }
	 
	   public void selectCar4()
	 { 
		 Car1.SetActive(false);
		 Car2.SetActive(false);
		 Car3.SetActive(false);
		 Car4.SetActive(true);
		 Car5.SetActive(false);	
	 }
	 
	   public void selectCar5()
	 { 
		 Car1.SetActive(false);
		 Car2.SetActive(false);
		 Car3.SetActive(false);
		 Car4.SetActive(false);
		 Car5.SetActive(true);	
	 }
	 
	  


}
