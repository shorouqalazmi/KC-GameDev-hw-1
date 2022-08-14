using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    string hero ="shorouq";
    int health = 40;
    int health_afterDamage;
    
    // Start is called before the first frame update
    void Start()
    {
       print("Health before damage:" + health);
      damaged(); //health = 20
       print("Health after damage:" +health);

       health_afterDamage = health;

       boost();//health = 30
       print("Health after boost:" +health);

       print(health_afterDamage+"is less than"+health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void damaged() 
    {
         health -=20;
    }
    void boost()
    {
        health +=10;    
    }
}
    