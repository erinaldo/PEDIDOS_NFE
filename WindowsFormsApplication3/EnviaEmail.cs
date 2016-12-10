using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace enviaremail 
{
    public class email 
    {
        public String inicio(String arq_from, String arq_to, String arq_cc, String arq_bcc, String arq_subjct, String arq_body, String arq_path, String arq_atch, String srv_smtp, String srv_user, String srv_pass)
        {
            int x = 0;
            int tam = 0;
            int inicio = 0;
            int fim = 0;
            string pedaco;

            if ((arq_from.Length + arq_to.Length + arq_bcc.Length) == 0)
            {
                if (arq_from.Length == 0)
                    return "Informe o remetente";
                if (arq_to.Length == 0)
                    return "Informe destinatario";
                if (arq_bcc.Length == 0)
                    return "Informe destinatario Copia Oculta";
            }
            
            if (arq_subjct.Length == 0)
                return "Informe o assunto";
            if (arq_path.Length == 0)
                arq_path = "c:\\arqmail.txt";
            if (srv_smtp.Length == 0)
                return "Informe o Servidor Smtp";
            if (srv_user.Length == 0)
                return "Informe o Usuario";
            if (srv_pass.Length == 0)
                return "Informe a Senha";

            SmtpClient client = new SmtpClient(srv_smtp);
            client.Credentials = new NetworkCredential(srv_user, srv_pass);
            MailMessage message = new MailMessage(new MailAddress(arq_from.ToString(), arq_from), new MailAddress(arq_to, arq_to));
            if (arq_cc.Length > 0) { message.CC.Add(new MailAddress(arq_cc)); }
            //********************************AQUI CARREGA COPIAS QDO MAIS DE UMA ********************************        
            x = arq_bcc.IndexOf(",");
            while (arq_bcc.IndexOf(",") > 0 || arq_bcc.IndexOf(";") > 0)
            {
                tam = arq_bcc.Length;
                fim = arq_bcc.IndexOf(",");
                if (fim < 0) { fim = arq_bcc.IndexOf(";"); }
                pedaco = arq_bcc.Substring(inicio, fim);
                message.Bcc.Add(new MailAddress(pedaco));
                inicio = fim + 1;
                arq_bcc = arq_bcc.Substring(inicio, tam - inicio);
                tam = arq_bcc.Length;
                inicio = 0;
            }
            if (arq_bcc.Length > 0) { message.Bcc.Add(new MailAddress(arq_bcc)); }
            //******************************************************************************************************
            message.Subject = arq_subjct;
            message.Body = arq_body;
            if (arq_atch.Length > 0)
            {
                Attachment att = new Attachment(@arq_atch);
                message.Attachments.Add(att);
            }
            client.Send(message);

            StreamWriter arqmail = new StreamWriter(arq_path, true, Encoding.ASCII);
            arq_from = "De: " + message.From.ToString();
            arq_to = "Para: " + message.To.ToString();
            arq_cc = "CC: " + message.CC.ToString(); ;
            arq_bcc = "Bcc: " + message.Bcc.ToString();
            arq_subjct = "Assunto: " + message.Subject.ToString();
            arq_body = "Menssagem: " + message.Body.ToString();
            arqmail.WriteLine(arq_from);
            arqmail.WriteLine(arq_to);
            arqmail.WriteLine(arq_cc);
            arqmail.WriteLine(arq_bcc);
            arqmail.WriteLine(arq_subjct);
            arqmail.WriteLine(arq_body);
            arqmail.WriteLine("================================================================");
            arqmail.Close();
            return "Enviado com Sucesso";
        }
    } // fim class email
} // fim namespace
