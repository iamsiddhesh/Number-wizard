using UnityEngine;

using System.Collections;

using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class NumberWizards : MonoBehaviour
 {
	
	int max;
	
	int min;
	
	int guess;
	
	int maxattempt = 20;

	
	public Text guesstext;
	
	public Text maxtext;
	
	
	
	void Start ()
	 {
		
		StartGame();
	}
	
		
	void StartGame () 	
	{
		
		max = 1000;
		
		min = 1;
					
		NextGuess ();
			
	

	}
	

	
	public void GuessLower()
	{
			
		max = guess;
				
		NextGuess ();
				
		MaxAttempt ();
		
	
	}

	
	public void GuessHigher()
	{
			
		min = guess;
		
		NextGuess ();
			
		MaxAttempt ();
		
	}
	
	
	void NextGuess () 
	{

		guess = Random.Range (max, min+1);
	
		guesstext.text = guess.ToString ();

		
		
	}
			
	void MaxAttempt()	
	{
				
		maxattempt = maxattempt - 1;
				
		print ("Max attempt is" + maxattempt);
					
		maxtext.text = maxattempt.ToString ();
					
		if (maxattempt <= 0) 	
		{

			SceneManager.LoadScene("win");

	
		}
	
	
}

}
