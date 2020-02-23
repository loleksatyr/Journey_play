using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Location : MonoBehaviour
{
   public string nazwa;
   public string opis;
   public Image zdjecie;
   public Location(string nazwa,string opis, Image zdjecie){
       nazwa = this.nazwa;
       opis = this.opis;
       zdjecie = this.zdjecie;
   }
}
