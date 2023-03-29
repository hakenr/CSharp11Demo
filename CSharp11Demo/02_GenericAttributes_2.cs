namespace GenericAtributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class DependsOnSeedAttribute<TDependency> : Attribute
{
}


[DependsOnSeed<LanguageSeed>]
public class RoleSeed
{
	// new Role() { Localizations = new[] { new RoleLocalization() { Name = "Owner", Language = Language.English } } }
}

public class LanguageSeed
{
	// ..
}


[DependsOnSeed<RoleSeed>]
[DependsOnSeed<LanguageSeed>]
public class UserSeed
{
	// new User() { Role = Role.Admin, Language = Language.English }
}