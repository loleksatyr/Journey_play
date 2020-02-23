using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
 public int HPE;
 public int APE;
 public string Ename;
 public string type;
 public Enemy (string name, int a, int b, string typ ){
    this.Ename= name; 
    this.HPE = a;
    this.APE = b;
    this.type = typ;
 }
}
