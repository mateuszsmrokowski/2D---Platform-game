using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SimpleInputNamespace
{
	public class AxisInputUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
	{
		public SimpleInput.AxisInput axis = new SimpleInput.AxisInput();
		public float value = 0f;
        private GameObject Player;
        private PllayerController PC;

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

        public void Start()
        {
            
        }

        private void Awake()
		{
			Graphic graphic = GetComponent<Graphic>();
			if( graphic != null )
				graphic.raycastTarget = true;
            Player = GameObject.FindGameObjectWithTag("Player");
            PC = Player.GetComponent<PllayerController>();
        }

		private void OnEnable()
		{
			axis.StartTracking();
		}

		private void OnDisable()
		{
			axis.StopTracking();
		}

		public void OnPointerDown( PointerEventData eventData )
		{
			axis.value = value;
            if (axis.value == -1)
            {
                PC.GetComponent<PllayerController>().MoveLeft();
                //Debug.Log(value);
            }

            if (axis.value == 1)
            {
                PC.GetComponent<PllayerController>().MoveRight();
                //Debug.Log(value);
            }

            if (axis.value == 2)
            {
                PC.GetComponent<PllayerController>().Jump();
            }

            if (axis.value == -2)
            {
                PC.GetComponent<PllayerController>().Enter();
            }

            if (axis.value == 0)
            {
                PC.GetComponent<PllayerController>().MoveNone();
                PC.GetComponent<PllayerController>().EnterEnd();
            }

            if (axis.value == 3)
            {
                PC.GetComponent<Player>().UseSkill();
            }

            if (axis.value == 4)
            {
                PC.GetComponent<Player>().NextSkill();
                
            }

        }

		public void OnPointerUp( PointerEventData eventData )
		{
            if ((axis.value == 4) || (axis.value == 3))
            {

            }
            else
            {
                axis.value = 0f;
                if (axis.value == 0)
                {
                    PC.GetComponent<PllayerController>().MoveNone();
                    PC.GetComponent<PllayerController>().JumpOver();
                    PC.GetComponent<PllayerController>().EnterEnd();
                }
            }
        }

	}
     
}