namespace ParentLib;

using Module01.Lib;

public class ParentClass01
{
    #region Public members

    public static void Foo()
    {
        Module01Class.Foo();
    }

    #endregion
}