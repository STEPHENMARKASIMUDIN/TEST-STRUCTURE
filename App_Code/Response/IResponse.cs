using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IResponse
/// </summary>
public interface IResponse
{
    string ResponseMessage { get; set; }
    int ResponseCode { get; set; }
}