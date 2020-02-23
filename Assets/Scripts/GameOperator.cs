using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOperator : MonoBehaviour
{
  
    [SerializeField] Text name;
    [SerializeField] Text fable;
    [SerializeField] Image background;
    public Items additem;
    public Enemy nemezis;
    public int current2;
    public int gold = 0;
    public int health;
    public int attack;
    public int PlayerDamage = 7;
    public GameObject messbox;
    public Text messboxtext;
    public Text goldcounter;
    public bool unlocked = false;
    public int EAtt;
    public int EHtt;
    public GameObject Death;
    public int il;
    public string named;
    public GameObject Goback;
   System.Random rnd = new System.Random();
    //LOKACJE ŚWIATA////////////////////////////////////
    public string [] tabn = new string[10];
    public string [] tabfable= new string[10];
    public Sprite [] tabback = new Sprite [10];
    public Items [] equip = new Items [20];
   
    public int current;
    public Items courses;
    ///////////SZCZEGÓŁY LOKACJI[ZAMEK]////////////////////////////////
    public string [] tabcastle = new string[10];
    public string [] tabfablecastle= new string[10];
    public Sprite [] tabbackcastle = new Sprite [10];
    public int castlecounter;
    //////////////////Szczegóły lokalizacji [LAS]/////////////////////////////////////////////////
    public string [] tabforest = new string[10];
    public string [] tabfableforest = new string[10];
    public Sprite [] tabbackforest = new Sprite [10];
     public int forestcounter;
     public int cuttentf;   
     public string co;
      public int playerDice;
       public  int EnemyDice;
    public Text battleinfo;
    public GameObject buttonF;
    public GameObject buttonR;
    public GameObject equpi;
    public Text PlayerPlusA;
    public Text PlayerPlusD;
    public int PlayerAAdd = 0;
    public int PlayerDAdd = 0;
    /////////////////////////////////////////////

    //////////////////////////////////////////////
    public Button Up;
    public Button Down;
    public Button Left;
    public Button Right;
    public GameObject Takegame;
    public GameObject shops;
    public GameObject battles;
     public GameObject mapp;
     public Text HPE;
     public Text AE;
     public Text NameE;
    public bool equipu = false;
    void Start()
    {
        current = 0;
        current2 = 0;
        castlecounter = 0;
        forestcounter = 0;
        cuttentf = 0;
        Takegame.SetActive(false);
        
        
     
     }
    
    void Update()
    {

        /* else if (current2 ==1 ){    
         name.text = tabn[current];
         fable.text = tabfable[current];
         background.sprite=tabback[current];
         }
         */
        goldcounter.text = gold.ToString();
        PlayerPlusA.text = PlayerAAdd.ToString();
        PlayerPlusD.text = PlayerDAdd.ToString();
        PlayerDamage = PlayerDamage+PlayerAAdd;
        if (current2<=0){
            //Down.SetActive("false");
            Down.interactable = false;
        }
        else if( current2 > 0){
            Down.interactable = true;
        }
        if(current < 0){
            current = tabn.Length - 1; 
        }
        if(castlecounter < 0){
            castlecounter = tabcastle.Length - 1; 
        }
         if( forestcounter< 0){
            forestcounter = tabforest.Length - 1; 
        }
        //Wyświetalnie lokalizacji
         if(current2 == 0 ){
            name.text = tabn[current];
           fable.text = tabfable[current];
           background.sprite=tabback[current];
           co = "world";
        }
        ////castleee
        else if(current2 == 1 && current == 0){
            name.text = tabcastle[castlecounter];
           fable.text = tabfablecastle[castlecounter];
           background.sprite=tabbackcastle[castlecounter];
           co = "castle";
        }
        /////forest
        else if(current2 == 1  && current == 1){
            name.text = tabforest[forestcounter];   
           fable.text = tabfableforest[forestcounter];
           background.sprite=tabbackforest[forestcounter];
           co = "forest";
        }
    if(messbox.activeSelf== true){
        Down.interactable = false;
        Up.interactable = false;
        Right.interactable = false;
        Left.interactable = false;
    }
     if(messbox.activeSelf== false){
        Down.interactable = true;
        Up.interactable = true;
        Right.interactable = true;
        Left.interactable = true;
    }
        ///caves
        ///    }
        if (equpi.activeSelf == true)
        {
            Down.interactable = false;
            Up.interactable = false;
            Right.interactable = false;
            Left.interactable = false;
        }
        if (equipu == true) {
            equpi.SetActive(true);
        }
        if (equipu == false)
        {
            equpi.SetActive(false);
        }
        if (equpi.activeSelf == false)
        {
            Down.interactable = true;
            Up.interactable = true;
            Right.interactable = true;
            Left.interactable = true;
            
        }

    }
    public void ButtDown(){
        if(current2 == 0){
            current = current - 1; 
        }
        if (current == 0 && current2 == 1){
             castlecounter =  castlecounter - 1;
        }
        else if(current == 1 && current2 == 1){
             forestcounter = forestcounter - 1;
            
        }
                   
    }
    public void ButtUp(){

        if(current2 == 0){
            current = current + 1;
            if(current == tabn.Length){
                current = 0;   
            }
        }
         else if (current2 == 1){
             if(current == 0){
                castlecounter = castlecounter + 1;
                if(castlecounter == tabcastle.Length){
                castlecounter = 0;   
                }
             }
              else if(current == 1){
               forestcounter = forestcounter + 1;
                if( forestcounter == tabforest.Length){
                forestcounter = 0;   
                }  
             }
        }
       
    }
    public void ComeIn(){
      
        current2 = current2 + 1;
        
        if(current2 == 2 && castlecounter == 0 && gold<=0&& current == 0 && co=="castle"){
            current2 = 1;
            StartCoroutine(ExampleCoroutine());
        }
        else if(current2 == 2 && castlecounter == 0 && gold>0&& current == 0 && co=="castle" ){
            //current2 = 2;
            //StartCoroutine(ExampleCoroutine());
            
            shop();
        
        }
        else if(current2 == 2 && castlecounter == 2 && unlocked == false  && co=="castle"){
            //current2 = 2;
            //StartCoroutine(ExampleCoroutine());
             current2 = 1;
           StartCoroutine(ExampleCoroutineK());
           
           
        
        }
        else if(current2 == 2 && forestcounter == 0 && co=="forest"){ 
            current2 = 1;
            int rnd = Random.Range(1,4);
            if (rnd < 3)
            {
                battle(EnemyList.wolf);

            }
            else {
                battle(EnemyList.bear);

            }

        }
        else{
           //messbox.SetActive(false);
        }

      
    }
    public void ComeOut(){
        current2 = current2 - 1; 
        
    }
     IEnumerator ExampleCoroutine()
    {
        messbox.SetActive(true);
        messboxtext.text = "You should earn more gold";
        yield return new WaitForSeconds(1);
        messbox.SetActive(false);
    }
      IEnumerator ExampleCoroutineK()
    {
        messbox.SetActive(true);
         messboxtext.text = "Are you serious? Go talk to the minister! Maybe one day you will be worthy to talk with king.";
        yield return new WaitForSeconds(3);
        messbox.SetActive(false);
    }
      IEnumerator battleco()
    {    
        
        yield return new WaitForSeconds(2);
        result();
    }
    public void result(){
        battleinfo.text = "You have attacked the enemy!";
        battleinfo.text +="\n Your attack is "+playerDice.ToString();
        battleinfo.text +="\n Yours enemy attack is "+EnemyDice.ToString();
         if(playerDice>EnemyDice){
            battleinfo.text +="\n You won!";     
            if(NameE.text == "Wolf"){
                /// adding(ItemsList.skin);
                gold = gold + 1;
            }
            else if (NameE.text == "Bear")
            {
                /// adding(ItemsList.skin);
                gold = gold + 3;
            }

            Goback.SetActive(true);
            
            
           
        }
        else{
             battleinfo.text +="\n You died!";
             Death.SetActive(true);
        }

       


       
    }
    
    public void shop(){
            //mapp.SetActive(false);
            shops.SetActive(true);

        Down.interactable = false;
      
        Right.interactable = false;
        Left.interactable = false;

    }
    public void equpimentcik()
    {
        equipu = !equipu;
    }
    public void battle(Enemy enemy){
            mapp.SetActive(false);
            battles.SetActive(true);
            NameE.text = enemy.Ename;
            switch(enemy.type){
                case "common":
                AE.text = "1-";

                break;
            case "boss":
                AE.text = "2-";
                break;
            }
            EHtt = enemy.HPE;
            EAtt = enemy.APE;
            HPE.text = enemy.HPE.ToString();
            AE.text += enemy.APE.ToString();

            
      

    }
   
    public void run(){
            mapp.SetActive(true);
            battles.SetActive(false);
    }
    public void fighting(){
        buttonR.SetActive(false);
        buttonF.SetActive(false);
        playerDice = Random.Range(2,PlayerDamage);
        EnemyDice = Random.Range(1,EAtt+1);
         battleinfo.text = "You have attacked the enemy!";
         battleinfo.text += "\n Wait, fighting...!";

        StartCoroutine(battleco());
        

    }
    public void goback(){
            mapp.SetActive(true);
            battles.SetActive(false);
            battleinfo.text = "";
            buttonR.SetActive(true);
            buttonF.SetActive(true);
            Goback.SetActive(false);
            Death.SetActive(false);
           
    }
    public void death(){
         SceneManager.LoadScene("DeathScene");
    }
    public void loot(Enemy enemy){
      
      
        
    }
    public void adding(Items item){
        
            named = item.name ;
            il =item.count ;
           courses.name = named;
           courses.count = il;
           equip[0]= courses;
    }
}