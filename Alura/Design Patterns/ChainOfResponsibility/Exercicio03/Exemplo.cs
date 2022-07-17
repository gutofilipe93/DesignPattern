enum Formato
{
    XML,
    CSV,
    PORCENTO
}

class Requisicao
{
    public Formato Formato { get; private set; }

    public Requisicao(Formato formato)
    {
        this.Formato = formato;
    }
}


class Conta
{
    public String Titular { get; private set; }
    public double Saldo { get; private set; }

    public Conta(String titular, double saldo)
    {
        this.Titular = titular;
        this.Saldo = saldo;
    }
}

// NÃO CRIANDO O PROXIMO 'ITEM' PELA INTERFACE, MAS SIM PELO PROPRIA CLASSE CONCRETA, PASSANDO ELE NO CONSTRUROR 
interface Resposta
{
    void Responde(Requisicao req, Conta conta);
}

class SemResposta : Resposta
{
    public SemResposta(Resposta outraResposta)
    {
        this.OutraResposta = outraResposta;
    }

    public Resposta OutraResposta { get; private set; }

    public void Responde(Requisicao req, Conta conta)
    {
        return;
    }
}

class RespostaEmXml : Resposta
{
    public Resposta OutraResposta { get; private set; }

    public RespostaEmXml(Resposta outraResposta)
    {
        this.OutraResposta = outraResposta;
    }

    public void Responde(Requisicao req, Conta conta)
    {
        if (req.Formato == Formato.XML)
        {
            Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
        }
        else
        {
            OutraResposta.Responde(req, conta);
        }
    }
}


class RespostaEmCsv : Resposta
{
    public Resposta OutraResposta { get; private set; }

    public RespostaEmCsv(Resposta outraResposta)
    {
        this.OutraResposta = outraResposta;
    }

    public void Responde(Requisicao req, Conta conta)
    {
        if (req.Formato == Formato.CSV)
        {
            Console.WriteLine(conta.Titular + ";" + conta.Saldo);
        }
        else
        {
            OutraResposta.Responde(req, conta);
        }
    }
}

class RespostaEmPorcento : Resposta
{
    public Resposta OutraResposta { get; private set; }

    public RespostaEmPorcento(Resposta outraResposta)
    {
        this.OutraResposta = outraResposta;
    }

    public void Responde(Requisicao req, Conta conta)
    {
        if (req.Formato == Formato.PORCENTO)
        {
            Console.WriteLine(conta.Titular + "%" + conta.Saldo);
        }
        else
        {
            OutraResposta.Responde(req, conta);
        }
    }
}