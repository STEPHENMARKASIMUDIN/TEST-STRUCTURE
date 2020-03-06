using log4net.Config;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class PortalService : IPortalService
{
    public PortalService() 
    {
        XmlConfigurator.Configure();
    }
    public Response CheckConnection()
    {
        Response result = (Response)DBConnection.Instance.CheckConnection();
        return new Response { ResponseCode = result.ResponseCode, ResponseMessage = result.ResponseMessage };
    }
    public LoginResponse Login()
    {
        LoginResponse result = (LoginResponse)DBConnection.Instance.DBConnect(new LoginProcess(),RequestType.Login);
        return new LoginResponse { ResponseCode = 200, ResponseMessage = "" };
    }
}
