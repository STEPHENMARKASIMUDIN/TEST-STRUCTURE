using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoginProcess
/// </summary>
public class LoginProcess : Process
{
    public LoginProcess()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public override IResponse PortalProcess(MySqlConnection Connection, RequestType RType, IModel Model = null, MySqlTransaction Transaction = null)
    {
        throw new NotImplementedException();
    }

    protected internal LoginResponse Login() 
    {
        return new LoginResponse { ResponseCode = 200, ResponseMessage = "" };
    }
}