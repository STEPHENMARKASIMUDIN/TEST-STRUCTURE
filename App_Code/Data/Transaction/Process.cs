﻿using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for Process
/// </summary>
public abstract class Process
{
    public abstract IResponse PortalProcess(MySqlConnection Connection, RequestType RType, IModel Model = null, MySqlTransaction Transaction = null);


}

