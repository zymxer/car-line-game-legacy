using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



[DisallowMultipleComponent]
public class LineFactory : MonoBehaviour
{
	public GameObject linePrefab;
	[HideInInspector]
	public Line currentLine;
	public Transform lineParent;
	public RigidbodyType2D lineRigidBodyType = RigidbodyType2D.Kinematic;
	public LineEnableMode lineEnableMode = LineEnableMode.ON_CREATE;
	public static LineFactory instance;
	public Image lineLife;
	public bool enableLineLife;
	public bool isRunning;
	public bool Released = false;
	public bool Drawing = false;

	void Awake ()
	{
		if (instance == null) {
			instance = this;
		} else {
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start ()
	{
		if (lineParent == null) {
			lineParent = GameObject.Find ("Lines").transform;
		}

		if (lineLife != null) {
			if (enableLineLife) {
				lineLife.gameObject.SetActive (true);
			} else {
				lineLife.gameObject.SetActive (false);
			}
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!isRunning) {
			return;
		}

		/*Touch[] myTouches = Input.touches;
        for (int i = 0; i < Input.touchCount; i++)
        {
			if (Input.GetTouch(0).phase == TouchPhase.Began && !EventSystem.current.IsPointerOverGameObject(myTouches[i].fingerId) && Drawing == false)
			{
				Drawing = true;
				CreateNewLine();
			}
			else if (Input.GetMouseButtonUp(0))
			{
				Drawing = false;
				RelaseCurrentLine();
			}
		} */ 
		if (Input.GetMouseButtonDown (0) /*&& !IsPointerOverUIObject()*/) {
			Drawing = true;
			CreateNewLine ();
		} else if (Input.GetMouseButtonUp (0)) {
			Drawing = false;
			RelaseCurrentLine ();
		}

		if (currentLine != null) {
			currentLine.AddPoint (Camera.main.ScreenToWorldPoint (Input.mousePosition));
			UpdateLineLife ();
			if (currentLine.ReachedPointsLimit ()) {
				RelaseCurrentLine ();
			}
		}
	}

	private bool IsPointerOverUIObject()
	{
		PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
		eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		List<RaycastResult> results = new List<RaycastResult>();
		EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
		return results.Count > 0;
	}

	private void CreateNewLine ()
	{
		currentLine = (Instantiate (linePrefab, Vector3.zero, Quaternion.identity) as GameObject).GetComponent<Line> ();
		currentLine.name = "Line";
		currentLine.transform.SetParent (lineParent);
		currentLine.SetRigidBodyType (lineRigidBodyType);

		if (lineEnableMode == LineEnableMode.ON_CREATE) {
			EnableLine ();
		}
	}

	private void EnableLine ()
	{
		currentLine.EnableCollider ();
		currentLine.SimulateRigidBody ();
		Released = true;
	}

	private void RelaseCurrentLine ()
	{
		if (lineEnableMode == LineEnableMode.ON_RELASE) {
			EnableLine ();
		}

		currentLine = null;
	}

	private void UpdateLineLife ()
	{
		if (!enableLineLife) {
			return;
		}

		if (lineLife == null) {
			return;
		}

		lineLife.fillAmount = 1 - (currentLine.points.Count / currentLine.maxPoints);
	}

	public enum LineEnableMode
	{
		ON_CREATE,
		ON_RELASE}

	;
}
