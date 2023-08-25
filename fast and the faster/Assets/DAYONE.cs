using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAYONE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroname = "sekiro";
        
        int heroage = 31;
            
        bool is_Hero = true;
            
        float Speed = 280f;
        
        string HeroSuperPower = "dragon rot";

        print(heroname + " Is the Name");
       
        

        string villainname = "isshin";

        int villainage = 200;

        bool is_villain = true;
        float speed = 320f;
        string villainsuperpower = "90s Glock";
        int age_diff = villainage - heroage;


        print("(Hesitation Is Defeat )" + villainname + " age " + villainage);



        print("A huge gap in age " + age_diff); 







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
