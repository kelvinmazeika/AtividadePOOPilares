using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public class NotificacaoSMS : Notificacao
    {
        public override void EnviarNotificacao(string mensagem)
        {
            Console.WriteLine($"Enviando notificação por SMS: {mensagem}");
        }
    }
}