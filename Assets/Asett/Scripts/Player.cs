using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    //public bool[] Skills;
    public string Klasa;
    public float SprintForce;
    public float JumpForce;
    public int HP = 3;
    public float Perception;
    public bool HPRegeneration;
    public bool PoisonResist;
    public string[,] Skills;
    private int CurrentSkill = 0;
    public GameObject ImgCurrentSkill;
    private Color Tmp;
    private BoxCollider2D TmpBox;
    public GameObject[] SkillAvaliable = new GameObject[5];
    private bool OnCD = false;
    public string jsonData;
    public SaveSkill loadData;


    public int SkillDiax = 6;
    public Text SkillAva;
    // Use this for initialization
    Controller2D controller;

    public PllayerController PllayerController
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public Controller2D Controller2D
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    void Start () {
        //Skills = new bool[12];
        LoadStats();

        Skills = new string[12, 6];
        
        //SkillAvaliable = new GameObject[5];

        for (int i = 0;i < 12; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Skills[i, j] = " ";
            }

        }

        if (Application.loadedLevelName == "Skills")
        {
            SkillAva.text = "Skill Avaliable:  " + SkillDiax.ToString();
        }

        controller = GetComponent<Controller2D>();

        //LoadSkills();

        //this.Skills = loadData.Skills;
        
        Skills[0, 0] = "Fireball"; //Co
        Skills[0, 1] = "1"; // Ilosc rozwinięc
        Skills[0, 2] = "3"; // Ilosc ladunków
        Skills[0, 3] = "15"; // Pojemnosc
        Skills[0, 4] = "15"; // Aktualny Stan ładunków
        Skills[0, 5] = "1"; // Aktualny Poziom rozwinięcia

        Skills[1, 0] = "Freez"; //Co
        Skills[1, 1] = "1"; // Ilosc rozwinięc
        Skills[1, 2] = "3"; // Ilosc ladunków
        Skills[1, 3] = "15"; // Pojemnosc
        Skills[1, 4] = "15"; // Aktualny Stan ładunków
        Skills[1, 5] = "1"; // Aktualny Poziom rozwinięcia

        Skills[2, 0] = "Dynamit"; //Co
        Skills[2, 1] = "2"; // Ilosc rozwinięc
        Skills[2, 2] = "3"; // Ilosc ladunków
        Skills[2, 3] = "9"; // Pojemnosc
        Skills[2, 4] = "9"; // Aktualny Stan ładunków
        Skills[2, 5] = "1"; // Aktualny Poziom rozwinięcia

        Skills[3, 0] = "Ghost"; //Co
        Skills[3, 1] = "2"; // Ilosc rozwinięc
        Skills[3, 2] = "3"; // Ilosc ladunków
        Skills[3, 3] = "15"; // Pojemnosc
        Skills[3, 4] = "15"; // Aktualny Stan ładunków
        Skills[3, 5] = "1"; // Aktualny Poziom rozwinięcia

        Skills[4, 0] = "Dash"; //Co
        Skills[4, 1] = "1"; // Ilosc rozwinięc
        Skills[4, 2] = "2"; // Ilosc ladunków
        Skills[4, 3] = "10"; // Pojemnosc
        Skills[4, 4] = "10"; // Aktualny Stan ładunków
        Skills[4, 5] = "1"; // Aktualny Poziom rozwinięcia

        Skills[5, 0] = "Recall"; //Co
        Skills[5, 1] = "1"; // Ilosc rozwinięc
        Skills[5, 2] = "5"; // Ilosc ladunków
        Skills[5, 3] = "15"; // Pojemnosc
        Skills[5, 4] = "15"; // Aktualny Stan ładunków
        Skills[5, 5] = "1"; // Aktualny Poziom rozwinięcia
        
        Skills[6, 0] = "Teleport"; //Co
        Skills[6, 1] = "1"; // Ilosc rozwinięc
        Skills[6, 2] = "1"; // Ilosc ladunków
        Skills[6, 3] = "5"; // Pojemnosc
        Skills[6, 4] = "2"; // Aktualny Stan ładunków
        Skills[6, 5] = "0"; // Aktualny Poziom rozwinięcia

        Skills[7, 0] = "Wizja"; //Co
        Skills[7, 1] = "1"; // Ilosc rozwinięc
        Skills[7, 2] = "2"; // Ilosc ladunków
        Skills[7, 3] = "6"; // Pojemnosc
        Skills[7, 4] = "4"; // Aktualny Stan ładunków
        Skills[7, 5] = "0"; // Aktualny Poziom rozwinięcia

      
