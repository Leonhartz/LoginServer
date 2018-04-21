using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System.Data;

public class DBConnector : MonoBehaviour {
	[System.NonSerialized]

	private static SqliteConnection con;
	public string databaseUrl = "C:/IgnisDB/Ignis.db";

	void Awake () {

		string path = "URI=file:" + databaseUrl; //Path to database.
		con = (SqliteConnection) new SqliteConnection(path);

	}
	
	public static SqliteConnection GetConnection(){
		return con;
	}
}
