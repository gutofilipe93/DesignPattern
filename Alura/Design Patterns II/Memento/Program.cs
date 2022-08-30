// See https://aka.ms/new-console-template for more information
using Memento;

    Historico historico = new Historico();

    Contrato contrato = new Contrato(DateTime.Now, "Mauricio", TipoContrato.Novo);
    historico.Adiciona(contrato);

    contrato.Avanca();
    historico.Adiciona(contrato);

    contrato.Avanca();
    historico.Adiciona(contrato);

    contrato.Avanca();
    historico.Adiciona(contrato);
