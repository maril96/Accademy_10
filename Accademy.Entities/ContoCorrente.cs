using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Entities
{
    public class ContoCorrente
    {
        private String numeroConto;
        private double saldo;
        private Cliente owner;

        public List<Movimento> Movimenti { get; }
        public ContoCorrente(Cliente owner)
        {
            Movimenti = new List<Movimento>();
            this.owner = owner;
        }
        public ContoCorrente(string numeroConto)
        {
            this.numeroConto = numeroConto;
            saldo = 0;     
        }

        public Cliente GetOwner()
        {
            return owner;
        }
        public string GetNumeroConto()
        {
            return numeroConto;
        }
        public double GetSaldo()
        {
            return saldo;
        }
        public OperationResult Deposita(double cifra)
        {
            saldo += cifra;
            Movimento deposito = new Movimento()
            {
                Tipo = TipoMovimento.Deposito,
                Importo = cifra,
                Data = DateTime.Now

                //questo è un altro modo per inizializzare i campi di una classe
            };
            Movimenti.Add(deposito);
            return OperationResult.Operazione_OK;
        }
        public OperationResult Preleva(double cifra)
        {
            OperationResult result = OperationResult.FondiInsufficienti;

            if (saldo >= cifra)
            {
                saldo -= cifra;
                Movimenti.Add(new Movimento()
                {
                    Tipo = TipoMovimento.Prelievo,
                    Importo=cifra,
                    Data=DateTime.Now
                });
                result = OperationResult.Operazione_OK;
            }
            return result;
        }
        public OperationResult Bonifico(double cifra, ContoCorrente beneficiario)
        {
            //da implementare
            Movimenti.Add(new Movimento()
            {
                Tipo = TipoMovimento.Bonifico,
                Importo = cifra,
                Data = DateTime.Now,
                Beneficiario = beneficiario.GetNumeroConto()
            }) ;
            return OperationResult.Operazione_OK;
        }
    }
}
