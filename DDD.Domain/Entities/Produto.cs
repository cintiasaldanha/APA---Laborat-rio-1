using System;

namespace DDD.Domain.Entities
{
    public class Produto : BaseEntity
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }  

        private decimal _Preco;  
        public decimal Preco { 
            get {
                return this._Preco;
            }
            set {
                if (VerificaPrecoProduto(value)) {
                    this._Preco = value;
                } else {
                    throw new Exception("Informe o valor do produto!");
                }
            }
        }
        public string SKU { get; set; }      
         
        public bool VerificaPrecoProduto (decimal value) {
           return decimal.Compare(value,0)>0;
        }    }
}