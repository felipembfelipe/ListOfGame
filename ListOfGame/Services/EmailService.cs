using ListOfGame.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ListOfGame.Services
{
    public class EmailService : IEmailService
    {
        private readonly string _emailOrigem = "felipembfelipek6@gmail.com";
        private readonly string _senhaApp = "swfs xsof lpny pydd"; // App password, não a senha normal

        public async Task<bool> EnviarEmailRecuperacao(string destino, string usuario, string senha)
        {
            try
            {
                var mensagem = new MailMessage();
                mensagem.From = new MailAddress(_emailOrigem, "Sistema de Login - Moretti Games");
                mensagem.To.Add(destino);
                mensagem.Subject = "Recuperação de Senha - Moretti Games";
                mensagem.Body = $"Olá!\n\nRecebemos uma solicitação para lembrar sua senha para o Lista de Games do Moretti.:\n\n" +
                                $"Seu login é: " + usuario.ToUpper() + "\n"+
                                $"Sua senha é: " + senha + "\n\n"+
                                $"Se não foi você, ignore este e-mail.";
                mensagem.IsBodyHtml = false;

                using var smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(_emailOrigem, _senhaApp),
                    EnableSsl = true
                };

                await smtp.SendMailAsync(mensagem);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
