using UnityEngine;

public class Controller : MonoBehaviour
{
	#region FIELDS

	[SerializeField]
	private View _viewModule = null;
	[SerializeField]
	private Model _modelModule = null;

	#endregion

	#region PROPERTIES

	protected View ViewModule => _viewModule;
	protected Model ModelModule => _modelModule;

	#endregion

	#region METHODS

	public virtual void Initialize()
	{
		ViewModule.Initialize();
		ModelModule.Initialize();
	}

	public T GetModel<T>() where T : Model
	{
		return ModelModule as T;
	}

	public T GetView<T>() where T : View
	{
		return ViewModule as T;
	}

	protected virtual void Awake()
	{
		Initialize();
	}

	#endregion

	#region ENUMS

	#endregion
}
