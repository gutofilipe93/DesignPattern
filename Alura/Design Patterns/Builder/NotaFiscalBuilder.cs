namespace Builder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public double ValorTotal { get; private set; }
        public double Impostos { get; private set; }
        public DateTime? Data { get; private set; }
        public string Observacoes { get; private set; }

        private IList<ItemDaNota> TodosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder SetRazaoSocial(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }
        public NotaFiscalBuilder SetCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder SetIemDaNota(ItemDaNota item)
        {
            TodosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder SetObservacao(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }
        
        public NotaFiscalBuilder SetData(DateTime date)
        {
            this.Data = date;
            return this;
        }

        public NotaFiscal Builder()
        {
            var data = this.Data.HasValue ? this.Data.Value : DateTime.Now;
            return new NotaFiscal(this.RazaoSocial,this.Cnpj,date,this.ValorTotal,this.Impostos,this.TodosItens,this.Observacoes);
        }

    }
}