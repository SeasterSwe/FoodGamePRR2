using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usable : Items {

    protected int uses;
    public int maxUses;
    public ParticleSystem usedP;

    private void Awake()
    {
        uses = maxUses;
    }
    
    private void OnMouseUpAsButton()
    {    
        if (uses > 0)
        {
            Destroy(activeBrap.gameObject);
            activeBrap = Instantiate(usedP, gameObject.transform.position, usedP.transform.rotation);

            Use();
            rend.color = Color.red;          
            MatDisplayText.ChangeText(UseText());
        }
        else 
        {
            MatDisplayText.ChangeText(NothingLeftText());
        }       
    }

    public override string ToString()
    {
        return base.ToString() + " : Max uses = " + maxUses + " : Uses remaning = " + uses;
    }

    public virtual void Use()
    {
        uses -= 1;
    }
    
    public virtual string UseText()
    {
        return "You used a  " + displayName + " : " + uses + " remaining";
    }

    public virtual string NothingLeftText()
    {
        return "Out of uses";
    }
}
