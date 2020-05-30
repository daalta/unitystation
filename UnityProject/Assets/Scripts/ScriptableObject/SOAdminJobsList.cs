using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

// [CreateAssetMenu(fileName = "adminJobsList", menuName = "ScriptableObjects/AdminJobsList", order = 0)]
public class SOAdminJobsList : SingletonScriptableObject<SOAdminJobsList>
{
	[SerializeField] [ReorderableList] private List<Occupation> adminAvailableJobs = null;
	public List<Occupation> AdminAvailableJobs => adminAvailableJobs;
}
