using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.BL
{
    public class clsGeneral
    {
        public void setEmail(Proyecto.Logica.Models.clsCorreo oClsCorreo)
        {
            //objeto de correo
            MailMessage oMail = new MailMessage();
            oMail.From = new System.Net.Mail.MailAddress(oClsCorreo.stFrom.ToString());
            oMail.To.Add(oClsCorreo.stTo);
            oMail.Subject = oClsCorreo.stAsunto;
            oMail.Body = oClsCorreo.stMensaje;

            if (oClsCorreo.inTipo == 0) oMail.IsBodyHtml = false;
            else if (oClsCorreo.inTipo == 1) oMail.IsBodyHtml = true;

            if (oClsCorreo.inPrioridad == 0) oMail.Priority = MailPriority.Normal;
            else if (oClsCorreo.inPrioridad == 1) oMail.Priority = MailPriority.Low;
            else if (oClsCorreo.inPrioridad == 2) oMail.Priority = MailPriority.High;

            //Incrustando una imagen
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(oClsCorreo.stMensaje, Encoding.UTF8, MediaTypeNames.Text.Html);
            LinkedResource img = new LinkedResource(oClsCorreo.stImagen, MediaTypeNames.Image.Gif);
            img.ContentId = oClsCorreo.stIdImagen;
            htmlView.LinkedResources.Add(img);
            oMail.AlternateViews.Add(htmlView);

            //Cliente de servidor de correo
            SmtpClient oSmtp = new SmtpClient();
            oSmtp.Host = oClsCorreo.stServidor;
            if (oClsCorreo.blAutenticacion)
                oSmtp.Credentials = new System.Net.NetworkCredential(oClsCorreo.stUsuario, oClsCorreo.stPassword);
            if (oClsCorreo.stPuerto.Length > 0) oSmtp.Port = int.Parse(oClsCorreo.stPuerto);
            oSmtp.EnableSsl = oClsCorreo.blConexionSegura;
            oSmtp.Send(oMail);
        }
    }
}
