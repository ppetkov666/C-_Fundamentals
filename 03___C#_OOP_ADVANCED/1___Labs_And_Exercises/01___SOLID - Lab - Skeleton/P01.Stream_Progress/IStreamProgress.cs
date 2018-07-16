using System;
using System.Collections.Generic;
using System.Text;


public interface IStreamProgress
{
     int BytesSent { get; set; }
     int Length { get; set; }
}

