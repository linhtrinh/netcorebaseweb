namespace LT.Core.Common.Entities;

public class ApplicationContext{
    public string EnvironmentName{get; private set;}
    public string ApplicationName{get; private set;}

    public ApplicationContext(string env, string app_name){
        EnvironmentName = env;
        ApplicationName = app_name;
    }
}