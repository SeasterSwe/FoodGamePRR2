using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food :  Usable {

    public float saturation;

    public override void Use()
    {
        if (uses > 0)
            uses -= 1;
        else
            uses = 0;       
    }

    public override string UseText()
    {
        return "U ate a " + displayName + " : Hunger decreased with " + saturation + " : Uses remaining = " + uses;
    }

    //Går att använda om man känner för det.
    //public override string ToString()
    //{
    //    return "Food kind = " + name + " You can eat it " + uses + "Times";
    //}
}