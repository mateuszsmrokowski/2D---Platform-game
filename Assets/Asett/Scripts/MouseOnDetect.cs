using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MouseOnDetect : MonoBehaviour {

    public BoxCollider2D BC1;
    public BoxCollider2D BC2;
    public BoxCollider2D BC3;
    public BoxCollider2D BC4;
    public BoxCollider2D BC5;
    public BoxCollider2D BC6;
    public BoxCollider2D BC7;
    public BoxCollider2D BC8;
    public BoxCollider2D BC9;
    public BoxCollider2D BC10;
    public BoxCollider2D BC11;
    public BoxCollider2D BC12;
    public Text SkillInfo;
    private Vector2 MouseCoords;
	// Use this for initialization
	void Start () {

        BC1 = BC1.GetComponent<BoxCollider2D>();
        BC2 = BC2.GetComponent<BoxCollider2D>();
        BC3 = BC3.GetComponent<BoxCollider2D>();
        BC4 = BC4.GetComponent<BoxCollider2D>();
        BC5 = BC5.GetComponent<BoxCollider2D>();
        BC6 = BC6.GetComponent<BoxCollider2D>();
        BC7 = BC7.GetComponent<BoxCollider2D>();
        BC8 = BC8.GetComponent<BoxCollider2D>();
        BC9 = BC9.GetComponent<BoxCollider2D>();
        BC10 = BC10.GetComponent<BoxCollider2D>();
        BC11 = BC11.GetComponent<BoxCollider2D>();
        BC12 = BC12.GetComponent<BoxCollider2D>();

        SkillInfo.enabled = false;
        InvokeRepeating("CheckFree", 0f, 0.2f);
    }
	
	// Update is called once per frame
	void Update () {
        


        if (BC1.bounds.Contains(MouseCoords))
        {
            SkillInfo.transform.position = new Vector2(BC1.transform.position.x + 200f, BC1.transform.position.y);
            //SkillInfo.color = Color.red;
            SkillInfo.enabled = true;
            SkillInfo.text = "Stara dobra kula" + Environment.NewLine + "ognia (Fireball)";
        }

        else if (BC2.bounds.Contains(MouseCoords))
        {
            SkillInfo.transform.position = new Vector2(BC2.transform.position.x + 200f, BC2.transform.position.y);
            //SkillInfo.color = Color.red;
            SkillInfo.enabled = true;
            SkillInfo.text = "A gdyby tak fireball mógł" + Environment.NewLine + "zamrozić? (Freezball)";
        }

        else if(BC3.bounds.Contains(MouseCoords))
        {
            SkillInfo.transform.position = new Vector2(BC3.transform.position.x + 200f, BC3.transform.position.y);
            //SkillInfo.color = Color.red;
            SkillInfo.enabled = true;
            SkillInfo.text = "Organiczny związek chemiczny" + Environment.NewLine + "z grupy nitrozwiązków. (TNT)";
        }

        else if(BC4.bounds.Contains(MouseCoords))
        {
            SkillInfo.transform.position = new Vector2(BC4.transform.position.x + 200f, BC4.transform.position.y);
            //SkillInfo.color = Color.red;
            SkillInfo.enabled = true;
            SkillInfo.text = "A gdybyś mógł być niewidzialny" + Environment.NewLine + "przez kilka chwil? (Ghost)";
        }

        else if(BC5.bounds.Contains(MouseCoords))
        {
            SkillInfo.transform.position = new Vector2(BC5.transform.position.x + 200f, BC5.transform.position.y);
            //SkillInfo.color = Color.red;
            SkillInfo.enabled = true;
            SkillInfo.text = "Sok z gumijagód to dobry" + Environment.NewLine + "doping (Skok)";
        }

        else if(BC6.bounds.Contains(MouseCoords))
        {
            SkillInfo.transform.position = new Vector2(BC6.transform.position.x + 200f, BC6.transform.position.y);
            //SkillInfo.color = Color.red;
            SkillInfo.enabled = true;
            SkillInfo.text = "Zdrowie jest" + Environment.NewLine + "Ważne! (Życie)";
        }

        else if(BC7.bounds.Contains(MouseCoords))
        {
            SkillInfo.transform.position = new Vector2(BC7.transform.position.x + 200f, BC7.transform.position.y);
            //SkillInfo.color = Color.red;
            SkillInfo.enabled = true;
            SkillInfo.text = "Struś pędziwiatr to przy" + Environment.NewLine + "tobie ślimak. (Prędkość)";
        }

        else if(BC8.bounds.Contains(MouseCoords))
        {
            SkillInfo.transform.position = new Vector2(BC8.transform.position.x + 200f, BC8.transform.position.y);
            //SkillInfo.color = Color.red;
            SkillInfo.enabled = true;
            SkillInfo.text = "Poszerz swoje horyzonty!" + Environment.NewLine + "(Percepcja)";
            
        }

        else if (BC9.bounds.Contains(MouseCoords))
        {
            SkillInfo.transform.position = new Vector2(BC9.transform.position.x + 200f, BC9.transform.position.y);
            //SkillInfo.color = Color.red;
            SkillInfo.enabled = true;
            SkillInfo.text = "Na skróty. (Teleport)";

        }
        else if (BC10.bounds.Contains(MouseCoords))
        {
            SkillInfo.transform.position = new Vector2(BC10.transform.position.x + 200f, BC10.transform.position.y);
            //SkillInfo.color = Color.red;
            SkillInfo.enabled = true;
            SkillInfo.text = "Badz jak Flash! (Dash)";

        }
        else if (BC11.bounds.Contains(MouseCoords))
        {
            SkillInfo.transform.position = new Vector2(BC11.transform.position.x + 200f, BC11.transform.position.y);
            //SkillInfo.color = Color.red;
            SkillInfo.enabled = true;
            SkillInfo.text = "Empty";

        }
        else if (BC12.bounds.Contains(MouseCoords))
        {
            SkillInfo.transform.position = new Vector2(BC12.transform.position.x + 200f, BC12.transform.position.y);
            //SkillInfo.color = Color.red;
            SkillInfo.enabled = true;
            SkillInfo.text = "Empty";

        }
        else
        {
            SkillInfo.enabled = false;
        }

         MouseCoords = Input.mousePosition;

    }

    void CheckFree()
    {
        
    }
}
