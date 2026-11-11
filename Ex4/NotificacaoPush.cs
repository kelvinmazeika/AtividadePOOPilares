using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public class NotificacaoPush : Notificacao
    {
        public override void EnviarNotificacao(string mensagem)
        {
            Console.WriteLine($"Enviando notificação por push: {mensagem}");
        }
        
    }
}