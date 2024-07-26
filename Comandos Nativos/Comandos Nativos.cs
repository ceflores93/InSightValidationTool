using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppReadIni
{
    internal class Comandos_Nativos
    {

        public static string  Comando(string IP , int Puerto, bool Debug,  string Comando1, string Comando2, string Comando3, string Comando4)
        {
            string Result = "";

            try
            {
                // Crear un punto final IP
                IPAddress serverIpAddress = IPAddress.Parse(IP); // Cambia esto por la dirección IP del servidor
                int serverPort = Puerto; // Cambia esto por el número de puerto del servidor
                IPEndPoint serverEndPoint = new IPEndPoint(serverIpAddress, serverPort);


                // Crear un cliente Socket
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(serverEndPoint); // Conectar al servidor

                    //Variables
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];

 
                    ////// LOGING---------------------------------------------
                    // Welcome
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    if (Debug)
                    {
                        MessageBox.Show(response);
                    }

                    // User
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    if (Debug)
                    {
                        MessageBox.Show(response);
                    }

                    // Enviar datos al servidor
                    byte[] data = Encoding.ASCII.GetBytes("admin" + System.Environment.NewLine);
                    stream.Write(data, 0, data.Length);

                    // PSW
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    if (Debug)
                    {
                        MessageBox.Show(response);
                    }

                    // Enviar datos al servidor
                    data = Encoding.ASCII.GetBytes("" + System.Environment.NewLine);
                    stream.Write(data, 0, data.Length);

                    // Login
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    if (Debug)
                    {
                        MessageBox.Show(response);
                    }
                    ////--------------------------------------------------------------


                    ////// COMANDO1---------------------------------------------
                    if (Comando1.Length > 0)
                    {
                        // Enviar datos al servidor
                        data = Encoding.ASCII.GetBytes(Comando1 + System.Environment.NewLine);
                        stream.Write(data, 0, data.Length);

                        // Recibir datos del servidor
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        if (Debug)
                        {
                            MessageBox.Show(response);
                        }

                        if (Comando1.Substring(0, 1) == "G")
                        {
                            // Recibir datos del servidor Valor
                            bytesRead = stream.Read(buffer, 0, buffer.Length);
                            response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                            if (Debug)
                            {
                                MessageBox.Show(response);
                            }
                        }

                        Result = Result+ response + ";";
                    }
                    else
                    {
                        Result = Result+ ";";
                    }
                    ////--------------------------------------------------------------

                    ////// COMANDO2---------------------------------------------
                    if (Comando2.Length > 0)
                    {
                        // Enviar datos al servidor
                        data = Encoding.ASCII.GetBytes(Comando2 + System.Environment.NewLine);
                        stream.Write(data, 0, data.Length);

                        // Recibir datos del servidor
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        if (Debug)
                        {
                            MessageBox.Show(response);
                        }

                        if (Comando2.Substring(0, 1) == "G")
                        {
                            // Recibir datos del servidor Valor
                            bytesRead = stream.Read(buffer, 0, buffer.Length);
                            response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                            if (Debug)
                            {
                                MessageBox.Show(response);
                            }
                        }

                        Result = Result+ response + ";";
                    }
                    else
                    {
                        Result = Result+ ";";
                    }
                    ////--------------------------------------------------------------



                    ////// COMANDO3---------------------------------------------
                    if (Comando3.Length > 0)
                    {
                        // Enviar datos al servidor
                        data = Encoding.ASCII.GetBytes(Comando3 + System.Environment.NewLine);
                        stream.Write(data, 0, data.Length);

                        // Recibir datos del servidor
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        if (Debug)
                        {
                            MessageBox.Show(response);
                        }

                        if (Comando3.Substring(0, 1) == "G")
                        {
                            // Recibir datos del servidor Valor
                            bytesRead = stream.Read(buffer, 0, buffer.Length);
                            response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                            if (Debug)
                            {
                                MessageBox.Show(response);
                            }
                        }

                        Result = Result + response + ";";
                    }
                    else
                    {
                        Result = Result + ";";
                    }
                    ////--------------------------------------------------------------



                    ////// COMANDO4---------------------------------------------
                    if (Comando4.Length > 0)
                    {
                        // Enviar datos al servidor
                        data = Encoding.ASCII.GetBytes(Comando4 + System.Environment.NewLine);
                        stream.Write(data, 0, data.Length);

                        // Recibir datos del servidor
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        if (Debug)
                        {
                            MessageBox.Show(response);
                        }

                        if (Comando4.Substring(0, 1) == "G")
                        {
                            // Recibir datos del servidor Valor
                            bytesRead = stream.Read(buffer, 0, buffer.Length);
                            response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                            if (Debug)
                            {
                                MessageBox.Show(response);
                            }
                        }

                        Result = Result + response + ";";
                    }
                    else
                    {
                        Result = Result + ";";
                    }
                    ////--------------------------------------------------------------

                    // Clos Socket 
                    client.Close();

                }

            }
            catch (Exception ex)
            {
                if (Debug)
                {
                    MessageBox.Show(ex.Message);
                }
                
                return ex.Message;

            }

            return Result;
        }

    }
}
