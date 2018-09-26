using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {

    public string displayName;
    public float weight;
    private float price;
    protected SpriteRenderer rend;
    public ParticleSystem brap;
    protected ParticleSystem activeBrap;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    private float CalcPrice(float multiplayer = 1.7f)
    {
        return weight * multiplayer;       
    }

    public override string ToString()
    {
        return "Name = " + displayName
            + " : weight = " + weight
            + " : price = " + CalcPrice();
    }

    virtual public void OnMouseEnter()
    {
        MatDisplayText.ChangeText(ToString());
        rend.color = Color.Lerp(Color.white, Color.green, 0.6f);
        activeBrap = Instantiate(brap, gameObject.transform.position, brap.transform.rotation);      
    }
    private void OnMouseExit()
    {
        rend.color = Color.white;
        Destroy(activeBrap.gameObject);
    }
}
