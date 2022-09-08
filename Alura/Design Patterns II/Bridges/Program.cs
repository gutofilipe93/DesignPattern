using Bridges;

IEnviador enviador = new EnviaPorEmail();
IMensagem mensagem = new MensagemAdministrativa("victor");
mensagem.Enviador = enviador;

mensagem.Envia();

enviador = new EnviaPorSms();
mensagem = new MensagemCliente("mauricio");
mensagem.Enviador = enviador;

mensagem.Envia();