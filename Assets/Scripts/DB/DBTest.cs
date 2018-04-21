using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;

public class DBTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SqliteConnection con = DBConnector.GetConnection ();
		SqliteCommand cmd = con.CreateCommand();
		SqliteDataReader reader;

		con.Open ();
		cmd.CommandText = "SELECT * FROM Avatars";

		reader = cmd.ExecuteReader();

		if(reader.Read()){
			Debug.Log (reader.GetString (1));
		}
		reader.Close();

		cmd.CommandText = "";
		reader = null;
		con.Close();
	}

}
