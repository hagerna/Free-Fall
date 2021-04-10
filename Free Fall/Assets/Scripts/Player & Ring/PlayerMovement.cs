using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
	public float fallForce;
	public float sideForce;
	public float boostFall;
	public Vector3 slowFall;
	public int jumpCount;
	
	private bool moveLeft = false;
	private bool moveRight = false;
	private bool moveForward = false;
	private bool moveBack = false;
	private float maxVelocity = 0f;
	
	void Awake()
	{
		if (FindObjectOfType<Upgrades>() == null)
			return;
		else {
		fallForce = FindObjectOfType<Upgrades>().fallForce;
		sideForce = FindObjectOfType<Upgrades>().sideForce;
		boostFall = FindObjectOfType<Upgrades>().boostFall;
		slowFall = FindObjectOfType<Upgrades>().slowFall;
		jumpCount = FindObjectOfType<Upgrades>().jumpCount;
		}
	}
	
	public void Boost()
	{rb.AddForce(0,-boostFall,0);}
	
	public void Slow()
	{rb.velocity = slowFall;}
	
	public void JumpRefresh()
	{jumpCount = jumpCount + 1;}
	
	void Jump()
	{
		if (jumpCount > 0)
		{
			jumpCount = jumpCount - 1;
			rb.AddForce(0,fallForce * 5,0);
		}
	}
	
	public void ResetStats()
	{
		fallForce = 500f;
		sideForce = 500f;
		boostFall = 500f;
		slowFall.y = -50;
		jumpCount = 1;
	}
		
	
    void Update() //Player Movement Controls
    {
        if (Input.GetKeyDown("a")) {moveLeft = true;}
		if (Input.GetKeyUp("a")) {moveLeft = false;}
		
		if(Input.GetKeyDown("d")) {moveRight = true;}
		if (Input.GetKeyUp("d")) {moveRight = false;}
		
		if (Input.GetKeyDown("w")) {moveForward = true;}
		if (Input.GetKeyUp("w")) {moveForward = false;}
		
		if(Input.GetKeyDown("s")) {moveBack = true;}
		if (Input.GetKeyUp("s")) {moveBack = false;}
		
		if(Input.GetKeyDown("space")) {Jump();}
    }
	
	void FixedUpdate() //Player Movement Results
	{
		rb.AddForce(0,-fallForce * Time.deltaTime, 0);
		
		if (moveLeft)
		{rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);}
		if (moveRight)
		{rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);}
		if (moveForward)
		{rb.AddForce(0, 0, sideForce * Time.deltaTime, ForceMode.VelocityChange);}
		if (moveBack)
		{rb.AddForce(0, 0, -sideForce * Time.deltaTime, ForceMode.VelocityChange);}
		
		if (rb.velocity.y < maxVelocity)
		{
			maxVelocity = rb.velocity.y;
			if (FindObjectOfType<Upgrades>() != null)
				FindObjectOfType<Upgrades>().topSpeed = maxVelocity;
		}
	
	}
}
