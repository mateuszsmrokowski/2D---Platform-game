using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsScript : MonoBehaviour {
    private Color Trained = Color.white;
    private Color UnTrained = new Color32(56, 56, 56, 255);
    private Color Test = Color.black;

    public Image[] ListImage = new Image[12];

    private Player Player;
    private List<GameObject> Children;

    public Player Player1
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }


    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        WczytajSkille();
    }
	
	// Update is called once per frame
	void Update () {

        WczytajSkille();

        
    }

    void WczytajSkille()
    {
        for (int i = 0; i < ListImage.Length; i++)
        {
            switch (int.Parse(Player.Skills[i, 5])){
                case 4:
                    {
                        ListImage[i].transform.GetChild(0).GetComponent<CanvasGroup>().alpha = 1f;
                        ListImage[i].transform.GetChild(1).GetComponent<CanvasGroup>().alpha = 1f;
                        ListImage[i].transform.GetChild(2).GetComponent<CanvasGroup>().alpha = 1f;
                        ListImage[i].transform.GetChild(3).GetComponent<CanvasGroup>().alpha = 1f;
                        break;
                    }
                case 3:
                    {
                            ListImage[i].transform.GetChild(0).GetComponent<CanvasGroup>().alpha = 1f;
                            ListImage[i].transform.GetChild(1).GetComponent<CanvasGroup>().alpha = 1f;
                            ListImage[i].transform.GetChild(2).GetComponent<CanvasGroup>().alpha = 1f;
                            ListImage[i].transform.GetChild(3).GetComponent<CanvasGroup>().alpha = 0f;
                        break;
                    }
                case 2:
                    {
                            ListImage[i].transform.GetChild(0).GetComponent<CanvasGroup>().alpha = 1f;
                            ListImage[i].transform.GetChild(1).GetComponent<CanvasGroup>().alpha = 1f;
                            ListImage[i].transform.GetChild(2).GetComponent<CanvasGroup>().alpha = 0f;
                            ListImage[i].transform.GetChild(3).GetComponent<CanvasGroup>().alpha = 0f;
                        break;
                    }
                case 1:
                    {
                            ListImage[i].transform.GetChild(0).GetComponent<CanvasGroup>().alpha = 1f;
                            ListImage[i].transform.GetChild(1).GetComponent<CanvasGroup>().alpha = 0f;
                            ListImage[i].transform.GetChild(2).GetComponent<CanvasGroup>().alpha = 0f;
                            ListImage[i].transform.GetChild(3).GetComponent<CanvasGroup>().alpha = 0f;
                            ListImage[i].color = Trained;
                        break;
                    }
                case 0:
                    {
                            ListImage[i].color = UnTrained;
                            ListImage[i].transform.GetChild(0).GetComponent<CanvasGroup>().alpha = 0f;
                            ListImage[i].transform.GetChild(1).GetComponent<CanvasGroup>().alpha = 0f;
                            ListImage[i].transform.GetChild(2).GetComponent<CanvasGroup>().alpha = 0f;
                            ListImage[i].transform.GetChild(3).GetComponent<CanvasGroup>().alpha = 0f;
                        break;
                    }
            }
        }


     
    }

    public void Skill1()
    {
        if ((int.Parse(Player.Skills[0, 5]) < (int.Parse(Player.Skills[0, 1]))) && (Player.SkillDiax > 0))
        {
            Debug.Log(Player.Skills[0, 5]);
            Player.Skills[0, 5] = (int.Parse(Player.Skills[0, 5]) + 1).ToString();
            WczytajSkille();
            Player.SkillDiax--;
            Debug.Log(Player.Skills[0, 5]);
        }
    }

    public void Skill2()
    {
        if ((int.Parse(Player.Skills[1, 5]) < (int.Parse(Player.Skills[1, 1]))) && (Player.SkillDiax > 0))
        {
            Player.Skills[1, 5] = (int.Parse(Player.Skills[1, 5]) + 1).ToString();
            WczytajSkille();
            Player.SkillDiax--;
        }
    }

    public void Skill3()
    {
        if ((int.Parse(Player.Skills[2, 5]) < (int.Parse(Player.Skills[2, 1]))) && (Player.SkillDiax > 0))
        {
            Player.Skills[2, 5] = (int.Parse(Player.Skills[2, 5]) + 1).ToString();
            WczytajSkille();
            Player.SkillDiax--;
        }
    }

    public void Skill4()
    {
        if ((int.Parse(Player.Skills[3, 5]) < (int.Parse(Player.Skills[3, 1]))) && (Player.SkillDiax > 0))
        {
            Player.Skills[3, 5] = (int.Parse(Player.Skills[3, 5]) + 1).ToString();
            WczytajSkille();
            Player.SkillDiax--;
        }
    }

    public void Skill5()
    {
        if ((int.Parse(Player.Skills[4, 5]) < (int.Parse(Player.Skills[4, 1]))) && (Player.SkillDiax > 0))
        {
            Player.Skills[4, 5] = (int.Parse(Player.Skills[4, 5]) + 1).ToString();
            WczytajSkille();
            Player.SkillDiax--;
        }
    }

    public void Skill6()
    {
        if ((int.Parse(Player.Skills[5, 5]) < (int.Parse(Player.Skills[5, 1]))) && (Player.SkillDiax > 0))
        {
            Player.Skills[5, 5] = (int.Parse(Player.Skills[5, 5]) + 1).ToString();
            WczytajSkille();
            Player.SkillDiax--;
        }
    }

    public void Skill7()
    {
        if ((int.Parse(Player.Skills[6, 5]) < (int.Parse(Player.Skills[6, 1]))) && (Player.SkillDiax > 0))
        {
            Player.Skills[6, 5] = (int.Parse(Player.Skills[6, 5]) + 1).ToString();
            WczytajSkille();
            Player.SkillDiax--;
        }
    }

    public void Skill8()
    {
        if ((int.Parse(Player.Skills[7, 5]) < (int.Parse(Player.Skills[7, 1]))) && (Player.SkillDiax > 0))
        {
            Player.Skills[7, 5] = (int.Parse(Player.Skills[7, 5]) + 1).ToString();
            WczytajSkille();
            Player.SkillDiax--;
        }
    }

    public void Skill9()
    {
        if ((int.Parse(Player.Skills[8, 5]) < (int.Parse(Player.Skills[8, 1]))) && (Player.SkillDiax > 0))
        {
            Player.Skills[8, 5] = (int.Parse(Player.Skills[8, 5]) + 1).ToString();
            WczytajSkille();
            Player.SkillDiax--;
            Player.GetComponent<PllayerController>().jumpForce = Player.GetComponent<PllayerController>().jumpForce + (Player.GetComponent<PllayerController>().jumpForce *( 0.1f * (int.Parse(Player.Skills[8, 5]))));
        }
    }

    public void Skill10()
    {
        if ((int.Parse(Player.Skills[9, 5]) < (int.Parse(Player.Skills[9, 1]))) && (Player.SkillDiax > 0))
        {
            Player.Skills[9, 5] = (int.Parse(Player.Skills[9, 5]) + 1).ToString();
            WczytajSkille();
            Player.SkillDiax--;
            Player.GetComponent<PllayerController>().HP = ((int.Parse(Player.Skills[9, 5])));
        }
    }

    public void Skill11()
    {
        if ((int.Parse(Player.Skills[10, 5]) < (int.Parse(Player.Skills[10, 1]))) && (Player.SkillDiax > 0))
        {
            Player.Skills[10, 5] = (int.Parse(Player.Skills[10, 5]) + 1).ToString();
            WczytajSkille();
            Player.SkillDiax--;
            Player.GetComponent<PllayerController>().speed = Player.GetComponent<PllayerController>().speed + (Player.GetComponent<PllayerController>().speed * (0.1f * (int.Parse(Player.Skills[10, 5]))));
        }
    }

    public void Skill12()
    {
        if ((int.Parse(Player.Skills[11, 5]) < (int.Parse(Player.Skills[11, 1]))) && (Player.SkillDiax > 0))
        {
            Player.Skills[11, 5] = (int.Parse(Player.Skills[11, 5]) + 1).ToString();
            WczytajSkille();
            Player.SkillDiax--;
        }
    }

    public void Exit()
    {
        Application.LoadLevel("Startowa Plansza");
    }
}

