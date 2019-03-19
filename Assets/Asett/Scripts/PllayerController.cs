using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PllayerController : MonoBehaviour {
	public float speed = 7f;
	public float jumpForce = 5f;
    public int HP = 3;
    public string Way;
    private float Tim, Tim1;
	private int count;
	public Text countText;
	public bool JumpStatus = false;
    public Transform GroundMid;
    public Transform GroundRight;
    public Transform GroundLeft;
    public Transform wallDetectionLeft;
    public Transform wallDetectionRight;
    RaycastHit2D groundInfoRight;
    RaycastHit2D groundInfoLeft;
    RaycastHit2D WallInfoRight;
    RaycastHit2D WallInfoLeft;
    public float distance = 1;
    public bool Ground;
    public bool LeftWall;
    public bool RightWall;
    public bool LeftGround;
    public bool RightGround;
    public float AirSlower = 0.4f;
    public bool EnterDoor = false;
    public Camera CamRef;

    public TeleportToScene2 TeleportToScene2
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public TeleportToScene3 TeleportToScene3
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public TeleportToScene TeleportToScene
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
        JumpStatus = false;
        //HP = int.Parse(this.GetComponent<Player>().Skills[9, 5]);
        HP = 3;
        Debug.Log(HP);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Debug.Log(HP);
        HP = int.Parse(this.GetComponent<Player>().Skills[9, 5]);
        Ground = false;
        //Grunt
        RaycastHit2D groundInfo1 = Physics2D.Raycast(GroundMid.position, Vector2.down, distance);
        RaycastHit2D groundInfo2 = Physics2D.Raycast(GroundRight.position, Vector2.down, distance);
        RaycastHit2D groundInfo3 = Physics2D.Raycast(GroundLeft.position, Vector2.down, distance);

        //Sciany
        RaycastHit2D LeftWallInfo = Physics2D.Raycast(wallDetectionLeft.position, Vector2.left, distance * 0.1f);
        RaycastHit2D RightWallInfo = Physics2D.Raycast(wallDetectionRight.position, Vector2.right, distance  *0.1f);
        LeftWall = LeftWallInfo.collider;
        RightWall = RightWallInfo.collider;
        //LewoPrawo
        RaycastHit2D groundInfoLeft = Physics2D.Raycast(GroundLeft.position, Vector2.left, distance * 0.1f);
        RaycastHit2D groundInfoRight = Physics2D.Raycast(GroundRight.position, Vector2.right, distance * 0.1f);
        LeftGround = groundInfoLeft.collider;
        RightGround = groundInfoRight.collider;

        RaycastHit2D groundInfo = Physics2D.Raycast(new Vector2(-500f, 0f), Vector2.down, distance);

        if ((groundInfo1.collider == true))
        {
            groundInfo = groundInfo1;
;
        }
        if ((groundInfo2.collider == true))
        {
            groundInfo = groundInfo2;
           
        }
        if ((groundInfo3.collider == true))
        {
            groundInfo = groundInfo3;
            
        }


        Ground = groundInfo.collider;

        {
            if (( Way == "left") && (groundInfo.collider == false))
            {
                this.GetComponent<Rigidbody2D>().velocity = (new Vector2(-1 * speed * AirSlower, this.GetComponent<Rigidbody2D>().velocity.y));
            }

            if ((Way == "right") && (groundInfo.collider == false))
            {
                this.GetComponent<Rigidbody2D>().velocity = (new Vector2( speed* AirSlower, this.GetComponent<Rigidbody2D>().velocity.y));
            }

            if((Way == "left") && (groundInfo.collider == true))
            {
                this.GetComponent<Rigidbody2D>().velocity = (new Vector2(-1 * speed, this.GetComponent<Rigidbody2D>().velocity.y));
            }

            if ((Way == "right") && (groundInfo.collider == true))
            {
                this.GetComponent<Rigidbody2D>().velocity = (new Vector2(speed, this.GetComponent<Rigidbody2D>().velocity.y));
            }

            if (((Way == "left") && (JumpStatus == true) && (groundInfo.collider == true)) && ((groundInfoLeft.collider == false) && (groundInfoRight.collider == false)))
            {
                this.GetComponent<Rigidbody2D>().velocity = (new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, jumpForce));
                //this.GetComponent<Rigidbody2D>().velocity = (new Vector2(-1 * speed, jumpForce));
                JumpStatus = false;
            }

            if ((( Way == "right") && (JumpStatus == true) && (groundInfo.collider == true)) && ((groundInfoLeft.collider == false) && (groundInfoRight.collider == false)))
            {
                this.GetComponent<Rigidbody2D>().velocity = (new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, jumpForce));
                //this.GetComponent<Rigidbody2D>().velocity = (new Vector2(speed, jumpForce));
                JumpStatus = false;
            }

            if ((( JumpStatus == true )  && ( groundInfo.collider == true )) && ((groundInfoLeft.collider == false) && (groundInfoRight.collider == false)))
            {
                //this.GetComponent<Rigidbody2D>().velocity = (new Vector2(0f, 8));
                this.GetComponent<Rigidbody2D>().velocity = (new Vector2(0f, jumpForce));
                JumpStatus = false;
            }
            Tim = Time.time;
        }
   
    }

	public void MoveLeft()
	{
        {
            Way = "left";
            this.GetComponent<Transform>().rotation = new Quaternion(0f, 180f, 0f, 0f);
        }

	}

	public void MoveRight()
	{
        {
            Way = "right";
            this.GetComponent<Transform>().rotation  = new Quaternion(0f, 0f, 0f, 0f);
        }
	}

	public void Jump()
	{
        if ((groundInfoLeft.collider == false) && (groundInfoRight.collider == false) && (WallInfoRight.collider == false) && (WallInfoLeft.collider == false))
        {
			JumpStatus = true;
            Debug.Log("Wat");
		}
	}

    public void Enter()
    {
        EnterDoor = true;
    }

    public void EnterEnd()
    {
        EnterDoor = false;
    }


    public void MoveNone()
    {
        Way = "";
    }

	public void JumpOver()
	{
		JumpStatus = false;
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Platform")
        {
            transform.parent = other.transform;
        }

        if (other.gameObject.CompareTag("Teleport"))
        {
            transform.position = other.gameObject.transform.GetChild(0).position;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "Platform")
        {
            transform.parent = null;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            Destroy(other.gameObject);

        }

        if (other.gameObject.CompareTag("Diax"))
        {
            Destroy(other.gameObject);
            this.GetComponent<Player>().SkillDiax++;

        }



    }




}
