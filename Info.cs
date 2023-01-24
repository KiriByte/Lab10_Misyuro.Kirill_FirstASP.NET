using System.Text;

namespace Lab10_Misyuro.Kirill_FirstASP.NET;

public class Info
{
    private string userName;
    private string envName;
    private string appName;
    private string host;
    private string protocol;

    public Info(HttpRequest app, WebApplication web)
    {
        userName = "Kirill Misyuro";
        //envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        envName = web.Environment.EnvironmentName;
        appName = web.Environment.ApplicationName;
        host = app.Host.Host;
        protocol = app.Protocol;
    }

    public string GetInfo()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Name: ").AppendLine(userName);
        sb.Append("Date: ").AppendLine(DateTime.Now.ToString());
        sb.Append("Enviroment: ").AppendLine(envName);
        sb.Append("Application Name: ").AppendLine(appName);
        sb.Append("Host: ").AppendLine(host);
        sb.Append("Protocol: ").AppendLine(protocol);
        return sb.ToString();
    }
}