/*        
        Skills[8, 0] = "Zamki"; //Co
        Skills[8, 1] = "2"; // Ilosc rozwinięc
        Skills[8, 2] = "2"; // Ilosc ladunków
        Skills[8, 3] = "10"; // Pojemnosc
        Skills[8, 4] = "4"; // Aktualny Stan ładunków
        Skills[8, 5] = "0"; // Aktualny Poziom rozwinięcia

        Skills[9, 0] = "Ciemnosc"; //Co
        Skills[9, 1] = "1"; // Ilosc rozwinięc
        Skills[9, 2] = "2"; // Ilosc ladunków
        Skills[9, 3] = "10"; // Pojemnosc
        Skills[9, 4] = "4"; // Aktualny Stan ładunków
        Skills[9, 5] = "0"; // Aktualny Poziom rozwinięcia
   */
   
        Skills[8, 0] = "Skok"; //Co
        Skills[8, 1] = "2"; // Ilosc rozwinięc
        Skills[8, 5] = "0"; // Aktualny Poziom rozwinięcia

        Skills[9, 0] = "Życie"; //Co
        Skills[9, 1] = "4"; // Ilosc rozwinięc
        Skills[9, 5] = "4"; // Aktualny Poziom rozwinięcia

        Skills[10, 0] = "Sprint"; //Co
        Skills[10, 1] = "2"; // Ilosc rozwinięc
        Skills[10, 5] = "0"; // Aktualny Poziom rozwinięcia

        Skills[11, 0] = "Percepcja"; //Co
        Skills[11, 1] = "2"; // Ilosc rozwinięc
        Skills[11, 5] = "0"; // Aktualny Poziom rozwinięcia

     
    
    }

    // Update is called once per frame
    void Update () {
 
        if (Application.loadedLevelName == "Skills")
        {
            SkillAva.text = "Skill Avaliable:  " + SkillDiax.ToString();
        }
        else
        {
            CurrentSkillAvaliable();
        }
        
        LoadStats();
    }

    public void UseSkill()
    {
        if ((CurrentSkill == 0) && ((int.Parse(Skills[CurrentSkill, 4]) - int.Parse(Skills[CurrentSkill, 2])) >= 0 ) && OnCD == false)
        {
            if (this.GetComponent<Transform>().rotation.eulerAngles.y == 0)
            {
                GameObject FireBall = Instantiate(Resources.Load("AnimatedFireball"), new Vector2(this.GetComponent<Transform>().position.x + 1.1f, this.GetComponent<Transform>().position.y), new Quaternion(0f, 0f, 0f, 0f)) as GameObject;
                FireBall.GetComponent<Transform>().Rotate(0f, 0f, -90f);

            }

            if (this.GetComponent<Transform>().rotation.eulerAngles.y == 180)
            {
                GameObject FireBall = Instantiate(Resources.Load("AnimatedFireball"), new Vector2(this.GetComponent<Transform>().position.x - 1.15f, this.GetComponent<Transform>().position.y - 0.79f), new Quaternion(0f, 0f, 0f, 0f)) as GameObject;
                FireBall.GetComponent<Transform>().Rotate(0f, 0f, 90f);

            }
            ImgCurrentSkill.GetComponent<Image>().type = Image.Type.Filled;
            ImgCurrentSkill.GetComponent<Image>().fillMethod = Image.FillMethod.Radial360;
            ImgCurrentSkill.GetComponent<Image>().fillAmount = 0f;
            InvokeRepeating("Cooldown", 0f, 0.001f);
            Skills[CurrentSkill, 4] = (int.Parse(Skills[CurrentSkill, 4]) - int.Parse(Skills[CurrentSkill, 2])).ToString();
            ReloadSkills();
        }

        if ((CurrentSkill == 1) && ((int.Parse(Skills[CurrentSkill, 4]) - int.Parse(Skills[CurrentSkill, 2])) >= 0) && OnCD == false)
        //Debug.Log(this.GetComponent<Transform>().rotation.eulerAngles.y);
        {
            if (this.GetComponent<Transform>().rotation.eulerAngles.y == 0)
            {
                GameObject FireBall = Instantiate(Resources.Load("FreezBall"), new Vector2(this.GetComponent<Transform>().position.x + 1.1f, this.GetComponent<Transform>().position.y), new Quaternion(0f, 0f, 0f, 0f)) as GameObject;
                FireBall.GetComponent<Transform>().Rotate(0f, 0f, -90f);
            }

            if (this.GetComponent<Transform>().rotation.eulerAngles.y == 180)
            {
                GameObject FireBall = Instantiate(Resources.Load("FreezBall"), new Vector2(this.GetComponent<Transform>().position.x - 1.15f, this.GetComponent<Transform>().position.y - 0.79f), new Quaternion(0f, 0f, 0f, 0f)) as GameObject;
                FireBall.GetComponent<Transform>().Rotate(0f, 0f, 90f);

            }

            ImgCurrentSkill.GetComponent<Image>().type = Image.Type.Filled;
            ImgCurrentSkill.GetComponent<Image>().fillMethod = Image.FillMethod.Radial360;
            ImgCurrentSkill.GetComponent<Image>().fillAmount = 0f;
            InvokeRepeating("Cooldown", 0f, 0.001f);
            Skills[CurrentSkill, 4] = (int.Parse(Skills[CurrentSkill, 4]) - int.Parse(Skills[CurrentSkill, 2])).ToString();
            ReloadSkills();
        }

        if ((CurrentSkill == 2) && ((int.Parse(Skills[CurrentSkill, 4]) - int.Parse(Skills[CurrentSkill, 2])) >= 0) && OnCD == false)
        //Debug.Log(this.GetComponent<Transform>().rotation.eulerAngles.y);
        {
            if (this.GetComponent<Transform>().rotation.eulerAngles.y == 0)
            {
                GameObject Dynamite = Instantiate(Resources.Load("Dynam"), new Vector2(this.GetComponent<Transform>().position.x + 0.5f, this.GetComponent<Transform>().position.y), new Quaternion(0f, 0f, 0f, 0f)) as GameObject;
            }
            if (this.GetComponent<Transform>().rotation.eulerAngles.y == 180)
            {
                GameObject Dynamite = Instantiate(Resources.Load("Dynam"), new Vector2(this.GetComponent<Transform>().position.x - 0.8f, this.GetComponent<Transform>().position.y), new Quaternion(0f, 0f, 0f, 0f)) as GameObject;
            }

                Skills[CurrentSkill, 4] = (int.Parse(Skills[CurrentSkill, 4]) - int.Parse(Skills[CurrentSkill, 2])).ToString();

            ImgCurrentSkill.GetComponent<Image>().type = Image.Type.Filled;
            ImgCurrentSkill.GetComponent<Image>().fillMethod = Image.FillMethod.Radial360;
            ImgCurrentSkill.GetComponent<Image>().fillAmount = 0f;
            InvokeRepeating("Cooldown", 0f, 0.001f);
            Skills[CurrentSkill, 4] = (int.Parse(Skills[CurrentSkill, 4]) - int.Parse(Skills[CurrentSkill, 2])).ToString();
            ReloadSkills();
        }

        if ((CurrentSkill == 3) && ((int.Parse(Skills[CurrentSkill, 4]) - int.Parse(Skills[CurrentSkill, 2])) >= 0) && OnCD == false)
        //Debug.Log(this.GetComponent<Transform>().rotation.eulerAngles.y);
        {
            Tmp = this.GetComponent<SpriteRenderer>().color;
            Tmp.a = 0.5f;
            this.GetComponent<SpriteRenderer>().color = Tmp;
            this.tag = "GhostPlayer";
            Skills[CurrentSkill, 4] = (int.Parse(Skills[CurrentSkill, 4]) - int.Parse(Skills[CurrentSkill, 2])).ToString();
            ImgCurrentSkill.GetComponent<Image>().type = Image.Type.Filled;
            ImgCurrentSkill.GetComponent<Image>().fillMethod = Image.FillMethod.Radial360;
            ImgCurrentSkill.GetComponent<Image>().fillAmount = 0f;
            InvokeRepeating("Cooldown", 0f, 0.001f);
            if (Skills[CurrentSkill, 5] == "1")
            {
                Invoke("UnGhost", 10f);
            }
            else
            {
                Invoke("UnGhost", 15f);
            }
            ReloadSkills();

        }

        if ((CurrentSkill == 4) && ((int.Parse(Skills[CurrentSkill, 4]) - int.Parse(Skills[CurrentSkill, 2])) >= 0) && OnCD == false)
        {

            if (this.GetComponent<Transform>().rotation.y == 0)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(15000f, 0f));
            }
            else if (this.GetComponent<Transform>().rotation.y == 1)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-15000f, 0f));
            }

            ImgCurrentSkill.GetComponent<Image>().type = Image.Type.Filled;
            ImgCurrentSkill.GetComponent<Image>().fillMethod = Image.FillMethod.Radial360;
            ImgCurrentSkill.GetComponent<Image>().fillAmount = 0f;
            InvokeRepeating("Cooldown", 0f, 0.001f);
            Skills[CurrentSkill, 4] = (int.Parse(Skills[CurrentSkill, 4]) - int.Parse(Skills[CurrentSkill, 2])).ToString();
            ReloadSkills();
        }

        if ((CurrentSkill == 5) && (OnCD == false))
        {

            this.GetComponent<PllayerController>().speed = 0f;
            Invoke("ReturnToLobby", 3f);


            //ImgCurrentSkill.GetComponent<Image>().type = Image.Type.Filled;
            //ImgCurrentSkill.GetComponent<Image>().fillMethod = Image.FillMethod.Radial360;
            //ImgCurrentSkill.GetComponent<Image>().fillAmount = 0f;
            //InvokeRepeating("Cooldown", 0f, 0.001f);
            //Skills[CurrentSkill, 4] = (int.Parse(Skills[CurrentSkill, 4]) - int.Parse(Skills[CurrentSkill, 2])).ToString();

        }
    }

    public void NextSkill()
    {

        if (CurrentSkill >= 5)
        {
            CurrentSkill = 0;
        }
        else
        {
            CurrentSkill++;
        }


        if (CurrentSkill == 0)
        {
            ImgCurrentSkill.GetComponent<Image>().sprite = Resources.Load<Sprite>("SpellBookPreface_18");
        }

        if (CurrentSkill == 1)
        {
            ImgCurrentSkill.GetComponent<Image>().sprite = Resources.Load<Sprite>("SpellBookPreface_05");
        }

        if (CurrentSkill == 2)
        {
            ImgCurrentSkill.GetComponent<Image>().sprite = Resources.Load<Sprite>("DYNAMIT");
        }

        if (CurrentSkill == 3)
        {
            ImgCurrentSkill.GetComponent<Image>().sprite = Resources.Load<Sprite>("Ghost");
        }

        if (CurrentSkill == 4)
        {

            ImgCurrentSkill.GetComponent<Image>().sprite = Resources.Load<Sprite>("Dash");
        }

        if (CurrentSkill == 5)
        {

            ImgCurrentSkill.GetComponent<Image>().sprite = Resources.Load<Sprite>("flatDark47");
        }

    }

    void UnGhost()
    {
        Tmp.a = 1f;
        this.GetComponent<SpriteRenderer>().color = Tmp;
        this.tag = "Player";
    }


    void CurrentSkillAvaliable()
    {
        for (int i = 0; i < 5; i++)
        {
            if (CurrentSkill == i)
            {
                if (int.Parse(Skills[i, 4]) >= 0)
                {
                    ShowSkillImage((int.Parse(Skills[i, 4])) / (int.Parse(Skills[i, 2])));
                }
            }
        }


    }

    void ShowSkillImage(int Count)
    {
        for (int i = 0; i < SkillAvaliable.Length; i++){
            if (i < Count)
            {
                SkillAvaliable[i].GetComponent<CanvasGroup>().alpha = 1f;
            }
            else
            {
                SkillAvaliable[i].GetComponent<CanvasGroup>().alpha = 0f;
            }
        }
    }

    void Cooldown()
    {
        if (ImgCurrentSkill.GetComponent<Image>().fillAmount < 1f)
        {
            ImgCurrentSkill.GetComponent<Image>().fillAmount = ImgCurrentSkill.GetComponent<Image>().fillAmount + 0.0025f;
            OnCD = true;
        }

        if (ImgCurrentSkill.GetComponent<Image>().fillAmount == 1f)
        {
            OnCD = false;
        }

    }

    void ReturnToLobby()
    {
        Application.LoadLevel("Startowa Plansza");
        LoadStats();
    }

    void LoadStats()
    {
        SprintForce = this.GetComponent<PllayerController>().speed;
        JumpForce = this.GetComponent<PllayerController>().jumpForce;
        HP = 3;
        //HP = this.GetComponent<PllayerController>().HP;
    }

    public void LoadSkills()
    {
        jsonData = PlayerPrefs.GetString("Skills");
        loadData = JsonUtility.FromJson<SaveSkill>(jsonData);
        int x = 0;
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                this.Skills[i, j] = loadData.Name[x];
                x++;
            }

        }
    }

    public void ReloadSkills()
    {
        this.GetComponent<SaveGame>().SaveSkills();
        this.LoadSkills();
    }
}
