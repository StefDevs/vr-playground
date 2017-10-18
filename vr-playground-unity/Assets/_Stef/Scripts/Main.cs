using UnityEngine;

public class Main : MonoBehaviour {

    internal static GameState gameState;

    void Awake()
    {
        Methods.Main_Awake(gameState);	
    }
	void Start () {
        Methods.Main_Start(gameState);
	}
	
	void Update () {
        Methods.Main_Update(gameState, Time.unscaledDeltaTime);
    }
    void FixedUpdate()
    {
        Methods.Main_FixedUpdate(gameState, Time.fixedUnscaledDeltaTime);
    }
}
