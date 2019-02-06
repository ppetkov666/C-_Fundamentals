namespace _9._HTTP_Server
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;

    class HTTP_Server
    {
        private const int PortNumber = 5666;
        private const string SourcePath = "../../../../Resources";
        private const string ErrorPath = "../../../../Resources/error.html";
        static void Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, PortNumber);
            tcpListener.Start();

            Console.WriteLine($"Listening on port {PortNumber}...");
            Console.WriteLine($"The Local End Point is : {tcpListener.LocalEndpoint}");
            Console.WriteLine("Waiting for connection...");

            while (true)
            {
                // it takes the bytes from the network
                using (NetworkStream networkStream = tcpListener
                    .AcceptTcpClient()
                    .GetStream())
                {
                    // we create a buffer
                    byte[] request = new byte[4096];
                    int readBytes = networkStream.Read(request, 0, request.Length);

                    // we take the info and convert it to string 
                    string reqData = Encoding
                        .UTF8
                        .GetString(request, 0, readBytes)
                        .Replace("\\", "/");
                    Console.WriteLine(reqData);

                    if (!string.IsNullOrEmpty(reqData))
                    {
                        string file = string.Empty;

                        // here we get the requet type, url and protocol and version and then from the array we extract it
                        string[] reqFirstLine = reqData
                            .Substring(0, reqData.IndexOf(Environment.NewLine))
                            .Split();
                        string url = reqFirstLine[1];
                        string statusLine = $"{reqFirstLine[2]} 200 OK";

                        // if this is the default url we just assing to var file - our index page with the path which later will be displayd
                        if (url == "/")
                        {
                            file = $"{SourcePath}/index.html";
                        }
                        else
                        {
                            string reqFile = $"{SourcePath}{url.Substring(url.IndexOf('/'))}";

                            if (!reqFile.EndsWith(".html"))
                            {
                                reqFile += ".html";
                            }

                            if (File.Exists(reqFile))
                            {
                                file = reqFile;
                            }
                            else
                            {
                                file = ErrorPath;
                                statusLine = "HTTP/1.0 404 Not Found";
                            }
                        }
                       // then here we create out response header pattern
                        StringBuilder responseHeader = new StringBuilder();
                        responseHeader.Append($"{statusLine}{Environment.NewLine}");
                        responseHeader.Append($"Accept-Ranges: bytes{Environment.NewLine}");
                       
                        // we initialize the response and read it from a file which is our html pages
                        // and append it to stringbuilder
                        StringBuilder response = new StringBuilder();

                        using (StreamReader reader = new StreamReader(file))
                        {
                            string line = reader.ReadLine();

                            while (line != null)
                            {
                                response.Append(line);
                                line = reader.ReadLine();
                            }
                        }

                        if (file.EndsWith("info.html"))
                        {
                            response
                                .Replace("{0}", DateTime.Now.ToString("dd MMM yyyy hh:mm:ss", new CultureInfo("en-EN")))
                                .Replace("{1}", Environment.ProcessorCount.ToString());
                        }
                        
                        
                        int contentLength = Encoding.UTF8.GetBytes(response.ToString()).Length;
                        responseHeader.Append($"ContentLength: {contentLength}{Environment.NewLine}");
                        responseHeader.Append($"Connection: close{Environment.NewLine}");
                        responseHeader.Append($"Content-Type: text/html{Environment.NewLine}");
                        responseHeader.Append(Environment.NewLine);
                        // then we insert our response header to the response if the right format 
                        // after the header we have new line and after the new line it is the content which browser will render
                        response.Insert(0, responseHeader);                  
                        // and the final step is to convert it to byte array  and to send it using Write method
                        byte[] responseBytes = Encoding.UTF8.GetBytes(response.ToString());
                        networkStream.Write(responseBytes, 0, responseBytes.Length);
                    }
                }
            }
        }
    }
}
