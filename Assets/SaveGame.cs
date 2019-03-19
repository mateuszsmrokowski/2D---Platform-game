using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour {
    public List<Transform> PickupCord = new List<Transform>();
    public List<string> PickupName = new List<string>();
    public Transform Pick;
    private int PickCount;
    private string NameLoad = "";
    SaveGame Data;
    public string jsonData;
    public Save loadData;
    public string Skills = "";
    // Use this for initialization
    void Start () {
        GetData();
        jsonData = PlayerPrefs.GetString("GameSave");
        //Debug.Log(jsonData);
        loadData = JsonUtility.FromJson<Save>(jsonData);
        if (Application.loadedLevelName != "Startowa Plansza")
        {
            Pick = GameObject.Find("PickUps").GetComponent<Transform>();
            PickCount = Pick.childCount;
        }
           
        //Debug.Log(loadData.Name.Count);

        LoadPick();
        //Debug.Log(Pick.childCount);
        //Debug.Log(loadData.Name.Count);
    }
	
	// Update is called once per frame
	void Update () {
        if (Application.loadedLevelName != "Startowa Plansza")
        {
            if (Pick.childCount < loadData.Name.Count)
            {
                //Debug.Log("enter");
                GetData();
                ToLoad();
                jsonData = PlayerPrefs.GetString("GameSave");
                loadData = JsonUtility.FromJson<Save>(jsonData);
            }
        }
	}

    public void ShowObject()
    {
        //GetData();
        //ToLoad();
        SaveSkills();
    }

    void GetData()
    {
        //Debug.Log("GetData");
        PickupName = new List<string>();
        PickupCord = new List<Transform>();

        foreach (Transform childs in Pick)
        {
            PickupCord.Add(childs);
            PickupName.Add(childs.name);
        }
        ToLoad();
    }

    void ToLoad()
    {
        //Debug.Log("ToLoad");
        Save saveData = new Save();

        foreach(Transform GO in PickupCord)
        {
            saveData.Name.Add(GO.name);
        }

        string jsonData = JsonUtility.ToJson(saveData);

        PlayerPrefs.SetString("GameSave", jsonData);
    }

    void LoadPick()
    {
        //Debug.Log("LoadPick");
        //Debug.Log(loadData.Name[0]);
        //Debug.Log(PickupName[0]);
        for (int i = 0; i < PickupName.Count; i++)
        {

            if (loadData.Name.Contains(PickupName[i]) == false)
            {
                //Debug.Log("No to wat?");
                Destroy(GameObject.Find(PickupName[i]));
            }

        }
    }

    public void SaveSkills()
    {
        SaveSkill SS = new SaveSkill();
        PlayerPrefs.DeleteKey("Skills");
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                SS.Name.Add(this.GetComponent<Player>().Skills[i, j]);
            }
        }
        //Skills = this.GetComponent<Player>().Skills;
        //Debug.Log(Skills);
        string jsonData1 = JsonUtility.ToJson(SS);
        Debug.Log(jsonData1);
        PlayerPrefs.SetString("Skills", jsonData1);
    }


}

public class Save
{
    public List<string> Name = new List<string>();

}

public class SaveSkill
{
    public List<string> Name = new List<string>();
}


