using System;
interface INotificable
{void Notifica();}
class NotificacionEmail : INotificable
{ private string DireccionCorreo;
    public NotificacionEmail(string direccionCorreo) => this.DireccionCorreo = direccionCorreo;
    public void Notifica() => Console.WriteLine($"Correo electrónico: {DireccionCorreo}");}
class NotificacionWhatsap : INotificable
{ private string NumeroTelefono;
    public NotificacionWhatsap(string numeroTelefono) => this.NumeroTelefono = numeroTelefono;
    public void Notifica() => Console.WriteLine($"Mensaje de Whatsapp: {NumeroTelefono}");}
class NotificacionSMS : INotificable
{private string numeroTelefono;
    public NotificacionSMS(string numeroTelefono) => this.numeroTelefono = numeroTelefono;
    public void Notifica() => Console.WriteLine($"Mensaje de SMS: {numeroTelefono}");}
class Program
{ static void Main(string[] args)
    {var notificacionEmail = new NotificacionEmail("jramirezs26@miumg.edu.gt");
        var notificacionWhatsap = new NotificacionWhatsap("47585847");
        var notificacionSMS = new NotificacionSMS("47585847");

        notificacionEmail.Notifica();
        notificacionWhatsap.Notifica();
        notificacionSMS.Notifica();}
}
