using Zenject;

public class GlobalInstaller : MonoInstaller
{
	public override void InstallBindings()
	{
		Container.Bind<UserController>().AsSingle();
	}
}